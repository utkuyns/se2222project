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
    public partial class DeleteCustomerForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public DeleteCustomerForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = Convert.ToInt32(txtCustomerID.Text);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Cars tablosundaki referansları temizle
                    string updateCarsQuery = "UPDATE Cars SET CustomerID = NULL WHERE CustomerID = @CustomerID";
                    MySqlCommand updateCarsCommand = new MySqlCommand(updateCarsQuery, connection);
                    updateCarsCommand.Parameters.AddWithValue("@CustomerID", customerID);
                    updateCarsCommand.ExecuteNonQuery();

                    // Services tablosundaki referansları temizle
                    string updateServicesQuery = "UPDATE Services SET CarID = NULL WHERE CarID IN (SELECT CarID FROM Cars WHERE CustomerID = @CustomerID)";
                    MySqlCommand updateServicesCommand = new MySqlCommand(updateServicesQuery, connection);
                    updateServicesCommand.Parameters.AddWithValue("@CustomerID", customerID);
                    updateServicesCommand.ExecuteNonQuery();

                    // Customers tablosundan müşteriyi sil
                    string deleteCustomerQuery = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                    MySqlCommand deleteCustomerCommand = new MySqlCommand(deleteCustomerQuery, connection);
                    deleteCustomerCommand.Parameters.AddWithValue("@CustomerID", customerID);
                    deleteCustomerCommand.ExecuteNonQuery();

                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
