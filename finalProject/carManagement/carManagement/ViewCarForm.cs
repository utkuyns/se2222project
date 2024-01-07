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
    public partial class ViewCarForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=cicero;Database=car_management_system;";
        public ViewCarForm()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = Convert.ToInt32(txtCarID.Text);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // JOIN ile müşteri bilgilerini içeren sorgu
                    string viewCarInfoQuery = "SELECT Customers.FirstName, Customers.LastName, Customers.Email, Customers.Phone " +
                                              "FROM Cars " +
                                              "JOIN Customers ON Cars.CustomerID = Customers.CustomerID " +
                                              "WHERE Cars.CarID = @CarID";
                    MySqlCommand viewCarInfoCommand = new MySqlCommand(viewCarInfoQuery, connection);

                    // Parametre ekleyin
                    viewCarInfoCommand.Parameters.AddWithValue("@CarID", carID);

                    // Sorguyu çalıştırın
                    MySqlDataReader reader = viewCarInfoCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Müşteri bilgilerini göster
                        string customerInfo = $"Customer Name: {reader["FirstName"]} {reader["LastName"]}\n" +
                                               $"Email: {reader["Email"]}\n" +
                                               $"Phone: {reader["Phone"]}";

                        MessageBox.Show(customerInfo, "Car Owner Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnViewOldestCar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // JOIN ile en eski aracın bilgilerini ve sahibinin bilgilerini içeren sorgu
                    string viewOldestCarQuery = "SELECT Cars.Make, Cars.Model, Cars.Color, Cars.Year, " +
                                                 "Customers.FirstName, Customers.LastName, Customers.Email, Customers.Phone " +
                                                 "FROM Cars " +
                                                 "JOIN Customers ON Cars.CustomerID = Customers.CustomerID " +
                                                 "ORDER BY Cars.Year ASC " +
                                                 "LIMIT 1";
                    MySqlCommand viewOldestCarCommand = new MySqlCommand(viewOldestCarQuery, connection);

                    // Sorgu
                    using (MySqlDataReader reader = viewOldestCarCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // En eski aracın ve sahibinin bilgileri
                            string oldestCarInfo = $"Oldest Car Make: {reader["Make"]}\n" +
                                                    $"Model: {reader["Model"]}\n" +
                                                    $"Color: {reader["Color"]}\n" +
                                                    $"Year: {reader["Year"]}\n\n" +
                                                    $"Owner Name: {reader["FirstName"]} {reader["LastName"]}\n" +
                                                    $"Email: {reader["Email"]}\n" +
                                                    $"Phone: {reader["Phone"]}";

                            MessageBox.Show(oldestCarInfo, "Oldest Car Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No cars found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewNewestCar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // JOIN ile en yeni aracın bilgilerini ve sahibinin bilgilerini içeren sorgu
                    string viewNewestCarQuery = "SELECT Cars.Make, Cars.Model, Cars.Color, Cars.Year, " +
                                                 "Customers.FirstName, Customers.LastName, Customers.Email, Customers.Phone " +
                                                 "FROM Cars " +
                                                 "JOIN Customers ON Cars.CustomerID = Customers.CustomerID " +
                                                 "ORDER BY Cars.Year DESC " +  // 'DESC' ile yıla göre azalan sıralama (en yeni ilk)
                                                 "LIMIT 1";
                    MySqlCommand viewNewestCarCommand = new MySqlCommand(viewNewestCarQuery, connection);

                    // Sorgu
                    using (MySqlDataReader reader = viewNewestCarCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // En yeni aracın ve sahibinin bilgilerini göster
                            string newestCarInfo = $"Newest Car Make: {reader["Make"]}\n" +
                                                    $"Model: {reader["Model"]}\n" +
                                                    $"Color: {reader["Color"]}\n" +
                                                    $"Year: {reader["Year"]}\n\n" +
                                                    $"Owner Name: {reader["FirstName"]} {reader["LastName"]}\n" +
                                                    $"Email: {reader["Email"]}\n" +
                                                    $"Phone: {reader["Phone"]}";

                            MessageBox.Show(newestCarInfo, "Newest Car Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No cars found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetSameMake_Click(object sender, EventArgs e)
        {
            try
            {
                string makeToSearch = txtMake.Text.Trim(); // TextBox'tan girilen marka adını al

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Girilen markaya sahip arabaların bilgilerini ve sahiplerinin bilgilerini içeren sorgu
                    string getSameMakeQuery = "SELECT Cars.Make, Cars.Model, Cars.Color, Cars.Year, " +
                                              "Customers.FirstName, Customers.LastName, Customers.Email, Customers.Phone " +
                                              "FROM Cars " +
                                              "JOIN Customers ON Cars.CustomerID = Customers.CustomerID " +
                                              "WHERE Cars.Make = @Make";
                    MySqlCommand getSameMakeCommand = new MySqlCommand(getSameMakeQuery, connection);

                    
                    getSameMakeCommand.Parameters.AddWithValue("@Make", makeToSearch);

                    // Sorguyu çalıştırma
                    using (MySqlDataReader reader = getSameMakeCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Bulunan arabaların bilgilerini gösterme
                            StringBuilder resultBuilder = new StringBuilder();
                            while (reader.Read())
                            {
                                resultBuilder.AppendLine($"Make: {reader["Make"]}, Model: {reader["Model"]}, Color: {reader["Color"]}, Year: {reader["Year"]}");
                                resultBuilder.AppendLine($"Owner Name: {reader["FirstName"]} {reader["LastName"]}");
                                resultBuilder.AppendLine($"Email: {reader["Email"]}, Phone: {reader["Phone"]}\n");
                            }

                            MessageBox.Show(resultBuilder.ToString(), "Cars with Same Make", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"No cars found with the make '{makeToSearch}'.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetSameModel_Click(object sender, EventArgs e)
        {
            try
            {
                string modelToSearch = txtModel.Text.Trim(); // TextBox'tan girilen model adını al

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Girilen modele sahip arabaların bilgilerini ve sahiplerinin bilgilerini içeren sorgu
                    string getSameModelQuery = "SELECT Cars.Make, Cars.Model, Cars.Color, Cars.Year, " +
                                               "Customers.FirstName, Customers.LastName, Customers.Email, Customers.Phone " +
                                               "FROM Cars " +
                                               "JOIN Customers ON Cars.CustomerID = Customers.CustomerID " +
                                               "WHERE Cars.Model = @Model";
                    MySqlCommand getSameModelCommand = new MySqlCommand(getSameModelQuery, connection);

                    
                    getSameModelCommand.Parameters.AddWithValue("@Model", modelToSearch);

                    // Sorguyu çalıştırma
                    using (MySqlDataReader reader = getSameModelCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Bulunan arabaların bilgilerini gösterme
                            StringBuilder resultBuilder = new StringBuilder();
                            while (reader.Read())
                            {
                                resultBuilder.AppendLine($"Make: {reader["Make"]}, Model: {reader["Model"]}, Color: {reader["Color"]}, Year: {reader["Year"]}");
                                resultBuilder.AppendLine($"Owner Name: {reader["FirstName"]} {reader["LastName"]}");
                                resultBuilder.AppendLine($"Email: {reader["Email"]}, Phone: {reader["Phone"]}\n");
                            }

                            MessageBox.Show(resultBuilder.ToString(), "Cars with Same Model", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"No cars found with the model '{modelToSearch}'.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
