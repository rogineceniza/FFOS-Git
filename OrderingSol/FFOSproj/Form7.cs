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
        private MySqlConnection connection = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11;");
        private DataTable dataTable = new DataTable();

        public Cashier_Formmmm()
        {
            InitializeComponent();
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

        public void add_btn_Click(object sender, EventArgs e)
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

           

        }

       public void add2_btn_Click(object sender, EventArgs e)
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



        private void Total_Click_1(object sender, EventArgs e)
        {
            decimal Total = 0;
            for (int i = 0; i < totalData.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(totalData.Rows[i].Cells["priceOfItem"].Value);
            }
            label3.Text = Total.ToString();

       }


        private void delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.totalData.SelectedRows)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=RteCh_0C#@11");
                using (MySqlConnection cs = new MySqlConnection())
                {
                    MySqlCommand cmd = con.CreateCommand();
                    string name = Convert.ToString(totalData.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from totalsum_table where Name='" + nameOfItem + "'";

                    totalData.Rows.RemoveAt(this.totalData.SelectedRows[0].Index);
                    con.Open();
                    cmd.ExecuteNonQuery();


                }

            }
        }

        private void saveToDb_Click(object sender, EventArgs e)
        {
            try
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
            }
        }

        private void totalData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}