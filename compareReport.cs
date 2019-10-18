using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SingleReaderTest
{
    public partial class compareReport : Form
    {
        MySqlConnection myconn = new MySqlConnection("Server=127.0.0.1;User Id=root;password=;Database=library");
        public compareReport()
        {
            myconn.Open();
            InitializeComponent();
            fetchWrongBooks();
            fetchMissingBook();
            myconn.Close();
        }

        public void fetchMissingBook()
        {
            MySqlDataAdapter getMissingBook = new MySqlDataAdapter("SELECT * FROM comparebarcode", myconn);
            MySqlDataAdapter getWrongBook = new MySqlDataAdapter("SELECT * FROM comparelayercode", myconn);
            DataSet ds1 = new DataSet();
            getMissingBook.Fill(ds1, "missingBook");
            dataGridView1.DataSource = ds1.Tables["missingBook"];
            dataGridView1.Columns[0].HeaderText = "barcode";
            dataGridView1.Columns[1].HeaderText = "title";
            getMissingBook.Dispose();

            DataSet ds2 = new DataSet();
            getWrongBook.Fill(ds2, "wrongBook");
            dataGridView2.DataSource = ds2.Tables["wrongBook"];
            dataGridView2.Columns[0].HeaderText = "barcode";
            dataGridView2.Columns[1].HeaderText = "title";
        }

        public void fetchWrongBooks()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter getWrongBook = new MySqlDataAdapter("SELECT * FROM comparelayercode", myconn);
            getWrongBook.Fill(dt);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    fetchTitle(dr["barcode"].ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            dt.Dispose();
        }

        public void fetchTitle(string barcode) { 

            string result = " ";
            string layercode = " ";
            try
            {
                //fetch the layercode that the book belongs to
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://lrctest.uic.edu.hk/Robot/api/getLayerCode");
                req.Method = "POST";
                req.ContentType = "application/json";
                //keyword
                byte[] data = Encoding.UTF8.GetBytes("{\"barcode\":\"" + barcode + "\"}");
                req.ContentLength = data.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
                System.Net.HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            JObject @object = (JObject)JsonConvert.DeserializeObject(result);
            JArray dataBack = (JArray)@object["data"]["code"];
            for (int i = 0; i < dataBack.Count; i++)
            {
                JObject item = (JObject)dataBack[i];
                layercode = (string)item["number"];
            }

            //when receiving the layercode, obtain the books' info from the server and find the book title of the barcode
            try
            {
                HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://lrctest.uic.edu.hk/Robot/api/getBarcode");
                req2.Method = "POST";
                req2.ContentType = "application/json";
                //keyword
                byte[] data = Encoding.UTF8.GetBytes("{\"number\": \" " + layercode + "\"}");
                req2.ContentLength = data.Length;
                using (Stream reqStream = req2.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
                System.Net.HttpWebResponse resp = (HttpWebResponse)req2.GetResponse();
                Stream stream = resp.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                //Transform JObject to JArray
                JObject obj = (JObject)JsonConvert.DeserializeObject(result);
                JArray data = (JArray)obj["data"]["book"];
                for (int i = 0; i < data.Count; i++)
                {
                    JObject item2 = (JObject)data[i];
                    string fetchedBarcode = (string)item2["barcode"];
                    string title = (string)item2["title"];
                    if(barcode == fetchedBarcode)
                    {
                        MySqlCommand insertTitle = new MySqlCommand("UPDATE compareLayercode SET title = \"" + title + "\" WHERE barCode = '" + barcode + "'", myconn);
                        insertTitle.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
