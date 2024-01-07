using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace carManagement
{
   
    public partial class FindCustomerIDForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public FindCustomerIDForm()
        {
            InitializeComponent();
        }

        private void btnFindID_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
           
            
            // SqlConnection oluşturma
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SELECT sorgusu 
                    string selectQuery = "SELECT CustomerID FROM Customers WHERE FirstName = @FirstName AND LastName = @LastName AND Phone = @Phone AND Email = @Email";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);

                    // Parametre
                    selectCommand.Parameters.AddWithValue("@FirstName", firstName);
                    selectCommand.Parameters.AddWithValue("@LastName", lastName);
                    selectCommand.Parameters.AddWithValue("@Phone", phone);
                    selectCommand.Parameters.AddWithValue("@Email", email);

                    // SqlDataReader 
                    MySqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Okunan bilgileri MessageBox ile görüntüleyin
                        int customerID = Convert.ToInt32(reader["CustomerID"]);
                        MessageBox.Show($"Customer ID: {customerID}", "Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer not found. Please check the entered information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
