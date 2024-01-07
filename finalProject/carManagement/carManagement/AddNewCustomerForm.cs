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

    public partial class AddNewCustomerForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public AddNewCustomerForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtMail.Text;
            string phone = txtPhone.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Müşteriyi ekleyin
                    string insertCustomerQuery = "INSERT INTO Customers (FirstName, LastName, Email, Phone) VALUES (@FirstName, @LastName, @Email, @Phone); SELECT LAST_INSERT_ID();";
                    MySqlCommand insertCustomerCommand = new MySqlCommand(insertCustomerQuery, connection);

                    insertCustomerCommand.Parameters.AddWithValue("@FirstName", firstName);
                    insertCustomerCommand.Parameters.AddWithValue("@LastName", lastName);
                    insertCustomerCommand.Parameters.AddWithValue("@Email", email);
                    insertCustomerCommand.Parameters.AddWithValue("@Phone", phone);

                    int customerID = Convert.ToInt32(insertCustomerCommand.ExecuteScalar());

                    if (customerID > 0)
                    {
                        MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       // Eklenen müşteri ID'sini kullanarak aracı ekleyin
                        AddCarForm addNewCarForm = new AddCarForm();
                        addNewCarForm.ShowDialog();

                        this.Close(); // Formu kapatın
                    }
                    else
                    {
                        MessageBox.Show("Failed to add customer. Please check the entered information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
