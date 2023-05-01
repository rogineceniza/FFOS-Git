using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Data.SqlClient;

namespace FFOSproj
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=RteCh_0C#@11");
        MySqlCommand command;
        MySqlDataAdapter da;

       /* SqlConnection con = new SqlConnection("Data Source=.;localhost;port=3306;username=root;password=RteCh_0C#@11");
        SqlCommand cmd;
        SqlDataAdapter adapt;*/
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void showPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void datagrid_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");

            string query = "select *from pizza_table";

            using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, con))
            {

                DataSet dset = new DataSet();

                 adpt.Fill(dset);

                 showPB.DataSource = dset.Tables[0];




            }
            con.Dispose();

            /*con.Open();
            DataTable dt = new DataTable();
            var adapt = new SqlDataAdapter("select * from pizza_table", con);
            adapt.Fill(dt);
            showPB.DataSource = dt;
            con.Dispose();*/



        }

        private void del_pizza_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewCell oneCell in showPB.SelectedCells)
            {
                if (oneCell.Selected)
                    showPB.Rows.RemoveAt(oneCell.RowIndex);
            }*/

            /* foreach (DataGridViewCell oneCell in showPB.SelectedCells)
             {
                 if (oneCell.Selected)
                     showPB.Rows.RemoveAt(oneCell.RowIndex);
             }

             int selectedCount = showPB.SelectedRows.Count;
             while (selectedCount > 0)
             {
                 if (!showPB.SelectedRows[0].IsNewRow)
                     showPB.Rows.RemoveAt(showPB.SelectedRows[0].Index);
                 selectedCount--;
             }*/


            foreach (DataGridViewRow item in this.showPB.SelectedRows)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");
                using (MySqlConnection cs = new MySqlConnection())
                {
                    MySqlCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(showPB.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from pizza_table where id='" + id + "'";

                    showPB.Rows.RemoveAt(this.showPB.SelectedRows[0].Index);
                    con.Open();
                    cmd.ExecuteNonQuery();

                }

            }
        }

        private void update_pizza_Click(object sender, EventArgs e)
        {
          /*  if (txt_Name.Text != "" && txt_State.Text != "")
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");
              var  cmd = new SqlCommand("update tbl_Record set Name=@name,State=@state where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@state", txt_State.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }*/
        }
    }
}
    

