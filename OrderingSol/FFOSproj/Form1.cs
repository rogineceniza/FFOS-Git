﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using MySqlX.XDevAPI.Relational;
using System.Security.Cryptography;

namespace FFOSproj
{
    public partial class inventoryManagementForm : Form
    {

        private MySqlConnection connection = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");
        private DataTable dataTable = new DataTable();
        private string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();
        //int ID = 0;
        private Timer timer;



        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            dateTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void inventoryManagementForm_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }

        public inventoryManagementForm()
        {
            InitializeComponent();
            inventoryPanel.Visible = true;
            dsrrrrr.Visible = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string Query = "insert into pizza_db.pizza_table(Name, Description, Size, Price) values('" + this.name_txt.Text + "','" + this.description_txt.Text + "','" + this.sizeBox.Text + "','" + this.priceBox.Text + /*"','" + this.brg_imagebox.Text + */"');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Successfully Saved!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            name_txt.Text = "";
            description_txt.Text = "";
            sizeBox.Text = "";
            priceBox.Text = "";

        }


        private void bvrg_save_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string Query = "insert into pizza_db.beverage_table(Name, Description, Size, Price) values('" + this.name_bvrg.Text + "','" + this.description_bvrg.Text + "','" + this.size_bvrg.Text + "','" + this.price_bvrg.Text + /*"','" + this.brg_imagebox.Text + */"');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Successfully Saved!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bvrg_clear_Click(object sender, EventArgs e)
        {
            name_bvrg.Text = "";
            description_bvrg.Text = "";
            size_bvrg.Text = "";
            price_bvrg.Text = "";
        }
        private void addInventoryBTN_Click(object sender, EventArgs e)
        {
            inventoryPanel.Visible = true;
            dsrrrrr.Visible = false;
        }

        private void viewInventoryBTN_Click(object sender, EventArgs e)
        {
            var myForm2 = new pizzaDatagrid();
            myForm2.ShowDialog();
            myForm2.Dispose();
        }
        private void viewBinventory_Click(object sender, EventArgs e)
        {
            var myForm3 = new beverageDatagrid();
            myForm3.ShowDialog();
            myForm3.Dispose();
        }
        private void viewBinventory_Click_1(object sender, EventArgs e)
        {
            var myForm3 = new beverageDatagrid();
            myForm3.ShowDialog();
            myForm3.Dispose();
        }

        private void logOutBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void DSRbtn_Click(object sender, EventArgs e)
        {

            dsrrrrr.Visible = true;
            inventoryPanel.Visible = false;

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

        private void dsrrrrr_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label11_Click(object sender, EventArgs e)
        {
            LoadDataIntoLabel();
        }

        private void LoadDataIntoLabel()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Calculate the total sum for the current day
                    string query = "SELECT SUM(TotalSum) FROM total_sum_saved WHERE DATE(DateTime) = CURDATE()";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    // Update the label with the total sum
                    decimal totalSum = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    DisplayTotalToday.Text = "Total Sum for Today: ₱" + totalSum.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

















