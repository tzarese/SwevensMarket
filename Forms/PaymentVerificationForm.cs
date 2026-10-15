using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public class PaymentVerificationForm : Form
    {
        private Button btnTabAll;
        private Button btnTabPending;
        private Button btnTabVerified;
        private Button btnTabRejected;
        private DataGridView dgvPayments;
        private string currentFilter = "All";

        // Right details panel
        private Panel pnlDetails;
        private Label lblOrderIdVal;
        private Label lblCustomerVal;
        private Label lblProductVal;
        private Label lblAmountVal;
        private Label lblRefVal;
        private Label lblStatusVal;
        private PictureBox picProof;
        private TextBox txtRemarks;
        private Button btnApprove;
        private Button btnReject;

        private Order selectedOrder = null;

        public PaymentVerificationForm()
        {
            InitializeComponent();
            LoadPayments("All");
        }

        private void InitializeComponent()
        {
            this.Size = new Size(1060, 650);
            this.BackColor = SwevenColors.LightPink;

            var lblHeader = new Label
            {
                Text = "💳 GCash Payment Verification",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(20, 15),
                AutoSize = true
            };

            // Filter Tabs
            btnTabAll = CreateTabButton("All Payments", new Point(20, 55), (s, e) => LoadPayments("All"));
            btnTabPending = CreateTabButton("⏳ Pending", new Point(140, 55), (s, e) => LoadPayments("Pending"));
            btnTabVerified = CreateTabButton("✔ Verified", new Point(260, 55), (s, e) => LoadPayments("Verified"));
            btnTabRejected = CreateTabButton("✖ Rejected", new Point(380, 55), (s, e) => LoadPayments("Rejected"));

            // Grid for payments
            dgvPayments = new DataGridView
            {
                Location = new Point(20, 100),
                Size = new Size(650, 530),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            dgvPayments.CellClick += DgvPayments_CellClick;

            // Details and Proof Review Panel on the Right
            BuildDetailsPanel();

            this.Controls.Add(lblHeader);
            this.Controls.Add(btnTabAll);
            this.Controls.Add(btnTabPending);
            this.Controls.Add(btnTabVerified);
            this.Controls.Add(btnTabRejected);
            this.Controls.Add(dgvPayments);
            this.Controls.Add(pnlDetails);
        }

        private Button CreateTabButton(string text, Point loc, EventHandler onClick)
        {
            var btn = new Button
            {
                Text = text,
                Location = loc,
                Size = new Size(110, 34),
                BackColor = SwevenColors.MainPink,
                ForeColor = SwevenColors.TextColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            btn.Click += onClick;
            return btn;
        }

        private void BuildDetailsPanel()
        {
            pnlDetails = new Panel
            {
                Location = new Point(685, 55),
                Size = new Size(355, 575),
                BackColor = Color.White,
                Padding = new Padding(15)
            };

            var lblT = new Label { Text = "GCash Receipt & Verification", Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = SwevenColors.DarkPink, Location = new Point(15, 12), AutoSize = true };

            int y = 45;
            lblOrderIdVal = AddDetailRow("Order ID:", "-", ref y);
            lblCustomerVal = AddDetailRow("Customer:", "-", ref y);
            lblProductVal = AddDetailRow("Product:", "-", ref y);
            lblAmountVal = AddDetailRow("Amount:", "-", ref y);
            lblRefVal = AddDetailRow("GCash Ref #:", "-", ref y);
            lblStatusVal = AddDetailRow("Payment Status:", "-", ref y);

            var lblProof = new Label { Text = "Proof of Payment Screenshot:", Font = new Font("Segoe UI", 8.5f, FontStyle.Bold), Location = new Point(15, y), AutoSize = true };
            y += 22;

            picProof = new PictureBox
            {
                Location = new Point(15, y),
                Size = new Size(325, 170),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = SwevenColors.LightGray
            };
            y += 180;

            var lblRemarks = new Label { Text = "Admin Remarks / Notes:", Font = new Font("Segoe UI", 8.5f, FontStyle.Bold), Location = new Point(15, y), AutoSize = true };
            y += 20;

            txtRemarks = new TextBox { Location = new Point(15, y), Size = new Size(325, 30), Font = new Font("Segoe UI", 9) };
            y += 40;

            btnApprove = new Button
            {
                Text = "✔ Approve Payment",
                Location = new Point(15, y),
                Size = new Size(155, 38),
                BackColor = SwevenColors.SuccessGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.Click += BtnApprove_Click;

            btnReject = new Button
            {
                Text = "✖ Reject Payment",
                Location = new Point(185, y),
                Size = new Size(155, 38),
                BackColor = SwevenColors.DangerRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.Click += BtnReject_Click;

            pnlDetails.Controls.Add(lblT);
            pnlDetails.Controls.Add(lblProof);
            pnlDetails.Controls.Add(picProof);
            pnlDetails.Controls.Add(lblRemarks);
            pnlDetails.Controls.Add(txtRemarks);
            pnlDetails.Controls.Add(btnApprove);
            pnlDetails.Controls.Add(btnReject);
        }

        private Label AddDetailRow(string title, string def, ref int y)
        {
            var lblLbl = new Label { Text = title, Location = new Point(15, y), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = SwevenColors.TextGray };
            var lblVal = new Label { Text = def, Location = new Point(130, y), AutoSize = true, Font = new Font("Segoe UI", 9), ForeColor = SwevenColors.TextColor };
            pnlDetails.Controls.Add(lblLbl);
            pnlDetails.Controls.Add(lblVal);
            y += 24;
            return lblVal;
        }

        private void LoadPayments(string filter)
        {
            currentFilter = filter;
            var query = DataStore.Orders.AsQueryable();

            if (filter != "All")
                query = query.Where(o => o.GCashStatus == filter);

            dgvPayments.DataSource = null;
            dgvPayments.DataSource = query.OrderByDescending(o => o.Date).ToList();
        }

        private void DgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPayments.CurrentRow?.DataBoundItem is Order o)
            {
                selectedOrder = o;
                lblOrderIdVal.Text = o.OrderId;
                lblCustomerVal.Text = o.Customer;
                lblProductVal.Text = o.Product;
                lblAmountVal.Text = $"₱{o.Amount:N2}";
                lblRefVal.Text = o.GCashReferenceNo;
                lblStatusVal.Text = o.GCashStatus;
                txtRemarks.Text = o.Remarks;

                if (!string.IsNullOrEmpty(o.ProofImagePath) && System.IO.File.Exists(o.ProofImagePath))
                    picProof.ImageLocation = o.ProofImagePath;
                else
                    picProof.Image = null;
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                MessageBox.Show("Please select an order to verify.");
                return;
            }

            selectedOrder.GCashStatus = "Verified";
            selectedOrder.OrderStatus = "Processing";
            selectedOrder.Remarks = txtRemarks.Text;
            MessageBox.Show($"Payment for Order #{selectedOrder.OrderId} Approved!", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPayments(currentFilter);
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            if (selectedOrder == null)
            {
                MessageBox.Show("Please select an order to reject.");
                return;
            }

            selectedOrder.GCashStatus = "Rejected";
            selectedOrder.OrderStatus = "Cancelled";
            selectedOrder.Remarks = txtRemarks.Text;
            MessageBox.Show($"Payment for Order #{selectedOrder.OrderId} Rejected!", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadPayments(currentFilter);
        }
    }
}
