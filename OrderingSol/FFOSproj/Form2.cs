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
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();
        int ID = 0;
        public Form2()
        {
            InitializeComponent();
        }



        private void datagrid_btn_Click(object sender, EventArgs e)
        {
            /* MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");

             string query = "select *from pizza_table";

             using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, con))
             {

                 DataSet dset = new DataSet();

                 adpt.Fill(dset);

                 showPB.DataSource = dset.Tables[0];




             }
             con.Dispose();*/

            string connectionString = "server = localhost; userid = root; database = pizza_db; port = 3306; password = RteCh_0C#@11";
            MySqlConnection mysqlCon = new MySqlConnection(connectionString);
            mysqlCon.Open();

            //select command has to include the primary key column, otherwise update command will fail
            //as it does not know exactly what row is updated.
            MyDA.SelectCommand = new MySqlCommand("SELECT * from pizza_table", mysqlCon);
            MyDA.Fill(table);
            bSource.DataSource = table;
            showPB.DataSource = bSource;

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
            

        }
    }
}
    

