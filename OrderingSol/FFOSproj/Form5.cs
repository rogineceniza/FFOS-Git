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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FFOSproj
{
    public partial class Form5 : Form
    {
        public Form5()
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
            var username = username_admin.Text;
            var password = password_admin.Text;
          
            if (username == "admin123" && password == "admin123")
            {
                    var myForm1 = new Form1();
                    myForm1.ShowDialog();
                    myForm1.Dispose();
            }
            else
            {
                MessageBox.Show("Username and Password do not match.");
                // Passwords do not match
                // Do something, such as displaying an error message or clearing the password field
            }

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
