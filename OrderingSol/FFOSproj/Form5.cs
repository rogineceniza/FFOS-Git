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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FFOSproj
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }


        public void username_admin_TextChanged(object sender, EventArgs e)
        {
        }

        public void password_admin_TextChanged(object sender, EventArgs e)
        {
        }
        public void login_admin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IJH96CPD;Initial Catalog=resetPassword;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from resetPassword where username = '" + username_admin.Text + "' and password = '" + password_admin.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully!");

                this.Hide();

                    var myForm1 = new inventoryManagementForm();
                    myForm1.ShowDialog();

                    myForm1.Close();
            }
            else
            {
                MessageBox.Show("Username and password do not match.");
                // Passwords do not match
                // Do something, such as displaying an error message or clearing the password field
            }

        }

        

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            var myForm1 = new LoginForm();
            myForm1.ShowDialog();

            myForm1.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            var myForm1 = new forgotPassword();
            myForm1.ShowDialog();

            myForm1.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
