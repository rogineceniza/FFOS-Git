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
        public adminLogin()
        {
            InitializeComponent();
        }

        private string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
      
        
        public void login_admin_Click(object sender, EventArgs e)
        {
            var username = username_admin.Text;
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
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
