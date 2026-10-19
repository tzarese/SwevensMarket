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
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlCustomerProfile = new CuteCardPanel();
            this.lblCustAvatar = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustTier = new System.Windows.Forms.Label();
            this.lblCustPoints = new System.Windows.Forms.Label();
            this.btnNavTopUp = new System.Windows.Forms.Button();
            this.btnNavHistory = new System.Windows.Forms.Button();
            this.btnNavPerks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.pnlSidebar.SuspendLayout();
            this.pnlCustomerProfile.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = SwevenColors.LightPink;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.pnlCustomerProfile);
            this.pnlSidebar.Controls.Add(this.btnNavTopUp);
            this.pnlSidebar.Controls.Add(this.btnNavHistory);
            this.pnlSidebar.Controls.Add(this.btnNavPerks);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 750);
            this.pnlSidebar.TabIndex = 0;

            // lblLogo
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Georgia", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = SwevenColors.DarkPink;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 60);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🎀 SWEVEN'S 🎀\nCUSTOMER HUB";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlCustomerProfile
            this.pnlCustomerProfile.BackColor = System.Drawing.Color.White;
            this.pnlCustomerProfile.Controls.Add(this.lblCustAvatar);
            this.pnlCustomerProfile.Controls.Add(this.lblCustName);
            this.pnlCustomerProfile.Controls.Add(this.lblCustTier);
            this.pnlCustomerProfile.Controls.Add(this.lblCustPoints);
            this.pnlCustomerProfile.Location = new System.Drawing.Point(12, 65);
            this.pnlCustomerProfile.Name = "pnlCustomerProfile";
            this.pnlCustomerProfile.Padding = new System.Windows.Forms.Padding(8);
            this.pnlCustomerProfile.Size = new System.Drawing.Size(196, 95);
            this.pnlCustomerProfile.TabIndex = 1;

            // lblCustAvatar
            this.lblCustAvatar.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblCustAvatar.Location = new System.Drawing.Point(8, 8);
            this.lblCustAvatar.Name = "lblCustAvatar";
            this.lblCustAvatar.Size = new System.Drawing.Size(35, 35);
            this.lblCustAvatar.TabIndex = 0;
            this.lblCustAvatar.Text = "🐱";
            this.lblCustAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCustName
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCustName.ForeColor = SwevenColors.TextColor;
            this.lblCustName.Location = new System.Drawing.Point(45, 10);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(89, 17);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Maria Santos";

            // lblCustTier
            this.lblCustTier.AutoSize = true;
            this.lblCustTier.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblCustTier.ForeColor = SwevenColors.DarkPink;
            this.lblCustTier.Location = new System.Drawing.Point(45, 30);
            this.lblCustTier.Name = "lblCustTier";
            this.lblCustTier.Size = new System.Drawing.Size(126, 13);
            this.lblCustTier.TabIndex = 2;
            this.lblCustTier.Text = "⭐ VIP Gamer Level 2";

            // lblCustPoints
            this.lblCustPoints.AutoSize = true;
            this.lblCustPoints.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCustPoints.ForeColor = SwevenColors.TextGray;
            this.lblCustPoints.Location = new System.Drawing.Point(10, 68);
            this.lblCustPoints.Name = "lblCustPoints";
            this.lblCustPoints.Size = new System.Drawing.Size(170, 13);
            this.lblCustPoints.TabIndex = 3;
            this.lblCustPoints.Text = "🎁 Sweven Points: 150 Pts (₱15)";

            // btnNavTopUp
            this.btnNavTopUp.BackColor = SwevenColors.DarkPink;
            this.btnNavTopUp.FlatAppearance.BorderSize = 0;
            this.btnNavTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTopUp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavTopUp.ForeColor = System.Drawing.Color.White;
            this.btnNavTopUp.Location = new System.Drawing.Point(10, 175);
            this.btnNavTopUp.Name = "btnNavTopUp";
            this.btnNavTopUp.Size = new System.Drawing.Size(200, 42);
            this.btnNavTopUp.TabIndex = 2;
            this.btnNavTopUp.Text = "🎮 Top-Up & Buy";
            this.btnNavTopUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTopUp.UseVisualStyleBackColor = false;
            this.btnNavTopUp.Click += new System.EventHandler(this.BtnNavTopUp_Click);

            // btnNavHistory
            this.btnNavHistory.BackColor = SwevenColors.LightPink;
            this.btnNavHistory.FlatAppearance.BorderSize = 0;
            this.btnNavHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavHistory.ForeColor = SwevenColors.TextColor;
            this.btnNavHistory.Location = new System.Drawing.Point(10, 225);
            this.btnNavHistory.Name = "btnNavHistory";
            this.btnNavHistory.Size = new System.Drawing.Size(200, 42);
            this.btnNavHistory.TabIndex = 3;
            this.btnNavHistory.Text = "📜 My Order History";
            this.btnNavHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHistory.UseVisualStyleBackColor = false;
            this.btnNavHistory.Click += new System.EventHandler(this.BtnNavHistory_Click);

            // btnNavPerks
            this.btnNavPerks.BackColor = SwevenColors.LightPink;
            this.btnNavPerks.FlatAppearance.BorderSize = 0;
            this.btnNavPerks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPerks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavPerks.ForeColor = SwevenColors.TextColor;
            this.btnNavPerks.Location = new System.Drawing.Point(10, 275);
            this.btnNavPerks.Name = "btnNavPerks";
            this.btnNavPerks.Size = new System.Drawing.Size(200, 42);
            this.btnNavPerks.TabIndex = 4;
            this.btnNavPerks.Text = "🎁 Gamer Perks";
            this.btnNavPerks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPerks.UseVisualStyleBackColor = false;
            this.btnNavPerks.Click += new System.EventHandler(this.BtnNavPerks_Click);

            // btnLogout
            this.btnLogout.BackColor = SwevenColors.DarkPink;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 335);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 42);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblRole);
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1080, 65);
            this.pnlHeader.TabIndex = 1;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = SwevenColors.DarkPink;
            this.lblWelcome.Location = new System.Drawing.Point(20, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(260, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "🌸 Welcome, Maria Santos! ✨";

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRole.ForeColor = SwevenColors.TextGray;
            this.lblRole.Location = new System.Drawing.Point(22, 36);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(350, 15);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "🛍️ Customer Portal • Member ID: CUST-004 • Sweven\'s Market";

            // lblDateTime
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = SwevenColors.TextColor;
            this.lblDateTime.Location = new System.Drawing.Point(780, 18);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(240, 25);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "Oct 19, 2026  10:00:00 PM";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // btnClose
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = SwevenColors.DarkPink;
            this.btnClose.Location = new System.Drawing.Point(1035, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            // pnlContent
            this.pnlContent.BackColor = SwevenColors.CardBg;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1080, 685);
            this.pnlContent.TabIndex = 2;

            // CustomerDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.CardBg;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlCustomerProfile.ResumeLayout(false);
            this.pnlCustomerProfile.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private CuteCardPanel pnlCustomerProfile;
        private System.Windows.Forms.Label lblCustAvatar;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustTier;
        private System.Windows.Forms.Label lblCustPoints;
        private System.Windows.Forms.Button btnNavTopUp;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnNavPerks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlContent;
    }
}
