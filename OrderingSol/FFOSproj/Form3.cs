using MySql.Data.MySqlClient;
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
    public partial class beverageDatagrid : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=RteCh_0C#@11");
        MySqlCommand command;
        MySqlDataAdapter da;

        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();
        int ID = 0;

        private string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");

        public beverageDatagrid()
        {
            InitializeComponent();
            string connectionString = "server = localhost; userid = root; database = pizza_db; port = 3306; password =  RteCh_0C#@11";
            MySqlConnection mysqlCon = new MySqlConnection(connectionString);
            mysqlCon.Open();

            MyDA.SelectCommand = new MySqlCommand("SELECT * from beverage_table", mysqlCon);
            MyDA.Fill(table);
            bSource.DataSource = table;
            showPB.DataSource = bSource;

            mysqlCon.Close();
        }




        private void del_pizza_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.showPB.SelectedRows)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");
                using (MySqlConnection cs = new MySqlConnection())
                {
                    MySqlCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(showPB.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from beverage_table where id='" + id + "'";

                    showPB.Rows.RemoveAt(this.showPB.SelectedRows[0].Index);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnection2 = "server=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string name = myname.Text;
                string description = mydes.Text;
                string size = mysize.Text;
                decimal price = decimal.Parse(myprice.Text);

                string insertQuery = "INSERT INTO pizza_db.beverage_table (Name, Description, Size, Price) VALUES (@name, @description, @size, @price)";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, MyConn2);

                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@description", description);
                insertCommand.Parameters.AddWithValue("@size", size);
                insertCommand.Parameters.AddWithValue("@price", price);

                MyConn2.Open();
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved!");

                myname.Text = "";
                mydes.Text = "";
                mysize.Text = "";
                myprice.Text = "";

                // Delete the current row from the database
                int selectedRowIndex = showPB.CurrentRow.Index;
                int id = Convert.ToInt32(showPB.Rows[selectedRowIndex].Cells["ID"].Value);
                string deleteQuery = "DELETE FROM pizza_db.beverage_table WHERE ID = @id";
                MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, MyConn2);
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();

                // Delete the current row from the DataGridView
                showPB.Rows.RemoveAt(selectedRowIndex);

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in showPB.SelectedRows)
            {
                // string itemID = row.Cells["ID"].Value.ToString();
                string itemName = row.Cells["Name"].Value.ToString();
                string itemDes = row.Cells["Description"].Value.ToString();
                string itemSize = row.Cells["Size"].Value.ToString();
                string itemPrice = row.Cells["Price"].Value.ToString();

                //  myid.Text = itemID;
                myname.Text = itemName;
                mydes.Text = itemDes;
                mysize.Text = itemSize;
                myprice.Text = itemPrice;
            }
        }

        private void refereshhh_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM beverage_table";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    showPB.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       
    }
}


