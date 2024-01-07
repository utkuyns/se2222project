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
    public partial class AddSaleForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public AddSaleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = Convert.ToInt32(txtCarID.Text);
                int customerID = Convert.ToInt32(txtCustomerID.Text);
                DateTime salesDate = dateTimePickerSalesDate.Value;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Satışı ekleyen sorgu
                    string addSaleQuery = "INSERT INTO Sales (CarID, CustomerID, SalesDate) VALUES (@CarID, @CustomerID, @SalesDate)";
                    MySqlCommand addSaleCommand = new MySqlCommand(addSaleQuery, connection);

                    // Parametreleri ekleyin
                    addSaleCommand.Parameters.AddWithValue("@CarID", carID);
                    addSaleCommand.Parameters.AddWithValue("@CustomerID", customerID);
                    addSaleCommand.Parameters.AddWithValue("@SalesDate", salesDate);

                    // Sorguyu çalıştırın
                    int rowsAffected = addSaleCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sale added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add sale. Please check the entered information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
