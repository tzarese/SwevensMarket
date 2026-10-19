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
        private string activeCategory = "MLBB";
        private string uploadedProofPath = "";
        private Product? selectedProduct = null;

        public CreateOrderGCashForm()
        {
            InitializeComponent();
            LoadCategoryItems();
        }

        private void LoadCategoryItems()
        {
            pnlItemCards.SuspendLayout();
            pnlItemCards.Controls.Clear();

            var items = DataStore.Products
                .Where(p => p.Category.Equals(activeCategory, StringComparison.OrdinalIgnoreCase) && p.Status == "Active")
                .ToList();

            if (items.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = $"🌸 No active products under {activeCategory} right now! 💕",
                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                    ForeColor = SwevenColors.TextGray,
                    AutoSize = false,
                    Size = new Size(500, 100),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                pnlItemCards.Controls.Add(lblEmpty);
            }
            else
            {
                foreach (var product in items)
                {
                    pnlItemCards.Controls.Add(CreateProductCard(product));
                }
            }

            pnlItemCards.ResumeLayout();
        }

        private Control CreateProductCard(Product p)
        {
            bool isSelected = selectedProduct?.Id == p.Id;

            var card = new CuteCardPanel
            {
                Size = new Size(250, 78),
                Margin = new Padding(0, 0, 10, 10),
                BackColor = isSelected ? ColorTranslator.FromHtml("#FFF0F5") : Color.White,
                CardBorderColor = isSelected ? SwevenColors.DarkPink : ColorTranslator.FromHtml("#FCE7F3"),
                BorderRadius = 12,
                Cursor = Cursors.Hand
            };

            var lblName = new Label
            {
                Text = p.Name,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = isSelected ? SwevenColors.DarkPink : SwevenColors.TextColor,
                Location = new Point(12, 10),
                AutoSize = true,
                Cursor = Cursors.Hand
            };

            var lblDesc = new Label
            {
                Text = p.Description,
                Font = new Font("Segoe UI", 7.8F),
                ForeColor = SwevenColors.TextGray,
                Location = new Point(12, 30),
                Size = new Size(225, 16),
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            var lblPrice = new Label
            {
                Text = $"₱ {p.Price:N2}",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                Location = new Point(12, 48),
                AutoSize = true,
                Cursor = Cursors.Hand
            };

            void SelectThisProduct()
            {
                selectedProduct = p;
                lblSelectedProduct.Text = $"🌸 Selected: {p.Name} ({p.Category}) 💖";
                lblSelectedPrice.Text = $"✨ Amount Due: ₱{p.Price:N2}";
                LoadCategoryItems(); // Refresh cards to show highlight on selected item
            }

            card.Click += (s, e) => SelectThisProduct();
            lblName.Click += (s, e) => SelectThisProduct();
            lblDesc.Click += (s, e) => SelectThisProduct();
            lblPrice.Click += (s, e) => SelectThisProduct();

            card.Controls.Add(lblName);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblPrice);

            return card;
        }

        private void BtnCategory_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn == btnCatMLBB) activeCategory = "MLBB";
                else if (btn == btnCatGames) activeCategory = "Games";
                else if (btn == btnCatVoucher) activeCategory = "Voucher";
                else if (btn == btnCatEntertainment) activeCategory = "Entertainment";

                // Reset all category buttons
                btnCatMLBB.BackColor = Color.White;
                btnCatMLBB.ForeColor = SwevenColors.TextColor;
                btnCatGames.BackColor = Color.White;
                btnCatGames.ForeColor = SwevenColors.TextColor;
                btnCatVoucher.BackColor = Color.White;
                btnCatVoucher.ForeColor = SwevenColors.TextColor;
                btnCatEntertainment.BackColor = Color.White;
                btnCatEntertainment.ForeColor = SwevenColors.TextColor;

                // Highlight active button
                btn.BackColor = SwevenColors.DarkPink;
                btn.ForeColor = Color.White;

                LoadCategoryItems();
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
                MessageBox.Show("Please click on an item from the category list first! 💕", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Customer = string.IsNullOrEmpty(UserSession.FullName) ? "Maria Santos" : UserSession.FullName,
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
            selectedProduct = null;
            lblSelectedProduct.Text = "Selected: None (Please click an item on the left)";
            lblSelectedPrice.Text = "Amount Due: ₱0.00";
            LoadCategoryItems();
        }
    }
}
