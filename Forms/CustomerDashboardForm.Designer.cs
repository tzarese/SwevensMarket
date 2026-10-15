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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnNavTopUp = new System.Windows.Forms.Button();
            this.btnNavHistory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = SwevenColors.MainPink;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.btnNavTopUp);
            this.pnlSidebar.Controls.Add(this.btnNavHistory);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 720);
            this.pnlSidebar.TabIndex = 0;

            // lblLogo
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = SwevenColors.DarkPink;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🌸 SWEVEN\'S 🌸\nCUSTOMER HUB";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnNavTopUp
            this.btnNavTopUp.BackColor = SwevenColors.MainPink;
            this.btnNavTopUp.FlatAppearance.BorderSize = 0;
            this.btnNavTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTopUp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavTopUp.ForeColor = SwevenColors.TextColor;
            this.btnNavTopUp.Location = new System.Drawing.Point(10, 90);
            this.btnNavTopUp.Name = "btnNavTopUp";
            this.btnNavTopUp.Size = new System.Drawing.Size(200, 42);
            this.btnNavTopUp.TabIndex = 1;
            this.btnNavTopUp.Text = "🎮 Top-Up & Buy";
            this.btnNavTopUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTopUp.UseVisualStyleBackColor = false;
            this.btnNavTopUp.Click += new System.EventHandler(this.BtnNavTopUp_Click);

            // btnNavHistory
            this.btnNavHistory.BackColor = SwevenColors.MainPink;
            this.btnNavHistory.FlatAppearance.BorderSize = 0;
            this.btnNavHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavHistory.ForeColor = SwevenColors.TextColor;
            this.btnNavHistory.Location = new System.Drawing.Point(10, 140);
            this.btnNavHistory.Name = "btnNavHistory";
            this.btnNavHistory.Size = new System.Drawing.Size(200, 42);
            this.btnNavHistory.TabIndex = 2;
            this.btnNavHistory.Text = "📜 My Order History";
            this.btnNavHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHistory.UseVisualStyleBackColor = false;
            this.btnNavHistory.Click += new System.EventHandler(this.BtnNavHistory_Click);

            // btnLogout
            this.btnLogout.BackColor = SwevenColors.MainPink;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = SwevenColors.TextColor;
            this.btnLogout.Location = new System.Drawing.Point(10, 210);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 42);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1060, 65);
            this.pnlHeader.TabIndex = 1;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = SwevenColors.DarkPink;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(288, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hello, Customer! ✨ Happy Gaming!";

            // btnClose
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = SwevenColors.DarkPink;
            this.btnClose.Location = new System.Drawing.Point(1010, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            // pnlContent
            this.pnlContent.BackColor = SwevenColors.LightPink;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1060, 655);
            this.pnlContent.TabIndex = 2;

            // CustomerDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
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
