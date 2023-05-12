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
       
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();
        int ID = 0;
        public Form2()
        {
            InitializeComponent();
            string connectionString = "server = localhost; userid = root; database = pizza_db; port = 3306; password = RteCh_0C#@11";
            MySqlConnection mysqlCon = new MySqlConnection(connectionString);
            mysqlCon.Open();

            //select command has to include the primary key column, otherwise update command will fail
            //as it does not know exactly what row is updated.
            MyDA.SelectCommand = new MySqlCommand("SELECT * from pizza_table", mysqlCon);
            MyDA.Fill(table);
            bSource.DataSource = table;
            showPB.DataSource = bSource;

            mysqlCon.Close();
        }



        private void datagrid_btn_Click(object sender, EventArgs e)
        {
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

        private void update_pizza_btn_Click(object sender, EventArgs e)
        {
            //using MySql.Data.MySqlClient; 

            /* string connectionString = "server=localhost;port=3306;database=pizza_db;uid=root;password=RteCh_0C#@11"; 

             MySqlConnection connection = new MySqlConnection(connectionString); 

             string query = "UPDATE pizza_table SET column1=@value1, column2=@value2 WHERE id=@id"; // replace with your own query

             MySqlCommand command = new MySqlCommand(query, connection); // create a new MySqlCommand object

             command.Parameters.AddWithValue("@value1", "new value 1"); // set the parameter values
             command.Parameters.AddWithValue("@value2", "new value 2");
             command.Parameters.AddWithValue("@id", 1);

             try
             {
                 connection.Open(); // open the connection

                 int rowsAffected = command.ExecuteNonQuery(); // execute the query and get the number of rows affected

                 Console.WriteLine("Rows affected: " + rowsAffected);
             }
             catch (MySqlException ex)
             {
                 Console.WriteLine("Error: " + ex.Message);
             }
             finally
             {
                 connection.Close(); // close the connection
             }*/

            
        }

        private void showPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
        
        

    



    