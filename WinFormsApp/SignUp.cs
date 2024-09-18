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
using Access = Microsoft.Office.Interop.Access;

namespace WinFormsApp
{
    public partial class SignUp : Form
    {
        // Create Access Application
        private Access.Application acApp;
        private string dbpath = @"C:\Users\VMware\Desktop\MIS 555\SignUpWinForm1.accdb"; // Access File Path

        public SignUp()
        {
            InitializeComponent();

            try
            {
                // Initialize Access Application
                acApp = new Access.Application();
                acApp.OpenCurrentDatabase(dbpath, false); // Open the database
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening database: {ex.Message}");
                Application.Exit(); // Exit the app if the database can't be opened
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            new Login().Show(); // Show the login form
            this.Close(); // Close the current signup form
        }

        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close Access Application on form close
            if (acApp != null)
            {
                acApp.Quit();
                acApp = null;
            }
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
                var username = txtNewUsername.Text;
                var password = txtNewPasswords.Text;

                // Build a SQL command to insert data into the Users table
                string query = $"INSERT INTO Users (Username, Password) VALUES ('{username}', '{password}')";

                // Run the query using the Access Application
                acApp.DoCmd.RunSQL(query);

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
    }
}
