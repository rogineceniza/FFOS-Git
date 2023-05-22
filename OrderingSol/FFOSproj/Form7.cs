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
using MySql.Data.MySqlClient;
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


        public Cashier_Formmmm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Cashier_Formmm_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Update the label text with the current date and time;
            dateToday.Text = DateTime.Now.ToString();
        }
        /*  private void Cashier_Formmmm_Load(object sender, EventArgs e)
          {
              LoadDataIntoDataGridView(); 
          }*/


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

                    // Bind the DataTable to the DataGridView
                    dataGridView4.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void LoadDataPizza()
        {

            string connectionString = "Server=localhost;Database=pizza_db;Uid=root;Pwd=RteCh_0C#@11;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT Name, Size, Price FROM pizza_table";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void LoadDataBeverages()
        {
            string connectionString = "Server=localhost;Database=pizza_db;Uid=root;Pwd=RteCh_0C#@11;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT Name, Size, Price FROM beverage_table";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadDataPizza();
        }

        private void refresh2_btn_Click(object sender, EventArgs e)
        {
            LoadDataBeverages();
        }

        /*public void add_btn_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                // int idNum = Convert.ToInt32(row.Cells["ID"].Value);
                string itemName = row.Cells["Name"].Value.ToString();
                string itemSize = row.Cells["Size"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                //cal.Rows.Add(itemName, itemSize, price);
                totalData.Rows.Add(itemName, itemSize, price);

                total += price;
            }



        }*/

        /*public void add2_btn_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                // int idNum = Convert.ToInt32(row.Cells["ID"].Value);
                string itemName = row.Cells["Name"].Value.ToString();
                string itemSize = row.Cells["Size"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                // cal.Rows.Add(itemName, itemSize, price);
                totalData.Rows.Add(itemName, itemSize, price);

                total += price;
            }

        }
*/


        /* private void Total_Click_1(object sender, EventArgs e)
         {
             decimal Total = 0;
             for (int i = 0; i < totalData.Rows.Count; i++)
             {
                 Total += Convert.ToDecimal(totalData.Rows[i].Cells["priceOfItem"].Value);
             }
             label3.Text = Total.ToString();

         }
 */

        /*  private void delete_Click(object sender, EventArgs e)
          {
              foreach (DataGridViewRow item in this.totalData.SelectedRows)
              {
                  MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");
                  using (MySqlConnection cs = new MySqlConnection())
                  {
                      MySqlCommand cmd = con.CreateCommand();
                      string name = Convert.ToString(totalData.SelectedRows[0].Cells[0].Value);
                      cmd.CommandText = "Delete from totalsum_table where Name ='" + nameOfItem + "'";

                      totalData.Rows.RemoveAt(this.totalData.SelectedRows[0].Index);
                      con.Open();
                      cmd.ExecuteNonQuery();


                  }

              }
          }*/




        private void saveToDb_Click(object sender, EventArgs e)
        {
            /*try
            {
                var test = this.sizeOFItem;

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string Query = "insert into pizza_db.totalsum_table(Name, Size, Price) values('" +this.nameOfItem + "','" + this.sizeOFItem + "','" + this.priceOfItem + "' );";
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

            /* string connectionString = "server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11";
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 connection.Open();

                 foreach (DataGridViewRow row in totalData.Rows)
                 {
                     string insertQuery = "INSERT INTO pizza_db.totalsum_table (Name, Size, Price) VALUES (@nameOfItem, @sizeOFItem, @priceOfItem)";

                     // Step 4: Extract values from the row
                     string value1 = row.Cells["Name"].Value.ToString();
                     string value2 = row.Cells["Size"].Value.ToString();
                     string value3 = row.Cells["Price"].Value.ToString();

                     // Step 5: Execute the SQL statement
                     using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                     {
                         command.Parameters.AddWithValue("@nameOfItem", value1);
                         command.Parameters.AddWithValue("@sizeOFItem", value2);
                         command.Parameters.AddWithValue("@priceOfItem", value3);

                         command.ExecuteNonQuery();
                     }
                 }
             }*/

            /* string connectionString = "server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11";
             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 connection.Open();

                 try
                 {
                     foreach (DataGridViewRow row in totalData.SelectedRows)
                     {
                         // Prepare SQL statement
                         string insertQuery = "INSERT INTO pizza_db.totalsum_table (Name, Size, Price) VALUES ('" + this.nameOfItem.Name + "','" + this.sizeOFItem.Name+ "','" + this.priceOfItem.Name+ "',);";
                         MySqlCommand command = new MySqlCommand(insertQuery, connection);
                         command.Parameters.AddWithValue("@nameOfItem", row.Cells["Name"].Value);
                         command.Parameters.AddWithValue("@sizeOFItem", row.Cells["Size"].Value);
                         command.Parameters.AddWithValue("@priceOfItem", row.Cells["Price"].Value);

                         // Execute SQL statement
                         command.ExecuteNonQuery();
                     }

                     MessageBox.Show("Selected rows saved successfully!");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("An error occurred while saving data: " + ex.Message);
                 }
             }
 */

            /* DataGridView totalData = new DataGridView();

             totalData.Name = "totalData";
             totalData.Location = new System.Drawing.Point(10, 10);
             totalData.Size = new System.Drawing.Size(400, 300);
             totalData.ColumnCount = 2;
             totalData.Columns[0].Name = "Name";
             totalData.Columns[1].Name = "Size";
             totalData.Columns[1].Name = "Price";

             this.Controls.Add(totalData);*/


            /*// Retrieve the value from the label
            string labelValue = label3.Text;
            string name = totalData.Name;
            string size = totalData.Name;
           // string price = totalData.Name;

            // MySQL database connection string
            string connectionString = "server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    // Prepare SQL statement
                    string insertQuery = "INSERT INTO pizza_db.totalsum_table (Price, Name, Size) VALUES ('" + this.label3 + "','" + this.nameOfItem + "','" + this.sizeOFItem + "');";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@label3", labelValue);
                    command.Parameters.AddWithValue("@nameOfItem", name);
                    command.Parameters.AddWithValue("@sizeOFItem", size);
                //    command.Parameters.AddWithValue("@priceOfItem", price);

                    // Execute SQL statement
                    command.ExecuteNonQuery();

                    MessageBox.Show("Value saved to database successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the value to the database: " + ex.Message);
                }
            }
*/


        }

        private void dateToday_Click(object sender, EventArgs e)
        {
            dateToday.Text = DateTime.Now.ToString();
            /*var timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();*/
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string itemName = row.Cells["Name"].Value.ToString();
                string itemSize = row.Cells["Size"].Value.ToString();
                string itemPrice = row.Cells["Price"].Value.ToString();

                // Transfer the values to separate TextBoxes
                nameTXT.Text = itemName;
                sizeTXT.Text = itemSize;
                priceTXT.Text = itemPrice;
            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                string itemName = row.Cells["Name"].Value.ToString();
                string itemSize = row.Cells["Size"].Value.ToString();
                string itemPrice = row.Cells["Price"].Value.ToString();

                // Transfer the values to separate TextBoxes
                nameTXT.Text = itemName;
                sizeTXT.Text = itemSize;
                priceTXT.Text = itemPrice;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string Query = "insert into pizza_db.purchased_items(Name,Size, Price) values('" + this.nameTXT.Text + "','" + this.sizeTXT.Text + "','" + this.priceTXT.Text + "');";
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
            }

        }

        private void displayBTN_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow item in this.dataGridView4.SelectedRows)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");
                using (MySqlConnection cs = new MySqlConnection())
                {
                    MySqlCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(dataGridView4.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from pizza_table where id='" + id + "'";

                    dataGridView4.Rows.RemoveAt(this.dataGridView4.SelectedRows[0].Index);
                    con.Open();
                    cmd.ExecuteNonQuery();


                }


            }*/




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





        private void saveCurrent_Click(object sender, EventArgs e)
        {

           /* try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                string Query = "insert into pizza_db.total_sum_saved(TotalSum, DateTime) values('" + this.totalLabel.Text + "', '" + this.dateToday.Text + "'); ";
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

            /*string TotalSum = totalLabel.Text;
            DateTime DateTime = DateTime.Now;
            SaveDataToDatabase(TotalSum, DateTime.ToString());
            MessageBox.Show("Data saved to the database successfully!");*/

/*
            string labelValue = dateToday.Text;
            DateTime currentDateTime = DateTime.Now;
            string dateTimeString = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            MessageBox.Show("Data saved to the database successfully!");*/


            string labelValue = totalLabel.Text;
            DateTime dateToday = DateTime.Now;
            string dateTimeString = dateToday.ToString("yyyy-MM-dd HH:mm:ss");
            SaveDataToDatabase(labelValue, dateTimeString);
          //  MessageBox.Show("Data saved to the database successfully!");


        }
        private void SaveDataToDatabase(string labelValue, string dateTimeString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=RteCh_0C#@11";
                    string Query = "insert into pizza_db.total_sum_saved(TotalSum) values('" + this.totalLabel.Text +/* "', '" + this.dateToday.Text + */"'); ";
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
    }
}


