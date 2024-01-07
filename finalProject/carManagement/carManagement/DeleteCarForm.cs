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
    public partial class DeleteCarForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public DeleteCarForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = Convert.ToInt32(txtCarID.Text);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Services tablosundaki referansları temizle
                    string updateServicesQuery = "UPDATE Services SET CarID = NULL WHERE CarID = @CarID";
                    MySqlCommand updateServicesCommand = new MySqlCommand(updateServicesQuery, connection);
                    updateServicesCommand.Parameters.AddWithValue("@CarID", carID);
                    updateServicesCommand.ExecuteNonQuery();

                    // Sales tablosundaki referansları temizle
                    string updateSalesQuery = "UPDATE Sales SET CarID = NULL WHERE CarID = @CarID";
                    MySqlCommand updateSalesCommand = new MySqlCommand(updateSalesQuery, connection);
                    updateSalesCommand.Parameters.AddWithValue("@CarID", carID);
                    updateSalesCommand.ExecuteNonQuery();

                    // Cars tablosundan aracı sil
                    string deleteCarQuery = "DELETE FROM Cars WHERE CarID = @CarID";
                    MySqlCommand deleteCarCommand = new MySqlCommand(deleteCarQuery, connection);
                    deleteCarCommand.Parameters.AddWithValue("@CarID", carID);

                    // Sorguyu çalıştırın
                    int rowsAffected = deleteCarCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Car deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Formu kapatın
                    }
                    else
                    {
                        MessageBox.Show("Car with the specified ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


