using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Collections;

namespace FFOSproj
{
    public partial class Cashier_Formmmm : Form
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");
        private DataTable dataTable = new DataTable();
        private string connectionString = ("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();
        int ID = 0;
        private Timer timer;
        private DataGridView dataGridView;
        private DataTable dataTablee;

        public Cashier_Formmmm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            LoadData();
        }

        private void InitializeComponents()
        {
            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            Controls.Add(dataGridView);
        }


        private void LoadData()
        {
            string connectionString = "Server=localhost;Database=pizza_db;Uid=root;Pwd=RteCh_0C#@11;";
            string query1 = "SELECT * FROM pizza_table";
            string query2 = "SELECT * FROM beverage_table";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    MySqlCommand command1 = new MySqlCommand(query1, connection);
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
                    adapter1.Fill(dataTable);
                    MySqlCommand command2 = new MySqlCommand(query2, connection);
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
                    adapter2.Fill(dataTable);
                    merge.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Cashier_Formmm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dateToday.Text = DateTime.Now.ToString();
        }

        private void LoadDataIntoDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM purchased_items";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView4.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        /* private void LoadDataPizza()
         {

             string connectionString = "Server=localhost;Database=pizza_db;Uid=root;Pwd=RteCh_0C#@11;";
             MySqlConnection connection = new MySqlConnection(connectionString);
             string query = "SELECT Name, Size, Price FROM (pizza_table)";
             MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
             DataTable table = new DataTable();
             adapter.Fill(table);
             merge.DataSource = table;

         }*/

        /*private void LoadDataBeverages()
        {
            string connectionString = "Server=localhost;Database=pizza_db;Uid=root;Pwd=RteCh_0C#@11;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT Name, Size, Price FROM beverage_table";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }*/

        /* private void refresh_btn_Click(object sender, EventArgs e)
         {
             LoadDataPizza();
         }*/

        /* private void refresh2_btn_Click(object sender, EventArgs e)
         {
             LoadDataBeverages();
         }
 */
        private void dateToday_Click(object sender, EventArgs e)
        {
            dateToday.Text = DateTime.Now.ToString();
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in merge.SelectedRows)
            {
                string itemName = row.Cells["Name"].Value.ToString();
                string itemSize = row.Cells["Size"].Value.ToString();
                string itemPrice = row.Cells["Price"].Value.ToString();

                nameTXT.Text = itemName;
                sizeTXT.Text = itemSize;
                priceTXT.Text = itemPrice;
            }


        }

        /* private void btn2_Click(object sender, EventArgs e)
         {
             foreach (DataGridViewRow row in dataGridView2.SelectedRows)
             {
                 string itemName = row.Cells["Name"].Value.ToString();
                 string itemSize = row.Cells["Size"].Value.ToString();
                 string itemPrice = row.Cells["Price"].Value.ToString();

                 nameTXT.Text = itemName;
                 sizeTXT.Text = itemSize;
                 priceTXT.Text = itemPrice;
             }
         }
 */
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBTN_Click(object sender, EventArgs e)
        {

            /*try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string Query = "insert into pizza_db.purchased_items(Name,Size,Quantity,Price) values('" + this.nameTXT.Text + "','" + this.sizeTXT.Text + "','" + this.quantityTXT.Text + "','" + this.priceTXT.Text + "'); ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Successfully Saved!");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string name = nameTXT.Text;
                string size = sizeTXT.Text;
                int quantity = int.Parse(quantityTXT.Text);
                decimal price = decimal.Parse(priceTXT.Text);
                decimal totalPrice = price * quantity;

                string Query = "insert into pizza_db.purchased_items(Name,Size,Quantity,Price) values('" + name + "','" + size + "','" + quantity + "','" + totalPrice + "'); ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Successfully Saved!");

                nameTXT.Text = "";
                sizeTXT.Text = "";
                quantityTXT.Text = "1";
                priceTXT.Text = "";

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


        private void displayBTN_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView4.SelectedRows)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");
                using (MySqlConnection cs = new MySqlConnection())
                {
                    MySqlCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(dataGridView4.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from purchased_items where id='" + id + "'"; /*current_table*/

                    dataGridView4.Rows.RemoveAt(this.dataGridView4.SelectedRows[0].Index);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }






        private void totalllll_Click(object sender, EventArgs e)
        {
            decimal Total = 0;
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dataGridView4.Rows[i].Cells["Price"].Value);
            }
            totalLabel.Text = Total.ToString();
        }


        string tableName = "total_sum_saved";
        private void saveCurrent_Click(object sender, EventArgs e)
        {
            try
            {
                string textBoxValue = totalLabel.Text;
                DateTime currentTime = DateTime.Now;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string insertQuery = $"INSERT INTO {tableName} (TotalSum, DateTime) VALUES (@sum, @time)";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@sum", textBoxValue);
                    command.Parameters.AddWithValue("@time", currentTime);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Data saved to the database successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving data to the database: " + ex.Message);
            }
        }

        private void SaveDataToDatabase(string labelValue, string dateTimeString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                    string Query = "insert into pizza_db.total_sum_saved(TotalSum) values('" + this.totalLabel.Text + "'); ";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Successfully Saved!");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void displayBTN_Click_1(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void clearBTN_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView4.SelectedRows)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");
                using (MySqlConnection cs = new MySqlConnection())
                {
                    MySqlCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(dataGridView4.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from purchased_items where id='" + id + "'"; /*current_table*/

                    dataGridView4.Rows.RemoveAt(this.dataGridView4.SelectedRows[0].Index);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void totalllll_Click_1(object sender, EventArgs e)
        {
            decimal Total = 0;
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dataGridView4.Rows[i].Cells["Price"].Value);
            }
            totalLabel.Text = Total.ToString();
        }
        private void saveCurrent_Click_1(object sender, EventArgs e)
        {
            try
            {
                string textBoxValue = totalLabel.Text;
                DateTime currentTime = DateTime.Now;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string insertQuery = $"INSERT INTO {tableName} (TotalSum, DateTime) VALUES (@sum, @time)";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@sum", textBoxValue);
                    command.Parameters.AddWithValue("@time", currentTime);

                    connection.Open();
                    command.ExecuteNonQuery();
                }


                MessageBox.Show("Data saved to the database successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving data to the database: " + ex.Message);
            }

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            SearchItem(searchTerm);
        }




        private void SearchItem(string searchTerm)
        {

            merge.ClearSelection();

            foreach (DataGridViewRow row in merge.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchTerm))
                    {
                        row.Selected = true;
                        merge.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }

            MessageBox.Show("Item not found.");
        }
    }
}
    
  