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

namespace FFOSproj
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=RteCh_0C#@11");
        MySqlCommand command;
        MySqlDataAdapter da;
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
    

