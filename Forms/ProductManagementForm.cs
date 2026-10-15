using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public partial class ProductManagementForm : Form
    {
        public ProductManagementForm()
        {
            InitializeComponent();
            CuteThemeHelper.ApplyCuteGrid(dgvProducts);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var query = DataStore.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                query = query.Where(p => p.Name.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);

            if (cmbCategory.SelectedIndex > 0)
                query = query.Where(p => p.Category == cmbCategory.SelectedItem!.ToString());

            if (cmbStatus.SelectedIndex > 0)
                query = query.Where(p => p.Status == cmbStatus.SelectedItem!.ToString());

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = query.ToList();
        }

        private void BtnAddProduct_Click(object? sender, EventArgs e)
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

        private void BtnEditSelected_Click(object? sender, EventArgs e)
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

        private void BtnSave_Click(object? sender, EventArgs e)
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
            MessageBox.Show("🌸 Product saved successfully! 💖", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e) => RefreshGrid();
        private void CmbCategory_SelectedIndexChanged(object? sender, EventArgs e) => RefreshGrid();
        private void CmbStatus_SelectedIndexChanged(object? sender, EventArgs e) => RefreshGrid();
        private void BtnCancel_Click(object? sender, EventArgs e) => pnlAddEdit.Visible = false;
    }
}
