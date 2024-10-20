using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class VendorInfo : Form
    {

        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=DESKTOP-3RCAUPI\SQLEXPRESS02;Initial Catalog=VendorLogin;Integrated Security=True;TrustServerCertificate=True"; // Access File Path


        public VendorInfo()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(connectionString);
        }

        private int GetNextId(SqlConnection sqlConnection)
        {
            sqlConnection.Open();
            string querry = "SELECT ISNULL (MAX(ID), 0) + 1 FROM VendorInfo";
            SqlCommand cmd = new SqlCommand(querry, sqlConnection);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }


        private void btnSave_Click_2(object sender, EventArgs e)
        {
            // Define the connection string (replace with your actual connection string)
            string connectionString = "your_connection_string_here";

            // Construct the SQL insert query
            string sqlCommandText = "INSERT INTO VendorInfo (Name, Company, Cell, Products, Diary_products, Delivery, Payment) " +
                                    "VALUES (@Name, @Company, @Cell, @Products, @Diary_products, @Delivery, @Payment)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the SQL connection
                    sqlConnection.Open();

                    // Get the next available ID (assuming you have a function like the one in the screenshot)
                    long nextID = GetNextId(sqlConnection); // You'll need to implement GetNextId

                    using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                    {
                        // Add parameters for the SQL command
                        sqlCommand.Parameters.AddWithValue("@Name", txtName.Text);
                        sqlCommand.Parameters.AddWithValue("@Company", txtCompany.Text);
                        sqlCommand.Parameters.AddWithValue("@Cell", txtCell.Text);
                        sqlCommand.Parameters.AddWithValue("@Products", listBox1.GetItemText(listBox1.SelectedItem));

                        // Determine product, dairy product, delivery status, and payment status based on user input
                        string product = rdCoffee.Checked ? "Coffee" :
                                         rdTea.Checked ? "Green Tea" :
                                         rdHerb.Checked ? "Herbs" : "";
                        sqlCommand.Parameters.AddWithValue("@Products", product);

                        string dairyProduct = rdMilk.Checked ? "Milk" :
                                              rdCream.Checked ? "Cream" : "";
                        sqlCommand.Parameters.AddWithValue("@Diary_products", dairyProduct);

                        string deliveryStatus = ckDelayed.Checked ? "Delayed" :
                                                ckOntime.Checked ? "On Time" : "";
                        sqlCommand.Parameters.AddWithValue("@Delivery", deliveryStatus);

                        string paymentStatus = ckPaid.Checked ? "Paid" :
                                               ckUnpaid.Checked ? "Unpaid" : "";
                        sqlCommand.Parameters.AddWithValue("@Payment", paymentStatus);

                        // Execute the SQL query
                        sqlCommand.ExecuteNonQuery();
                    }

                    // Show success message
                    MessageBox.Show("Vendor information saved successfully!");

                }
                catch (Exception ex)
                {
                    // Show error message in case of failure
                    MessageBox.Show("Failed to save data to SQL: " + ex.Message);
                }
                finally
                {
                    // Close the SQL connection
                    sqlConnection.Close();
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



