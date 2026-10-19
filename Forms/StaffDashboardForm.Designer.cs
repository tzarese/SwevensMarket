using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class StaffDashboardForm
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
            this.pnlStaffProfile = new CuteCardPanel();
            this.lblStaffAvatar = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffRole = new System.Windows.Forms.Label();
            this.lblStaffShift = new System.Windows.Forms.Label();
            this.btnNavHub = new System.Windows.Forms.Button();
            this.btnNavPayments = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavProducts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlHubView = new System.Windows.Forms.Panel();
            this.pnlCardPending = new CuteCardPanel();
            this.lblPendingVal = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.pnlCardProcessing = new CuteCardPanel();
            this.lblProcessingVal = new System.Windows.Forms.Label();
            this.lblProcessingTitle = new System.Windows.Forms.Label();
            this.pnlCardCompleted = new CuteCardPanel();
            this.lblCompletedVal = new System.Windows.Forms.Label();
            this.lblCompletedTitle = new System.Windows.Forms.Label();
            this.pnlCardProducts = new CuteCardPanel();
            this.lblProductsVal = new System.Windows.Forms.Label();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.lblTasksTitle = new System.Windows.Forms.Label();
            this.dgvStaffQueue = new System.Windows.Forms.DataGridView();

            this.pnlSidebar.SuspendLayout();
            this.pnlStaffProfile.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.pnlHubView.SuspendLayout();
            this.pnlCardPending.SuspendLayout();
            this.pnlCardProcessing.SuspendLayout();
            this.pnlCardCompleted.SuspendLayout();
            this.pnlCardProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffQueue)).BeginInit();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = SwevenColors.LightPink;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.pnlStaffProfile);
            this.pnlSidebar.Controls.Add(this.btnNavHub);
            this.pnlSidebar.Controls.Add(this.btnNavPayments);
            this.pnlSidebar.Controls.Add(this.btnNavOrders);
            this.pnlSidebar.Controls.Add(this.btnNavProducts);
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
            this.lblLogo.Text = "🎀 SWEVEN'S 🎀\nSTAFF PORTAL";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlStaffProfile
            this.pnlStaffProfile.BackColor = System.Drawing.Color.White;
            this.pnlStaffProfile.Controls.Add(this.lblStaffAvatar);
            this.pnlStaffProfile.Controls.Add(this.lblStaffName);
            this.pnlStaffProfile.Controls.Add(this.lblStaffRole);
            this.pnlStaffProfile.Controls.Add(this.lblStaffShift);
            this.pnlStaffProfile.Location = new System.Drawing.Point(12, 65);
            this.pnlStaffProfile.Name = "pnlStaffProfile";
            this.pnlStaffProfile.Padding = new System.Windows.Forms.Padding(8);
            this.pnlStaffProfile.Size = new System.Drawing.Size(196, 95);
            this.pnlStaffProfile.TabIndex = 1;

            // lblStaffAvatar
            this.lblStaffAvatar.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblStaffAvatar.Location = new System.Drawing.Point(8, 8);
            this.lblStaffAvatar.Name = "lblStaffAvatar";
            this.lblStaffAvatar.Size = new System.Drawing.Size(35, 35);
            this.lblStaffAvatar.TabIndex = 0;
            this.lblStaffAvatar.Text = "👔";
            this.lblStaffAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblStaffName
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStaffName.ForeColor = SwevenColors.TextColor;
            this.lblStaffName.Location = new System.Drawing.Point(45, 10);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(73, 17);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Store Staff";

            // lblStaffRole
            this.lblStaffRole.AutoSize = true;
            this.lblStaffRole.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblStaffRole.ForeColor = SwevenColors.DarkPink;
            this.lblStaffRole.Location = new System.Drawing.Point(45, 30);
            this.lblStaffRole.Name = "lblStaffRole";
            this.lblStaffRole.Size = new System.Drawing.Size(110, 13);
            this.lblStaffRole.TabIndex = 2;
            this.lblStaffRole.Text = "🛠️ Operations & Queue";

            // lblStaffShift
            this.lblStaffShift.AutoSize = true;
            this.lblStaffShift.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStaffShift.ForeColor = SwevenColors.TextGray;
            this.lblStaffShift.Location = new System.Drawing.Point(10, 68);
            this.lblStaffShift.Name = "lblStaffShift";
            this.lblStaffShift.Size = new System.Drawing.Size(130, 13);
            this.lblStaffShift.TabIndex = 3;
            this.lblStaffShift.Text = "🟢 Shift: Active (Duty A)";

            // btnNavHub
            this.btnNavHub.BackColor = SwevenColors.DarkPink;
            this.btnNavHub.FlatAppearance.BorderSize = 0;
            this.btnNavHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavHub.ForeColor = System.Drawing.Color.White;
            this.btnNavHub.Location = new System.Drawing.Point(10, 175);
            this.btnNavHub.Name = "btnNavHub";
            this.btnNavHub.Size = new System.Drawing.Size(200, 42);
            this.btnNavHub.TabIndex = 2;
            this.btnNavHub.Text = "📊 Staff Hub";
            this.btnNavHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHub.UseVisualStyleBackColor = false;
            this.btnNavHub.Click += new System.EventHandler(this.BtnNavHub_Click);

            // btnNavPayments
            this.btnNavPayments.BackColor = SwevenColors.LightPink;
            this.btnNavPayments.FlatAppearance.BorderSize = 0;
            this.btnNavPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPayments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavPayments.ForeColor = SwevenColors.TextColor;
            this.btnNavPayments.Location = new System.Drawing.Point(10, 225);
            this.btnNavPayments.Name = "btnNavPayments";
            this.btnNavPayments.Size = new System.Drawing.Size(200, 42);
            this.btnNavPayments.TabIndex = 3;
            this.btnNavPayments.Text = "💳 GCash Verification";
            this.btnNavPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPayments.UseVisualStyleBackColor = false;
            this.btnNavPayments.Click += new System.EventHandler(this.BtnNavPayments_Click);

            // btnNavOrders
            this.btnNavOrders.BackColor = SwevenColors.LightPink;
            this.btnNavOrders.FlatAppearance.BorderSize = 0;
            this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavOrders.ForeColor = SwevenColors.TextColor;
            this.btnNavOrders.Location = new System.Drawing.Point(10, 275);
            this.btnNavOrders.Name = "btnNavOrders";
            this.btnNavOrders.Size = new System.Drawing.Size(200, 42);
            this.btnNavOrders.TabIndex = 4;
            this.btnNavOrders.Text = "📦 Order Fulfillment";
            this.btnNavOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOrders.UseVisualStyleBackColor = false;
            this.btnNavOrders.Click += new System.EventHandler(this.BtnNavOrders_Click);

            // btnNavProducts
            this.btnNavProducts.BackColor = SwevenColors.LightPink;
            this.btnNavProducts.FlatAppearance.BorderSize = 0;
            this.btnNavProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavProducts.ForeColor = SwevenColors.TextColor;
            this.btnNavProducts.Location = new System.Drawing.Point(10, 325);
            this.btnNavProducts.Name = "btnNavProducts";
            this.btnNavProducts.Size = new System.Drawing.Size(200, 42);
            this.btnNavProducts.TabIndex = 5;
            this.btnNavProducts.Text = "🛍️ Product Catalog";
            this.btnNavProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProducts.UseVisualStyleBackColor = false;
            this.btnNavProducts.Click += new System.EventHandler(this.BtnNavProducts_Click);

            // btnLogout
            this.btnLogout.BackColor = SwevenColors.DarkPink;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 385);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 42);
            this.btnLogout.TabIndex = 6;
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
            this.lblWelcome.Size = new System.Drawing.Size(220, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "🌸 Welcome, Store Staff! ✨";

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRole.ForeColor = SwevenColors.TextGray;
            this.lblRole.Location = new System.Drawing.Point(22, 36);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(350, 15);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "🛠️ Store Operations & Fulfillment Portal • Sweven\'s Market";

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

            // pnlMainContainer
            this.pnlMainContainer.BackColor = SwevenColors.CardBg;
            this.pnlMainContainer.Controls.Add(this.pnlHubView);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(220, 65);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1080, 685);
            this.pnlMainContainer.TabIndex = 2;

            // pnlHubView
            this.pnlHubView.Controls.Add(this.pnlCardPending);
            this.pnlHubView.Controls.Add(this.pnlCardProcessing);
            this.pnlHubView.Controls.Add(this.pnlCardCompleted);
            this.pnlHubView.Controls.Add(this.pnlCardProducts);
            this.pnlHubView.Controls.Add(this.lblTasksTitle);
            this.pnlHubView.Controls.Add(this.dgvStaffQueue);
            this.pnlHubView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHubView.Location = new System.Drawing.Point(0, 0);
            this.pnlHubView.Name = "pnlHubView";
            this.pnlHubView.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHubView.Size = new System.Drawing.Size(1080, 685);
            this.pnlHubView.TabIndex = 0;

            // pnlCardPending
            this.pnlCardPending.BackColor = System.Drawing.Color.White;
            this.pnlCardPending.Controls.Add(this.lblPendingVal);
            this.pnlCardPending.Controls.Add(this.lblPendingTitle);
            this.pnlCardPending.Location = new System.Drawing.Point(20, 20);
            this.pnlCardPending.Name = "pnlCardPending";
            this.pnlCardPending.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCardPending.Size = new System.Drawing.Size(240, 100);
            this.pnlCardPending.TabIndex = 0;

            // lblPendingVal
            this.lblPendingVal.AutoSize = true;
            this.lblPendingVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPendingVal.ForeColor = CuteColors.CuteBanana;
            this.lblPendingVal.Location = new System.Drawing.Point(15, 45);
            this.lblPendingVal.Name = "lblPendingVal";
            this.lblPendingVal.Size = new System.Drawing.Size(28, 32);
            this.lblPendingVal.TabIndex = 1;
            this.lblPendingVal.Text = "3";

            // lblPendingTitle
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.ForeColor = SwevenColors.TextColor;
            this.lblPendingTitle.Location = new System.Drawing.Point(15, 15);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(162, 17);
            this.lblPendingTitle.TabIndex = 0;
            this.lblPendingTitle.Text = "⏳ Pending Verifications";

            // pnlCardProcessing
            this.pnlCardProcessing.BackColor = System.Drawing.Color.White;
            this.pnlCardProcessing.Controls.Add(this.lblProcessingVal);
            this.pnlCardProcessing.Controls.Add(this.lblProcessingTitle);
            this.pnlCardProcessing.Location = new System.Drawing.Point(280, 20);
            this.pnlCardProcessing.Name = "pnlCardProcessing";
            this.pnlCardProcessing.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCardProcessing.Size = new System.Drawing.Size(240, 100);
            this.pnlCardProcessing.TabIndex = 1;

            // lblProcessingVal
            this.lblProcessingVal.AutoSize = true;
            this.lblProcessingVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblProcessingVal.ForeColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.lblProcessingVal.Location = new System.Drawing.Point(15, 45);
            this.lblProcessingVal.Name = "lblProcessingVal";
            this.lblProcessingVal.Size = new System.Drawing.Size(28, 32);
            this.lblProcessingVal.TabIndex = 1;
            this.lblProcessingVal.Text = "2";

            // lblProcessingTitle
            this.lblProcessingTitle.AutoSize = true;
            this.lblProcessingTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProcessingTitle.ForeColor = SwevenColors.TextColor;
            this.lblProcessingTitle.Location = new System.Drawing.Point(15, 15);
            this.lblProcessingTitle.Name = "lblProcessingTitle";
            this.lblProcessingTitle.Size = new System.Drawing.Size(155, 17);
            this.lblProcessingTitle.TabIndex = 0;
            this.lblProcessingTitle.Text = "⚙ Deliveries to Fulfill";

            // pnlCardCompleted
            this.pnlCardCompleted.BackColor = System.Drawing.Color.White;
            this.pnlCardCompleted.Controls.Add(this.lblCompletedVal);
            this.pnlCardCompleted.Controls.Add(this.lblCompletedTitle);
            this.pnlCardCompleted.Location = new System.Drawing.Point(540, 20);
            this.pnlCardCompleted.Name = "pnlCardCompleted";
            this.pnlCardCompleted.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCardCompleted.Size = new System.Drawing.Size(240, 100);
            this.pnlCardCompleted.TabIndex = 2;

            // lblCompletedVal
            this.lblCompletedVal.AutoSize = true;
            this.lblCompletedVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCompletedVal.ForeColor = CuteColors.CuteMintGreen;
            this.lblCompletedVal.Location = new System.Drawing.Point(15, 45);
            this.lblCompletedVal.Name = "lblCompletedVal";
            this.lblCompletedVal.Size = new System.Drawing.Size(42, 32);
            this.lblCompletedVal.TabIndex = 1;
            this.lblCompletedVal.Text = "12";

            // lblCompletedTitle
            this.lblCompletedTitle.AutoSize = true;
            this.lblCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCompletedTitle.ForeColor = SwevenColors.TextColor;
            this.lblCompletedTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCompletedTitle.Name = "lblCompletedTitle";
            this.lblCompletedTitle.Size = new System.Drawing.Size(170, 17);
            this.lblCompletedTitle.TabIndex = 0;
            this.lblCompletedTitle.Text = "✔ Completed Deliveries";

            // pnlCardProducts
            this.pnlCardProducts.BackColor = System.Drawing.Color.White;
            this.pnlCardProducts.Controls.Add(this.lblProductsVal);
            this.pnlCardProducts.Controls.Add(this.lblProductsTitle);
            this.pnlCardProducts.Location = new System.Drawing.Point(800, 20);
            this.pnlCardProducts.Name = "pnlCardProducts";
            this.pnlCardProducts.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCardProducts.Size = new System.Drawing.Size(255, 100);
            this.pnlCardProducts.TabIndex = 3;

            // lblProductsVal
            this.lblProductsVal.AutoSize = true;
            this.lblProductsVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblProductsVal.ForeColor = SwevenColors.DarkPink;
            this.lblProductsVal.Location = new System.Drawing.Point(15, 45);
            this.lblProductsVal.Name = "lblProductsVal";
            this.lblProductsVal.Size = new System.Drawing.Size(42, 32);
            this.lblProductsVal.TabIndex = 1;
            this.lblProductsVal.Text = "31";

            // lblProductsTitle
            this.lblProductsTitle.AutoSize = true;
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProductsTitle.ForeColor = SwevenColors.TextColor;
            this.lblProductsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(155, 17);
            this.lblProductsTitle.TabIndex = 0;
            this.lblProductsTitle.Text = "🛍️ Total Active Items";

            // lblTasksTitle
            this.lblTasksTitle.AutoSize = true;
            this.lblTasksTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTasksTitle.ForeColor = SwevenColors.TextColor;
            this.lblTasksTitle.Location = new System.Drawing.Point(20, 140);
            this.lblTasksTitle.Name = "lblTasksTitle";
            this.lblTasksTitle.Size = new System.Drawing.Size(280, 20);
            this.lblTasksTitle.TabIndex = 4;
            this.lblTasksTitle.Text = "📋 Active Staff Operations Queue:";

            // dgvStaffQueue
            this.dgvStaffQueue.AllowUserToAddRows = false;
            this.dgvStaffQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffQueue.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaffQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaffQueue.Location = new System.Drawing.Point(20, 170);
            this.dgvStaffQueue.Name = "dgvStaffQueue";
            this.dgvStaffQueue.ReadOnly = true;
            this.dgvStaffQueue.RowHeadersVisible = false;
            this.dgvStaffQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffQueue.Size = new System.Drawing.Size(1035, 480);
            this.dgvStaffQueue.TabIndex = 5;

            // StaffDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.CardBg;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Operations Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlStaffProfile.ResumeLayout(false);
            this.pnlStaffProfile.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlHubView.ResumeLayout(false);
            this.pnlHubView.PerformLayout();
            this.pnlCardPending.ResumeLayout(false);
            this.pnlCardPending.PerformLayout();
            this.pnlCardProcessing.ResumeLayout(false);
            this.pnlCardProcessing.PerformLayout();
            this.pnlCardCompleted.ResumeLayout(false);
            this.pnlCardCompleted.PerformLayout();
            this.pnlCardProducts.ResumeLayout(false);
            this.pnlCardProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffQueue)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private CuteCardPanel pnlStaffProfile;
        private System.Windows.Forms.Label lblStaffAvatar;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffRole;
        private System.Windows.Forms.Label lblStaffShift;
        private System.Windows.Forms.Button btnNavHub;
        private System.Windows.Forms.Button btnNavPayments;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlHubView;
        private CuteCardPanel pnlCardPending;
        private System.Windows.Forms.Label lblPendingVal;
        private System.Windows.Forms.Label lblPendingTitle;
        private CuteCardPanel pnlCardProcessing;
        private System.Windows.Forms.Label lblProcessingVal;
        private System.Windows.Forms.Label lblProcessingTitle;
        private CuteCardPanel pnlCardCompleted;
        private System.Windows.Forms.Label lblCompletedVal;
        private System.Windows.Forms.Label lblCompletedTitle;
        private CuteCardPanel pnlCardProducts;
        private System.Windows.Forms.Label lblProductsVal;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Label lblTasksTitle;
        private System.Windows.Forms.DataGridView dgvStaffQueue;
    }
}
