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
    public partial class ViewServiceForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public ViewServiceForm()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan Car ID'yi alma
                int carID = Convert.ToInt32(txtCarID.Text);

                // Veritabanına bağlanma
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Servis bilgilerini alma
                    string getServiceInfoQuery = "SELECT * FROM Services " +
                                                 "WHERE CarID = @CarID";
                    MySqlCommand getServiceInfoCommand = new MySqlCommand(getServiceInfoQuery, connection);

                    // Parametreyi ekleme
                    getServiceInfoCommand.Parameters.AddWithValue("@CarID", carID);

                    // Sorguyu çalıştırma
                    using (MySqlDataReader reader = getServiceInfoCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Servis bilgilerini göster
                            string serviceInfo = $"Service Type: {reader["ServiceType"]}\n" +
                                                 $"Service Date: {reader["ServiceDate"]}\n" +
                                                 $"Technician Name: {reader["TechnicianName"]}";

                            MessageBox.Show(serviceInfo, "Service Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No service found for the specified Car ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
