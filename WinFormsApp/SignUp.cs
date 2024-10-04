using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class SignUp : Form
    {
        // Create Access Application
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=DESKTOP-3RCAUPI\SQLEXPRESS02;Initial Catalog=VendorLogin;Integrated Security=True;TrustServerCertificate=True"; // Access File Path

        public SignUp()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(connectionString);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }


        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            // Check if the passwords match
            if (txtNewPasswords.Text != txtConfirmPasswords.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return; // Exit the function if passwords don't match
            }

            // Insert new user into the database
            try
            {
                sqlConnection.Open();

                var username = txtNewUsername.Text;
                var password = txtNewPasswords.Text;

                // Build a SQL command to insert data into the Users table
                string query = $"INSERT INTO VendorCredentials (Username, Password) VALUES (@username, @password)";

                // Run the query using the Access Application
                SqlCommand command = new SqlCommand(query, sqlConnection); 

                command.Parameters.AddWithValue("username", username); 
                command.Parameters.AddWithValue("password", password);

                command.ExecuteNonQuery();
                
                sqlConnection.Close();

                // Inform the user of a successful registration
                MessageBox.Show("User Registered Successfully! Please go back and log in.");

                new Login().Show(); // Show the login form after successful registration
                this.Close(); // Close the signup form
            }
            catch (Exception ex)
            {
                // Show an error message if registration fails
                MessageBox.Show("Failed to register: " + ex.Message);
            }

        }

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbLogin_Click_1(object sender, EventArgs e)
        {
            new Login().Show(); // Show the login form
            this.Close(); // Close the current signup form
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
