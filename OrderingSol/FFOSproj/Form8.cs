using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FFOSproj
{
    public partial class test : Form
    {
        private DataGridView dataGridView;
        public test()
        {
            InitializeComponent();
            LoadData();

        }
        private void InitializeComponents()
        {
            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            Controls.Add(dataGridView);
        }

        private void LoadData()
        {
            string connectionString = "Server=localhost;Database=pizza_db;Uid=root;Pwd=RteCh_0C#@11;";

            string query1 = "SELECT * FROM pizza_table";

            string query2 = "SELECT * FROM beverage_table";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();

                    MySqlCommand command1 = new MySqlCommand(query1, connection);
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
                    adapter1.Fill(dataTable);

                    MySqlCommand command2 = new MySqlCommand(query2, connection);
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
                    adapter2.Fill(dataTable);

                    merge.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}

