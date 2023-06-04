﻿using System;
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



        private void reset_Click(object sender, EventArgs e)
        {
            // Get the user input
            string newUsername = txtNewUsername.Text;
            string oldUsername = txtOldUsername.Text;
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;

            string query = "UPDATE password SET Username = @newUsername, Password = @newPassword WHERE Username = @oldUsername AND Password = @oldPassword";

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
      
       
       



 








