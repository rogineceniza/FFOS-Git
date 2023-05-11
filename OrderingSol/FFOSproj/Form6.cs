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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void login_admin_Click(object sender, EventArgs e)
        {
            var username = username_cashier.Text;
            var password = password_cashier.Text;

            if (username == "cashier123" && password == "cashier123")
            {
                var myForm6 = new Cashier_Formmmm();
                myForm6.ShowDialog();
                myForm6.Dispose();
            }
            else
            {
                MessageBox.Show("Username and Password do not match.");
                // Passwords do not match
                // Do something, such as displaying an error message or clearing the password field
            }

        }
    }
    }

