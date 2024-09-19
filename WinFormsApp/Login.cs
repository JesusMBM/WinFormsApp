using System.Data.SqlClient;
using Access = System.Data.SqlClient; // Adding an SQL Object

namespace WinFormsApp
{
    public partial class Login : Form
    {
        // Create Access Application
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=DESKTOP-3RCAUPI\SQLEXPRESS02;Initial Catalog=VendorLogin;Integrated Security=True;TrustServerCertificate=True"; // Access File Path

        public Login()
        {
            InitializeComponent();
            // Initialize the SqlConnection here
            sqlConnection = new SqlConnection(connectionString);
        }

        private bool ValidateUser(string username, string passwords)
        {
            try
            {
                // Open the Connection
                sqlConnection.Open();

                string query = @"SELECT COUNT (*) AS UserCount FROM VendorCredentials WHERE Username = @username AND Password = @password";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", passwords);

                    int userCount = (int)command.ExecuteScalar();

                    return userCount > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            finally
            {
                // Ensure the connection is closed after the query
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Check if the username and password are valid
            if (ValidateUser(txtUsername.Text, txtPasswords.Text))
            {
                // Ensure the user has selected a user type from the ComboBox
                if (comboBoxType.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid user type.");
                    comboBoxType.Focus();
                    return;
                }

                // Get the selected user type from the ComboBox
                string userSelectedType = comboBoxType.Text;

                string userTypeQuery = "SELECT Type FROM VendorCredentials WHERE Username = @Username";

                try
                {
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(userTypeQuery, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@Username", txtUsername.Text);

                        string sqlType = (string)command.ExecuteScalar();

                        // Check if the selected user type matches the database value
                        if (userSelectedType == sqlType)
                        {
                            if (userSelectedType == "Admin")
                            {
                                new Admin().Show();
                                this.Hide();
                            }
                            else if (userSelectedType == "Vendor")
                            {
                                new VendorInfo().Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User Type is incorrect! Please select the correct user type.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    if (sqlConnection.State == System.Data.ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
                txtPasswords.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        // Other button click and form load methods remain unchanged
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (txtPasswords.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPasswords.PasswordChar = '\0';
            }
        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            if (txtPasswords.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPasswords.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e) { }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPasswords.Clear();
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e) { }
    }
}
