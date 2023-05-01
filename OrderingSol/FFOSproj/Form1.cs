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
                string Query = "insert into pizza_db.pizza_table(Name, Description, Size, Price) values('" + this.name_txt.Text + "','" + this.description_txt.Text+ "','" + this.sizeBox.Text + "','" + this.priceBox.Text +/* "','" + this.imageBox.Text +  */"');";
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
         //   imageBox.Image = null;

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

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(vScrollBar1_Scroll);
        }

        private void bvrg_save_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string Query = "insert into pizza_db.beverage_table(Name, Description, Size, Price) values('" + this.name_bvrg.Text + "','" + this.description_bvrg.Text + "','" + this.size_bvrg.Text + "','" + this.price_bvrg.Text + /*"','" + this.brg_imagebox.Text + */"');";
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

        private void bvrg_clear_Click(object sender, EventArgs e)
        {
            name_bvrg.Text = "";
            description_bvrg.Text = "";
            size_bvrg.Text = "";
            price_bvrg.Text = "";
         //  brg_imagebox.Image = null;
        }

       /* private void upload_bvrg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    brg_imagebox.Text = openFileDialog1.FileName;
                    brg_imagebox.Image = Image.FromFile(openFileDialog1.FileName);
                }
                brg_imagebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void del_bvrg_Click(object sender, EventArgs e)
        {
            brg_imagebox.Image = null;
        }*/
    }
}

            

//NOTE: images in db, deleted
//Commented upload and delete (image)
//Return image and uncomment 
//Covered image picturebox with panel, remove after