using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class Cashier_Formmmm : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=RteCh_0C#@11");
        MySqlCommand command;
        MySqlDataAdapter da;

        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();
        int ID = 0;

      



        public Cashier_Formmmm()
        {


            InitializeComponent();
            string connectionString = "server = localhost; userid = root; database = pizza_db; port = 3306; password = RteCh_0C#@11";
            MySqlConnection mysqlCon = new MySqlConnection(connectionString);
            mysqlCon.Open();

            MyDA.SelectCommand = new MySqlCommand("SELECT * from beverage_table", mysqlCon);
            MyDA.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            mysqlCon.Close();

          
            mysqlCon.Open();
            MyDA.SelectCommand = new MySqlCommand("SELECT * from pizza_table", mysqlCon);
            MyDA.Fill(table);
            bSource.DataSource = table;
            dataGridView2.DataSource = bSource;
            mysqlCon.Close();


        }


    }
}
