using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFOSproj
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=RteCh_0C#@11");
        MySqlCommand command;
        MySqlDataAdapter da;
        public Form2()
        {
            InitializeComponent();
        }

        private void showPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void datagrid_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");

            string query = "select *from pizza_table";

            using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, con))
            {

                DataSet dset = new DataSet();

                adpt.Fill(dset);

                showPB.DataSource = dset.Tables[0];

            }
            con.Dispose();





        }
    }
}
