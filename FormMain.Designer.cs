namespace SingleReaderTest
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConn = new System.Windows.Forms.Button();
            this.btnDisconn = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDBDisconn = new System.Windows.Forms.Button();
            this.btnDBConn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnArmUp = new System.Windows.Forms.Button();
            this.btnArmDown = new System.Windows.Forms.Button();
            this.btnArmStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openDB = new System.Windows.Forms.Button();
            this.storageDBDisConnect = new System.Windows.Forms.Button();
            this.storageDBConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Button();
            this.openStorageDB = new System.Windows.Forms.Button();
            this.DBclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConn
            // 
            this.btnConn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConn.Location = new System.Drawing.Point(3, 69);
            this.btnConn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(87, 29);
            this.btnConn.TabIndex = 0;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnDisconn
            // 
            this.btnDisconn.Enabled = false;
            this.btnDisconn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconn.Location = new System.Drawing.Point(3, 106);
            this.btnDisconn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisconn.Name = "btnDisconn";
            this.btnDisconn.Size = new System.Drawing.Size(87, 29);
            this.btnDisconn.TabIndex = 0;
            this.btnDisconn.Text = "Disconnect";
            this.btnDisconn.UseVisualStyleBackColor = true;
            this.btnDisconn.Click += new System.EventHandler(this.btnDisconn_Click);
            // 
            // btnScan
            // 
            this.btnScan.Enabled = false;
            this.btnScan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(176, 34);
            this.btnScan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(87, 29);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Start Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(365, 34);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(87, 29);
            this.btnClean.TabIndex = 0;
            this.btnClean.Text = "Clear";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 552);
            this.dataGridView1.TabIndex = 21;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 632);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1199, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(271, 34);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 29);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop Scan";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(2, 574);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(975, 70);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(476, 552);
            this.dataGridView2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Reader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 26;
            // 
            // btnDBDisconn
            // 
            this.btnDBDisconn.Enabled = false;
            this.btnDBDisconn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBDisconn.Location = new System.Drawing.Point(3, 198);
            this.btnDBDisconn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDBDisconn.Name = "btnDBDisconn";
            this.btnDBDisconn.Size = new System.Drawing.Size(87, 29);
            this.btnDBDisconn.TabIndex = 27;
            this.btnDBDisconn.Text = "Disconnect";
            this.btnDBDisconn.UseVisualStyleBackColor = true;
            this.btnDBDisconn.Click += new System.EventHandler(this.btnDBDisconn_Click);
            // 
            // btnDBConn
            // 
            this.btnDBConn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBConn.Location = new System.Drawing.Point(3, 161);
            this.btnDBConn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDBConn.Name = "btnDBConn";
            this.btnDBConn.Size = new System.Drawing.Size(87, 29);
            this.btnDBConn.TabIndex = 28;
            this.btnDBConn.Text = "Connect";
            this.btnDBConn.UseVisualStyleBackColor = true;
            this.btnDBConn.Click += new System.EventHandler(this.btnDBConn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Arm";
            // 
            // btnArmUp
            // 
            this.btnArmUp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmUp.Location = new System.Drawing.Point(3, 435);
            this.btnArmUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArmUp.Name = "btnArmUp";
            this.btnArmUp.Size = new System.Drawing.Size(87, 26);
            this.btnArmUp.TabIndex = 30;
            this.btnArmUp.Text = "Up";
            this.btnArmUp.UseVisualStyleBackColor = true;
            this.btnArmUp.Click += new System.EventHandler(this.btnArmUp_Click);
            // 
            // btnArmDown
            // 
            this.btnArmDown.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmDown.Location = new System.Drawing.Point(3, 469);
            this.btnArmDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArmDown.Name = "btnArmDown";
            this.btnArmDown.Size = new System.Drawing.Size(87, 26);
            this.btnArmDown.TabIndex = 31;
            this.btnArmDown.Text = "Down";
            this.btnArmDown.UseVisualStyleBackColor = true;
            this.btnArmDown.Click += new System.EventHandler(this.btnArmDown_Click);
            // 
            // btnArmStop
            // 
            this.btnArmStop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmStop.Location = new System.Drawing.Point(3, 502);
            this.btnArmStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArmStop.Name = "btnArmStop";
            this.btnArmStop.Size = new System.Drawing.Size(87, 26);
            this.btnArmStop.TabIndex = 32;
            this.btnArmStop.Text = "Recyle";
            this.btnArmStop.UseVisualStyleBackColor = true;
            this.btnArmStop.Click += new System.EventHandler(this.btnArmStop_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 536);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 33;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openDB
            // 
            this.openDB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDB.Location = new System.Drawing.Point(2, 234);
            this.openDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openDB.Name = "openDB";
            this.openDB.Size = new System.Drawing.Size(87, 29);
            this.openDB.TabIndex = 34;
            this.openDB.Text = "View";
            this.openDB.UseVisualStyleBackColor = true;
            this.openDB.Click += new System.EventHandler(this.Button2_Click);
            // 
            // storageDBDisConnect
            // 
            this.storageDBDisConnect.Enabled = false;
            this.storageDBDisConnect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storageDBDisConnect.Location = new System.Drawing.Point(3, 329);
            this.storageDBDisConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.storageDBDisConnect.Name = "storageDBDisConnect";
            this.storageDBDisConnect.Size = new System.Drawing.Size(87, 29);
            this.storageDBDisConnect.TabIndex = 36;
            this.storageDBDisConnect.Text = "Disconnect";
            this.storageDBDisConnect.UseVisualStyleBackColor = true;
            this.storageDBDisConnect.Click += new System.EventHandler(this.StorageDBDisConnect_Click);
            // 
            // storageDBConnect
            // 
            this.storageDBConnect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storageDBConnect.Location = new System.Drawing.Point(3, 292);
            this.storageDBConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.storageDBConnect.Name = "storageDBConnect";
            this.storageDBConnect.Size = new System.Drawing.Size(87, 29);
            this.storageDBConnect.TabIndex = 37;
            this.storageDBConnect.Text = "Connect";
            this.storageDBConnect.UseVisualStyleBackColor = true;
            this.storageDBConnect.Click += new System.EventHandler(this.StorageDBConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Database storage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "From read to database";
            // 
            // c
            // 
            this.c.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(460, 34);
            this.c.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(87, 29);
            this.c.TabIndex = 39;
            this.c.Text = "Report";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // openStorageDB
            // 
            this.openStorageDB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStorageDB.Location = new System.Drawing.Point(3, 365);
            this.openStorageDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openStorageDB.Name = "openStorageDB";
            this.openStorageDB.Size = new System.Drawing.Size(87, 29);
            this.openStorageDB.TabIndex = 40;
            this.openStorageDB.Text = "View";
            this.openStorageDB.UseVisualStyleBackColor = true;
            this.openStorageDB.Click += new System.EventHandler(this.OpenStorageDB_Click);
            // 
            // DBclear
            // 
            this.DBclear.Location = new System.Drawing.Point(866, 34);
            this.DBclear.Name = "DBclear";
            this.DBclear.Size = new System.Drawing.Size(88, 29);
            this.DBclear.TabIndex = 41;
            this.DBclear.Text = "Clear All DB";
            this.DBclear.UseVisualStyleBackColor = true;
            this.DBclear.Click += new System.EventHandler(this.DBclear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 654);
            this.Controls.Add(this.DBclear);
            this.Controls.Add(this.openStorageDB);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.storageDBDisConnect);
            this.Controls.Add(this.storageDBConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.openDB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArmStop);
            this.Controls.Add(this.btnArmDown);
            this.Controls.Add(this.btnArmUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDBDisconn);
            this.Controls.Add(this.btnDBConn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisconn);
            this.Controls.Add(this.btnConn);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Robot Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnDisconn;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDBDisconn;
        private System.Windows.Forms.Button btnDBConn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnArmUp;
        private System.Windows.Forms.Button btnArmDown;
        private System.Windows.Forms.Button btnArmStop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openDB;
        private System.Windows.Forms.Button storageDBDisConnect;
        private System.Windows.Forms.Button storageDBConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button openStorageDB;
        private System.Windows.Forms.Button DBclear;
    }
}

