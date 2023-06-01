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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string username = textBox4.Text;
                string currentPassword = textBox1.Text;

                // Verify username and current password from the database
                if (VerifyCredentials(username, currentPassword))
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");
                    string updateQuery = "UPDATE password SET Password = @password WHERE Username = @username";

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            MySqlCommand command = new MySqlCommand(updateQuery, connection);
                            command.Parameters.AddWithValue("@password", HashPassword(textBox3.Text));
                            command.Parameters.AddWithValue("@username", username);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password reset successfully!");

                                this.Hide();

                                var changePassword = new adminLogin();
                                changePassword.ShowDialog();

                                changePassword.Close();
                            }
                            else
                            {
                                MessageBox.Show("Could not reset password for user " + username);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match. Please enter the same password in both fields.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or current password.");
                }
            }

            private bool VerifyCredentials(string username, string currentPassword)
            {
                string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");
            string selectQuery = "SELECT COUNT(*) FROM Password WHERE Username = @username AND @password = @currentPassword";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@currentPassword", HashPassword(currentPassword));
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }


        private string HashPassword(string password)
        {
            // TODO: Implement password hashing algorithm (e.g. SHA256)
            return password;
        }
    }
    }
      
       
       



 








