using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFOSproj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void showPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            


        }

        private void datagrid_btn_Click(object sender, EventArgs e)
        {
            /*MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");

            string query = "select *from pizza_table";

            using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, con))
            {

                DataSet dset = new DataSet();

                adpt.Fill(dset);

                showPB.DataSource = dset.Tables[0];

            }
            con.Dispose();*/


            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=RteCh_0C#@11");
            MySqlCommand command;
            MySqlDataAdapter da;

            string selectQuery = "SELECT * FROM pizza_db.pizza_table";
            command = new MySqlCommand(selectQuery, connection);
            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            showPB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showPB.RowTemplate.Height = 100;
            showPB.AllowUserToAddRows = false;

            da.Fill(table);

            showPB.DataSource = table;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)showPB.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            da.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}
