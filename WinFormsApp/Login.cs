using System.Data.SqlClient;
using Access = System.Data.SqlClient; // Adding an SQL Object

namespace WinFormsApp
{
    public partial class Login : Form
    {
        // Create Access Application
        private SqlConnection sqlConnection;
        private string connectionstring = @"Data Source=DESKTOP-3RCAUPI\SQLEXPRESS02;Initial Catalog=VendorLogin;Integrated Security=True;TrustServerCertificate=True"; // Access File Path
        public Login()
        {
            InitializeComponent();
            //
            // Initialize the SqlConnection here
            sqlConnection = new SqlConnection(connectionstring);
        }

        private bool ValidateUser(string username, string passwords)
        {
           // Open the Connection
           sqlConnection.Open();

            string query = @"SELECT COUNT (*) AS UserCount FROM VendorCredentials WHERE Username = @username AND Password = @password";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", passwords);

            int userCount = (int)command.ExecuteScalar();

            sqlConnection.Close();

            return userCount > 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPasswords.Clear();
            txtUsername.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Username and password 

            if (ValidateUser(txtUsername.Text, txtPasswords.Text))
            {
                new VendorInfo().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                txtPasswords.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

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
            if (txtUsername.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtUsername.PasswordChar = '*';
            }
        }
    }
}
