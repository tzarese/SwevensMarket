using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public partial class CreateOrderGCashForm : Form
    {
        private string uploadedProofPath = "";
        private Product? selectedProduct = null;

        public CreateOrderGCashForm()
        {
            InitializeComponent();
            CuteThemeHelper.ApplyCuteGrid(dgvCatalog);
            LoadCatalog();
        }

        private void LoadCatalog()
        {
            var activeItems = DataStore.Products.Where(p => p.Status == "Active").ToList();
            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = activeItems;
        }

        private void DgvCatalog_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvCatalog.CurrentRow?.DataBoundItem is Product p)
            {
                selectedProduct = p;
                lblSelectedProduct.Text = $"🌸 Selected: {p.Name} ({p.Category}) 💖";
                lblSelectedPrice.Text = $"✨ Amount Due: ₱{p.Price:N2}";
            }
        }

        private void BtnUpload_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    uploadedProofPath = ofd.FileName;
                    picReceiptPreview.ImageLocation = uploadedProofPath;
                }
            }
        }

        private void BtnSubmitOrder_Click(object? sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please click on a product from the list first! 💕", "Select Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGCashRef.Text) || txtGCashRef.Text.Trim().Length < 8)
            {
                MessageBox.Show("Please enter a valid GCash Reference Number from your SMS or screenshot! 📱", "Reference Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newOrderId = $"OR{DataStore.Orders.Count + 1:D4}";
            var newOrder = new Order
            {
                OrderId = newOrderId,
                Date = DateTime.Now,
                Customer = string.IsNullOrEmpty(UserSession.FullName) ? "Guest Customer" : UserSession.FullName,
                Product = selectedProduct.Name,
                Amount = selectedProduct.Price,
                GCashReferenceNo = txtGCashRef.Text.Trim(),
                GCashStatus = "Pending",
                OrderStatus = "Pending",
                ProofImagePath = uploadedProofPath,
                Remarks = $"Target ID: {txtGameUserId.Text.Trim()}"
            };

            DataStore.Orders.Add(newOrder);

            MessageBox.Show($"🎉 Order #{newOrderId} for {selectedProduct.Name} placed successfully!\n\n💖 GCash Ref #{newOrder.GCashReferenceNo} has been submitted for verification.\nCheck 'My Order History' to track status! ✨",
                            "Order Placed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtGCashRef.Clear();
            txtGameUserId.Clear();
            picReceiptPreview.Image = null;
            uploadedProofPath = "";
        }
    }
}
