using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public partial class OrderHistoryForm : Form
    {
        public OrderHistoryForm()
        {
            InitializeComponent();
            LoadHistory();
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

        private void DgvHistory_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHistory.Columns[e.ColumnIndex].Name == "GCashStatus" && e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val == "Verified") e.CellStyle.BackColor = SwevenColors.SuccessGreen;
                else if (val == "Pending") e.CellStyle.BackColor = SwevenColors.WarningYellow;
                else if (val == "Rejected") e.CellStyle.BackColor = SwevenColors.DangerRed;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dgvHistory.Columns[e.ColumnIndex].Name == "OrderStatus" && e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val == "Completed") e.CellStyle.BackColor = SwevenColors.SuccessGreen;
                else if (val == "Processing" || val == "Pending") e.CellStyle.BackColor = SwevenColors.WarningYellow;
                else if (val == "Cancelled") e.CellStyle.BackColor = SwevenColors.DangerRed;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void BtnRefresh_Click(object? sender, EventArgs e) => LoadHistory();
    }
}
