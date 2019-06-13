using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingleReaderTest
{
    public partial class detailDB : Form
    {
        MySqlConnection myconn = new MySqlConnection("Server=127.0.0.1;User Id=root;password=;Database=test");
        public detailDB()
        {
            InitializeComponent();
            newFetchData();
        }

        public void newFetchData()
        {
            MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM testlibraryreader", myconn);
            DataSet ds = new DataSet();
            mysda.Fill(ds, "result");
            dataGridView1.DataSource = ds.Tables["result"];
            mysda.Dispose();
            myconn.Close();
        }

        public void insertData(String id, int count)
        {
            MySqlCommand mycom = new MySqlCommand("INSERT INTO testlibraryreader (book_ID, count) VALUES('" + id + "','" + count + "')", myconn);
            try
            {
                myconn.Open();
                mycom.ExecuteNonQuery();
                MessageBox.Show(id + " has been successfully added to the database.");
            }
            catch
            {
                MessageBox.Show("Insert error!");
            }
            mycom.Dispose();
            myconn.Close();
        }

        private void DBbutton1_Click_1(object sender, EventArgs e)
        {
            String id;
            int count = 0;
            String temp;
            id = textBox1.Text;
            temp = textBox2.Text;
            
            try
            {
                count = int.Parse(temp);
            }
            catch
            {
                textBox2.Clear();
                MessageBox.Show("You must input an integer");
                return;
            }
            textBox1.Clear();
            textBox2.Clear();
            insertData(id, count);
            newFetchData();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnClearTable_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to clear this database?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                myconn.Open();
                MySqlCommand mycom = new MySqlCommand("DELETE FROM testlibraryreader", myconn);
                mycom.ExecuteNonQuery();
                myconn.Close();
            }
            else
            {
                return;
            }
            newFetchData();
        }
    }
}
