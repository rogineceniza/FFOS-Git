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
        public cashierLogin()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var cashierLogin = new LoginForm();
            cashierLogin.ShowDialog();

            cashierLogin.Close();
        }

        private void cLogin_Click(object sender, EventArgs e)
        {
            var username = username_cashier.Text;
            var password = password_cashier.Text;

            if (username == "cashier123" && password == "cashier123")
            {
                this.Hide();
                var myForm6 = new Cashier_Formmmm();
                myForm6.ShowDialog();
                myForm6.Close();
            }
            else
            {
                MessageBox.Show("Username and password do not match.");
                // Passwords do not match
                // Do something, such as displaying an error message or clearing the password field
            }
        }
    }
    }

