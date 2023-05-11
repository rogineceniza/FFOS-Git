using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class Cashier_Formmmm : Form
    {
        
        public Cashier_Formmmm()
        {
            InitializeComponent();

            vScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            vScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;
            vScrollBar1.Value = flowLayoutPanel1.VerticalScroll.Value;

         
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Button() { Text = "Hello World!" });

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Panel myPanel = new Panel();

            myPanel.AutoScroll = true;

            vScrollBar1.Maximum = 100;
            vScrollBar1.Minimum = 0;
            vScrollBar1.Value = 0;
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.Location = new Point(vScrollBar1.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
