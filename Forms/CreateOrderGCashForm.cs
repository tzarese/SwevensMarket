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
    public class CreateOrderGCashForm : Form
    {
        private DataGridView dgvCatalog;
        private Label lblSelectedProduct;
        private Label lblSelectedPrice;
        private TextBox txtGameUserId; // Game ID / Server
        private TextBox txtGCashRef;
        private PictureBox picReceiptPreview;
        private string uploadedProofPath = "";
        private Button btnUpload;
        private Button btnSubmitOrder;
        private Product selectedProduct = null;

        public CreateOrderGCashForm()
        {
            InitializeComponent();
            LoadCatalog();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(1060, 650);
            this.BackColor = SwevenColors.LightPink;

            var lblHeader = new Label
            {
                Text = "🎮 Create Top-Up Order + GCash Payment",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(20, 15),
                AutoSize = true
            };

            // Catalog Grid on Left
            var lblCatTitle = new Label { Text = "1. Choose Your Top-Up / Service:", Location = new Point(20, 50), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = SwevenColors.DarkPink };
            dgvCatalog = new DataGridView
            {
                Location = new Point(20, 75),
                Size = new Size(520, 550),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvCatalog.CellClick += DgvCatalog_CellClick;

            // GCash Payment Section on Right
            var pnlGCash = new Panel
            {
                Location = new Point(560, 75),
                Size = new Size(475, 550),
                BackColor = Color.White,
                Padding = new Padding(20)
            };

            var lblStep2 = new Label { Text = "2. Enter Details & GCash Payment", Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = SwevenColors.DarkPink, Location = new Point(15, 12), AutoSize = true };

            int y = 45;
            lblSelectedProduct = new Label { Text = "Selected: None (Please click an item on the left)", Location = new Point(15, y), AutoSize = true, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = SwevenColors.TextColor };
            y += 25;
            lblSelectedPrice = new Label { Text = "Amount Due: ₱0.00", Location = new Point(15, y), AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = SwevenColors.DarkPink };
            y += 35;

            var lblGame = new Label { Text = "Game User ID / Server (e.g. 12345678 (2001)):", Location = new Point(15, y), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            y += 20;
            txtGameUserId = new TextBox { Location = new Point(15, y), Size = new Size(440, 28), Font = new Font("Segoe UI", 9.5f) };
            y += 35;

            // GCash Merchant Box
            var pnlMerchant = new Panel { Location = new Point(15, y), Size = new Size(440, 65), BackColor = SwevenColors.MainPink, Padding = new Padding(10) };
            var lblGCashMerchant = new Label
            {
                Text = "📱 GCash Merchant Details:\nNumber: 0917-888-9999 (Sweven's Market Official)\nSend via Express Send & save your Reference Number.",
                Font = new Font("Segoe UI", 8.5f, FontStyle.Regular),
                ForeColor = SwevenColors.TextColor,
                Dock = DockStyle.Fill
            };
            pnlMerchant.Controls.Add(lblGCashMerchant);
            y += 75;

            var lblRef = new Label { Text = "Enter 13-Digit GCash Reference Number *", Location = new Point(15, y), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = SwevenColors.TextColor };
            y += 20;
            txtGCashRef = new TextBox { Location = new Point(15, y), Size = new Size(440, 28), Font = new Font("Segoe UI", 10), PlaceholderText = "e.g. 1002345678901" };
            y += 35;

            var lblProof = new Label { Text = "Attach Payment Screenshot (Optional):", Location = new Point(15, y), AutoSize = true, Font = new Font("Segoe UI", 8.5f, FontStyle.Bold) };
            y += 20;
            btnUpload = new Button { Text = "📎 Browse Image...", Location = new Point(15, y), Size = new Size(140, 30), BackColor = SwevenColors.MainPink, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 8.5f, FontStyle.Bold) };
            btnUpload.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            btnUpload.Click += BtnUpload_Click;

            picReceiptPreview = new PictureBox { Location = new Point(165, y), Size = new Size(290, 80), BorderStyle = BorderStyle.FixedSingle, SizeMode = PictureBoxSizeMode.Zoom, BackColor = SwevenColors.LightGray };
            y += 90;

            btnSubmitOrder = new Button
            {
                Text = "🚀 SUBMIT ORDER & GCASH PAYMENT",
                Location = new Point(15, y),
                Size = new Size(440, 45),
                BackColor = SwevenColors.DarkPink,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnSubmitOrder.FlatAppearance.BorderSize = 0;
            btnSubmitOrder.Click += BtnSubmitOrder_Click;

            pnlGCash.Controls.Add(lblStep2);
            pnlGCash.Controls.Add(lblSelectedProduct);
            pnlGCash.Controls.Add(lblSelectedPrice);
            pnlGCash.Controls.Add(lblGame);
            pnlGCash.Controls.Add(txtGameUserId);
            pnlGCash.Controls.Add(pnlMerchant);
            pnlGCash.Controls.Add(lblRef);
            pnlGCash.Controls.Add(txtGCashRef);
            pnlGCash.Controls.Add(lblProof);
            pnlGCash.Controls.Add(btnUpload);
            pnlGCash.Controls.Add(picReceiptPreview);
            pnlGCash.Controls.Add(btnSubmitOrder);

            this.Controls.Add(lblHeader);
            this.Controls.Add(lblCatTitle);
            this.Controls.Add(dgvCatalog);
            this.Controls.Add(pnlGCash);
        }

        private void LoadCatalog()
        {
            var activeItems = DataStore.Products.Where(p => p.Status == "Active").ToList();
            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = activeItems;
        }

        private void DgvCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCatalog.CurrentRow?.DataBoundItem is Product p)
            {
                selectedProduct = p;
                lblSelectedProduct.Text = $"Selected: {p.Name} ({p.Category})";
                lblSelectedPrice.Text = $"Amount Due: ₱{p.Price:N2}";
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)
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

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please click on a product from the list first!", "Select Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGCashRef.Text) || txtGCashRef.Text.Trim().Length < 8)
            {
                MessageBox.Show("Please enter a valid GCash Reference Number (from your GCash SMS/receipt)!", "Reference Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            MessageBox.Show($"Order #{newOrderId} for {selectedProduct.Name} placed successfully!\n\nGCash Ref #{newOrder.GCashReferenceNo} has been submitted to Admin for verification.\nCheck 'My Order History' to track status.",
                            "Order Placed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtGCashRef.Clear();
            txtGameUserId.Clear();
            picReceiptPreview.Image = null;
            uploadedProofPath = "";
        }
    }
}
