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
    public partial class Form3 : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=P@ssw0rd");
        MySqlCommand command;
        MySqlDataAdapter da;

        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();
        int ID = 0;


        public Form3()
        {
            InitializeComponent();
            string connectionString = "server = localhost; userid = root; database = pizza_db; port = 3306; password =  P@ssw0rd";
            MySqlConnection mysqlCon = new MySqlConnection(connectionString);
            mysqlCon.Open();

            MyDA.SelectCommand = new MySqlCommand("SELECT * from beverage_table", mysqlCon);
            MyDA.Fill(table);
            bSource.DataSource = table;
            showPB.DataSource = bSource;

            mysqlCon.Close();
        }



        private void showPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void del_pizza_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.showPB.SelectedRows)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=P@ssw0rd");
                using (MySqlConnection cs = new MySqlConnection())
                {
                    MySqlCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(showPB.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from beverage_table where id='" + id + "'";

                    showPB.Rows.RemoveAt(this.showPB.SelectedRows[0].Index);
                    con.Open();
                    cmd.ExecuteNonQuery();


                }

            }
        }
    }
}


