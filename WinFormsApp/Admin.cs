using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newVendorInfoDBpic.NewVendorInfo' table. You can move, or remove it, as needed.
            this.newVendorInfoTableAdapter1.Fill(this.newVendorInfoDBpic.NewVendorInfo);
            // TODO: This line of code loads data into the 'vendorInfoData.VendorInfo' table. You can move, or remove it, as needed.
            this.vendorInfoTableAdapter.Fill(this.vendorInfoData.VendorInfo);
            // TODO: This line of code loads data into the 'vendorLoginDataSet.VendorCredentials' table. You can move, or remove it, as needed.
            this.vendorCredentialsTableAdapter.Fill(this.vendorLoginDataSet.VendorCredentials);



        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void btnNewVendorLogin_Click(object sender, EventArgs e)
        {
            new NewVendorInfo().Show();
            this.Close();
        }

        private void btnViewUserData_Click(object sender, EventArgs e)
        {
            this.vendorCredentialsTableAdapter.Fill(this.vendorLoginDataSet.VendorCredentials);

            gdUserData.DataSource = this.vendorLoginDataSet.VendorCredentials;

            gdUserData.Visible = true;
            gdUserData.BringToFront();
            dgVendorDelivery.Visible = false;
            dgNewVendor.Visible = false;
        }

        private void btnViewVendorDelivery_Click(object sender, EventArgs e)
        {
            this.vendorInfoTableAdapter.Fill(this.vendorInfoData.VendorInfo);
            dgVendorDelivery.DataSource = this.vendorInfoData.VendorInfo;

            dgVendorDelivery.Visible = true;
            dgVendorDelivery.BringToFront();
            gdUserData.Visible=false;
            dgNewVendor.Visible=false;
        }

        private void btnViewVendorData_Click(object sender, EventArgs e)
        {
            this.newVendorInfoTableAdapter1.Fill(this.newVendorInfoDBpic.NewVendorInfo);


            dgNewVendor.DataSource = this.newVendorInfoDBpic.NewVendorInfo;

            dgNewVendor.Visible = true;
            dgNewVendor.BringToFront();
            dgVendorDelivery.Visible=false;
            gdUserData.Visible = false;
        }

        private void dgUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
