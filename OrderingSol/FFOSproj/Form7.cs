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
        private MySqlConnection connection = new MySqlConnection("server=localhost;database=pizza_db;user=root;password=P@ssw0rd;");
        private DataTable dataTable = new DataTable();

        public Cashier_Formmmm()
        {
            InitializeComponent();
        }

        private void LoadDataPizza()
        {
            
                string connectionString = "Server=localhost;Database=pizza_db;Uid=root;Pwd=P@ssw0rd;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                string query = "SELECT Name, Size, Price FROM pizza_table";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
    }

        private void LoadDataBeverages()
        {
            string connectionString = "Server=localhost;Database=pizza_db;Uid=root;Pwd=P@ssw0rd;";
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string itemName = row.Cells["Name"].Value.ToString();
                string itemSize = row.Cells["Size"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                cal.Rows.Add(itemName, itemSize, price);

                total += price;
            }

            foreach (DataGridViewRow row in cal.SelectedRows)
            {
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                total += price;
            }

            label1.Text = total.ToString();
        }

        private void add2_btn_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                string itemName = row.Cells["Name"].Value.ToString();
                string itemSize = row.Cells["Size"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                cal.Rows.Add(itemName, itemSize, price);

                total += price;
            }

            foreach (DataGridViewRow row in cal.SelectedRows)
            {
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                total += price;
            }

            label1.Text = total.ToString();
        }
    }
}