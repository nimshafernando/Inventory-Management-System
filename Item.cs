using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SDAM2STOCKTRY1
{
    internal class Item
    {
        private string StockCode;
        private string Name;
        private int Quantity;

        private string connectionString = "server=localhost;user id=root;password=;database=mystocksystem";

        public void SetStockCode(string TheStockCode)
        {
            StockCode = TheStockCode;
        }
        public string GetStockCode()
        {
            return StockCode;
        }

        public void SetStockName(string TheStockName)
        {
            Name = TheStockName;
        }

        public string GetStockName()
        {
            return Name;
        }

        public void SetQuantity(int TheQuantity)
        {
            Quantity = TheQuantity;
        }

        public int GetQuantity()
        {
            return Quantity;
        }


        public bool AddStock()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (string.IsNullOrEmpty(StockCode))
                {
                    MessageBox.Show("Stock code cannot be empty.");
                    return false; 
                }

                if (string.IsNullOrEmpty(Name))
                {
                    MessageBox.Show("Stock name cannot be empty.");
                    return false; 
                }

                if (Quantity <= 0)
                {
                    MessageBox.Show("Quantity must be a positive number.");
                    return false; 
                }

                if (ItemExists(StockCode, Name))
                {
                    MessageBox.Show("A stock item with the same stock code and name already exists.");
                    return false; 
                }

                string insertQuery = "INSERT INTO newstocktable (StockCode, StockName, StockQuantity) VALUES (@code, @name, @quantity)";
                cmd.CommandText = insertQuery;

                cmd.Parameters.AddWithValue("@code", StockCode);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@quantity", Quantity);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    
                    LogTransaction("Item added", StockCode, Name, Quantity, Quantity); 
                    return true;
                }
                else
                {
                    return false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; 
            }
            finally
            {
                conn.Close();
            }
        }



        private bool ItemExists(string stockCode, string stockName)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM newstocktable WHERE StockCode = @stockCode AND StockName = @stockName", conn);
                cmd.Parameters.AddWithValue("@stockCode", stockCode);
                cmd.Parameters.AddWithValue("@stockName", stockName);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public string GetStockName(string stockCode)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT StockName FROM newstocktable WHERE StockCode = @stockCode", conn);
                cmd.Parameters.AddWithValue("@stockCode", stockCode);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }

                return null;
            }
        }

        public bool AddQuantityToStock()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.Connection = conn;

                if (string.IsNullOrEmpty(StockCode) || Quantity <= 0)
                {
                    return false; 
                }

                string stockName = GetStockNameByCode(StockCode);

                if (stockName == null)
                {
                    return false; 
                }

                string updateQuery = "UPDATE newstocktable SET StockQuantity = StockQuantity + @additionalQuantity WHERE StockCode = @code";
                cmd.CommandText = updateQuery;

                cmd.Parameters.AddWithValue("@code", StockCode);
                cmd.Parameters.AddWithValue("@additionalQuantity", Quantity);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    int newQuantity = GetStockQuantity(StockCode);
                    LogTransaction("Quantity added", StockCode, stockName, Quantity, newQuantity);
                    return true;
                }
                else
                {
                    return false; 
                }
            }
            catch (Exception)
            {
                return false; 
            }
            finally
            {
                conn.Close();
            }
        }

        private int GetStockQuantity(string stockCode)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT StockQuantity FROM newstocktable WHERE StockCode = @stockCode", conn);
                cmd.Parameters.AddWithValue("@stockCode", stockCode);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }

                return 0;
            }
        }

        private bool UpdateStockQuantity(string stockCode, int newQuantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE newstocktable SET StockQuantity = @newQuantity WHERE StockCode = @stockCode", conn);
                cmd.Parameters.AddWithValue("@stockCode", stockCode);
                cmd.Parameters.AddWithValue("@newQuantity", newQuantity);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        private string GetStockNameByCode(string stockCode)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT StockName FROM newstocktable WHERE StockCode = @stockCode", conn);
                cmd.Parameters.AddWithValue("@stockCode", stockCode);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }

                return null;
            }
        }

        private void LogTransaction(string action, string stockCode, string stockName, int quantityAdded, int newQuantityInStock)
        {
            Transaction transaction = new Transaction();
            transaction.LogTransaction(action, stockCode, stockName, quantityAdded, newQuantityInStock);
        }

    }
}
