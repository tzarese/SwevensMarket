using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class CustomerDashboardForm
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
            pnlSidebar = new Panel();
            lblLogo = new Label();
            btnNavTopUp = new Button();
            btnNavHistory = new Button();
            btnLogout = new Button();
            pnlHeader = new Panel();
            lblWelcome = new Label();
            btnClose = new Button();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(253, 231, 240);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(btnNavTopUp);
            pnlSidebar.Controls.Add(btnNavHistory);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(251, 960);
            pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Georgia", 13F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(236, 72, 153);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(251, 107);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "SWEVEN'S CUSTOMER HUB";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNavTopUp
            // 
            btnNavTopUp.BackColor = Color.FromArgb(253, 231, 240);
            btnNavTopUp.FlatAppearance.BorderSize = 0;
            btnNavTopUp.FlatStyle = FlatStyle.Flat;
            btnNavTopUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavTopUp.ForeColor = Color.FromArgb(123, 63, 94);
            btnNavTopUp.Location = new Point(11, 120);
            btnNavTopUp.Margin = new Padding(3, 4, 3, 4);
            btnNavTopUp.Name = "btnNavTopUp";
            btnNavTopUp.Size = new Size(229, 56);
            btnNavTopUp.TabIndex = 1;
            btnNavTopUp.Text = "🎮 Top-Up & Buy";
            btnNavTopUp.TextAlign = ContentAlignment.MiddleLeft;
            btnNavTopUp.UseVisualStyleBackColor = false;
            btnNavTopUp.Click += BtnNavTopUp_Click;
            // 
            // btnNavHistory
            // 
            btnNavHistory.BackColor = Color.FromArgb(253, 231, 240);
            btnNavHistory.FlatAppearance.BorderSize = 0;
            btnNavHistory.FlatStyle = FlatStyle.Flat;
            btnNavHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavHistory.ForeColor = Color.FromArgb(123, 63, 94);
            btnNavHistory.Location = new Point(11, 187);
            btnNavHistory.Margin = new Padding(3, 4, 3, 4);
            btnNavHistory.Name = "btnNavHistory";
            btnNavHistory.Size = new Size(229, 56);
            btnNavHistory.TabIndex = 2;
            btnNavHistory.Text = "📜 My Order History";
            btnNavHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnNavHistory.UseVisualStyleBackColor = false;
            btnNavHistory.Click += BtnNavHistory_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(253, 231, 240);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(123, 63, 94);
            btnLogout.Location = new Point(11, 280);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(229, 56);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(251, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1212, 87);
            pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(236, 72, 153);
            lblWelcome.Location = new Point(23, 27);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(323, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hello, Customer! Happy Gaming!";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(236, 72, 153);
            btnClose.Location = new Point(1154, 20);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 47);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(255, 245, 248);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(251, 87);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1212, 873);
            pnlContent.TabIndex = 2;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 248);
            ClientSize = new Size(1463, 960);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnNavTopUp;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlContent;
    }
}
