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
    public partial class AddCarForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public AddCarForm()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {   
            try
            {
                string make = txtMake.Text;
                string model = txtModel.Text;
                int year = Convert.ToInt32(txtYear.Text);
                string color = txtColor.Text;
                int customerID = Convert.ToInt32(txtCustomerID.Text);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // INSERT sorgusu 
                    string insertCarQuery = "INSERT INTO Cars (Make, Model, Year, Color, CustomerID) VALUES (@Make, @Model, @Year, @Color, @CustomerID)";
                    MySqlCommand insertCarCommand = new MySqlCommand(insertCarQuery, connection);

                    // Parametreleri ekleyin
                    insertCarCommand.Parameters.AddWithValue("@Make", make);
                    insertCarCommand.Parameters.AddWithValue("@Model", model);
                    insertCarCommand.Parameters.AddWithValue("@Year", year);
                    insertCarCommand.Parameters.AddWithValue("@Color", color);
                    insertCarCommand.Parameters.AddWithValue("@CustomerID", customerID);

                    
                    int rowsAffected = insertCarCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Car added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Formu kapatma
                    }
                    else
                    {
                        MessageBox.Show("Failed to add car. Please check the entered information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
