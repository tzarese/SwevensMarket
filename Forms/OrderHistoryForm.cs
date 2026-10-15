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
    public class OrderHistoryForm : Form
    {
        private DataGridView dgvHistory;
        private Button btnRefresh;

        public OrderHistoryForm()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(1060, 650);
            this.BackColor = SwevenColors.LightPink;

            var lblHeader = new Label
            {
                Text = "📜 My Personal Order History & GCash Status",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(20, 15),
                AutoSize = true
            };

            btnRefresh = new Button
            {
                Text = "🔄 Refresh Status",
                Location = new Point(20, 55),
                Size = new Size(150, 32),
                BackColor = SwevenColors.DarkPink,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Click += (s, e) => LoadHistory();

            var lblTip = new Label
            {
                Text = "💡 Tip: Once Admin verifies your GCash reference number, your status will change from 'Pending' to 'Verified'.",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = SwevenColors.TextGray,
                Location = new Point(190, 62),
                AutoSize = true
            };

            dgvHistory = new DataGridView
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
            dgvHistory.CellFormatting += DgvHistory_CellFormatting;

            this.Controls.Add(lblHeader);
            this.Controls.Add(btnRefresh);
            this.Controls.Add(lblTip);
            this.Controls.Add(dgvHistory);
        }

        private void LoadHistory()
        {
            string currentCustomer = string.IsNullOrEmpty(UserSession.FullName) ? "Maria Santos" : UserSession.FullName;

            var myOrders = DataStore.Orders
                .Where(o => o.Customer.Equals(currentCustomer, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(o => o.Date)
                .ToList();

            dgvHistory.DataSource = null;
            dgvHistory.DataSource = myOrders;
        }

        private void DgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHistory.Columns[e.ColumnIndex].Name == "GCashStatus" && e.Value != null)
            {
                string val = e.Value.ToString();
                if (val == "Verified") e.CellStyle.BackColor = SwevenColors.SuccessGreen;
                else if (val == "Pending") e.CellStyle.BackColor = SwevenColors.WarningYellow;
                else if (val == "Rejected") e.CellStyle.BackColor = SwevenColors.DangerRed;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dgvHistory.Columns[e.ColumnIndex].Name == "OrderStatus" && e.Value != null)
            {
                string val = e.Value.ToString();
                if (val == "Completed") e.CellStyle.BackColor = SwevenColors.SuccessGreen;
                else if (val == "Processing" || val == "Pending") e.CellStyle.BackColor = SwevenColors.WarningYellow;
                else if (val == "Cancelled") e.CellStyle.BackColor = SwevenColors.DangerRed;
                e.CellStyle.ForeColor = Color.White;
            }
        }
    }
}
