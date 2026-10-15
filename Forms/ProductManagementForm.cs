using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public class ProductManagementForm : Form
    {
        private TextBox txtSearch;
        private ComboBox cmbCategory;
        private ComboBox cmbStatus;
        private Button btnAddProduct;
        private DataGridView dgvProducts;

        // Slide-out panel for Add/Edit
        private Panel pnlAddEdit;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private ComboBox cmbProductCategory;
        private TextBox txtPrice;
        private ComboBox cmbProductStatus;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnCancel;

        public ProductManagementForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(1060, 650);
            this.BackColor = SwevenColors.LightPink;

            var lblHeader = new Label
            {
                Text = "🛍️ Product Management",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(20, 15),
                AutoSize = true
            };

            // Filters
            txtSearch = new TextBox
            {
                Location = new Point(20, 55),
                Size = new Size(220, 30),
                Font = new Font("Segoe UI", 10),
                PlaceholderText = "Search product name..."
            };
            txtSearch.TextChanged += (s, e) => RefreshGrid();

            cmbCategory = new ComboBox
            {
                Location = new Point(250, 55),
                Size = new Size(180, 30),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            cmbCategory.Items.AddRange(new string[] { "All Categories", "Mobile Legends", "Valorant", "Call of Duty Mobile", "Roblox", "Digital Service" });
            cmbCategory.SelectedIndex = 0;
            cmbCategory.SelectedIndexChanged += (s, e) => RefreshGrid();

            cmbStatus = new ComboBox
            {
                Location = new Point(440, 55),
                Size = new Size(130, 30),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            cmbStatus.Items.AddRange(new string[] { "All Status", "Active", "Inactive" });
            cmbStatus.SelectedIndex = 0;
            cmbStatus.SelectedIndexChanged += (s, e) => RefreshGrid();

            btnAddProduct = new Button
            {
                Text = "+ Add Product",
                Location = new Point(580, 53),
                Size = new Size(130, 34),
                BackColor = SwevenColors.DarkPink,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.Click += BtnAddProduct_Click;

            var btnEditSelected = new Button
            {
                Text = "✏️ Edit Selected",
                Location = new Point(720, 53),
                Size = new Size(130, 34),
                BackColor = SwevenColors.MainPink,
                ForeColor = SwevenColors.TextColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnEditSelected.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            btnEditSelected.Click += BtnEditSelected_Click;

            // Product DataGridView
            dgvProducts = new DataGridView
            {
                Location = new Point(20, 100),
                Size = new Size(1015, 520),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Slide-out Add/Edit Panel
            BuildAddEditPanel();

            this.Controls.Add(pnlAddEdit);
            this.Controls.Add(lblHeader);
            this.Controls.Add(txtSearch);
            this.Controls.Add(cmbCategory);
            this.Controls.Add(cmbStatus);
            this.Controls.Add(btnAddProduct);
            this.Controls.Add(btnEditSelected);
            this.Controls.Add(dgvProducts);
        }

        private void BuildAddEditPanel()
        {
            pnlAddEdit = new Panel
            {
                Location = new Point(660, 95),
                Size = new Size(375, 525),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            var lblPanelTitle = new Label
            {
                Text = "Product Details",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                Location = new Point(20, 15),
                AutoSize = true
            };

            var lblId = new Label { Text = "Product ID", Location = new Point(20, 55), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            txtProductID = new TextBox { Location = new Point(20, 75), Size = new Size(330, 28), ReadOnly = true, BackColor = SwevenColors.LightGray };

            var lblName = new Label { Text = "Product Name", Location = new Point(20, 110), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            txtProductName = new TextBox { Location = new Point(20, 130), Size = new Size(330, 28) };

            var lblCat = new Label { Text = "Category", Location = new Point(20, 165), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            cmbProductCategory = new ComboBox { Location = new Point(20, 185), Size = new Size(330, 28), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbProductCategory.Items.AddRange(new string[] { "Mobile Legends", "Valorant", "Call of Duty Mobile", "Roblox", "Digital Service" });

            var lblPrc = new Label { Text = "Price (₱)", Location = new Point(20, 220), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            txtPrice = new TextBox { Location = new Point(20, 240), Size = new Size(330, 28) };

            var lblSts = new Label { Text = "Status", Location = new Point(20, 275), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            cmbProductStatus = new ComboBox { Location = new Point(20, 295), Size = new Size(330, 28), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbProductStatus.Items.AddRange(new string[] { "Active", "Inactive" });

            var lblDesc = new Label { Text = "Description", Location = new Point(20, 330), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            txtDescription = new TextBox { Location = new Point(20, 350), Size = new Size(330, 80), Multiline = true };

            btnSave = new Button
            {
                Text = "Save Product",
                Location = new Point(20, 450),
                Size = new Size(160, 40),
                BackColor = SwevenColors.DarkPink,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += BtnSave_Click;

            btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(190, 450),
                Size = new Size(160, 40),
                BackColor = SwevenColors.MainPink,
                ForeColor = SwevenColors.TextColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            btnCancel.Click += (s, e) => pnlAddEdit.Visible = false;

            pnlAddEdit.Controls.Add(lblPanelTitle);
            pnlAddEdit.Controls.Add(lblId);
            pnlAddEdit.Controls.Add(txtProductID);
            pnlAddEdit.Controls.Add(lblName);
            pnlAddEdit.Controls.Add(txtProductName);
            pnlAddEdit.Controls.Add(lblCat);
            pnlAddEdit.Controls.Add(cmbProductCategory);
            pnlAddEdit.Controls.Add(lblPrc);
            pnlAddEdit.Controls.Add(txtPrice);
            pnlAddEdit.Controls.Add(lblSts);
            pnlAddEdit.Controls.Add(cmbProductStatus);
            pnlAddEdit.Controls.Add(lblDesc);
            pnlAddEdit.Controls.Add(txtDescription);
            pnlAddEdit.Controls.Add(btnSave);
            pnlAddEdit.Controls.Add(btnCancel);
        }

        private void RefreshGrid()
        {
            var query = DataStore.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                query = query.Where(p => p.Name.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);

            if (cmbCategory.SelectedIndex > 0)
                query = query.Where(p => p.Category == cmbCategory.SelectedItem.ToString());

            if (cmbStatus.SelectedIndex > 0)
                query = query.Where(p => p.Status == cmbStatus.SelectedItem.ToString());

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = query.ToList();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            txtProductID.Text = $"P{DataStore.Products.Count + 1:D3}";
            txtProductName.Clear();
            cmbProductCategory.SelectedIndex = 0;
            txtPrice.Clear();
            cmbProductStatus.SelectedIndex = 0;
            txtDescription.Clear();

            pnlAddEdit.Visible = true;
            pnlAddEdit.BringToFront();
        }

        private void BtnEditSelected_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product p)
            {
                txtProductID.Text = p.Id;
                txtProductName.Text = p.Name;
                cmbProductCategory.SelectedItem = p.Category;
                txtPrice.Text = p.Price.ToString("F2");
                cmbProductStatus.SelectedItem = p.Status;
                txtDescription.Text = p.Description;

                pnlAddEdit.Visible = true;
                pnlAddEdit.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a product from the list to edit.");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid product name and numerical price.");
                return;
            }

            var existing = DataStore.Products.Find(p => p.Id == txtProductID.Text);
            if (existing != null)
            {
                existing.Name = txtProductName.Text.Trim();
                existing.Category = cmbProductCategory.SelectedItem?.ToString() ?? "General";
                existing.Price = price;
                existing.Status = cmbProductStatus.SelectedItem?.ToString() ?? "Active";
                existing.Description = txtDescription.Text;
            }
            else
            {
                DataStore.Products.Add(new Product
                {
                    Id = txtProductID.Text,
                    Name = txtProductName.Text.Trim(),
                    Category = cmbProductCategory.SelectedItem?.ToString() ?? "General",
                    Price = price,
                    Status = cmbProductStatus.SelectedItem?.ToString() ?? "Active",
                    Description = txtDescription.Text
                });
            }

            pnlAddEdit.Visible = false;
            RefreshGrid();
            MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
