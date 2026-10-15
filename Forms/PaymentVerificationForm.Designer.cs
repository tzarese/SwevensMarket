using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class PaymentVerificationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnTabAll = new System.Windows.Forms.Button();
            this.btnTabPending = new System.Windows.Forms.Button();
            this.btnTabVerified = new System.Windows.Forms.Button();
            this.btnTabRejected = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblT = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblOrderIdVal = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustomerVal = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProductVal = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAmountVal = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblRefVal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusVal = new System.Windows.Forms.Label();
            this.lblProof = new System.Windows.Forms.Label();
            this.picProof = new System.Windows.Forms.PictureBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProof)).BeginInit();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = SwevenColors.TextColor;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(287, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "💳 GCash Payment Verification";

            // btnTabAll
            this.btnTabAll.BackColor = SwevenColors.MainPink;
            this.btnTabAll.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnTabAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabAll.ForeColor = SwevenColors.TextColor;
            this.btnTabAll.Location = new System.Drawing.Point(20, 55);
            this.btnTabAll.Name = "btnTabAll";
            this.btnTabAll.Size = new System.Drawing.Size(110, 34);
            this.btnTabAll.TabIndex = 1;
            this.btnTabAll.Text = "All Payments";
            this.btnTabAll.UseVisualStyleBackColor = false;
            this.btnTabAll.Click += new System.EventHandler(this.BtnTabAll_Click);

            // btnTabPending
            this.btnTabPending.BackColor = SwevenColors.MainPink;
            this.btnTabPending.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnTabPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabPending.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabPending.ForeColor = SwevenColors.TextColor;
            this.btnTabPending.Location = new System.Drawing.Point(140, 55);
            this.btnTabPending.Name = "btnTabPending";
            this.btnTabPending.Size = new System.Drawing.Size(110, 34);
            this.btnTabPending.TabIndex = 2;
            this.btnTabPending.Text = "⏳ Pending";
            this.btnTabPending.UseVisualStyleBackColor = false;
            this.btnTabPending.Click += new System.EventHandler(this.BtnTabPending_Click);

            // btnTabVerified
            this.btnTabVerified.BackColor = SwevenColors.MainPink;
            this.btnTabVerified.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnTabVerified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabVerified.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabVerified.ForeColor = SwevenColors.TextColor;
            this.btnTabVerified.Location = new System.Drawing.Point(260, 55);
            this.btnTabVerified.Name = "btnTabVerified";
            this.btnTabVerified.Size = new System.Drawing.Size(110, 34);
            this.btnTabVerified.TabIndex = 3;
            this.btnTabVerified.Text = "✔ Verified";
            this.btnTabVerified.UseVisualStyleBackColor = false;
            this.btnTabVerified.Click += new System.EventHandler(this.BtnTabVerified_Click);

            // btnTabRejected
            this.btnTabRejected.BackColor = SwevenColors.MainPink;
            this.btnTabRejected.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnTabRejected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabRejected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabRejected.ForeColor = SwevenColors.TextColor;
            this.btnTabRejected.Location = new System.Drawing.Point(380, 55);
            this.btnTabRejected.Name = "btnTabRejected";
            this.btnTabRejected.Size = new System.Drawing.Size(110, 34);
            this.btnTabRejected.TabIndex = 4;
            this.btnTabRejected.Text = "✖ Rejected";
            this.btnTabRejected.UseVisualStyleBackColor = false;
            this.btnTabRejected.Click += new System.EventHandler(this.BtnTabRejected_Click);

            // dgvPayments
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.Location = new System.Drawing.Point(20, 100);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(650, 530);
            this.dgvPayments.TabIndex = 5;
            this.dgvPayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPayments_CellClick);

            // pnlDetails
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.lblT);
            this.pnlDetails.Controls.Add(this.lblOrderId);
            this.pnlDetails.Controls.Add(this.lblOrderIdVal);
            this.pnlDetails.Controls.Add(this.lblCustomer);
            this.pnlDetails.Controls.Add(this.lblCustomerVal);
            this.pnlDetails.Controls.Add(this.lblProduct);
            this.pnlDetails.Controls.Add(this.lblProductVal);
            this.pnlDetails.Controls.Add(this.lblAmount);
            this.pnlDetails.Controls.Add(this.lblAmountVal);
            this.pnlDetails.Controls.Add(this.lblRef);
            this.pnlDetails.Controls.Add(this.lblRefVal);
            this.pnlDetails.Controls.Add(this.lblStatus);
            this.pnlDetails.Controls.Add(this.lblStatusVal);
            this.pnlDetails.Controls.Add(this.lblProof);
            this.pnlDetails.Controls.Add(this.picProof);
            this.pnlDetails.Controls.Add(this.lblRemarks);
            this.pnlDetails.Controls.Add(this.txtRemarks);
            this.pnlDetails.Controls.Add(this.btnApprove);
            this.pnlDetails.Controls.Add(this.btnReject);
            this.pnlDetails.Location = new System.Drawing.Point(685, 55);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDetails.Size = new System.Drawing.Size(355, 575);
            this.pnlDetails.TabIndex = 6;

            // lblT
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblT.ForeColor = SwevenColors.DarkPink;
            this.lblT.Location = new System.Drawing.Point(15, 12);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(217, 20);
            this.lblT.TabIndex = 0;
            this.lblT.Text = "GCash Receipt & Verification";

            // lblOrderId
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrderId.ForeColor = SwevenColors.TextGray;
            this.lblOrderId.Location = new System.Drawing.Point(15, 45);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(59, 15);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "Order ID:";

            // lblOrderIdVal
            this.lblOrderIdVal.AutoSize = true;
            this.lblOrderIdVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrderIdVal.ForeColor = SwevenColors.TextColor;
            this.lblOrderIdVal.Location = new System.Drawing.Point(130, 45);
            this.lblOrderIdVal.Name = "lblOrderIdVal";
            this.lblOrderIdVal.Size = new System.Drawing.Size(12, 15);
            this.lblOrderIdVal.TabIndex = 2;
            this.lblOrderIdVal.Text = "-";

            // lblCustomer
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomer.ForeColor = SwevenColors.TextGray;
            this.lblCustomer.Location = new System.Drawing.Point(15, 69);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(63, 15);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Customer:";

            // lblCustomerVal
            this.lblCustomerVal.AutoSize = true;
            this.lblCustomerVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerVal.ForeColor = SwevenColors.TextColor;
            this.lblCustomerVal.Location = new System.Drawing.Point(130, 69);
            this.lblCustomerVal.Name = "lblCustomerVal";
            this.lblCustomerVal.Size = new System.Drawing.Size(12, 15);
            this.lblCustomerVal.TabIndex = 4;
            this.lblCustomerVal.Text = "-";

            // lblProduct
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProduct.ForeColor = SwevenColors.TextGray;
            this.lblProduct.Location = new System.Drawing.Point(15, 93);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(54, 15);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Product:";

            // lblProductVal
            this.lblProductVal.AutoSize = true;
            this.lblProductVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProductVal.ForeColor = SwevenColors.TextColor;
            this.lblProductVal.Location = new System.Drawing.Point(130, 93);
            this.lblProductVal.Name = "lblProductVal";
            this.lblProductVal.Size = new System.Drawing.Size(12, 15);
            this.lblProductVal.TabIndex = 6;
            this.lblProductVal.Text = "-";

            // lblAmount
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = SwevenColors.TextGray;
            this.lblAmount.Location = new System.Drawing.Point(15, 117);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 15);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount:";

            // lblAmountVal
            this.lblAmountVal.AutoSize = true;
            this.lblAmountVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmountVal.ForeColor = SwevenColors.TextColor;
            this.lblAmountVal.Location = new System.Drawing.Point(130, 117);
            this.lblAmountVal.Name = "lblAmountVal";
            this.lblAmountVal.Size = new System.Drawing.Size(12, 15);
            this.lblAmountVal.TabIndex = 8;
            this.lblAmountVal.Text = "-";

            // lblRef
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRef.ForeColor = SwevenColors.TextGray;
            this.lblRef.Location = new System.Drawing.Point(15, 141);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(73, 15);
            this.lblRef.TabIndex = 9;
            this.lblRef.Text = "GCash Ref #:";

            // lblRefVal
            this.lblRefVal.AutoSize = true;
            this.lblRefVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRefVal.ForeColor = SwevenColors.TextColor;
            this.lblRefVal.Location = new System.Drawing.Point(130, 141);
            this.lblRefVal.Name = "lblRefVal";
            this.lblRefVal.Size = new System.Drawing.Size(12, 15);
            this.lblRefVal.TabIndex = 10;
            this.lblRefVal.Text = "-";

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = SwevenColors.TextGray;
            this.lblStatus.Location = new System.Drawing.Point(15, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 15);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Payment Status:";

            // lblStatusVal
            this.lblStatusVal.AutoSize = true;
            this.lblStatusVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusVal.ForeColor = SwevenColors.TextColor;
            this.lblStatusVal.Location = new System.Drawing.Point(130, 165);
            this.lblStatusVal.Name = "lblStatusVal";
            this.lblStatusVal.Size = new System.Drawing.Size(12, 15);
            this.lblStatusVal.TabIndex = 12;
            this.lblStatusVal.Text = "-";

            // lblProof
            this.lblProof.AutoSize = true;
            this.lblProof.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProof.Location = new System.Drawing.Point(15, 195);
            this.lblProof.Name = "lblProof";
            this.lblProof.Size = new System.Drawing.Size(176, 15);
            this.lblProof.TabIndex = 13;
            this.lblProof.Text = "Proof of Payment Screenshot:";

            // picProof
            this.picProof.BackColor = SwevenColors.LightGray;
            this.picProof.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProof.Location = new System.Drawing.Point(15, 215);
            this.picProof.Name = "picProof";
            this.picProof.Size = new System.Drawing.Size(325, 170);
            this.picProof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProof.TabIndex = 14;
            this.picProof.TabStop = false;

            // lblRemarks
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.Location = new System.Drawing.Point(15, 400);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(137, 15);
            this.lblRemarks.TabIndex = 15;
            this.lblRemarks.Text = "Admin Remarks / Notes:";

            // txtRemarks
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRemarks.Location = new System.Drawing.Point(15, 420);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(325, 23);
            this.txtRemarks.TabIndex = 16;

            // btnApprove
            this.btnApprove.BackColor = SwevenColors.SuccessGreen;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(15, 460);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(155, 38);
            this.btnApprove.TabIndex = 17;
            this.btnApprove.Text = "✔ Approve Payment";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.BtnApprove_Click);

            // btnReject
            this.btnReject.BackColor = SwevenColors.DangerRed;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(185, 460);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(155, 38);
            this.btnReject.TabIndex = 18;
            this.btnReject.Text = "✖ Reject Payment";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.BtnReject_Click);

            // PaymentVerificationForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnTabRejected);
            this.Controls.Add(this.btnTabVerified);
            this.Controls.Add(this.btnTabPending);
            this.Controls.Add(this.btnTabAll);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentVerificationForm";
            this.Text = "Payment Verification";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnTabAll;
        private System.Windows.Forms.Button btnTabPending;
        private System.Windows.Forms.Button btnTabVerified;
        private System.Windows.Forms.Button btnTabRejected;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblOrderIdVal;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustomerVal;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProductVal;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAmountVal;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblRefVal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusVal;
        private System.Windows.Forms.Label lblProof;
        private System.Windows.Forms.PictureBox picProof;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}
