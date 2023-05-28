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
        private MySqlConnection connection;
        private const string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");

        public test()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);

        }
        private void InitializeComponents()
        {

        }

        private void test_Load(object sender, EventArgs e)
        {
           
                // Connection string for connecting to MySQL
                string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");

            // SQL query to retrieve the daily sales data
            string query = "SELECT DATE(DateTime) AS Date, SUM(TotalSum) AS TotalSales " +
                               "FROM total_sum_saved " +
                               "GROUP BY DATE(DateTime)";
            try
                {
                    // Create a MySqlConnection using the connection string
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        // Open the database connection
                        connection.Open();

                        // Create a MySqlCommand with the query and connection
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Create a DataTable to store the results
                            DataTable dataTable = new DataTable();

                            // Load the data from the MySqlCommand into the DataTable
                            dataTable.Load(command.ExecuteReader());

                            // Bind the DataTable to the DataGridView control
                            sales.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the process
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

    }
}











