using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SDAM2STOCKTRY1
{
    public partial class Form1 : Form
    {
        private Item item = new Item();
        private MySqlConnection connection;
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = "server=localhost;user id=root;password=;database=mystocksystem";
            connection = new MySqlConnection(connectionString);
        }

        private void AddQuantityButton_Click(object sender, EventArgs e)
        {
            Item item = CreateItem();

            if (item != null)
            {
                if (item.AddQuantityToStock())
                {
                    MessageBox.Show("Quantity successfully added");
                }
            }
        }

        private Item CreateItem()
        {
            Item item = new Item();

            item.SetStockCode(StockCodeInput.Text);
            item.SetStockName(StockNameInput.Text);

            if (int.TryParse(StockQuantityInput.Text, out int quantity))
            {
                item.SetQuantity(quantity);
                return item;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for Stock Quantity.");
                return null;
            }
        }

        private void AddStockButton_Click_1(object sender, EventArgs e)
        {
            Item item = CreateItem();

            if (item != null)
            {
                if (item.AddStock())
                {
                    MessageBox.Show("Item successfully added");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string deleteTransactionQuery = "DELETE FROM transactiontable";
                using (MySqlCommand cmd = new MySqlCommand(deleteTransactionQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string deleteStockQuery = "DELETE FROM newstocktable";
                using (MySqlCommand cmd = new MySqlCommand(deleteStockQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Tables deleted successfully.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
