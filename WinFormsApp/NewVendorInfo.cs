using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormsApp
{
    public partial class NewVendorInfo : Form
    {
        private Excel.Application xlApp;
        private string dbpath = @"C:\Users\Jesus\Desktop\WinFormsApp-master\NewVendorInfo.xlsx";
        public NewVendorInfo()
        {
            InitializeComponent();

            xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Workbook xlWorkSheet;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var xlWorkBook = xlApp.Workbooks.Open(dbpath);
            var xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets["Sheet1"];
            try
            {
                // Find the first empty row 
                int iRow = 2; // Row 1 has headers, starting form the 2nd row

                while (xlWorkSheet.Cells[iRow, 1].Value != null) // This Checks if the value in the cell is not null
                {
                    iRow++; // Move to the Next Row if the current is not empty
                }

                // Writing Data from the New Vendor Request form to Excel
                xlWorkSheet.Cells[iRow, 1].Value = txtPOCName.Text;
                xlWorkSheet.Cells[iRow, 2].Value = txtPOCJobTitle.Text;
                xlWorkSheet.Cells[iRow, 3].Value = txtPOCEmail.Text;
                xlWorkSheet.Cells[iRow, 4].Value = txtPOCPhone.Text;
                xlWorkSheet.Cells[iRow, 5].Value = txtPOCCompany.Text;
                xlWorkSheet.Cells[iRow, 6].Value = txtComapanyAddress.Text;
                xlWorkSheet.Cells[iRow, 7].Value = listBox2.GetItemText(listBox2.SelectedItem);

                MessageBox.Show("Vendor Information saved successfully!");

                // Save and close the workbook
                xlWorkBook.Save();
                xlWorkBook.Close(true);
                xlApp.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to write to Excel: " + ex.Message);
            }

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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Open the Excel workbook and worksheet
            var xlWorkBook = xlApp.Workbooks.Open(dbpath);
            var xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets["Sheet1"];

            int iRow = 2;

            if (picVendorPhoto.Image != null)
            {
                
                var ms = new MemoryStream();
                picVendorPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); 
                ms.Position = 0; 

                string tempImagePath = Path.GetTempFileName() + ".png"; 
                File.WriteAllBytes(tempImagePath, ms.ToArray()); 

                float left = Convert.ToSingle(xlWorkSheet.Cells[iRow, 8].Left);  
                float top = Convert.ToSingle(xlWorkSheet.Cells[iRow, 8].Top);

                dynamic shapes = xlWorkSheet.Shapes;

                shapes.AddPicture(tempImagePath,
                                  Microsoft.Office.Core.MsoTriState.msoFalse,
                                  Microsoft.Office.Core.MsoTriState.msoCTrue,
                                  left, top, 50, 50);

                ms.Close();

                MessageBox.Show("Vendor photo saved successfully!");

                xlWorkBook.Save();
                xlWorkBook.Close(true);
                xlApp.Quit();

                MessageBox.Show("Vendor photo saved successfully!");
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

