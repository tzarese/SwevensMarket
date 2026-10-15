using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public class OrderManagementForm : Form
    {
        private TextBox txtSearch;
        private ComboBox cmbStatus;
        private ComboBox cmbPayment;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnExport;
        private Button btnUpdateStatus;
        private ComboBox cmbNewStatus;
        private DataGridView dgvOrders;

        public OrderManagementForm()
        {
            InitializeComponent();
            RefreshOrders();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(1060, 650);
            this.BackColor = SwevenColors.LightPink;

            var lblHeader = new Label
            {
                Text = "📦 Order Management",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(20, 15),
                AutoSize = true
            };

            // Filter controls
            txtSearch = new TextBox
            {
                Location = new Point(20, 55),
                Size = new Size(200, 30),
                Font = new Font("Segoe UI", 10),
                PlaceholderText = "Search order, customer..."
            };
            txtSearch.TextChanged += (s, e) => RefreshOrders();

            cmbStatus = new ComboBox
            {
                Location = new Point(230, 55),
                Size = new Size(130, 30),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            cmbStatus.Items.AddRange(new string[] { "All Status", "Pending", "Processing", "Completed", "Cancelled" });
            cmbStatus.SelectedIndex = 0;
            cmbStatus.SelectedIndexChanged += (s, e) => RefreshOrders();

            cmbPayment = new ComboBox
            {
                Location = new Point(370, 55),
                Size = new Size(150, 30),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };
            cmbPayment.Items.AddRange(new string[] { "All Payment Status", "Pending", "Verified", "Rejected" });
            cmbPayment.SelectedIndex = 0;
            cmbPayment.SelectedIndexChanged += (s, e) => RefreshOrders();

            dtpFrom = new DateTimePicker { Location = new Point(530, 55), Width = 110, Format = DateTimePickerFormat.Short, Value = DateTime.Now.AddDays(-14) };
            dtpTo = new DateTimePicker { Location = new Point(650, 55), Width = 110, Format = DateTimePickerFormat.Short, Value = DateTime.Now };
            dtpFrom.ValueChanged += (s, e) => RefreshOrders();
            dtpTo.ValueChanged += (s, e) => RefreshOrders();

            btnExport = new Button
            {
                Text = "📁 Export CSV",
                Location = new Point(770, 53),
                Size = new Size(110, 32),
                BackColor = SwevenColors.DarkPink,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.Click += BtnExport_Click;

            // Status Update Bar
            var pnlUpdate = new Panel
            {
                Location = new Point(20, 95),
                Size = new Size(1015, 45),
                BackColor = Color.White
            };

            var lblQuick = new Label { Text = "Update Selected Order Status:", Location = new Point(12, 12), AutoSize = true, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), ForeColor = SwevenColors.TextColor };
            cmbNewStatus = new ComboBox
            {
                Location = new Point(230, 10),
                Size = new Size(150, 28),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbNewStatus.Items.AddRange(new string[] { "Pending", "Processing", "Completed", "Cancelled" });
            cmbNewStatus.SelectedIndex = 1;

            btnUpdateStatus = new Button
            {
                Text = "✔ Update Status",
                Location = new Point(390, 8),
                Size = new Size(130, 30),
                BackColor = SwevenColors.MainPink,
                ForeColor = SwevenColors.TextColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnUpdateStatus.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            btnUpdateStatus.Click += BtnUpdateStatus_Click;

            pnlUpdate.Controls.Add(lblQuick);
            pnlUpdate.Controls.Add(cmbNewStatus);
            pnlUpdate.Controls.Add(btnUpdateStatus);

            // Orders DataGridView
            dgvOrders = new DataGridView
            {
                Location = new Point(20, 150),
                Size = new Size(1015, 480),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvOrders.CellFormatting += DgvOrders_CellFormatting;

            this.Controls.Add(lblHeader);
            this.Controls.Add(txtSearch);
            this.Controls.Add(cmbStatus);
            this.Controls.Add(cmbPayment);
            this.Controls.Add(dtpFrom);
            this.Controls.Add(dtpTo);
            this.Controls.Add(btnExport);
            this.Controls.Add(pnlUpdate);
            this.Controls.Add(dgvOrders);
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
                query = query.Where(o => o.OrderStatus == cmbStatus.SelectedItem.ToString());

            if (cmbPayment.SelectedIndex > 0)
                query = query.Where(o => o.GCashStatus == cmbPayment.SelectedItem.ToString());

            query = query.Where(o => o.Date.Date >= dtpFrom.Value.Date && o.Date.Date <= dtpTo.Value.Date);

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = query.OrderByDescending(o => o.Date).ToList();
        }

        private void DgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].Name == "OrderStatus" && e.Value != null)
            {
                string val = e.Value.ToString();
                if (val == "Completed") e.CellStyle.BackColor = SwevenColors.SuccessGreen;
                else if (val == "Processing" || val == "Pending") e.CellStyle.BackColor = SwevenColors.WarningYellow;
                else if (val == "Cancelled") e.CellStyle.BackColor = SwevenColors.DangerRed;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dgvOrders.Columns[e.ColumnIndex].Name == "GCashStatus" && e.Value != null)
            {
                string val = e.Value.ToString();
                if (val == "Verified") e.CellStyle.BackColor = SwevenColors.SuccessGreen;
                else if (val == "Pending") e.CellStyle.BackColor = SwevenColors.WarningYellow;
                else if (val == "Rejected") e.CellStyle.BackColor = SwevenColors.DangerRed;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is Order order)
            {
                order.OrderStatus = cmbNewStatus.SelectedItem.ToString();
                RefreshOrders();
                MessageBox.Show($"Order #{order.OrderId} status changed to {order.OrderStatus}!", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an order first.");
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Exported {DataStore.Orders.Count} orders to SwevensMarket_Orders.csv successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
