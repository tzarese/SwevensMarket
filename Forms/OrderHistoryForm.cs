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
    public partial class OrderHistoryForm : Form
    {
        private string activeFilter = "All";

        public OrderHistoryForm()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory()
        {
            string currentCustomer = string.IsNullOrEmpty(UserSession.FullName) ? "Maria Santos" : UserSession.FullName;

            var query = DataStore.Orders
                .Where(o => o.Customer.Equals(currentCustomer, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(o => o.Date)
                .AsEnumerable();

            // Filter by Status Tab
            if (activeFilter == "Success")
                query = query.Where(o => o.OrderStatus == "Completed");
            else if (activeFilter == "Processing")
                query = query.Where(o => o.OrderStatus == "Processing");
            else if (activeFilter == "Pending")
                query = query.Where(o => o.OrderStatus == "Pending");
            else if (activeFilter == "Canceled")
                query = query.Where(o => o.OrderStatus == "Cancelled");

            // Filter by Search Query
            string search = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(o =>
                    o.OrderId.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    o.Product.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    o.GCashReferenceNo.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    o.Remarks.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            var orders = query.ToList();

            pnlCardsFlow.SuspendLayout();
            pnlCardsFlow.Controls.Clear();

            if (orders.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = "🌸 No orders found in this category! 💕\nPlace a new top-up order in 'Create Top-Up Order'!",
                    Font = new Font("Segoe UI", 11F, FontStyle.Italic),
                    ForeColor = SwevenColors.TextGray,
                    AutoSize = false,
                    Size = new Size(950, 150),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                pnlCardsFlow.Controls.Add(lblEmpty);
            }
            else
            {
                foreach (var order in orders)
                {
                    pnlCardsFlow.Controls.Add(CreateOrderCard(order));
                }
            }

            pnlCardsFlow.ResumeLayout();
        }

        private Control CreateOrderCard(Order o)
        {
            var card = new CuteCardPanel
            {
                Size = new Size(490, 175),
                Margin = new Padding(0, 0, 16, 16),
                BackColor = Color.White,
                CardBorderColor = ColorTranslator.FromHtml("#FCE7F3"),
                BorderRadius = 14
            };

            // 1. Date Label
            var lblDate = new Label
            {
                Text = o.Date.ToString("MMMM dd, yyyy HH:mm:ss"),
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = SwevenColors.TextGray,
                Location = new Point(16, 12),
                AutoSize = true
            };

            // 2. Status Badge Pill
            Color badgeBg;
            string badgeText;

            if (o.OrderStatus == "Completed")
            {
                badgeBg = CuteColors.CuteMintGreen;
                badgeText = "✔ Success";
            }
            else if (o.OrderStatus == "Processing")
            {
                badgeBg = Color.FromArgb(99, 102, 241);
                badgeText = "⚙ Processing";
            }
            else if (o.OrderStatus == "Pending")
            {
                badgeBg = CuteColors.CuteBanana;
                badgeText = "⏳ Pending";
            }
            else
            {
                badgeBg = CuteColors.CuteRoseRed;
                badgeText = "❌ Canceled";
            }

            var lblBadge = new Label
            {
                Text = badgeText,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = badgeBg,
                Size = new Size(95, 22),
                Location = new Point(375, 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 3. Product Title
            var lblProduct = new Label
            {
                Text = $"1x {o.Product}",
                Font = new Font("Segoe UI", 11.5F, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(16, 36),
                AutoSize = true
            };

            // 4. User ID / Game Target
            string gameId = string.IsNullOrWhiteSpace(o.Remarks) ? "N/A" : o.Remarks;
            var lblUser = new Label
            {
                Text = $"User ID: {gameId}",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = SwevenColors.TextGray,
                Location = new Point(16, 62),
                AutoSize = true
            };

            // 5. Payment Method & GCash Ref
            var lblMethod = new Label
            {
                Text = $"Method: GCash   •   GCash Status: {o.GCashStatus}",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = SwevenColors.TextGray,
                Location = new Point(16, 82),
                AutoSize = true
            };

            // 6. Big Bold Price
            var lblPrice = new Label
            {
                Text = $"₱ {o.Amount:N2}",
                Font = new Font("Segoe UI", 13.5F, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                Location = new Point(16, 106),
                AutoSize = true
            };

            // 7. Transaction ID
            var lblTrans = new Label
            {
                Text = $"Transaction ID: {o.OrderId}",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#DB2777"),
                Location = new Point(16, 142),
                AutoSize = true
            };

            // 8. "View my order >" Link
            var lnkView = new LinkLabel
            {
                Text = "View my order ➔",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                LinkColor = SwevenColors.DarkPink,
                ActiveLinkColor = ColorTranslator.FromHtml("#BE185D"),
                Location = new Point(365, 142),
                AutoSize = true
            };
            lnkView.LinkClicked += (s, e) =>
            {
                MessageBox.Show(
                    $"📋 ORDER SUMMARY\n\n" +
                    $"• Order ID: {o.OrderId}\n" +
                    $"• Date: {o.Date:yyyy-MM-dd HH:mm}\n" +
                    $"• Product: {o.Product}\n" +
                    $"• Amount: ₱{o.Amount:N2}\n" +
                    $"• Game / Target: {gameId}\n" +
                    $"• GCash Ref No: {o.GCashReferenceNo}\n" +
                    $"• Payment Status: {o.GCashStatus}\n" +
                    $"• Delivery Status: {o.OrderStatus}\n\n" +
                    $"Thank you for purchasing at Sweven's Market! 💖",
                    "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            card.Controls.Add(lblDate);
            card.Controls.Add(lblBadge);
            card.Controls.Add(lblProduct);
            card.Controls.Add(lblUser);
            card.Controls.Add(lblMethod);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblTrans);
            card.Controls.Add(lnkView);

            return card;
        }

        private void BtnTab_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                activeFilter = btn.Text;

                // Reset all tab button styles
                btnTabAll.BackColor = Color.White;
                btnTabAll.ForeColor = SwevenColors.TextColor;
                btnTabSuccess.BackColor = Color.White;
                btnTabSuccess.ForeColor = SwevenColors.TextColor;
                btnTabProcessing.BackColor = Color.White;
                btnTabProcessing.ForeColor = SwevenColors.TextColor;
                btnTabPending.BackColor = Color.White;
                btnTabPending.ForeColor = SwevenColors.TextColor;
                btnTabCanceled.BackColor = Color.White;
                btnTabCanceled.ForeColor = SwevenColors.TextColor;

                // Highlight active button
                btn.BackColor = SwevenColors.DarkPink;
                btn.ForeColor = Color.White;

                LoadHistory();
            }
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e) => LoadHistory();

        private void BtnRefresh_Click(object? sender, EventArgs e) => LoadHistory();
    }
}
