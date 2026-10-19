using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class OrderHistoryForm
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
            this.pnlFilterTabs = new System.Windows.Forms.Panel();
            this.btnTabAll = new System.Windows.Forms.Button();
            this.btnTabSuccess = new System.Windows.Forms.Button();
            this.btnTabProcessing = new System.Windows.Forms.Button();
            this.btnTabPending = new System.Windows.Forms.Button();
            this.btnTabCanceled = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlCardsFlow = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlFilterTabs.SuspendLayout();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = SwevenColors.TextColor;
            this.lblHeader.Location = new System.Drawing.Point(20, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(260, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "📜 Order History";

            // pnlFilterTabs
            this.pnlFilterTabs.Controls.Add(this.btnTabAll);
            this.pnlFilterTabs.Controls.Add(this.btnTabSuccess);
            this.pnlFilterTabs.Controls.Add(this.btnTabProcessing);
            this.pnlFilterTabs.Controls.Add(this.btnTabPending);
            this.pnlFilterTabs.Controls.Add(this.btnTabCanceled);
            this.pnlFilterTabs.Location = new System.Drawing.Point(20, 48);
            this.pnlFilterTabs.Name = "pnlFilterTabs";
            this.pnlFilterTabs.Size = new System.Drawing.Size(460, 36);
            this.pnlFilterTabs.TabIndex = 1;

            // btnTabAll
            this.btnTabAll.BackColor = SwevenColors.DarkPink;
            this.btnTabAll.FlatAppearance.BorderSize = 0;
            this.btnTabAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabAll.ForeColor = System.Drawing.Color.White;
            this.btnTabAll.Location = new System.Drawing.Point(0, 3);
            this.btnTabAll.Name = "btnTabAll";
            this.btnTabAll.Size = new System.Drawing.Size(80, 30);
            this.btnTabAll.TabIndex = 0;
            this.btnTabAll.Text = "All";
            this.btnTabAll.UseVisualStyleBackColor = false;
            this.btnTabAll.Click += new System.EventHandler(this.BtnTab_Click);

            // btnTabSuccess
            this.btnTabSuccess.BackColor = System.Drawing.Color.White;
            this.btnTabSuccess.FlatAppearance.BorderSize = 0;
            this.btnTabSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSuccess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabSuccess.ForeColor = SwevenColors.TextColor;
            this.btnTabSuccess.Location = new System.Drawing.Point(85, 3);
            this.btnTabSuccess.Name = "btnTabSuccess";
            this.btnTabSuccess.Size = new System.Drawing.Size(85, 30);
            this.btnTabSuccess.TabIndex = 1;
            this.btnTabSuccess.Text = "Success";
            this.btnTabSuccess.UseVisualStyleBackColor = false;
            this.btnTabSuccess.Click += new System.EventHandler(this.BtnTab_Click);

            // btnTabProcessing
            this.btnTabProcessing.BackColor = System.Drawing.Color.White;
            this.btnTabProcessing.FlatAppearance.BorderSize = 0;
            this.btnTabProcessing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabProcessing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabProcessing.ForeColor = SwevenColors.TextColor;
            this.btnTabProcessing.Location = new System.Drawing.Point(175, 3);
            this.btnTabProcessing.Name = "btnTabProcessing";
            this.btnTabProcessing.Size = new System.Drawing.Size(95, 30);
            this.btnTabProcessing.TabIndex = 2;
            this.btnTabProcessing.Text = "Processing";
            this.btnTabProcessing.UseVisualStyleBackColor = false;
            this.btnTabProcessing.Click += new System.EventHandler(this.BtnTab_Click);

            // btnTabPending
            this.btnTabPending.BackColor = System.Drawing.Color.White;
            this.btnTabPending.FlatAppearance.BorderSize = 0;
            this.btnTabPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabPending.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabPending.ForeColor = SwevenColors.TextColor;
            this.btnTabPending.Location = new System.Drawing.Point(275, 3);
            this.btnTabPending.Name = "btnTabPending";
            this.btnTabPending.Size = new System.Drawing.Size(85, 30);
            this.btnTabPending.TabIndex = 3;
            this.btnTabPending.Text = "Pending";
            this.btnTabPending.UseVisualStyleBackColor = false;
            this.btnTabPending.Click += new System.EventHandler(this.BtnTab_Click);

            // btnTabCanceled
            this.btnTabCanceled.BackColor = System.Drawing.Color.White;
            this.btnTabCanceled.FlatAppearance.BorderSize = 0;
            this.btnTabCanceled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabCanceled.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabCanceled.ForeColor = SwevenColors.TextColor;
            this.btnTabCanceled.Location = new System.Drawing.Point(365, 3);
            this.btnTabCanceled.Name = "btnTabCanceled";
            this.btnTabCanceled.Size = new System.Drawing.Size(85, 30);
            this.btnTabCanceled.TabIndex = 4;
            this.btnTabCanceled.Text = "Canceled";
            this.btnTabCanceled.UseVisualStyleBackColor = false;
            this.btnTabCanceled.Click += new System.EventHandler(this.BtnTab_Click);

            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.Location = new System.Drawing.Point(495, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Search by Transaction ID or Product...";
            this.txtSearch.Size = new System.Drawing.Size(410, 24);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);

            // btnRefresh
            this.btnRefresh.BackColor = SwevenColors.DarkPink;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(915, 49);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

            // pnlCardsFlow
            this.pnlCardsFlow.AutoScroll = true;
            this.pnlCardsFlow.BackColor = System.Drawing.Color.Transparent;
            this.pnlCardsFlow.Location = new System.Drawing.Point(20, 92);
            this.pnlCardsFlow.Name = "pnlCardsFlow";
            this.pnlCardsFlow.Size = new System.Drawing.Size(1020, 545);
            this.pnlCardsFlow.TabIndex = 4;

            // OrderHistoryForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.pnlCardsFlow);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlFilterTabs);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistoryForm";
            this.Text = "Order History";
            this.pnlFilterTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlFilterTabs;
        private System.Windows.Forms.Button btnTabAll;
        private System.Windows.Forms.Button btnTabSuccess;
        private System.Windows.Forms.Button btnTabProcessing;
        private System.Windows.Forms.Button btnTabPending;
        private System.Windows.Forms.Button btnTabCanceled;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel pnlCardsFlow;
    }
}
