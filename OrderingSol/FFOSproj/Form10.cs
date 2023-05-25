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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FFOSproj
{
    public partial class changePassword : Form
    {
        string username = "cenizamahinay@gmail.com";
        public changePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var changePassword = new adminLogin();
            changePassword.ShowDialog();

            changePassword.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                string connectionString = "Data Source=LAPTOP-IJH96CPD;Initial Catalog=resetPassword;Integrated Security=True";
                string updateQuery = "UPDATE [dbo].[resetPassword] SET [password] = @password WHERE username = @username";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(updateQuery, connection);
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

        private string HashPassword(string password)
        {
            // TODO: Implement password hashing algorithm (e.g. SHA256)
            return password;
        }
    }
    
}
