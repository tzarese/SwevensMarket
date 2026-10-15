using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public partial class PaymentVerificationForm : Form
    {
        private string currentFilter = "All";
        private Order? selectedOrder = null;

        public PaymentVerificationForm()
        {
            InitializeComponent();
            btnApprove.BackColor = SwevenColors.SuccessGreen;
            btnReject.BackColor = SwevenColors.DangerRed;
            LoadPayments("All");
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

        private void DgvPayments_CellClick(object? sender, DataGridViewCellEventArgs e)
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

        private void BtnApprove_Click(object? sender, EventArgs e)
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

        private void BtnReject_Click(object? sender, EventArgs e)
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

        private void BtnTabAll_Click(object? sender, EventArgs e) => LoadPayments("All");
        private void BtnTabPending_Click(object? sender, EventArgs e) => LoadPayments("Pending");
        private void BtnTabVerified_Click(object? sender, EventArgs e) => LoadPayments("Verified");
        private void BtnTabRejected_Click(object? sender, EventArgs e) => LoadPayments("Rejected");
    }
}
