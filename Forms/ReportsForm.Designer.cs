using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class ReportsForm
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlRev = new System.Windows.Forms.Panel();
            this.lblRevTitle = new System.Windows.Forms.Label();
            this.lblTotalRev = new System.Windows.Forms.Label();
            this.pnlOrd = new System.Windows.Forms.Panel();
            this.lblOrdTitle = new System.Windows.Forms.Label();
            this.lblTotalOrd = new System.Windows.Forms.Label();
            this.pnlAvg = new System.Windows.Forms.Panel();
            this.lblAvgTitle = new System.Windows.Forms.Label();
            this.lblAvgVal = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();

            this.pnlRev.SuspendLayout();
            this.pnlOrd.SuspendLayout();
            this.pnlAvg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = SwevenColors.TextColor;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.UseMnemonic = false;
            this.lblHeader.Text = "📊 Financial Reports & Sales Analytics";

            // lblFrom
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFrom.Location = new System.Drawing.Point(20, 58);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 17);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From:";

            // dtpStart
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(70, 55);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(130, 23);
            this.dtpStart.TabIndex = 2;

            // lblTo
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(220, 58);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 17);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To:";

            // dtpEnd
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(255, 55);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(130, 23);
            this.dtpEnd.TabIndex = 4;

            // btnGenerate
            this.btnGenerate.BackColor = SwevenColors.DarkPink;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(410, 53);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 32);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "🔍 Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);

            // pnlRev
            this.pnlRev.BackColor = System.Drawing.Color.White;
            this.pnlRev.Controls.Add(this.lblRevTitle);
            this.pnlRev.Controls.Add(this.lblTotalRev);
            this.pnlRev.Location = new System.Drawing.Point(20, 100);
            this.pnlRev.Name = "pnlRev";
            this.pnlRev.Size = new System.Drawing.Size(320, 80);
            this.pnlRev.TabIndex = 6;

            // lblRevTitle
            this.lblRevTitle.AutoSize = true;
            this.lblRevTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRevTitle.ForeColor = SwevenColors.TextGray;
            this.lblRevTitle.Location = new System.Drawing.Point(16, 12);
            this.lblRevTitle.Name = "lblRevTitle";
            this.lblRevTitle.Size = new System.Drawing.Size(83, 15);
            this.lblRevTitle.TabIndex = 0;
            this.lblRevTitle.Text = "Total Revenue";

            // lblTotalRev
            this.lblTotalRev.AutoSize = true;
            this.lblTotalRev.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalRev.ForeColor = SwevenColors.TextColor;
            this.lblTotalRev.Location = new System.Drawing.Point(14, 34);
            this.lblTotalRev.Name = "lblTotalRev";
            this.lblTotalRev.Size = new System.Drawing.Size(61, 25);
            this.lblTotalRev.TabIndex = 1;
            this.lblTotalRev.Text = "₱0.00";

            // pnlOrd
            this.pnlOrd.BackColor = System.Drawing.Color.White;
            this.pnlOrd.Controls.Add(this.lblOrdTitle);
            this.pnlOrd.Controls.Add(this.lblTotalOrd);
            this.pnlOrd.Location = new System.Drawing.Point(360, 100);
            this.pnlOrd.Name = "pnlOrd";
            this.pnlOrd.Size = new System.Drawing.Size(320, 80);
            this.pnlOrd.TabIndex = 7;

            // lblOrdTitle
            this.lblOrdTitle.AutoSize = true;
            this.lblOrdTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrdTitle.ForeColor = SwevenColors.TextGray;
            this.lblOrdTitle.Location = new System.Drawing.Point(16, 12);
            this.lblOrdTitle.Name = "lblOrdTitle";
            this.lblOrdTitle.Size = new System.Drawing.Size(92, 15);
            this.lblOrdTitle.TabIndex = 0;
            this.lblOrdTitle.Text = "Verified Orders";

            // lblTotalOrd
            this.lblTotalOrd.AutoSize = true;
            this.lblTotalOrd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrd.ForeColor = SwevenColors.TextColor;
            this.lblTotalOrd.Location = new System.Drawing.Point(14, 34);
            this.lblTotalOrd.Name = "lblTotalOrd";
            this.lblTotalOrd.Size = new System.Drawing.Size(23, 25);
            this.lblTotalOrd.TabIndex = 1;
            this.lblTotalOrd.Text = "0";

            // pnlAvg
            this.pnlAvg.BackColor = System.Drawing.Color.White;
            this.pnlAvg.Controls.Add(this.lblAvgTitle);
            this.pnlAvg.Controls.Add(this.lblAvgVal);
            this.pnlAvg.Location = new System.Drawing.Point(700, 100);
            this.pnlAvg.Name = "pnlAvg";
            this.pnlAvg.Size = new System.Drawing.Size(320, 80);
            this.pnlAvg.TabIndex = 8;

            // lblAvgTitle
            this.lblAvgTitle.AutoSize = true;
            this.lblAvgTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvgTitle.ForeColor = SwevenColors.TextGray;
            this.lblAvgTitle.Location = new System.Drawing.Point(16, 12);
            this.lblAvgTitle.Name = "lblAvgTitle";
            this.lblAvgTitle.Size = new System.Drawing.Size(121, 15);
            this.lblAvgTitle.TabIndex = 0;
            this.lblAvgTitle.Text = "Average Transaction";

            // lblAvgVal
            this.lblAvgVal.AutoSize = true;
            this.lblAvgVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAvgVal.ForeColor = SwevenColors.TextColor;
            this.lblAvgVal.Location = new System.Drawing.Point(14, 34);
            this.lblAvgVal.Name = "lblAvgVal";
            this.lblAvgVal.Size = new System.Drawing.Size(61, 25);
            this.lblAvgVal.TabIndex = 1;
            this.lblAvgVal.Text = "₱0.00";

            // dgvReport
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.Location = new System.Drawing.Point(20, 200);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1000, 420);
            this.dgvReport.TabIndex = 9;

            // ReportsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.pnlAvg);
            this.Controls.Add(this.pnlOrd);
            this.Controls.Add(this.pnlRev);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.Text = "Reports & Analytics";
            this.pnlRev.ResumeLayout(false);
            this.pnlRev.PerformLayout();
            this.pnlOrd.ResumeLayout(false);
            this.pnlOrd.PerformLayout();
            this.pnlAvg.ResumeLayout(false);
            this.pnlAvg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlRev;
        private System.Windows.Forms.Label lblRevTitle;
        private System.Windows.Forms.Label lblTotalRev;
        private System.Windows.Forms.Panel pnlOrd;
        private System.Windows.Forms.Label lblOrdTitle;
        private System.Windows.Forms.Label lblTotalOrd;
        private System.Windows.Forms.Panel pnlAvg;
        private System.Windows.Forms.Label lblAvgTitle;
        private System.Windows.Forms.Label lblAvgVal;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}
