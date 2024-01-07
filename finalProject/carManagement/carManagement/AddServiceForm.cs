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
    public partial class AddServiceForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan girişleri alın
                int carID = Convert.ToInt32(txtCarID.Text);
                string serviceType = txtServiceType.Text;
                DateTime serviceDate = dateTimePickerServiceDate.Value;
                string technicianName = txtTechnicianName.Text;

                // Veritabanına bağlanın
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Servis bilgilerini ekleyin
                    string addServiceQuery = "INSERT INTO Services (CarID, ServiceType, ServiceDate, TechnicianName) " +
                                             "VALUES (@CarID, @ServiceType, @ServiceDate, @TechnicianName)";
                    MySqlCommand addServiceCommand = new MySqlCommand(addServiceQuery, connection);

                    // Parametreleri ekleyin
                    addServiceCommand.Parameters.AddWithValue("@CarID", carID);
                    addServiceCommand.Parameters.AddWithValue("@ServiceType", serviceType);
                    addServiceCommand.Parameters.AddWithValue("@ServiceDate", serviceDate);
                    addServiceCommand.Parameters.AddWithValue("@TechnicianName", technicianName);

                    // Sorguyu çalıştırın
                    int rowsAffected = addServiceCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Formu kapatın
                    }
                    else
                    {
                        MessageBox.Show("Failed to add service. Please check the entered information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
