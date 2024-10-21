using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp
{
    public partial class NewVendorInfo : Form
    {

        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=vendor-mgmtform.database.windows.net;Initial Catalog=VendorLogin;Persist Security Info=True;User ID=Jesus;Password=Bustillos1005!;TrustServerCertificate=True"; // Access File Path

        public NewVendorInfo()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(connectionString);

        }

        private int GetNextId(SqlConnection sqlConnection)
        {
            sqlConnection.Open();

            string query = "SELECT ISNULL (MAX(ID), 0) + 1 FROM NewVendorInfo";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            return(int)cmd.ExecuteScalar();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private byte[] GetPhoto()
        {
            if (picVendorPhoto.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    picVendorPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray();
                }
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Initialize SQL command and set the command text for insertion
            string sqlCommandText = @"INSERT INTO NewVendorInfo (ID, POC_Name, POC_JobTitle, POC_Email, POC_Phone, POC_Company, POC_CompanyAddress, City, Photo)
                                    VALUES (@ID, @POC_Name, @POC_JobTitle, @POC_Email, @POC_Phone, @POC_Company, @POC_CompanyAddress, @City, @Photo)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                // Get the next ID (assuming you have a method for generating the next available ID)
                long nextID = GetNextId(sqlConnection);

                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                {
                    // Add parameters to the SQL command
                    sqlCommand.Parameters.AddWithValue("@ID", nextID);
                    sqlCommand.Parameters.AddWithValue("@POC_Name", txtPOCName.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_JobTitle", txtPOCJobTitle.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_Email", txtPOCEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_Phone", txtPOCPhone.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_Company", txtPOCCompany.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_CompanyAddress", txtComapanyAddress.Text);
                    sqlCommand.Parameters.AddWithValue("@City", listBox2.GetItemText(listBox2.SelectedItem));

                    // If the picture is present in the PictureBox, add the logic for photo later (as per screenshot)
                    sqlCommand.Parameters.AddWithValue("@Photo", GetPhoto());

                    // Execute the SQL command
                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("New vendor information saved successfully!");
            }
            sqlConnection.Close();
        }
            

          


        private void btnUploadPhoto_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picVendorPhoto.Image = Image.FromFile(openFileDialog1.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load the photo: " + ex.Message);
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new NewVendorInfo().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPOCName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }
    }
}


