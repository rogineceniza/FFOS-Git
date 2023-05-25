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
    public partial class beverageDatagrid : Form
    {

        private SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=beverage_table;Integrated Security=True");
        private SqlCommand command;

        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();
        int ID = 0;


        public beverageDatagrid()
        {
            InitializeComponent();
            string connectionString = "Data Source=LAPTOP-IJH96CPD;Initial Catalog=beverage_table;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM beverage_table", sqlCon);
            dataAdapter.Fill(table);
            bSource.DataSource = table;
            showPB.DataSource = bSource;

            sqlCon.Close();

        }



        private void showPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitializeComponent();
            string connectionString = "Data Source=LAPTOP-IJH96CPD;Initial Catalog=beverage_table;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM beverage_table", sqlCon);
            dataAdapter.Fill(table);
            bSource.DataSource = table;
            showPB.DataSource = bSource;

            sqlCon.Close();
        }

      

        private void del_pizza_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.showPB.SelectedRows)
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=beverage_table;Integrated Security=True"))
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

                        cmd.CommandText = "DELETE FROM beverage_table WHERE Name=@Name AND Description=@Description AND Size=@Size AND Price=@Price";
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

        private void beverageDatagrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizza_tableDataSet1.pizza_table' table. You can move, or remove it, as needed.
            this.beverage_tableTableAdapter.Fill(this.beverage_tableDataSet.beverage_table);
            // TODO: This line of code loads data into the 'pizza_tableDataSet.pizza_table' table. You can move, or remove it, as needed.

            // Create a new instance of SqlConnection using your connection string
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=beverage_table;Integrated Security=True"))
            {
                // Open the connection
                connection.Open();

                // Create a new instance of SqlDataAdapter and SqlCommand
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT * FROM beverage_table", connection);

                // Clear the existing DataTable
                beverage_tableDataSet.beverage_table.Clear();

                // Fill the DataTable with data from the database using SqlDataAdapter
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(beverage_tableDataSet.beverage_table);
            }

        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new instance of SqlConnection using your connection string
                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=beverage_table;Integrated Security=True"))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new instance of SqlDataAdapter and SqlCommand
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand("SELECT * FROM beverage_table", connection);

                    // Clear the existing DataTable
                    beverage_tableDataSet.beverage_table.Clear();

                    // Fill the DataTable with data from the database using SqlDataAdapter
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(beverage_tableDataSet.beverage_table);
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

            var beverageDatagrid = new inventoryManagementForm();
            beverageDatagrid.ShowDialog();

            beverageDatagrid.Close();
        }
    }
}


