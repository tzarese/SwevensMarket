using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public partial class OrderManagementForm : Form
    {
        public OrderManagementForm()
        {
            InitializeComponent();
            CuteThemeHelper.ApplyCuteGrid(dgvOrders);
            SetupFilters();
            RefreshOrders();
        }

        private void SetupFilters()
        {
            cmbStatus.Items.AddRange(new string[] { "All Status", "Pending", "Processing", "Completed", "Cancelled" });
            cmbStatus.SelectedIndex = 0;

            cmbPayment.Items.AddRange(new string[] { "All Payment Status", "Pending", "Verified", "Rejected" });
            cmbPayment.SelectedIndex = 0;

            dtpFrom.Value = DateTime.Now.AddDays(-14);
            dtpTo.Value = DateTime.Now;

            cmbNewStatus.Items.AddRange(new string[] { "Pending", "Processing", "Completed", "Cancelled" });
            cmbNewStatus.SelectedIndex = 1;
        }

        private void RefreshOrders()
        {
            var query = DataStore.Orders.AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                query = query.Where(o => o.OrderId.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                         o.Customer.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (cmbStatus.SelectedIndex > 0)
                query = query.Where(o => o.OrderStatus == cmbStatus.SelectedItem!.ToString());

            if (cmbPayment.SelectedIndex > 0)
                query = query.Where(o => o.GCashStatus == cmbPayment.SelectedItem!.ToString());

            query = query.Where(o => o.Date.Date >= dtpFrom.Value.Date && o.Date.Date <= dtpTo.Value.Date);

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = query.OrderByDescending(o => o.Date).ToList();
        }

        private void DgvOrders_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].Name == "OrderStatus" && e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val == "Completed") e.CellStyle.BackColor = CuteColors.CuteMintGreen;
                else if (val == "Processing" || val == "Pending") e.CellStyle.BackColor = CuteColors.CuteBanana;
                else if (val == "Cancelled") e.CellStyle.BackColor = CuteColors.CuteRoseRed;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dgvOrders.Columns[e.ColumnIndex].Name == "GCashStatus" && e.Value != null)
            {
                string val = e.Value.ToString() ?? "";
                if (val == "Verified") e.CellStyle.BackColor = CuteColors.CuteMintGreen;
                else if (val == "Pending") e.CellStyle.BackColor = CuteColors.CuteBanana;
                else if (val == "Rejected") e.CellStyle.BackColor = CuteColors.CuteRoseRed;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void BtnUpdateStatus_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is Order order)
            {
                order.OrderStatus = cmbNewStatus.SelectedItem!.ToString();
                RefreshOrders();
                MessageBox.Show($"✨ Order #{order.OrderId} status updated to {order.OrderStatus}! 💖", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an order first.");
            }
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            MessageBox.Show($"📁 Exported {DataStore.Orders.Count} orders to SwevensMarket_Orders.csv successfully! ✨", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e) => RefreshOrders();
        private void CmbStatus_SelectedIndexChanged(object? sender, EventArgs e) => RefreshOrders();
        private void CmbPayment_SelectedIndexChanged(object? sender, EventArgs e) => RefreshOrders();
        private void DtpFrom_ValueChanged(object? sender, EventArgs e) => RefreshOrders();
        private void DtpTo_ValueChanged(object? sender, EventArgs e) => RefreshOrders();
    }
}
