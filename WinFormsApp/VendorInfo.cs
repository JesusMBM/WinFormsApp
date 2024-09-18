using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; // Adding an Excel object

namespace WinFormsApp
{
    public partial class VendorInfo : Form
    {

        // Create Excel App
        private Excel.Application xlApp;
       // private string dbpath = @"C:\Users\VMware\Desktop\MIS 555\Vendor.xlsx"; // Excel Path for VMware
        private string dbpath = @"C:\Users\Jesus\Desktop\WinFormsApp-master\VendorInfo.xlsx"; // Excel Path for Desktop

        public VendorInfo()
        {
            InitializeComponent();

            xlApp = new Excel.Application();
            Excel.Workbook xlWorbook;
            Excel.Worksheet xlWorkSheet;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Initalize Excel App
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

                // Writing Data
                xlWorkSheet.Cells[iRow, 1].Value = txtName.Text;
                xlWorkSheet.Cells[iRow, 2].Value = txtCompany.Text;
                xlWorkSheet.Cells[iRow, 3].Value = txtCell.Text;
                xlWorkSheet.Cells[iRow, 4].Value = listBox1.GetItemText(listBox1.SelectedItem);

                string product = rdCoffee.Checked ? "Coffee" :
                                 rdTea.Checked ? "Green Tea" :
                                 rdHerb.Checked ? "Herbs" : "";

                xlWorkSheet.Cells[iRow, 5].Value = product;

                string dairyproduct = rdMilk.Checked ? "Milk" :
                                    rdCream.Checked ? "Cream" : "";
                xlWorkSheet.Cells[iRow, 6].Value = dairyproduct;

                string deliverystatus = ckDelayed.Checked ? "Delayed" :
                                        ckOntime.Checked ? "On Time" : "";
                xlWorkSheet.Cells[iRow, 7].Value = deliverystatus;

                string paymentstatus = ckPaid.Checked ? "Paid" :
                                       ckUnpaid.Checked ? "Unpaid" : "";
                xlWorkSheet.Cells[iRow, 8].value = paymentstatus;

                MessageBox.Show("Vendor Information saved succesfully!");

                xlWorkBook.Save();
                xlWorkBook.Close(true);
                xlApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to write to Excel: " + ex.Message);
            }
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);


            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_2(object sender, EventArgs e)
        {
            // Initalize Excel App
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

                // Writing Data
                xlWorkSheet.Cells[iRow, 1].Value = txtName.Text;
                xlWorkSheet.Cells[iRow, 2].Value = txtCompany.Text;
                xlWorkSheet.Cells[iRow, 3].Value = txtCell.Text;
                xlWorkSheet.Cells[iRow, 4].Value = listBox1.GetItemText(listBox1.SelectedItem);

                string product = rdCoffee.Checked ? "Coffee" :
                                 rdTea.Checked ? "Green Tea" :
                                 rdHerb.Checked ? "Herbs" : "";

                xlWorkSheet.Cells[iRow, 5].Value = product;

                string dairyproduct = rdMilk.Checked ? "Milk" :
                                    rdCream.Checked ? "Cream" : "";
                xlWorkSheet.Cells[iRow, 6].Value = dairyproduct;

                string deliverystatus = ckDelayed.Checked ? "Delayed" :
                                        ckOntime.Checked ? "On Time" : "";
                xlWorkSheet.Cells[iRow, 7].Value = deliverystatus;

                string paymentstatus = ckPaid.Checked ? "Paid" :
                                       ckUnpaid.Checked ? "Unpaid" : "";
                xlWorkSheet.Cells[iRow, 8].value = paymentstatus;

                MessageBox.Show("Vendor Information saved succesfully!");

                xlWorkBook.Save();
                xlWorkBook.Close(true);
                xlApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to write to Excel: " + ex.Message);
            }
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
