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
    public partial class cashierChangePass : Form
    {
        private MySqlConnection connection;
        private const string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");
        public cashierChangePass()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Get the user input
            string newUsername = txtNewUsername.Text;
            string oldUsername = txtOldUsername.Text;
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;

            string query = "UPDATE password_cashier SET Username = @newUsername, Password = @newPassword WHERE Username = @oldUsername AND Password = @oldPassword";

            using (connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newUsername", newUsername);
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@oldUsername", oldUsername);
                    command.Parameters.AddWithValue("@oldPassword", oldPassword);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Username and password changed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or old password!");
                    }
                }
            }
        }
    }
    }

