namespace WinFormsApp
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnViewUserData = new System.Windows.Forms.Button();
            this.btnViewVendorData = new System.Windows.Forms.Button();
            this.btnViewVendorDelivery = new System.Windows.Forms.Button();
            this.btnBackLogin = new System.Windows.Forms.Button();
            this.btnNewVendorLogin = new System.Windows.Forms.Button();
            this.gdUserData = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorCredentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorLoginDataSet = new WinFormsApp.VendorLoginDataSet();
            this.vendorCredentialsTableAdapter = new WinFormsApp.VendorLoginDataSetTableAdapters.VendorCredentialsTableAdapter();
            this.dgVendorDelivery = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCJobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCCompanyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newVendorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newVendorDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newVendorDB = new WinFormsApp.NewVendorDB();
            this.newVendorInfoTableAdapter = new WinFormsApp.NewVendorDBTableAdapters.NewVendorInfoTableAdapter();
            this.dgNewVendor = new System.Windows.Forms.DataGridView();
            this.newVendorInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newVendorInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.newVendorInfoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoData = new WinFormsApp.VendorInfoData();
            this.vendorInfoDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInfoTableAdapter = new WinFormsApp.VendorInfoDataTableAdapters.VendorInfoTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaryProductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newVendorInfoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewUserData
            // 
            this.btnViewUserData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewUserData.Location = new System.Drawing.Point(12, 12);
            this.btnViewUserData.Name = "btnViewUserData";
            this.btnViewUserData.Size = new System.Drawing.Size(166, 37);
            this.btnViewUserData.TabIndex = 0;
            this.btnViewUserData.Text = "View User Data";
            this.btnViewUserData.UseVisualStyleBackColor = false;
            this.btnViewUserData.Click += new System.EventHandler(this.btnViewUserData_Click);
            // 
            // btnViewVendorData
            // 
            this.btnViewVendorData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewVendorData.Location = new System.Drawing.Point(12, 188);
            this.btnViewVendorData.Name = "btnViewVendorData";
            this.btnViewVendorData.Size = new System.Drawing.Size(166, 37);
            this.btnViewVendorData.TabIndex = 1;
            this.btnViewVendorData.Text = "View Vendor Data";
            this.btnViewVendorData.UseVisualStyleBackColor = false;
            this.btnViewVendorData.Click += new System.EventHandler(this.btnViewVendorData_Click);
            // 
            // btnViewVendorDelivery
            // 
            this.btnViewVendorDelivery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewVendorDelivery.Location = new System.Drawing.Point(12, 101);
            this.btnViewVendorDelivery.Name = "btnViewVendorDelivery";
            this.btnViewVendorDelivery.Size = new System.Drawing.Size(166, 37);
            this.btnViewVendorDelivery.TabIndex = 2;
            this.btnViewVendorDelivery.Text = "View Vendor Delivery";
            this.btnViewVendorDelivery.UseVisualStyleBackColor = false;
            this.btnViewVendorDelivery.Click += new System.EventHandler(this.btnViewVendorDelivery_Click);
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackLogin.Location = new System.Drawing.Point(12, 375);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(166, 37);
            this.btnBackLogin.TabIndex = 3;
            this.btnBackLogin.Text = "Back";
            this.btnBackLogin.UseVisualStyleBackColor = false;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // btnNewVendorLogin
            // 
            this.btnNewVendorLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewVendorLogin.Location = new System.Drawing.Point(601, 384);
            this.btnNewVendorLogin.Name = "btnNewVendorLogin";
            this.btnNewVendorLogin.Size = new System.Drawing.Size(166, 37);
            this.btnNewVendorLogin.TabIndex = 4;
            this.btnNewVendorLogin.Text = "New Vendor Login";
            this.btnNewVendorLogin.UseVisualStyleBackColor = false;
            this.btnNewVendorLogin.Click += new System.EventHandler(this.btnNewVendorLogin_Click);
            // 
            // gdUserData
            // 
            this.gdUserData.AllowUserToOrderColumns = true;
            this.gdUserData.AutoGenerateColumns = false;
            this.gdUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.gdUserData.DataSource = this.vendorCredentialsBindingSource;
            this.gdUserData.Location = new System.Drawing.Point(203, 13);
            this.gdUserData.Name = "gdUserData";
            this.gdUserData.Size = new System.Drawing.Size(564, 347);
            this.gdUserData.TabIndex = 5;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // vendorCredentialsBindingSource
            // 
            this.vendorCredentialsBindingSource.DataMember = "VendorCredentials";
            this.vendorCredentialsBindingSource.DataSource = this.vendorLoginDataSet;
            // 
            // vendorLoginDataSet
            // 
            this.vendorLoginDataSet.DataSetName = "VendorLoginDataSet";
            this.vendorLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorCredentialsTableAdapter
            // 
            this.vendorCredentialsTableAdapter.ClearBeforeFill = true;
            // 
            // dgVendorDelivery
            // 
            this.dgVendorDelivery.AllowUserToOrderColumns = true;
            this.dgVendorDelivery.AutoGenerateColumns = false;
            this.dgVendorDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendorDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.pOCNameDataGridViewTextBoxColumn,
            this.pOCJobTitleDataGridViewTextBoxColumn,
            this.pOCEmailDataGridViewTextBoxColumn,
            this.pOCPhoneDataGridViewTextBoxColumn,
            this.pOCCompanyDataGridViewTextBoxColumn,
            this.pOCCompanyAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dgVendorDelivery.DataSource = this.newVendorInfoBindingSource4;
            this.dgVendorDelivery.Location = new System.Drawing.Point(203, 13);
            this.dgVendorDelivery.Name = "dgVendorDelivery";
            this.dgVendorDelivery.Size = new System.Drawing.Size(564, 347);
            this.dgVendorDelivery.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // pOCNameDataGridViewTextBoxColumn
            // 
            this.pOCNameDataGridViewTextBoxColumn.DataPropertyName = "POC_Name";
            this.pOCNameDataGridViewTextBoxColumn.HeaderText = "POC_Name";
            this.pOCNameDataGridViewTextBoxColumn.Name = "pOCNameDataGridViewTextBoxColumn";
            // 
            // pOCJobTitleDataGridViewTextBoxColumn
            // 
            this.pOCJobTitleDataGridViewTextBoxColumn.DataPropertyName = "POC_JobTitle";
            this.pOCJobTitleDataGridViewTextBoxColumn.HeaderText = "POC_JobTitle";
            this.pOCJobTitleDataGridViewTextBoxColumn.Name = "pOCJobTitleDataGridViewTextBoxColumn";
            // 
            // pOCEmailDataGridViewTextBoxColumn
            // 
            this.pOCEmailDataGridViewTextBoxColumn.DataPropertyName = "POC_Email";
            this.pOCEmailDataGridViewTextBoxColumn.HeaderText = "POC_Email";
            this.pOCEmailDataGridViewTextBoxColumn.Name = "pOCEmailDataGridViewTextBoxColumn";
            // 
            // pOCPhoneDataGridViewTextBoxColumn
            // 
            this.pOCPhoneDataGridViewTextBoxColumn.DataPropertyName = "POC_Phone";
            this.pOCPhoneDataGridViewTextBoxColumn.HeaderText = "POC_Phone";
            this.pOCPhoneDataGridViewTextBoxColumn.Name = "pOCPhoneDataGridViewTextBoxColumn";
            // 
            // pOCCompanyDataGridViewTextBoxColumn
            // 
            this.pOCCompanyDataGridViewTextBoxColumn.DataPropertyName = "POC_Company";
            this.pOCCompanyDataGridViewTextBoxColumn.HeaderText = "POC_Company";
            this.pOCCompanyDataGridViewTextBoxColumn.Name = "pOCCompanyDataGridViewTextBoxColumn";
            // 
            // pOCCompanyAddressDataGridViewTextBoxColumn
            // 
            this.pOCCompanyAddressDataGridViewTextBoxColumn.DataPropertyName = "POC_CompanyAddress";
            this.pOCCompanyAddressDataGridViewTextBoxColumn.HeaderText = "POC_CompanyAddress";
            this.pOCCompanyAddressDataGridViewTextBoxColumn.Name = "pOCCompanyAddressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // newVendorInfoBindingSource
            // 
            this.newVendorInfoBindingSource.DataMember = "NewVendorInfo";
            this.newVendorInfoBindingSource.DataSource = this.newVendorDBBindingSource;
            // 
            // newVendorDBBindingSource
            // 
            this.newVendorDBBindingSource.DataSource = this.newVendorDB;
            this.newVendorDBBindingSource.Position = 0;
            // 
            // newVendorDB
            // 
            this.newVendorDB.DataSetName = "NewVendorDB";
            this.newVendorDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newVendorInfoTableAdapter
            // 
            this.newVendorInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dgNewVendor
            // 
            this.dgNewVendor.AllowUserToOrderColumns = true;
            this.dgNewVendor.AutoGenerateColumns = false;
            this.dgNewVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNewVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.cellDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn1,
            this.productsDataGridViewTextBoxColumn,
            this.diaryProductsDataGridViewTextBoxColumn,
            this.deliveryDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn});
            this.dgNewVendor.DataSource = this.vendorInfoBindingSource;
            this.dgNewVendor.Location = new System.Drawing.Point(194, 13);
            this.dgNewVendor.Name = "dgNewVendor";
            this.dgNewVendor.Size = new System.Drawing.Size(573, 347);
            this.dgNewVendor.TabIndex = 7;
            this.dgNewVendor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUserData_CellContentClick);
            // 
            // newVendorInfoBindingSource1
            // 
            this.newVendorInfoBindingSource1.DataMember = "NewVendorInfo";
            this.newVendorInfoBindingSource1.DataSource = this.newVendorDBBindingSource;
            // 
            // newVendorInfoBindingSource2
            // 
            this.newVendorInfoBindingSource2.DataMember = "NewVendorInfo";
            this.newVendorInfoBindingSource2.DataSource = this.newVendorDBBindingSource;
            // 
            // newVendorInfoBindingSource3
            // 
            this.newVendorInfoBindingSource3.DataMember = "NewVendorInfo";
            this.newVendorInfoBindingSource3.DataSource = this.newVendorDBBindingSource;
            // 
            // vendorInfoData
            // 
            this.vendorInfoData.DataSetName = "VendorInfoData";
            this.vendorInfoData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorInfoDataBindingSource
            // 
            this.vendorInfoDataBindingSource.DataSource = this.vendorInfoData;
            this.vendorInfoDataBindingSource.Position = 0;
            // 
            // vendorInfoBindingSource
            // 
            this.vendorInfoBindingSource.DataMember = "VendorInfo";
            this.vendorInfoBindingSource.DataSource = this.vendorInfoDataBindingSource;
            // 
            // vendorInfoTableAdapter
            // 
            this.vendorInfoTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // cellDataGridViewTextBoxColumn
            // 
            this.cellDataGridViewTextBoxColumn.DataPropertyName = "Cell";
            this.cellDataGridViewTextBoxColumn.HeaderText = "Cell";
            this.cellDataGridViewTextBoxColumn.Name = "cellDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            // 
            // productsDataGridViewTextBoxColumn
            // 
            this.productsDataGridViewTextBoxColumn.DataPropertyName = "Products";
            this.productsDataGridViewTextBoxColumn.HeaderText = "Products";
            this.productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            // 
            // diaryProductsDataGridViewTextBoxColumn
            // 
            this.diaryProductsDataGridViewTextBoxColumn.DataPropertyName = "Diary_Products";
            this.diaryProductsDataGridViewTextBoxColumn.HeaderText = "Diary_Products";
            this.diaryProductsDataGridViewTextBoxColumn.Name = "diaryProductsDataGridViewTextBoxColumn";
            // 
            // deliveryDataGridViewTextBoxColumn
            // 
            this.deliveryDataGridViewTextBoxColumn.DataPropertyName = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.HeaderText = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.Name = "deliveryDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // newVendorInfoBindingSource4
            // 
            this.newVendorInfoBindingSource4.DataMember = "NewVendorInfo";
            this.newVendorInfoBindingSource4.DataSource = this.newVendorDB;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgNewVendor);
            this.Controls.Add(this.dgVendorDelivery);
            this.Controls.Add(this.gdUserData);
            this.Controls.Add(this.btnNewVendorLogin);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.btnViewVendorDelivery);
            this.Controls.Add(this.btnViewVendorData);
            this.Controls.Add(this.btnViewUserData);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdUserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInfoBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnViewUserData;
        private Button btnViewVendorData;
        private Button btnViewVendorDelivery;
        private Button btnBackLogin;
        private Button btnNewVendorLogin;
        private DataGridView gdUserData;
        private VendorLoginDataSet vendorLoginDataSet;
        private BindingSource vendorCredentialsBindingSource;
        private VendorLoginDataSetTableAdapters.VendorCredentialsTableAdapter vendorCredentialsTableAdapter;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridView dgVendorDelivery;
        private BindingSource newVendorDBBindingSource;
        private NewVendorDB newVendorDB;
        private BindingSource newVendorInfoBindingSource;
        private NewVendorDBTableAdapters.NewVendorInfoTableAdapter newVendorInfoTableAdapter;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pOCNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pOCJobTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pOCEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pOCPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pOCCompanyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pOCCompanyAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private DataGridView dgNewVendor;
        private BindingSource newVendorInfoBindingSource1;
        private BindingSource newVendorInfoBindingSource2;
        private BindingSource newVendorInfoBindingSource3;
        private BindingSource vendorInfoDataBindingSource;
        private VendorInfoData vendorInfoData;
        private BindingSource vendorInfoBindingSource;
        private VendorInfoDataTableAdapters.VendorInfoTableAdapter vendorInfoTableAdapter;
        private BindingSource newVendorInfoBindingSource4;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaryProductsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deliveryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
    }
}