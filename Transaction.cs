using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace SDAM2STOCKTRY1
{
    internal class Transaction
    {
        private DateTime DateTime { get; set; }
        private string Action { get; set; }
        private string StockCode { get; set; }
        private string StockItemName { get; set; }
        private int QuantityChanged { get; set; }
        private int NewQuantityInStock { get; set; }

        private string connectionString = "server=localhost;user id=root;password=;database=mystocksystem";

        public DateTime GetDateTime()
        {
            return DateTime;
        }

        public void SetDateTime(DateTime value)
        {
            DateTime = value;
        }

        public string GetAction()
        {
            return Action;
        }

        public void SetAction(string value)
        {
            Action = value;
        }

        public string GetStockCode()
        {
            return StockCode;
        }

        public void SetStockCode(string value)
        {
            StockCode = value;
        }

        public string GetStockItemName()
        {
            return StockItemName;
        }

        public void SetStockItemName(string value)
        {
            StockItemName = value;
        }

        public int GetQuantityChanged()
        {
            return QuantityChanged;
        }

        public void SetQuantityChanged(int value)
        {
            QuantityChanged = value;
        }

        public int GetNewQuantityInStock()
        {
            return NewQuantityInStock;
        }

        public void SetNewQuantityInStock(int value)
        {
            NewQuantityInStock = value;
        }

        public bool LogTransaction(string action, string stockCode, string stockName, int quantityAdded, int newQuantityInStock)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                conn.Open();
                cmd.Connection = conn;

                DateTime now = DateTime.Now;
                string formattedDateTime = now.ToString("dd-MM-yyyy HH:mm"); // Format as "DD-MM-YYYY HH:MM"


                string logQuery = "INSERT INTO transactiontable (DateTime, TransactionType, StockCode, StockName, QuantityAdded, NewQuantityInStock) VALUES (@dateTime, @action, @stockCode, @stockName, @quantityAdded, @newQuantity)";
                cmd.CommandText = logQuery;

                cmd.Parameters.AddWithValue("@dateTime", formattedDateTime); 
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@stockCode", stockCode);
                cmd.Parameters.AddWithValue("@stockName", stockName);
                cmd.Parameters.AddWithValue("@quantityAdded", quantityAdded);
                cmd.Parameters.AddWithValue("@newQuantity", newQuantityInStock);

                cmd.ExecuteNonQuery();
                return true;
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







    }
    }


