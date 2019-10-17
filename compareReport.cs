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
    public partial class compareReport : Form
    {
        MySqlConnection myconn = new MySqlConnection("Server=127.0.0.1;User Id=root;password=;Database=library");
        public compareReport()
        {
            InitializeComponent();
            newFetchData();
        }

        public void newFetchData()
        {
            MySqlDataAdapter getMissingBook = new MySqlDataAdapter("SELECT * FROM comparebarcode", myconn);
            //MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM comparebarcode", myconn);
            DataSet ds = new DataSet();
            getMissingBook.Fill(ds, "missingBook");
            dataGridView1.DataSource = ds.Tables["missingBook"];
            dataGridView1.Columns[0].HeaderText = "barcode";
            dataGridView1.Columns[1].HeaderText = "title";
            getMissingBook.Dispose();
            myconn.Close();
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
