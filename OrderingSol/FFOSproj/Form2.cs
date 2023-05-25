using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FFOSproj
{
    public partial class pizzaDatagrid : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=pizza_table;Integrated Security=True");
        private SqlCommand command;

        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();
        int ID = 0;

        public pizzaDatagrid()
        {
            InitializeComponent();
            string connectionString = "Data Source=LAPTOP-IJH96CPD;Initial Catalog=pizza_table;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            // Select command has to include the primary key column, otherwise update command will fail
            // as it does not know exactly which row is updated.
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM pizza_table", sqlCon);
            dataAdapter.Fill(table);
            bSource.DataSource = table;
            showPB.DataSource = bSource;

            sqlCon.Close();
        }

        private void datagrid_btn_Click(object sender, EventArgs e)
        {
        }

        private void del_pizza_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow item in this.showPB.SelectedRows)
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=pizza_table;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        int rowIndex = item.Index;
                        // Assuming the columns are in the following order: Name, Description, Size, Price
                        string Name = showPB.Rows[rowIndex].Cells[0].Value.ToString();
                        string Description = showPB.Rows[rowIndex].Cells[1].Value.ToString();
                        string Size = showPB.Rows[rowIndex].Cells[2].Value.ToString();
                        decimal Price = Convert.ToDecimal(showPB.Rows[rowIndex].Cells[3].Value);

                        cmd.CommandText = "DELETE FROM pizza_table WHERE Name=@Name AND Description=@Description AND Size=@Size AND Price=@Price";
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Description", Description);
                        cmd.Parameters.AddWithValue("@Size", Size);
                        cmd.Parameters.AddWithValue("@Price", Price);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        showPB.Rows.RemoveAt(rowIndex);
                    }
                }
            }

        }

        private void update_pizza_btn_Click(object sender, EventArgs e)
        {
            //using MySql.Data.MySqlClient; 

            /* string connectionString = "server=localhost;port=3306;database=pizza_db;uid=root;password=RteCh_0C#@11"; 

             MySqlConnection connection = new MySqlConnection(connectionString); 

             string query = "UPDATE pizza_table SET column1=@value1, column2=@value2 WHERE id=@id"; // replace with your own query

             MySqlCommand command = new MySqlCommand(query, connection); // create a new MySqlCommand object

             command.Parameters.AddWithValue("@value1", "new value 1"); // set the parameter values
             command.Parameters.AddWithValue("@value2", "new value 2");
             command.Parameters.AddWithValue("@id", 1);

             try
             {
                 connection.Open(); // open the connection

                 int rowsAffected = command.ExecuteNonQuery(); // execute the query and get the number of rows affected

                 Console.WriteLine("Rows affected: " + rowsAffected);
             }
             catch (MySqlException ex)
             {
                 Console.WriteLine("Error: " + ex.Message);
             }
             finally
             {
                 connection.Close(); // close the connection
             }*/

            
        }

        private void showPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pizzaDatagrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizza_tableDataSet1.pizza_table' table. You can move, or remove it, as needed.
            this.pizza_tableTableAdapter1.Fill(this.pizza_tableDataSet1.pizza_table);
            // TODO: This line of code loads data into the 'pizza_tableDataSet.pizza_table' table. You can move, or remove it, as needed.

            // Create a new instance of SqlConnection using your connection string
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=pizza_table;Integrated Security=True"))
            {
                // Open the connection
                connection.Open();

                // Create a new instance of SqlDataAdapter and SqlCommand
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM pizza_table", connection);

                // Clear the existing DataTable
                pizza_tableDataSet.pizza_table.Clear();

                // Fill the DataTable with data from the database using SqlDataAdapter
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(pizza_tableDataSet.pizza_table);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new instance of SqlConnection using your connection string
                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=pizza_table;Integrated Security=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new instance of SqlDataAdapter and SqlCommand
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand("SELECT * FROM pizza_table", connection);

                    // Clear the existing DataTable
                    pizza_tableDataSet.pizza_table.Clear();

                    // Fill the DataTable with data from the database using SqlDataAdapter
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(pizza_tableDataSet.pizza_table);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var pizzaDatagrid = new inventoryManagementForm();
            pizzaDatagrid.ShowDialog();

            pizzaDatagrid.Close();
        }
    }
}
        
        

    



    