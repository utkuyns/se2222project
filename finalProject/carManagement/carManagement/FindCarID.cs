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
using MySql.Data.MySqlClient;

namespace carManagement
{   

    public partial class FindCarID : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public FindCarID()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string phone = txtPhone.Text.Trim();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteri ve araç bilgilerini içeren sorgu
                    string getCarInfoQuery = "SELECT Cars.CarID, Cars.Make, Cars.Model, Cars.Year, Cars.Color " +
                                             "FROM Cars " +
                                             "JOIN Customers ON Cars.CustomerID = Customers.CustomerID " +
                                             "WHERE Customers.FirstName = @FirstName AND Customers.LastName = @LastName AND Customers.Phone = @Phone";
                    MySqlCommand getCarInfoCommand = new MySqlCommand(getCarInfoQuery, connection);

                    // Parametreleri ekleyin
                    getCarInfoCommand.Parameters.AddWithValue("@FirstName", firstName);
                    getCarInfoCommand.Parameters.AddWithValue("@LastName", lastName);
                    getCarInfoCommand.Parameters.AddWithValue("@Phone", phone);

                    // Sorguyu çalıştırın
                    using (MySqlDataReader reader = getCarInfoCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Bulunan aracın bilgilerini göster
                            string carInfo = $"CarID: {reader["CarID"]}\n" +
                                             $"Make: {reader["Make"]}, Model: {reader["Model"]}, Year: {reader["Year"]}, Color: {reader["Color"]}";

                            MessageBox.Show(carInfo, "Car Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No car found with the specified customer information.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
