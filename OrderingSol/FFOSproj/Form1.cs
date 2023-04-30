using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FFOSproj
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void viewInventoryBTN_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.ShowDialog();

            myForm2.Dispose();

        }

       

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string Query = "insert into pizza_db.pizza_table(Name, Description, Size, Price, Image) values('" + this.name_txt.Text + "','" + this.description_txt.Text+ "','" + this.sizeBox.Text + "','" + this.priceBox.Text + "','" + this.imageBox.Text +  "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            name_txt.Text = "";
            description_txt.Text = "";
            sizeBox.Text = "";
            priceBox.Text = "";
            imageBox.Image = null;

        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                   imageBox.Text = openFileDialog1.FileName;
                   imageBox.Image = Image.FromFile(openFileDialog1.FileName);
                }
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
             imageBox.Image = null;
        }
    }
}

            

