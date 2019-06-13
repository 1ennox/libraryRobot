using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Core = Invengo.NetAPI.Core;
using IRP1 = Invengo.NetAPI.Protocol.IRP1;
using System.Threading;
using System.IO;
using System.IO.Ports;
using MySql.Data.MySqlClient;

namespace SingleReaderTest
{
    public partial class FormMain : Form
    {
        // 实例化读写器类
        SerialPort port;
        
        //laptop only
        IRP1.Reader reader = new IRP1.Reader("Reader1", "RS232", "COM9,115200");//串口

        //desktop
        //IRP1.Reader reader = new IRP1.Reader("Reader1", "RS232", "COM3,115200");//串口

        //IRP1.Reader reader = new IRP1.Reader("Reader1", "TCPIP_Client", "192.168.1.230:7086");//网口
        IRP1.ReadTag scanMsg = new IRP1.ReadTag(IRP1.ReadTag.ReadMemoryBank.EPC_6C);//扫描消息
        DataTable myDt = new DataTable();//显示扫描数据
        object lockobj = new object();//显示数据锁定
        bool isTryReconnNet = false;
        int tryReconnNetTimeSpan;
        //Database connection test
        MySqlConnection mycon = new MySqlConnection("Server=127.0.0.1;User Id=root;password=;Database=test");
        string tableName = " ";
        bool dbisConnect = false;

        public FormMain()
        {
            InitializeComponent();

            this.FormClosed += new FormClosedEventHandler(FormMain_FormClosed);

            if (port == null)
            {
                //COM4为Arduino使用的串口号，需根据实际情况调整
                //port = new SerialPort("COM3", 9600);
                //port.Open();
            }

            //InitializeComponent();
            myDt.Columns.Add("EPC");
            myDt.Columns.Add("TID");
            myDt.Columns.Add("Userdata");
            myDt.Columns.Add("Count");
            dataGridView1.DataSource = myDt;
            dataGridView1.Columns[0].HeaderText = "EPC";
            dataGridView1.Columns[1].HeaderText = "TID/ID";
            dataGridView1.Columns[2].HeaderText = "Data";
            dataGridView1.Columns[3].HeaderText = "Count";

            IRP1.Reader.OnApiException += new Core.ApiExceptionHandle(Reader_OnApiException);
        }
        void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }


        void Reader_OnApiException(Core.ErrInfo e)
        {            
            if (e.Ei.ErrCode == "FF22")
            {
                changeCtrlEnable("disconn");
                showMsg(e.Ei.ErrMsg);
                if (isTryReconnNet)
                    ReConn();                
            }
            else if (e.Ei.ErrCode == "FF24")//发现连接作废,不作断网恢复尝试
            {
                isTryReconnNet = false;
                changeCtrlEnable("disconn");
                showMsg(e.Ei.ErrMsg);
            }
        }

