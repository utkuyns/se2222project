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
    public partial class ViewCustomerInfoForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public ViewCustomerInfoForm()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCustomerID.Text, out int customerID))
            {
                
                
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // SELECT sorgusu için
                        string selectQuery = "SELECT Customers.FirstName, Customers.LastName, Customers.Email, Customers.Phone, Cars.Make, Cars.Model, Cars.Year FROM Customers JOIN Cars ON Customers.CustomerID = Cars.CustomerID WHERE Customers.CustomerID = @CustomerID";
                        MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);

                        // Parametreyi ekleme
                        selectCommand.Parameters.AddWithValue("@CustomerID", customerID);

                        // SqlDataReader kullanarak veriyi okuma
                        MySqlDataReader reader = selectCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            // Okunan bilgileri MessageBox ile görüntüleyin
                            string customerInfo = $"Name: {reader["FirstName"]} {reader["LastName"]}\nEmail: {reader["Email"]}\nPhone: {reader["Phone"]}\nCar: {reader["Make"]} {reader["Model"]} ({reader["Year"]})";
                            MessageBox.Show(customerInfo, "Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Customer not found. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid customer ID. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
