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
        MySqlConnection myconn = new MySqlConnection("Server=127.0.0.1;User Id=root;password=;Database=test");
        public compareReport()
        {
            InitializeComponent();
            newFetchData();
        }

        public void newFetchData()
        {
            MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT book_ID FROM compareResult", myconn);
            DataSet ds = new DataSet();
            mysda.Fill(ds, "book_ID");
            dataGridView1.DataSource = ds.Tables["book_ID"];
            mysda.Dispose();
            myconn.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear this database?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                myconn.Open();
                MySqlCommand mycom = new MySqlCommand("DELETE FROM compareResult", myconn);
                mycom.ExecuteNonQuery();
                myconn.Close();
            }
            else
            {
                return;
            }
            newFetchData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