        #region 重连接
        private void ReConn()
        {
            bool isSuc = false;
            using (Ping ping = new Ping())
            {
                for (int i = 0; i < tryReconnNetTimeSpan * 60; i++)
                {
                    PingReply pingReply = null;
                    try
                    {
                        pingReply = ping.Send(reader.ConnString.Substring(0,
                            reader.ConnString.IndexOf(':')), 1000);//超时为1秒

                        if (pingReply.Status != IPStatus.Success)
                        {
                            showMsg("Ping 不通");
                            continue;
                        }
                        else
                        {
                            isSuc = true;
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        showMsg("尝试自动恢复连接失败！" + ex.Message);
                        return;
                    }
                }
            }
            //建立连接
            if (isSuc)
            {
                isSuc = false;
                for (int i = 0; i < 3; i++)//尝试3次
                {
                    if (reader.Connect())
                    {
                        showMsg("尝试自动恢复连接成功！");
                        changeCtrlEnable("conn");
                        isSuc = true;
                        break;
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        continue;                        
                    }
                }
                if(!isSuc)
                    showMsg("尝试自动恢复连接失败！");
            }
        }
        #endregion

        // 关闭窗体
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        // 建立连接
        private void btnConn_Click(object sender, EventArgs e)
        {
            if (reader.Connect())
            {
                changeCtrlEnable("conn");
                //注册接收读写器消息事件
                reader.OnMessageNotificationReceived += new Invengo.NetAPI.Core.MessageNotificationReceivedHandle(reader_OnMessageNotificationReceived);                
                lblMsg.Text = "Connection Successful!";
            }
            else
            {
                lblMsg.Text = "Connection Failed!";
                MessageBox.Show("Failed to create the connection.");
            }
        }

        /// <summary>
        /// 接收到读写器消息触发事件
        /// </summary>
        /// <param name="reader">读写器类</param>
        /// <param name="msg">消息内容</param>
        void reader_OnMessageNotificationReceived(Invengo.NetAPI.Core.BaseReader reader, Invengo.NetAPI.Core.IMessageNotification msg)
        {
            if (msg.StatusCode != 0)
            {
                //显示错误信息
                showMsg(msg.ErrInfo);
                return;
            }
            String msgType = msg.GetMessageType();
            msgType = msgType.Substring(msgType.LastIndexOf('.') + 1);
            switch (msgType)
            {
                #region RXD_TagData
                case "RXD_TagData":
                    {
                        IRP1.RXD_TagData m = (IRP1.RXD_TagData)msg;
                        string tagType = m.ReceivedMessage.TagType;
                        display(m);                        
                    }
                    break;
                #endregion               
                #region RXD_IOTriggerSignal_800
                case "RXD_IOTriggerSignal_800":
                    {
                        IRP1.RXD_IOTriggerSignal_800 m = (IRP1.RXD_IOTriggerSignal_800)msg;
                        if (m.ReceivedMessage.IsStart)
                        {
                            changeCtrlEnable("scan");
                            showMsg(" I/O 触发，正在读卡...");
                        }
                        else
                        {
                            changeCtrlEnable("conn");
                            showMsg(" I/O 触发，停止读卡");
                        }
                    }
                    break;
                #endregion               
            }
        }

        #region 状态栏显示信息
        private delegate void showMsgHandle(string str);

        private void showMsg(string str)
        {
            if (this.InvokeRequired)
            {
                showMsgHandle h = new showMsgHandle(showMsgMethod);
                this.BeginInvoke(h, str);
            }
            else
            {
                showMsgMethod(str);
            }
        }

        private void showMsgMethod(string str)
        {
            lblMsg.Text = str;
        }
        #endregion

        #region 显示扫描标签数据
        private delegate void displayHandle(IRP1.RXD_TagData msg);

        private void display(IRP1.RXD_TagData msg)
        {
            if (dataGridView1.InvokeRequired)
            {
                displayHandle h = new displayHandle(displayMethod);
                dataGridView1.BeginInvoke(h, msg);
            }
            else
            {
                displayMethod(msg);
            }
        }
        
        private void displayMethod(IRP1.RXD_TagData msg)
        {
            lock (lockobj)
            {
                bool isAdd = true;
                int count = 0;
                string epc = Core.Util.ConvertByteArrayToHexString(msg.ReceivedMessage.EPC);
                string tid = Core.Util.ConvertByteArrayToHexString(msg.ReceivedMessage.TID);
                foreach (DataRow dr in myDt.Rows)
                {
                    if((dr["EPC"] != null && dr["EPC"].ToString() != "" && dr["EPC"].ToString() == epc)
                        || (dr["TID"] != null && dr["TID"].ToString() != "" && dr["TID"].ToString() == tid))
                    {
                        isAdd = false;
                        count = int.Parse(dr["Count"].ToString()) + 1;
                        dr["Count"] = count;
                    }
                    if(whetherInDB(epc) == true && dbisConnect == true)
                    {
                        updateToDB(epc, count);
                    }
                    else if(whetherInDB(epc) == false && dbisConnect == true)
                    {
                        insertToDB(epc, count);
                    }
                    else
                    {

                    }
                }

                if (isAdd)
                {
                    DataRow mydr = myDt.NewRow();
                    mydr["EPC"] = epc;
                    mydr["TID"] = tid;
                    mydr["Userdata"] = Core.Util.ConvertByteArrayToHexString(msg.ReceivedMessage.UserData);
                    mydr["Count"] = 1;
                    myDt.Rows.Add(mydr);
                    //add data to database
                    if (dbisConnect == true)
                    {
                        String temp = mydr["count"].ToString();
                        int.TryParse(temp, out count);
                        insertToDB(epc, 1);
                    }
                }
            }
        }
        #endregion

        private void insertToDB(String epc, int count)
        {
            if(whetherInDB(epc) == true)//if this book has already been put into database, then update its count value
            {
                updateToDB(epc, count);
            }
            else
            {
                MySqlCommand mycom = new MySqlCommand("INSERT INTO " + tableName + " (book_ID, count) VALUES('" + epc + "','" + count + "')", mycon);
                try
                {
                    mycom.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Insert error!");
                }
            }
        }
        private void updateToDB(String epc, int count)
        {
            MySqlCommand mycom = new MySqlCommand("UPDATE " + tableName + " SET count = '" + count + "' WHERE book_ID = '" + epc + "'", mycon);
                    try
                    {
                        mycom.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Update error!");
                    }
        }

        private bool whetherInDB(string epc)
        {
            MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT book_ID FROM " + tableName, mycon);
            DataTable dt = new DataTable();
            mysda.Fill(dt);
            string result = " ";
            foreach (DataRow book in dt.Rows)
            {
                result = book["book_ID"].ToString();
                if (result.Equals(epc))
                {
                    return true;
                }
            }
            return false;
        }

        private bool whetherResultInDB(string epc)
        {
            MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT book_ID FROM compareResult", mycon);
            DataTable dt = new DataTable();
            mysda.Fill(dt);
            string result = " ";
            foreach (DataRow book in dt.Rows)
            {
                result = book["book_ID"].ToString();
                if (result.Equals(epc))
                {
                    return true;
                }
            }
            return false;
        }


        private void compare()
        {
            MySqlDataAdapter myTest = new MySqlDataAdapter("SELECT book_ID FROM testlibraryreader", mycon);
            MySqlDataAdapter myTotal = new MySqlDataAdapter("SELECT book_ID FROM totalstorage", mycon);

            DataTable dtTest = new DataTable();
            DataTable dtTotal = new DataTable();

            myTest.Fill(dtTest);
            myTotal.Fill(dtTotal);

            bool isLost = true;
            string resultTest = " ";
            string resultTotal = " ";

            string resultLoss = " ";
            //string resultReport = " ";
            foreach (DataRow bookTotal in dtTotal.Rows)
            {
                resultTotal = bookTotal["book_ID"].ToString();
                foreach (DataRow bookTest in dtTest.Rows)
                {
                    resultTest = bookTest["book_ID"].ToString();
                    if (resultTotal.Equals(resultTest))
                    {
                        isLost = false;
                        break;
                    }

                }
                if (isLost == true)
                {
                 resultLoss = bookTotal["book_ID"].ToString();
                    if(whetherResultInDB(resultLoss) == false)
                    {
                        try
                        {
                            mycon.Open();
                            string storeReport = "insert into compareresult (book_ID) VALUES ('" + resultLoss + "')";
                            MySqlCommand store = new MySqlCommand(storeReport, mycon);
                            store.ExecuteNonQuery();
                            store.Dispose();
                            mycon.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Report generate error.");
                        }
                        
                    }
                }
                isLost = true;

            }
        }

        // 改变界面按钮状态
        private void changeCtrlEnable(string state)
        {
            if (this.InvokeRequired)
            {
                changeCtrlEnableHandle h = new changeCtrlEnableHandle(changeCtrlEnableMethod);
                this.BeginInvoke(h, state);
            }
            else
                changeCtrlEnableMethod(state);
        }

        private delegate void changeCtrlEnableHandle(string state);

        private void changeCtrlEnableMethod(string state)
        {
            switch (state)
            {
                case "conn":
                    btnConn.Enabled = false;
                    btnDisconn.Enabled = true;
                    btnScan.Enabled = true;
                    btnStop.Enabled = false;
                    //MI_ScanConfig.Enabled = true;
                    //MI_ReaderConfig.Enabled = true;
                    //MI_GPIO.Enabled = true;
                    break;
                case "disconn":
                    btnConn.Enabled = true;
                    btnDisconn.Enabled = false;
                    btnScan.Enabled = false;
                    btnStop.Enabled = false;
                    //MI_ScanConfig.Enabled = false;
                    //MI_ReaderConfig.Enabled = false;
                    //MI_GPIO.Enabled = false;
                    break;
                case "dbconn":
                    btnDBConn.Enabled = false;
                    btnDBDisconn.Enabled = true;
                    storageDBConnect.Enabled = false;
                    storageDBDisConnect.Enabled = false;
                    break;
                case "dbdisconn":
                    btnDBConn.Enabled = true;
                    btnDBDisconn.Enabled = false;
                    storageDBConnect.Enabled = true;
                    storageDBDisConnect.Enabled = false;
                    break;
                case "storagedbconn":
                    btnDBConn.Enabled = false;
                    btnDBDisconn.Enabled = false;
                    storageDBConnect.Enabled = false;
                    storageDBDisConnect.Enabled = true;
                    break;
                case "storagedbdisconn":
                    btnDBConn.Enabled = true;
                    btnDBDisconn.Enabled = false;
                    storageDBConnect.Enabled = true;
                    storageDBDisConnect.Enabled = false;
                    break;
                case "scan":
                    btnConn.Enabled = false;
                    btnDisconn.Enabled = true;
                    btnScan.Enabled = false;
                    btnStop.Enabled = true;
                    //MI_ScanConfig.Enabled = false;
                    //MI_ReaderConfig.Enabled = false;
                    //MI_GPIO.Enabled = false;
                    break;
            }
        }

        // 断开连接
        private void btnDisconn_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.OnMessageNotificationReceived -= new Invengo.NetAPI.Core.MessageNotificationReceivedHandle(reader_OnMessageNotificationReceived);
                reader.Disconnect();
            }
            changeCtrlEnable("disconn");
            lblMsg.Text = "断开连接";
        }

        // 退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 扫描标签
        private void btnScan_Click(object sender, EventArgs e)
        {
            btnClean_Click(sender, e);

            if (reader != null && reader.IsConnected)
            {
                if (reader.Send(scanMsg))
                {
                    changeCtrlEnable("scan");
                    lblMsg.Text = "Reading tags...";
                }
            }
        }

        // 停止扫描
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (reader != null && reader.IsConnected)
            {
                if (reader.Send(new IRP1.PowerOff()))//发送关功放消息
                {
                    changeCtrlEnable("conn");
                    lblMsg.Text = "Stop reading tags";
                }
            }
        }

        // 清空数据
        private void btnClean_Click(object sender, EventArgs e)
        {
            lock (lockobj)
            {
                myDt.Rows.Clear();
            }
        }

        FormScanConfig frmScanConfig = null;
        // 扫描配置
        private void MI_ScanConfig_Click(object sender, EventArgs e)
        {
            if(frmScanConfig == null)
                frmScanConfig = new FormScanConfig(reader);
            if (frmScanConfig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                scanMsg = frmScanConfig.msg;
        }

        // 读写器配置
        private void MI_ReaderConfig_Click(object sender, EventArgs e)
        {
            FormReaderConfig frm = new FormReaderConfig(reader);
            frm.isTryReconnNet = this.isTryReconnNet;
            frm.ShowDialog();
            this.isTryReconnNet = frm.isTryReconnNet;
            this.tryReconnNetTimeSpan = frm.tryReconnNetTimeSpan;
            frm.Dispose();
        }

        // GPIO
        private void MI_GPIO_Click(object sender, EventArgs e)
        {
            FormGPIO frm = new FormGPIO(reader,scanMsg);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void MI_Help_Click(object sender, EventArgs e)
        {
            FormHelp frm = new FormHelp();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void MI_Config_Click(object sender, EventArgs e)
        {

        }

        private void MI_DBConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnDBConn_Click(object sender, EventArgs e)
        {
            //con.ConnectionString = 
            //    "server=192.168.111.231;database=ZHUICLibDBnew;user=lrcreadyonly;pwd=sql@lrc2019.15";
            mycon.Open();
            tableName = " testlibraryreader ";
            dbisConnect = true;
            changeCtrlEnable("dbconn");


            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //string sql = "";
        }

        private void btnDBDisconn_Click(object sender, EventArgs e)
        {
            //con.ConnectionString = 
            //    "server=192.168.111.231;database=ZHUICLibDBnew;user=lrcreadyonly;pwd=sql@lrc2019.15";
            mycon.Close();
            tableName = " ";
            dbisConnect = false;
            changeCtrlEnable("dbdisconn");


            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //string sql = "";
        }
        private void StorageDBConnect_Click(object sender, EventArgs e)
        {
            mycon.Open();
            tableName = " totalStorage ";
            dbisConnect = true;
            changeCtrlEnable("storagedbconn");
        }

        private void StorageDBDisConnect_Click(object sender, EventArgs e)
        {
            mycon.Close();
            tableName = " ";
            dbisConnect = false;
            changeCtrlEnable("storagedbdisconn");
        }
        private void btnArmStop_Click(object sender, EventArgs e)//r
        {
           
                PortWrite("F");
            
        }

        private void btnArmUp_Click(object sender, EventArgs e)//u
        {
            PortWrite("U");
        }

        private void btnArmDown_Click(object sender, EventArgs e)//d
        {
            PortWrite("C");
        }

        private void PortWrite(string message)
        {
            if (port != null && port.IsOpen)
            {
                port.Write(message);
                //port.WriteLine(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PortWrite("K");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            detailDB detailDBform = new detailDB();
            detailDBform.ShowDialog();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            compare();
            compareReport detailReportform = new compareReport();
            detailReportform.ShowDialog();
        }
    }
}
