using System;
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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using MySqlX.XDevAPI.Relational;

namespace FFOSproj
{
    public partial class inventoryManagementForm : Form
    {
        // First database connection
        private SqlConnection connection1 = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=pizza_table;Integrated Security=True");
        private DataTable dataTable1 = new DataTable();
        private string connectionString1 = "Data Source=LAPTOP-IJH96CPD;Initial Catalog=pizza_table;Integrated Security=True";
        private SqlDataAdapter dataAdapter1 = new SqlDataAdapter();
        private BindingSource bSource1 = new BindingSource();
        private DataSet dataSet1 = new DataSet();
        private DataTable table1 = new DataTable();

        // Second database connection
        private SqlConnection connection2 = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=beverage_table;Integrated Security=True");
        private DataTable dataTable2 = new DataTable();
        private string connectionString2 = "Data Source=LAPTOP-IJH96CPD;Initial Catalog=beverage_table;Integrated Security=True";
        private SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
        private BindingSource bSource2 = new BindingSource();
        private DataSet dataSet2 = new DataSet();
        private DataTable table2 = new DataTable();

        int ID = 0;
        private Timer timer;

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
                string connectionString = "Data Source=LAPTOP-IJH96CPD;Initial Catalog=pizza_table;Integrated Security=True";
                string query = "INSERT INTO pizza_table (Name, Description, Size, Price) VALUES (@Name, @Description, @Size, @Price)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name_txt.Text);
                        command.Parameters.AddWithValue("@Description", description_txt.Text);
                        command.Parameters.AddWithValue("@Size", sizeBox.Text);
                        command.Parameters.AddWithValue("@Price", priceBox.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");
                    }
                }
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
                string connectionString = "Data Source=LAPTOP-IJH96CPD;Initial Catalog=beverage_table;Integrated Security=True";
                string query = "INSERT INTO beverage_table (Name, Description, Size, Price) VALUES (@Name, @Description, @Size, @Price)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name_bvrg.Text);
                        command.Parameters.AddWithValue("@Description", description_bvrg.Text);
                        command.Parameters.AddWithValue("@Size", size_bvrg.Text);
                        command.Parameters.AddWithValue("@Price", price_bvrg.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved!");
                    }
                }
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
            this.Hide();

            var inventoryManagementForm = new pizzaDatagrid();
            inventoryManagementForm.ShowDialog();

            inventoryManagementForm.Close();

            /*
                        ViewP.Visible = true;
                        dsrrrrr.Visible = false;
                        inventoryPanel.Visible = false;
                        ViewB.Visible = false;*/


        }

        private void DSRbtn_Click(object sender, EventArgs e)
        {

            dsrrrrr.Visible = true;
            inventoryPanel.Visible = false;

        }
        private void viewBinventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inventoryManagementForm = new beverageDatagrid();
            inventoryManagementForm.ShowDialog();
            inventoryManagementForm.Close();

            /*ViewB.Visible = true;
            ViewP.Visible = false;
            dsrrrrr.Visible = false;
            inventoryPanel.Visible = false;
*/

        }



        private void viewBinventory_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var inventoryManagementForm = new beverageDatagrid();
            inventoryManagementForm.ShowDialog();
            inventoryManagementForm.Close();
        }

        private void logOutBTN_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Hide(); // Hide the current form instead of closing it

            // Create and display the new login form
            var loginForm = new LoginForm();
            loginForm.ShowDialog();

            // After the login form is closed, close the previous form
            this.Close();
        }
    }
}











