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
    public partial class ViewSalesForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public ViewSalesForm()
        {
            InitializeComponent();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            try
            {
                
                DateTime selectedDate = dateTimePickerSelectedDate.Value.Date;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Seçilen tarihe ait satışları getiren sorgu
                    string viewSalesQuery = "SELECT Cars.Make, Cars.Model, Customers.FirstName, Customers.LastName, Sales.SalesDate " +
                                            "FROM Sales " +
                                            "JOIN Cars ON Sales.CarID = Cars.CarID " +
                                            "JOIN Customers ON Sales.CustomerID = Customers.CustomerID " +
                                            "WHERE Sales.SalesDate = @SelectedDate";
                    MySqlCommand viewSalesCommand = new MySqlCommand(viewSalesQuery, connection);

                    // Parametreyi ekleyin
                    
                    viewSalesCommand.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    // Verileri okuyun
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(viewSalesCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Satışları MessageBox ile göster
                        StringBuilder message = new StringBuilder();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            message.AppendLine($"Make: {row["Make"]}, Model: {row["Model"]}, Owner: {row["FirstName"]} {row["LastName"]}, Sales Date: {row["SalesDate"]}");
                        }

                        MessageBox.Show(message.ToString(), "Sales Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No sales found for the selected date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
