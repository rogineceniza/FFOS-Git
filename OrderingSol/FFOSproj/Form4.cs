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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void admin_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm4 = new adminLogin();
            myForm4.ShowDialog();
            this.Close();
        }

        private void cashier_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm4 = new cashierLogin();
            myForm4.ShowDialog();
            myForm4.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
