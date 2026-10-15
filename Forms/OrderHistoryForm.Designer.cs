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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = SwevenColors.TextColor;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(412, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "📜 My Personal Order History & GCash Status";

            // btnRefresh
            this.btnRefresh.BackColor = SwevenColors.DarkPink;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(20, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 32);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "🔄 Refresh Status";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

            // lblTip
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTip.ForeColor = SwevenColors.TextGray;
            this.lblTip.Location = new System.Drawing.Point(190, 62);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(588, 15);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "💡 Tip: Once Admin verifies your GCash reference number, your status will change from \'Pending\' to \'Verified\'.";

            // dgvHistory
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.Location = new System.Drawing.Point(20, 100);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(1015, 520);
            this.dgvHistory.TabIndex = 3;
            this.dgvHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvHistory_CellFormatting);

            // OrderHistoryForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderHistoryForm";
            this.Text = "Order History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.DataGridView dgvHistory;
    }
}
