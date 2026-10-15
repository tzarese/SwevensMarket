using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class ProductManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlAddEdit = new System.Windows.Forms.Panel();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.lblPrc = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblSts = new System.Windows.Forms.Label();
            this.cmbProductStatus = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlAddEdit.SuspendLayout();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = SwevenColors.TextColor;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(232, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "🛍️ Product Management";

            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(20, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search product name...";
            this.txtSearch.Size = new System.Drawing.Size(220, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);

            // cmbCategory
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "All Categories",
            "Mobile Legends",
            "Valorant",
            "Call of Duty Mobile",
            "Roblox",
            "Digital Service"});
            this.cmbCategory.Location = new System.Drawing.Point(250, 55);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 25);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.CmbCategory_SelectedIndexChanged);

            // cmbStatus
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All Status",
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(440, 55);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(130, 25);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.SelectedIndex = 0;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbStatus_SelectedIndexChanged);

            // btnAddProduct
            this.btnAddProduct.BackColor = SwevenColors.DarkPink;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(580, 53);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(130, 34);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "+ Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);

            // btnEditSelected
            this.btnEditSelected.BackColor = SwevenColors.MainPink;
            this.btnEditSelected.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnEditSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelected.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEditSelected.ForeColor = SwevenColors.TextColor;
            this.btnEditSelected.Location = new System.Drawing.Point(720, 53);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(130, 34);
            this.btnEditSelected.TabIndex = 5;
            this.btnEditSelected.Text = "✏️ Edit Selected";
            this.btnEditSelected.UseVisualStyleBackColor = false;
            this.btnEditSelected.Click += new System.EventHandler(this.BtnEditSelected_Click);

            // dgvProducts
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.Location = new System.Drawing.Point(20, 100);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1015, 520);
            this.dgvProducts.TabIndex = 6;

            // pnlAddEdit
            this.pnlAddEdit.BackColor = System.Drawing.Color.White;
            this.pnlAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEdit.Controls.Add(this.lblPanelTitle);
            this.pnlAddEdit.Controls.Add(this.lblId);
            this.pnlAddEdit.Controls.Add(this.txtProductID);
            this.pnlAddEdit.Controls.Add(this.lblName);
            this.pnlAddEdit.Controls.Add(this.txtProductName);
            this.pnlAddEdit.Controls.Add(this.lblCat);
            this.pnlAddEdit.Controls.Add(this.cmbProductCategory);
            this.pnlAddEdit.Controls.Add(this.lblPrc);
            this.pnlAddEdit.Controls.Add(this.txtPrice);
            this.pnlAddEdit.Controls.Add(this.lblSts);
            this.pnlAddEdit.Controls.Add(this.cmbProductStatus);
            this.pnlAddEdit.Controls.Add(this.lblDesc);
            this.pnlAddEdit.Controls.Add(this.txtDescription);
            this.pnlAddEdit.Controls.Add(this.btnSave);
            this.pnlAddEdit.Controls.Add(this.btnCancel);
            this.pnlAddEdit.Location = new System.Drawing.Point(660, 95);
            this.pnlAddEdit.Name = "pnlAddEdit";
            this.pnlAddEdit.Size = new System.Drawing.Size(375, 525);
            this.pnlAddEdit.TabIndex = 7;
            this.pnlAddEdit.Visible = false;

            // lblPanelTitle
            this.lblPanelTitle.AutoSize = true;
            this.lblPanelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPanelTitle.ForeColor = SwevenColors.DarkPink;
            this.lblPanelTitle.Location = new System.Drawing.Point(20, 15);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Size = new System.Drawing.Size(125, 21);
            this.lblPanelTitle.TabIndex = 0;
            this.lblPanelTitle.Text = "Product Details";

            // lblId
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(20, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(66, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Product ID";

            // txtProductID
            this.txtProductID.BackColor = SwevenColors.LightGray;
            this.txtProductID.Location = new System.Drawing.Point(20, 75);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(330, 23);
            this.txtProductID.TabIndex = 2;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(20, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Product Name";

            // txtProductName
            this.txtProductName.Location = new System.Drawing.Point(20, 130);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(330, 23);
            this.txtProductName.TabIndex = 4;

            // lblCat
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCat.Location = new System.Drawing.Point(20, 165);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(57, 15);
            this.lblCat.TabIndex = 5;
            this.lblCat.Text = "Category";

            // cmbProductCategory
            this.cmbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Items.AddRange(new object[] {
            "Mobile Legends",
            "Valorant",
            "Call of Duty Mobile",
            "Roblox",
            "Digital Service"});
            this.cmbProductCategory.Location = new System.Drawing.Point(20, 185);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(330, 23);
            this.cmbProductCategory.TabIndex = 6;

            // lblPrc
            this.lblPrc.AutoSize = true;
            this.lblPrc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrc.Location = new System.Drawing.Point(20, 220);
            this.lblPrc.Name = "lblPrc";
            this.lblPrc.Size = new System.Drawing.Size(53, 15);
            this.lblPrc.TabIndex = 7;
            this.lblPrc.Text = "Price (₱)";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(20, 240);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(330, 23);
            this.txtPrice.TabIndex = 8;

            // lblSts
            this.lblSts.AutoSize = true;
            this.lblSts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSts.Location = new System.Drawing.Point(20, 275);
            this.lblSts.Name = "lblSts";
            this.lblSts.Size = new System.Drawing.Size(42, 15);
            this.lblSts.TabIndex = 9;
            this.lblSts.Text = "Status";

            // cmbProductStatus
            this.cmbProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductStatus.FormattingEnabled = true;
            this.cmbProductStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbProductStatus.Location = new System.Drawing.Point(20, 295);
            this.cmbProductStatus.Name = "cmbProductStatus";
            this.cmbProductStatus.Size = new System.Drawing.Size(330, 23);
            this.cmbProductStatus.TabIndex = 10;

            // lblDesc
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesc.Location = new System.Drawing.Point(20, 330);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(71, 15);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Description";

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(20, 350);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(330, 80);
            this.txtDescription.TabIndex = 12;

            // btnSave
            this.btnSave.BackColor = SwevenColors.DarkPink;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // btnCancel
            this.btnCancel.BackColor = SwevenColors.MainPink;
            this.btnCancel.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = SwevenColors.TextColor;
            this.btnCancel.Location = new System.Drawing.Point(190, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 40);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);

            // ProductManagementForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.pnlAddEdit);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManagementForm";
            this.Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlAddEdit.ResumeLayout(false);
            this.pnlAddEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlAddEdit;
        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label lblPrc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblSts;
        private System.Windows.Forms.ComboBox cmbProductStatus;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
