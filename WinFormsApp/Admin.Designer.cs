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
            this.vendorLoginDataSet = new WinFormsApp.VendorLoginDataSet();
            this.vendorCredentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorCredentialsTableAdapter = new WinFormsApp.VendorLoginDataSetTableAdapters.VendorCredentialsTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).BeginInit();
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
            // 
            // btnViewVendorData
            // 
            this.btnViewVendorData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewVendorData.Location = new System.Drawing.Point(12, 95);
            this.btnViewVendorData.Name = "btnViewVendorData";
            this.btnViewVendorData.Size = new System.Drawing.Size(166, 37);
            this.btnViewVendorData.TabIndex = 1;
            this.btnViewVendorData.Text = "View Vendor Data";
            this.btnViewVendorData.UseVisualStyleBackColor = false;
            // 
            // btnViewVendorDelivery
            // 
            this.btnViewVendorDelivery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewVendorDelivery.Location = new System.Drawing.Point(12, 193);
            this.btnViewVendorDelivery.Name = "btnViewVendorDelivery";
            this.btnViewVendorDelivery.Size = new System.Drawing.Size(166, 37);
            this.btnViewVendorDelivery.TabIndex = 2;
            this.btnViewVendorDelivery.Text = "View Vendor Delivery";
            this.btnViewVendorDelivery.UseVisualStyleBackColor = false;
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
            // vendorLoginDataSet
            // 
            this.vendorLoginDataSet.DataSetName = "VendorLoginDataSet";
            this.vendorLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorCredentialsBindingSource
            // 
            this.vendorCredentialsBindingSource.DataMember = "VendorCredentials";
            this.vendorCredentialsBindingSource.DataSource = this.vendorLoginDataSet;
            // 
            // vendorCredentialsTableAdapter
            // 
            this.vendorCredentialsTableAdapter.ClearBeforeFill = true;
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).EndInit();
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
    }
}