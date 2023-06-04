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
    public partial class cashierLogin : Form
    {
        private MySqlConnection connection;
        private const string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");
        public cashierLogin()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cLogin_Click(object sender, EventArgs e)
        {
            /* var username = username_cashier.Text;
             var password = password_cashier.Text;

             if (username == "cashier123" && password == "cashier123")
             {
                 this.Hide();
                 Cashier_Formmmm sistema = new Cashier_Formmmm();
                 sistema.ShowDialog();
                 this.Close();
             }
             else
             {
                 MessageBox.Show("Username and password do not match.");
                 // Passwords do not match
                 // Do something, such as displaying an error message or clearing the password field
             }*/

            string username = username_cashier.Text;
            string password = password_cashier.Text;

            string query = "SELECT * FROM password_cashier WHERE Username = @username AND Password = @password";

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
                            Cashier_Formmmm sistema = new Cashier_Formmmm();
                            sistema.ShowDialog();
                            this.Close();
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
            var openChangePass = new cashierChangePass();
            openChangePass.ShowDialog();
            openChangePass.Dispose();
        }
    }
}

