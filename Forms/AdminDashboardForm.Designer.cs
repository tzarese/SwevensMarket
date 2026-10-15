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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavProducts = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavPayments = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlDashboardView = new System.Windows.Forms.Panel();
            this.lblRecent = new System.Windows.Forms.Label();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.pnlCardSales = new System.Windows.Forms.Panel();
            this.lblSalesVal = new System.Windows.Forms.Label();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.pnlCardOrders = new System.Windows.Forms.Panel();
            this.lblOrdersVal = new System.Windows.Forms.Label();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.pnlCardPending = new System.Windows.Forms.Panel();
            this.lblPendingVal = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.pnlCardCompleted = new System.Windows.Forms.Panel();
            this.lblCompletedVal = new System.Windows.Forms.Label();
            this.lblCompletedTitle = new System.Windows.Forms.Label();

            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.pnlDashboardView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.pnlCardSales.SuspendLayout();
            this.pnlCardOrders.SuspendLayout();
            this.pnlCardPending.SuspendLayout();
            this.pnlCardCompleted.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = SwevenColors.MainPink;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavProducts);
            this.pnlSidebar.Controls.Add(this.btnNavOrders);
            this.pnlSidebar.Controls.Add(this.btnNavPayments);
            this.pnlSidebar.Controls.Add(this.btnNavUsers);
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(210, 720);
            this.pnlSidebar.TabIndex = 0;

            // lblLogo
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = SwevenColors.DarkPink;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(210, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🎀 SWEVEN\'S 🎀\nMARKET";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnNavDashboard
            this.btnNavDashboard.BackColor = SwevenColors.MainPink;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.ForeColor = SwevenColors.TextColor;
            this.btnNavDashboard.Location = new System.Drawing.Point(10, 90);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(190, 40);
            this.btnNavDashboard.TabIndex = 1;
            this.btnNavDashboard.Text = "📊 Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.BtnNavDashboard_Click);

            // btnNavProducts
            this.btnNavProducts.BackColor = SwevenColors.MainPink;
            this.btnNavProducts.FlatAppearance.BorderSize = 0;
            this.btnNavProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProducts.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavProducts.ForeColor = SwevenColors.TextColor;
            this.btnNavProducts.Location = new System.Drawing.Point(10, 136);
            this.btnNavProducts.Name = "btnNavProducts";
            this.btnNavProducts.Size = new System.Drawing.Size(190, 40);
            this.btnNavProducts.TabIndex = 2;
            this.btnNavProducts.Text = "🛍️ Products";
            this.btnNavProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProducts.UseVisualStyleBackColor = false;
            this.btnNavProducts.Click += new System.EventHandler(this.BtnNavProducts_Click);

            // btnNavOrders
            this.btnNavOrders.BackColor = SwevenColors.MainPink;
            this.btnNavOrders.FlatAppearance.BorderSize = 0;
            this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrders.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavOrders.ForeColor = SwevenColors.TextColor;
            this.btnNavOrders.Location = new System.Drawing.Point(10, 182);
            this.btnNavOrders.Name = "btnNavOrders";
            this.btnNavOrders.Size = new System.Drawing.Size(190, 40);
            this.btnNavOrders.TabIndex = 3;
            this.btnNavOrders.Text = "📦 Orders";
            this.btnNavOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOrders.UseVisualStyleBackColor = false;
            this.btnNavOrders.Click += new System.EventHandler(this.BtnNavOrders_Click);

            // btnNavPayments
            this.btnNavPayments.BackColor = SwevenColors.MainPink;
            this.btnNavPayments.FlatAppearance.BorderSize = 0;
            this.btnNavPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPayments.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavPayments.ForeColor = SwevenColors.TextColor;
            this.btnNavPayments.Location = new System.Drawing.Point(10, 228);
            this.btnNavPayments.Name = "btnNavPayments";
            this.btnNavPayments.Size = new System.Drawing.Size(190, 40);
            this.btnNavPayments.TabIndex = 4;
            this.btnNavPayments.Text = "💳 GCash Verification";
            this.btnNavPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPayments.UseVisualStyleBackColor = false;
            this.btnNavPayments.Click += new System.EventHandler(this.BtnNavPayments_Click);

            // btnNavUsers
            this.btnNavUsers.BackColor = SwevenColors.MainPink;
            this.btnNavUsers.FlatAppearance.BorderSize = 0;
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavUsers.ForeColor = SwevenColors.TextColor;
            this.btnNavUsers.Location = new System.Drawing.Point(10, 274);
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavUsers.Size = new System.Drawing.Size(190, 40);
            this.btnNavUsers.TabIndex = 5;
            this.btnNavUsers.Text = "👥 Users";
            this.btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUsers.UseVisualStyleBackColor = false;
            this.btnNavUsers.Click += new System.EventHandler(this.BtnNavUsers_Click);

            // btnNavReports
            this.btnNavReports.BackColor = SwevenColors.MainPink;
            this.btnNavReports.FlatAppearance.BorderSize = 0;
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavReports.ForeColor = SwevenColors.TextColor;
            this.btnNavReports.Location = new System.Drawing.Point(10, 320);
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.Size = new System.Drawing.Size(190, 40);
            this.btnNavReports.TabIndex = 6;
            this.btnNavReports.Text = "📈 Reports";
            this.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.UseVisualStyleBackColor = false;
            this.btnNavReports.Click += new System.EventHandler(this.BtnNavReports_Click);

            // btnLogout
            this.btnLogout.BackColor = SwevenColors.MainPink;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = SwevenColors.TextColor;
            this.btnLogout.Location = new System.Drawing.Point(10, 390);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 40);
            this.btnLogout.TabIndex = 7;
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
            this.pnlHeader.Location = new System.Drawing.Point(210, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1070, 65);
            this.pnlHeader.TabIndex = 1;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = SwevenColors.TextColor;
            this.lblWelcome.Location = new System.Drawing.Point(20, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(139, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin!";

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRole.ForeColor = SwevenColors.DarkPink;
            this.lblRole.Location = new System.Drawing.Point(21, 36);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(70, 15);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role: Admin";

            // lblDateTime
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateTime.ForeColor = SwevenColors.TextGray;
            this.lblDateTime.Location = new System.Drawing.Point(780, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(220, 25);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // btnClose
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = SwevenColors.DarkPink;
            this.btnClose.Location = new System.Drawing.Point(1020, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            // pnlMainContainer
            this.pnlMainContainer.BackColor = SwevenColors.LightPink;
            this.pnlMainContainer.Controls.Add(this.pnlDashboardView);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(210, 65);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1070, 655);
            this.pnlMainContainer.TabIndex = 2;

            // pnlDashboardView
            this.pnlDashboardView.BackColor = SwevenColors.LightPink;
            this.pnlDashboardView.Controls.Add(this.pnlCardSales);
            this.pnlDashboardView.Controls.Add(this.pnlCardOrders);
            this.pnlDashboardView.Controls.Add(this.pnlCardPending);
            this.pnlDashboardView.Controls.Add(this.pnlCardCompleted);
            this.pnlDashboardView.Controls.Add(this.lblRecent);
            this.pnlDashboardView.Controls.Add(this.dgvRecentOrders);
            this.pnlDashboardView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardView.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardView.Name = "pnlDashboardView";
            this.pnlDashboardView.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDashboardView.Size = new System.Drawing.Size(1070, 655);
            this.pnlDashboardView.TabIndex = 0;

            // pnlCardSales
            this.pnlCardSales.BackColor = System.Drawing.Color.White;
            this.pnlCardSales.Controls.Add(this.lblSalesVal);
            this.pnlCardSales.Controls.Add(this.lblSalesTitle);
            this.pnlCardSales.Location = new System.Drawing.Point(20, 20);
            this.pnlCardSales.Name = "pnlCardSales";
            this.pnlCardSales.Size = new System.Drawing.Size(240, 95);
            this.pnlCardSales.TabIndex = 0;

            // lblSalesTitle
            this.lblSalesTitle.AutoSize = true;
            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalesTitle.ForeColor = SwevenColors.TextGray;
            this.lblSalesTitle.Location = new System.Drawing.Point(16, 12);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(65, 15);
            this.lblSalesTitle.TabIndex = 0;
            this.lblSalesTitle.Text = "Total Sales";

            // lblSalesVal
            this.lblSalesVal.AutoSize = true;
            this.lblSalesVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblSalesVal.ForeColor = SwevenColors.TextColor;
            this.lblSalesVal.Location = new System.Drawing.Point(14, 32);
            this.lblSalesVal.Name = "lblSalesVal";
            this.lblSalesVal.Size = new System.Drawing.Size(117, 28);
            this.lblSalesVal.TabIndex = 1;
            this.lblSalesVal.Text = "₱25,450.00";

            // pnlCardOrders
            this.pnlCardOrders.BackColor = System.Drawing.Color.White;
            this.pnlCardOrders.Controls.Add(this.lblOrdersVal);
            this.pnlCardOrders.Controls.Add(this.lblOrdersTitle);
            this.pnlCardOrders.Location = new System.Drawing.Point(275, 20);
            this.pnlCardOrders.Name = "pnlCardOrders";
            this.pnlCardOrders.Size = new System.Drawing.Size(240, 95);
            this.pnlCardOrders.TabIndex = 1;

            // lblOrdersTitle
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrdersTitle.ForeColor = SwevenColors.TextGray;
            this.lblOrdersTitle.Location = new System.Drawing.Point(16, 12);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(73, 15);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "Total Orders";

            // lblOrdersVal
            this.lblOrdersVal.AutoSize = true;
            this.lblOrdersVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblOrdersVal.ForeColor = SwevenColors.TextColor;
            this.lblOrdersVal.Location = new System.Drawing.Point(14, 32);
            this.lblOrdersVal.Name = "lblOrdersVal";
            this.lblOrdersVal.Size = new System.Drawing.Size(48, 28);
            this.lblOrdersVal.TabIndex = 1;
            this.lblOrdersVal.Text = "156";

            // pnlCardPending
            this.pnlCardPending.BackColor = System.Drawing.Color.White;
            this.pnlCardPending.Controls.Add(this.lblPendingVal);
            this.pnlCardPending.Controls.Add(this.lblPendingTitle);
            this.pnlCardPending.Location = new System.Drawing.Point(530, 20);
            this.pnlCardPending.Name = "pnlCardPending";
            this.pnlCardPending.Size = new System.Drawing.Size(240, 95);
            this.pnlCardPending.TabIndex = 2;

            // lblPendingTitle
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.ForeColor = SwevenColors.TextGray;
            this.lblPendingTitle.Location = new System.Drawing.Point(16, 12);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(52, 15);
            this.lblPendingTitle.TabIndex = 0;
            this.lblPendingTitle.Text = "Pending";

            // lblPendingVal
            this.lblPendingVal.AutoSize = true;
            this.lblPendingVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblPendingVal.ForeColor = SwevenColors.TextColor;
            this.lblPendingVal.Location = new System.Drawing.Point(14, 32);
            this.lblPendingVal.Name = "lblPendingVal";
            this.lblPendingVal.Size = new System.Drawing.Size(36, 28);
            this.lblPendingVal.TabIndex = 1;
            this.lblPendingVal.Text = "28";

            // pnlCardCompleted
            this.pnlCardCompleted.BackColor = System.Drawing.Color.White;
            this.pnlCardCompleted.Controls.Add(this.lblCompletedVal);
            this.pnlCardCompleted.Controls.Add(this.lblCompletedTitle);
            this.pnlCardCompleted.Location = new System.Drawing.Point(785, 20);
            this.pnlCardCompleted.Name = "pnlCardCompleted";
            this.pnlCardCompleted.Size = new System.Drawing.Size(240, 95);
            this.pnlCardCompleted.TabIndex = 3;

            // lblCompletedTitle
            this.lblCompletedTitle.AutoSize = true;
            this.lblCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCompletedTitle.ForeColor = SwevenColors.TextGray;
            this.lblCompletedTitle.Location = new System.Drawing.Point(16, 12);
            this.lblCompletedTitle.Name = "lblCompletedTitle";
            this.lblCompletedTitle.Size = new System.Drawing.Size(68, 15);
            this.lblCompletedTitle.TabIndex = 0;
            this.lblCompletedTitle.Text = "Completed";

            // lblCompletedVal
            this.lblCompletedVal.AutoSize = true;
            this.lblCompletedVal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblCompletedVal.ForeColor = SwevenColors.TextColor;
            this.lblCompletedVal.Location = new System.Drawing.Point(14, 32);
            this.lblCompletedVal.Name = "lblCompletedVal";
            this.lblCompletedVal.Size = new System.Drawing.Size(48, 28);
            this.lblCompletedVal.TabIndex = 1;
            this.lblCompletedVal.Text = "118";

            // lblRecent
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecent.ForeColor = SwevenColors.TextColor;
            this.lblRecent.Location = new System.Drawing.Point(20, 140);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(189, 21);
            this.lblRecent.TabIndex = 4;
            this.lblRecent.Text = "Recent Orders & Status";

            // dgvRecentOrders
            this.dgvRecentOrders.AllowUserToAddRows = false;
            this.dgvRecentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentOrders.Location = new System.Drawing.Point(20, 175);
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.ReadOnly = true;
            this.dgvRecentOrders.RowHeadersVisible = false;
            this.dgvRecentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentOrders.Size = new System.Drawing.Size(1015, 440);
            this.dgvRecentOrders.TabIndex = 5;

            // AdminDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sweven\'s Market - Admin Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlDashboardView.ResumeLayout(false);
            this.pnlDashboardView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.pnlCardSales.ResumeLayout(false);
            this.pnlCardSales.PerformLayout();
            this.pnlCardOrders.ResumeLayout(false);
            this.pnlCardOrders.PerformLayout();
            this.pnlCardPending.ResumeLayout(false);
            this.pnlCardPending.PerformLayout();
            this.pnlCardCompleted.ResumeLayout(false);
            this.pnlCardCompleted.PerformLayout();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlDashboardView;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.Panel pnlCardSales;
        private System.Windows.Forms.Label lblSalesVal;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.Panel pnlCardOrders;
        private System.Windows.Forms.Label lblOrdersVal;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Panel pnlCardPending;
        private System.Windows.Forms.Label lblPendingVal;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Panel pnlCardCompleted;
        private System.Windows.Forms.Label lblCompletedVal;
        private System.Windows.Forms.Label lblCompletedTitle;
        private System.Windows.Forms.Timer clockTimer;
    }
}
