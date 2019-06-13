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
    public partial class storageForm : Form
    {
        MySqlConnection myconn = new MySqlConnection("Server=127.0.0.1;User Id=root;password=;Database=test");
        public storageForm()
        {
            InitializeComponent();
            fetchData();
        }

        public void fetchData()
        {
            MySqlDataAdapter mysda = new MySqlDataAdapter("SELECT * FROM totalstorage", myconn);
            DataSet ds = new DataSet();
            mysda.Fill(ds, "result");
            storageDBView.DataSource = ds.Tables["result"];
            mysda.Dispose();
            myconn.Close();
        }

        private void BtnClearStorageDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear this database?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                myconn.Open();
                MySqlCommand mycom = new MySqlCommand("DELETE FROM totalstorage", myconn);
                mycom.ExecuteNonQuery();
                myconn.Close();
            }
            else
            {
                return;
            }
            fetchData();
        }
    }
}
