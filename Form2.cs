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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SDAM2STOCKTRY1
{
    public partial class Form2 : Form
    {

        private MySqlConnection connection;
        public Form2()
        {
            InitializeComponent();
            passwordInput.PasswordChar = '*';

            // Initialize the database connection//
            string connectionString = "server=localhost;user id=root;password=;database=mystocksystem";
            connection = new MySqlConnection(connectionString);

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            string username = userNameInput.Text;
            string password = passwordInput.Text;

            
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check if the username and password are correct by querying the database//
            string query = "SELECT * FROM logincredentials WHERE Username = @username AND Password = @password";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                     
                        MessageBox.Show("Login Successful!");

                        // Open my main form (Form1) and close the login form//
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide(); 
                    }
                    else
                    {
                        
                        MessageBox.Show("Invalid username or password. Please try again.");

                        passwordInput.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
