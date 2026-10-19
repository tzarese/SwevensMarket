using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class AdminDashboardForm
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
            btnNavDashboard = new Button();
            btnNavProducts = new Button();
            btnNavOrders = new Button();
            btnNavPayments = new Button();
            btnNavUsers = new Button();
            btnNavReports = new Button();
            btnLogout = new Button();
            lblSidebarMascot = new Label();
            pnlHeader = new Panel();
            lblWelcome = new Label();
            lblRole = new Label();
            lblDateTime = new Label();
            btnClose = new Button();
            pnlMainContainer = new Panel();
            pnlDashboardView = new Panel();
            pnlCardSales = new CuteCardPanel();
            lblSalesVal = new Label();
            lblSalesTitle = new Label();
            pnlCardOrders = new CuteCardPanel();
            lblOrdersVal = new Label();
            lblOrdersTitle = new Label();
            pnlCardPending = new CuteCardPanel();
            lblPendingVal = new Label();
            lblPendingTitle = new Label();
            pnlCardCompleted = new CuteCardPanel();
            lblCompletedVal = new Label();
            lblCompletedTitle = new Label();
            lblRecent = new Label();
            dgvRecentOrders = new DataGridView();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlMainContainer.SuspendLayout();
            pnlDashboardView.SuspendLayout();
            pnlCardSales.SuspendLayout();
            pnlCardOrders.SuspendLayout();
            pnlCardPending.SuspendLayout();
            pnlCardCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(253, 226, 228);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(btnNavProducts);
            pnlSidebar.Controls.Add(btnNavOrders);
            pnlSidebar.Controls.Add(btnNavPayments);
            pnlSidebar.Controls.Add(btnNavUsers);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(lblSidebarMascot);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(251, 960);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Font = new Font("Georgia", 13F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(255, 77, 141);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(251, 113);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🎀 SWEVEN'S 🎀\nMARKET";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.BackColor = Color.White;
            btnNavDashboard.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavDashboard.ForeColor = Color.FromArgb(94, 33, 69);
            btnNavDashboard.Location = new Point(14, 127);
            btnNavDashboard.Margin = new Padding(3, 4, 3, 4);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(223, 56);
            btnNavDashboard.TabIndex = 1;
            btnNavDashboard.Text = "📊 Dashboard";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.UseVisualStyleBackColor = false;
            btnNavDashboard.Click += BtnNavDashboard_Click;
            // 
            // btnNavProducts
            // 
            btnNavProducts.BackColor = Color.FromArgb(253, 226, 228);
            btnNavProducts.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnNavProducts.FlatStyle = FlatStyle.Flat;
            btnNavProducts.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavProducts.ForeColor = Color.FromArgb(94, 33, 69);
            btnNavProducts.Location = new Point(14, 193);
            btnNavProducts.Margin = new Padding(3, 4, 3, 4);
            btnNavProducts.Name = "btnNavProducts";
            btnNavProducts.Size = new Size(223, 56);
            btnNavProducts.TabIndex = 2;
            btnNavProducts.Text = "🛍️ Products";
            btnNavProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnNavProducts.UseVisualStyleBackColor = false;
            btnNavProducts.Click += BtnNavProducts_Click;
            // 
            // btnNavOrders
            // 
            btnNavOrders.BackColor = Color.FromArgb(253, 226, 228);
            btnNavOrders.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnNavOrders.FlatStyle = FlatStyle.Flat;
            btnNavOrders.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavOrders.ForeColor = Color.FromArgb(94, 33, 69);
            btnNavOrders.Location = new Point(14, 260);
            btnNavOrders.Margin = new Padding(3, 4, 3, 4);
            btnNavOrders.Name = "btnNavOrders";
            btnNavOrders.Size = new Size(223, 56);
            btnNavOrders.TabIndex = 3;
            btnNavOrders.Text = "📦 Orders";
            btnNavOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnNavOrders.UseVisualStyleBackColor = false;
            btnNavOrders.Click += BtnNavOrders_Click;
            // 
            // btnNavPayments
            // 
            btnNavPayments.BackColor = Color.FromArgb(253, 226, 228);
            btnNavPayments.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnNavPayments.FlatStyle = FlatStyle.Flat;
            btnNavPayments.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavPayments.ForeColor = Color.FromArgb(94, 33, 69);
            btnNavPayments.Location = new Point(14, 327);
            btnNavPayments.Margin = new Padding(3, 4, 3, 4);
            btnNavPayments.Name = "btnNavPayments";
            btnNavPayments.Size = new Size(223, 56);
            btnNavPayments.TabIndex = 4;
            btnNavPayments.Text = "💳 GCash Verification";
            btnNavPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnNavPayments.UseVisualStyleBackColor = false;
            btnNavPayments.Click += BtnNavPayments_Click;
            // 
            // btnNavUsers
            // 
            btnNavUsers.BackColor = Color.FromArgb(253, 226, 228);
            btnNavUsers.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnNavUsers.FlatStyle = FlatStyle.Flat;
            btnNavUsers.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavUsers.ForeColor = Color.FromArgb(94, 33, 69);
            btnNavUsers.Location = new Point(14, 393);
            btnNavUsers.Margin = new Padding(3, 4, 3, 4);
            btnNavUsers.Name = "btnNavUsers";
            btnNavUsers.Size = new Size(223, 56);
            btnNavUsers.TabIndex = 5;
            btnNavUsers.Text = "👥 Users";
            btnNavUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnNavUsers.UseVisualStyleBackColor = false;
            btnNavUsers.Click += BtnNavUsers_Click;
            // 
            // btnNavReports
            // 
            btnNavReports.BackColor = Color.FromArgb(253, 226, 228);
            btnNavReports.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnNavReports.FlatStyle = FlatStyle.Flat;
            btnNavReports.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavReports.ForeColor = Color.FromArgb(94, 33, 69);
            btnNavReports.Location = new Point(14, 460);
            btnNavReports.Margin = new Padding(3, 4, 3, 4);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Size = new Size(223, 56);
            btnNavReports.TabIndex = 6;
            btnNavReports.Text = "📈 Reports";
            btnNavReports.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReports.UseVisualStyleBackColor = false;
            btnNavReports.Click += BtnNavReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 77, 141);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(14, 560);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(223, 56);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "🚪 Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // lblSidebarMascot
            // 
            lblSidebarMascot.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSidebarMascot.ForeColor = Color.FromArgb(158, 88, 127);
            lblSidebarMascot.Location = new Point(14, 840);
            lblSidebarMascot.Name = "lblSidebarMascot";
            lblSidebarMascot.Size = new Size(223, 80);
            lblSidebarMascot.TabIndex = 8;
            lblSidebarMascot.Text = "🎀 ✨ 🐾 💕 🌸\nSweven's Gaming System";
            lblSidebarMascot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblRole);
            pnlHeader.Controls.Add(lblDateTime);
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
            lblWelcome.ForeColor = Color.FromArgb(255, 77, 141);
            lblWelcome.Location = new Point(23, 16);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(185, 28);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin! ";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F);
            lblRole.ForeColor = Color.FromArgb(158, 88, 127);
            lblRole.Location = new Point(25, 48);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(290, 20);
            lblRole.TabIndex = 1;
            lblRole.Text = "👑 Administrator Portal • Sweven's Market";
            // 
            // lblDateTime
            // 
            lblDateTime.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDateTime.ForeColor = Color.FromArgb(94, 33, 69);
            lblDateTime.Location = new Point(869, 27);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(274, 33);
            lblDateTime.TabIndex = 2;
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(255, 77, 141);
            btnClose.Location = new Point(1154, 20);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 47);
            btnClose.TabIndex = 3;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.BackColor = Color.FromArgb(255, 240, 245);
            pnlMainContainer.Controls.Add(pnlDashboardView);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(251, 87);
            pnlMainContainer.Margin = new Padding(3, 4, 3, 4);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Size = new Size(1212, 873);
            pnlMainContainer.TabIndex = 2;
            // 
            // pnlDashboardView
            // 
            pnlDashboardView.BackColor = Color.FromArgb(255, 240, 245);
            pnlDashboardView.Controls.Add(pnlCardSales);
            pnlDashboardView.Controls.Add(pnlCardOrders);
            pnlDashboardView.Controls.Add(pnlCardPending);
            pnlDashboardView.Controls.Add(pnlCardCompleted);
            pnlDashboardView.Controls.Add(lblRecent);
            pnlDashboardView.Controls.Add(dgvRecentOrders);
            pnlDashboardView.Dock = DockStyle.Fill;
            pnlDashboardView.Location = new Point(0, 0);
            pnlDashboardView.Margin = new Padding(3, 4, 3, 4);
            pnlDashboardView.Name = "pnlDashboardView";
            pnlDashboardView.Padding = new Padding(23, 27, 23, 27);
            pnlDashboardView.Size = new Size(1212, 873);
            pnlDashboardView.TabIndex = 0;
            // 
            // pnlCardSales
            // 
            pnlCardSales.BackColor = Color.White;
            pnlCardSales.Controls.Add(lblSalesVal);
            pnlCardSales.Controls.Add(lblSalesTitle);
            pnlCardSales.Location = new Point(23, 20);
            pnlCardSales.Margin = new Padding(3, 4, 3, 4);
            pnlCardSales.Name = "pnlCardSales";
            pnlCardSales.Padding = new Padding(17, 20, 17, 20);
            pnlCardSales.Size = new Size(274, 127);
            pnlCardSales.TabIndex = 0;
            // 
            // lblSalesVal
            // 
            lblSalesVal.AutoSize = true;
            lblSalesVal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSalesVal.ForeColor = Color.FromArgb(255, 77, 141);
            lblSalesVal.Location = new Point(16, 45);
            lblSalesVal.Name = "lblSalesVal";
            lblSalesVal.Size = new Size(143, 35);
            lblSalesVal.TabIndex = 1;
            lblSalesVal.Text = "₱25,450.00";
            // 
            // lblSalesTitle
            // 
            lblSalesTitle.AutoSize = true;
            lblSalesTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSalesTitle.ForeColor = Color.FromArgb(158, 88, 127);
            lblSalesTitle.Location = new Point(18, 16);
            lblSalesTitle.Name = "lblSalesTitle";
            lblSalesTitle.Size = new Size(109, 20);
            lblSalesTitle.TabIndex = 0;
            lblSalesTitle.Text = "💖 Total Sales";
            // 
            // pnlCardOrders
            // 
            pnlCardOrders.BackColor = Color.White;
            pnlCardOrders.Controls.Add(lblOrdersVal);
            pnlCardOrders.Controls.Add(lblOrdersTitle);
            pnlCardOrders.Location = new Point(314, 20);
            pnlCardOrders.Margin = new Padding(3, 4, 3, 4);
            pnlCardOrders.Name = "pnlCardOrders";
            pnlCardOrders.Padding = new Padding(17, 20, 17, 20);
            pnlCardOrders.Size = new Size(274, 127);
            pnlCardOrders.TabIndex = 1;
            // 
            // lblOrdersVal
            // 
            lblOrdersVal.AutoSize = true;
            lblOrdersVal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblOrdersVal.ForeColor = Color.FromArgb(94, 33, 69);
            lblOrdersVal.Location = new Point(16, 45);
            lblOrdersVal.Name = "lblOrdersVal";
            lblOrdersVal.Size = new Size(57, 35);
            lblOrdersVal.TabIndex = 1;
            lblOrdersVal.Text = "156";
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.AutoSize = true;
            lblOrdersTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrdersTitle.ForeColor = Color.FromArgb(158, 88, 127);
            lblOrdersTitle.Location = new Point(18, 16);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(121, 20);
            lblOrdersTitle.TabIndex = 0;
            lblOrdersTitle.Text = "🛍️ Total Orders";
            // 
            // pnlCardPending
            // 
            pnlCardPending.BackColor = Color.White;
            pnlCardPending.Controls.Add(lblPendingVal);
            pnlCardPending.Controls.Add(lblPendingTitle);
            pnlCardPending.Location = new Point(606, 20);
            pnlCardPending.Margin = new Padding(3, 4, 3, 4);
            pnlCardPending.Name = "pnlCardPending";
            pnlCardPending.Padding = new Padding(17, 20, 17, 20);
            pnlCardPending.Size = new Size(274, 127);
            pnlCardPending.TabIndex = 2;
            // 
            // lblPendingVal
            // 
            lblPendingVal.AutoSize = true;
            lblPendingVal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblPendingVal.ForeColor = Color.FromArgb(255, 183, 3);
            lblPendingVal.Location = new Point(16, 45);
            lblPendingVal.Name = "lblPendingVal";
            lblPendingVal.Size = new Size(43, 35);
            lblPendingVal.TabIndex = 1;
            lblPendingVal.Text = "28";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPendingTitle.ForeColor = Color.FromArgb(158, 88, 127);
            lblPendingTitle.Location = new Point(18, 16);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(143, 20);
            lblPendingTitle.TabIndex = 0;
            lblPendingTitle.Text = "⏳ Pending Orders";
            // 
            // pnlCardCompleted
            // 
            pnlCardCompleted.BackColor = Color.White;
            pnlCardCompleted.Controls.Add(lblCompletedVal);
            pnlCardCompleted.Controls.Add(lblCompletedTitle);
            pnlCardCompleted.Location = new Point(897, 20);
            pnlCardCompleted.Margin = new Padding(3, 4, 3, 4);
            pnlCardCompleted.Name = "pnlCardCompleted";
            pnlCardCompleted.Padding = new Padding(17, 20, 17, 20);
            pnlCardCompleted.Size = new Size(274, 127);
            pnlCardCompleted.TabIndex = 3;
            // 
            // lblCompletedVal
            // 
            lblCompletedVal.AutoSize = true;
            lblCompletedVal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCompletedVal.ForeColor = Color.FromArgb(56, 176, 0);
            lblCompletedVal.Location = new Point(16, 45);
            lblCompletedVal.Name = "lblCompletedVal";
            lblCompletedVal.Size = new Size(57, 35);
            lblCompletedVal.TabIndex = 1;
            lblCompletedVal.Text = "118";
            // 
            // lblCompletedTitle
            // 
            lblCompletedTitle.AutoSize = true;
            lblCompletedTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCompletedTitle.ForeColor = Color.FromArgb(158, 88, 127);
            lblCompletedTitle.Location = new Point(18, 16);
            lblCompletedTitle.Name = "lblCompletedTitle";
            lblCompletedTitle.Size = new Size(162, 20);
            lblCompletedTitle.TabIndex = 0;
            lblCompletedTitle.Text = "🎉 Completed Orders";
            // 
            // lblRecent
            // 
            lblRecent.AutoSize = true;
            lblRecent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecent.ForeColor = Color.FromArgb(94, 33, 69);
            lblRecent.Location = new Point(23, 173);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(238, 28);
            lblRecent.TabIndex = 4;
            lblRecent.Text = "Recent Orders & Activity ";
            // 
            // dgvRecentOrders
            // 
            dgvRecentOrders.AllowUserToAddRows = false;
            dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentOrders.BackgroundColor = Color.White;
            dgvRecentOrders.BorderStyle = BorderStyle.None;
            dgvRecentOrders.ColumnHeadersHeight = 29;
            dgvRecentOrders.Location = new Point(23, 213);
            dgvRecentOrders.Margin = new Padding(3, 4, 3, 4);
            dgvRecentOrders.Name = "dgvRecentOrders";
            dgvRecentOrders.ReadOnly = true;
            dgvRecentOrders.RowHeadersVisible = false;
            dgvRecentOrders.RowHeadersWidth = 51;
            dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentOrders.Size = new Size(1149, 620);
            dgvRecentOrders.TabIndex = 5;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 240, 245);
            ClientSize = new Size(1463, 960);
            Controls.Add(pnlMainContainer);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sweven's Market - Admin Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMainContainer.ResumeLayout(false);
            pnlDashboardView.ResumeLayout(false);
            pnlDashboardView.PerformLayout();
            pnlCardSales.ResumeLayout(false);
            pnlCardSales.PerformLayout();
            pnlCardOrders.ResumeLayout(false);
            pnlCardOrders.PerformLayout();
            pnlCardPending.ResumeLayout(false);
            pnlCardPending.PerformLayout();
            pnlCardCompleted.ResumeLayout(false);
            pnlCardCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavPayments;
        private System.Windows.Forms.Button btnNavUsers;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSidebarMascot;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlDashboardView;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private SwevensMarket.Theme.CuteCardPanel pnlCardSales;
        private System.Windows.Forms.Label lblSalesVal;
        private System.Windows.Forms.Label lblSalesTitle;
        private SwevensMarket.Theme.CuteCardPanel pnlCardOrders;
        private System.Windows.Forms.Label lblOrdersVal;
        private System.Windows.Forms.Label lblOrdersTitle;
        private SwevensMarket.Theme.CuteCardPanel pnlCardPending;
        private System.Windows.Forms.Label lblPendingVal;
        private System.Windows.Forms.Label lblPendingTitle;
        private SwevensMarket.Theme.CuteCardPanel pnlCardCompleted;
        private System.Windows.Forms.Label lblCompletedVal;
        private System.Windows.Forms.Label lblCompletedTitle;
        private System.Windows.Forms.Timer clockTimer;
    }
}
