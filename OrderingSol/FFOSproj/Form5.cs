using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FFOSproj
{

    public partial class adminLogin : Form
    {

        private MySqlConnection connection;
        private string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;"); // Replace with your MySQL connection string
        public adminLogin()
        {
            InitializeComponent();
        }



        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void login_admin_Click(object sender, EventArgs e)
        {
            /* var username = username_admin.Text;
             var password = password_admin.Text;

             if (username == "admin123" && password == "admin123")
             {

                 this.Hide();
                 inventoryManagementForm sistema = new inventoryManagementForm();
                 sistema.ShowDialog();
                 this.Close();
             }
             else
             {
                 MessageBox.Show("Username and password do not match.");
                 // Passwords do not match
                 // Do something, such as displaying an error message or clearing the password field
             }*/

            string username = username_admin.Text;
            string password = password_admin.Text;

            string query = "SELECT * FROM password WHERE Username = @username AND Password = @password";

            using (connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            this.Hide();
                            inventoryManagementForm sistema = new inventoryManagementForm();
                            sistema.ShowDialog();
                            this.Close();
                            // Proceed to the application
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                        }
                    }
                }

            }


        }

        private void changePass_Click(object sender, EventArgs e)
        {
            var openChangePass = new test();
            openChangePass.ShowDialog();
            openChangePass.Dispose();
        }
    }
}
