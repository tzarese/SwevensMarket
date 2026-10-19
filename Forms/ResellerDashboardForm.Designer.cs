using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class ResellerDashboardForm
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
            this.pnlResellerProfile = new CuteCardPanel();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTier = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnNavHub = new System.Windows.Forms.Button();
            this.btnNavBulkOrder = new System.Windows.Forms.Button();
            this.btnNavHistory = new System.Windows.Forms.Button();
            this.btnNavMargin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlHubView = new System.Windows.Forms.Panel();
            this.pnlCardWallet = new CuteCardPanel();
            this.lblWalletVal = new System.Windows.Forms.Label();
            this.lblWalletTitle = new System.Windows.Forms.Label();
            this.pnlCardDiscount = new CuteCardPanel();
            this.lblDiscountVal = new System.Windows.Forms.Label();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.pnlCardOrders = new CuteCardPanel();
            this.lblOrdersVal = new System.Windows.Forms.Label();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.pnlCardMargin = new CuteCardPanel();
            this.lblMarginVal = new System.Windows.Forms.Label();
            this.lblMarginTitle = new System.Windows.Forms.Label();
            this.lblWholesaleTitle = new System.Windows.Forms.Label();
            this.dgvResellerOrders = new System.Windows.Forms.DataGridView();

            this.pnlSidebar.SuspendLayout();
            this.pnlResellerProfile.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.pnlHubView.SuspendLayout();
            this.pnlCardWallet.SuspendLayout();
            this.pnlCardDiscount.SuspendLayout();
            this.pnlCardOrders.SuspendLayout();
            this.pnlCardMargin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResellerOrders)).BeginInit();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = SwevenColors.LightPink;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.pnlResellerProfile);
            this.pnlSidebar.Controls.Add(this.btnNavHub);
            this.pnlSidebar.Controls.Add(this.btnNavBulkOrder);
            this.pnlSidebar.Controls.Add(this.btnNavHistory);
            this.pnlSidebar.Controls.Add(this.btnNavMargin);
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
            this.lblLogo.Text = "🎀 SWEVEN'S 🎀\nRESELLER PORTAL";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlResellerProfile
            this.pnlResellerProfile.BackColor = System.Drawing.Color.White;
            this.pnlResellerProfile.Controls.Add(this.lblAvatar);
            this.pnlResellerProfile.Controls.Add(this.lblName);
            this.pnlResellerProfile.Controls.Add(this.lblTier);
            this.pnlResellerProfile.Controls.Add(this.lblBalance);
            this.pnlResellerProfile.Location = new System.Drawing.Point(12, 65);
            this.pnlResellerProfile.Name = "pnlResellerProfile";
            this.pnlResellerProfile.Padding = new System.Windows.Forms.Padding(8);
            this.pnlResellerProfile.Size = new System.Drawing.Size(196, 95);
            this.pnlResellerProfile.TabIndex = 1;

            // lblAvatar
            this.lblAvatar.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblAvatar.Location = new System.Drawing.Point(8, 8);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(35, 35);
            this.lblAvatar.TabIndex = 0;
            this.lblAvatar.Text = "💎";
            this.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = SwevenColors.TextColor;
            this.lblName.Location = new System.Drawing.Point(45, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "VIP Reseller";

            // lblTier
            this.lblTier.AutoSize = true;
            this.lblTier.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTier.ForeColor = SwevenColors.DarkPink;
            this.lblTier.Location = new System.Drawing.Point(45, 30);
            this.lblTier.Name = "lblTier";
            this.lblTier.Size = new System.Drawing.Size(135, 13);
            this.lblTier.TabIndex = 2;
            this.lblTier.Text = "⭐ Tier 2 Partner (8% Off)";

            // lblBalance
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBalance.ForeColor = CuteColors.CuteMintGreen;
            this.lblBalance.Location = new System.Drawing.Point(10, 68);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(155, 13);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "💳 Wallet: ₱12,450.00 Credits";

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
            this.btnNavHub.Text = "📊 Reseller Hub";
            this.btnNavHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHub.UseVisualStyleBackColor = false;
            this.btnNavHub.Click += new System.EventHandler(this.BtnNavHub_Click);

            // btnNavBulkOrder
            this.btnNavBulkOrder.BackColor = SwevenColors.LightPink;
            this.btnNavBulkOrder.FlatAppearance.BorderSize = 0;
            this.btnNavBulkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBulkOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavBulkOrder.ForeColor = SwevenColors.TextColor;
            this.btnNavBulkOrder.Location = new System.Drawing.Point(10, 225);
            this.btnNavBulkOrder.Name = "btnNavBulkOrder";
            this.btnNavBulkOrder.Size = new System.Drawing.Size(200, 42);
            this.btnNavBulkOrder.TabIndex = 3;
            this.btnNavBulkOrder.Text = "⚡ Fast Top-Up / Buy";
            this.btnNavBulkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBulkOrder.UseVisualStyleBackColor = false;
            this.btnNavBulkOrder.Click += new System.EventHandler(this.BtnNavBulkOrder_Click);

            // btnNavHistory
            this.btnNavHistory.BackColor = SwevenColors.LightPink;
            this.btnNavHistory.FlatAppearance.BorderSize = 0;
            this.btnNavHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavHistory.ForeColor = SwevenColors.TextColor;
            this.btnNavHistory.Location = new System.Drawing.Point(10, 275);
            this.btnNavHistory.Name = "btnNavHistory";
            this.btnNavHistory.Size = new System.Drawing.Size(200, 42);
            this.btnNavHistory.TabIndex = 4;
            this.btnNavHistory.Text = "📜 Client Transactions";
            this.btnNavHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHistory.UseVisualStyleBackColor = false;
            this.btnNavHistory.Click += new System.EventHandler(this.BtnNavHistory_Click);

            // btnNavMargin
            this.btnNavMargin.BackColor = SwevenColors.LightPink;
            this.btnNavMargin.FlatAppearance.BorderSize = 0;
            this.btnNavMargin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMargin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavMargin.ForeColor = SwevenColors.TextColor;
            this.btnNavMargin.Location = new System.Drawing.Point(10, 325);
            this.btnNavMargin.Name = "btnNavMargin";
            this.btnNavMargin.Size = new System.Drawing.Size(200, 42);
            this.btnNavMargin.TabIndex = 5;
            this.btnNavMargin.Text = "💰 Profit & Rates";
            this.btnNavMargin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMargin.UseVisualStyleBackColor = false;
            this.btnNavMargin.Click += new System.EventHandler(this.BtnNavMargin_Click);

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
            this.lblWelcome.Size = new System.Drawing.Size(275, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "💎 Welcome, VIP Reseller Partner! ✨";

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRole.ForeColor = SwevenColors.TextGray;
            this.lblRole.Location = new System.Drawing.Point(22, 36);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(395, 15);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "🤝 Wholesale Partner Portal • ID: RSL-8802 • VIP Tier 2 (8% Discount Active)";

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
            this.pnlHubView.Controls.Add(this.pnlCardWallet);
            this.pnlHubView.Controls.Add(this.pnlCardDiscount);
            this.pnlHubView.Controls.Add(this.pnlCardOrders);
            this.pnlHubView.Controls.Add(this.pnlCardMargin);
            this.pnlHubView.Controls.Add(this.lblWholesaleTitle);
            this.pnlHubView.Controls.Add(this.dgvResellerOrders);
            this.pnlHubView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHubView.Location = new System.Drawing.Point(0, 0);
            this.pnlHubView.Name = "pnlHubView";
            this.pnlHubView.Padding = new System.Windows.Forms.Padding(20);
            this.pnlHubView.Size = new System.Drawing.Size(1080, 685);
            this.pnlHubView.TabIndex = 0;

            // pnlCardWallet
            this.pnlCardWallet.BackColor = System.Drawing.Color.White;
            this.pnlCardWallet.Controls.Add(this.lblWalletVal);
            this.pnlCardWallet.Controls.Add(this.lblWalletTitle);
            this.pnlCardWallet.Location = new System.Drawing.Point(20, 20);
            this.pnlCardWallet.Name = "pnlCardWallet";
            this.pnlCardWallet.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCardWallet.Size = new System.Drawing.Size(240, 100);
            this.pnlCardWallet.TabIndex = 0;

            // lblWalletVal
            this.lblWalletVal.AutoSize = true;
            this.lblWalletVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWalletVal.ForeColor = CuteColors.CuteMintGreen;
            this.lblWalletVal.Location = new System.Drawing.Point(15, 45);
            this.lblWalletVal.Name = "lblWalletVal";
            this.lblWalletVal.Size = new System.Drawing.Size(130, 32);
            this.lblWalletVal.TabIndex = 1;
            this.lblWalletVal.Text = "₱12,450.00";

            // lblWalletTitle
            this.lblWalletTitle.AutoSize = true;
            this.lblWalletTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblWalletTitle.ForeColor = SwevenColors.TextColor;
            this.lblWalletTitle.Location = new System.Drawing.Point(15, 15);
            this.lblWalletTitle.Name = "lblWalletTitle";
            this.lblWalletTitle.Size = new System.Drawing.Size(185, 17);
            this.lblWalletTitle.TabIndex = 0;
            this.lblWalletTitle.Text = "💳 Reseller Credit Balance";

            // pnlCardDiscount
            this.pnlCardDiscount.BackColor = System.Drawing.Color.White;
            this.pnlCardDiscount.Controls.Add(this.lblDiscountVal);
            this.pnlCardDiscount.Controls.Add(this.lblDiscountTitle);
            this.pnlCardDiscount.Location = new System.Drawing.Point(280, 20);
            this.pnlCardDiscount.Name = "pnlCardDiscount";
            this.pnlCardDiscount.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCardDiscount.Size = new System.Drawing.Size(240, 100);
            this.pnlCardDiscount.TabIndex = 1;

            // lblDiscountVal
            this.lblDiscountVal.AutoSize = true;
            this.lblDiscountVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDiscountVal.ForeColor = SwevenColors.DarkPink;
            this.lblDiscountVal.Location = new System.Drawing.Point(15, 45);
            this.lblDiscountVal.Name = "lblDiscountVal";
            this.lblDiscountVal.Size = new System.Drawing.Size(107, 32);
            this.lblDiscountVal.TabIndex = 1;
            this.lblDiscountVal.Text = "8% OFF";

            // lblDiscountTitle
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDiscountTitle.ForeColor = SwevenColors.TextColor;
            this.lblDiscountTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(168, 17);
            this.lblDiscountTitle.TabIndex = 0;
            this.lblDiscountTitle.Text = "🏷️ Wholesale VIP Rate";

            // pnlCardOrders
            this.pnlCardOrders.BackColor = System.Drawing.Color.White;
            this.pnlCardOrders.Controls.Add(this.lblOrdersVal);
            this.pnlCardOrders.Controls.Add(this.lblOrdersTitle);
            this.pnlCardOrders.Location = new System.Drawing.Point(540, 20);
            this.pnlCardOrders.Name = "pnlCardOrders";
            this.pnlCardOrders.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCardOrders.Size = new System.Drawing.Size(240, 100);
            this.pnlCardOrders.TabIndex = 2;

            // lblOrdersVal
            this.lblOrdersVal.AutoSize = true;
            this.lblOrdersVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblOrdersVal.ForeColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.lblOrdersVal.Location = new System.Drawing.Point(15, 45);
            this.lblOrdersVal.Name = "lblOrdersVal";
            this.lblOrdersVal.Size = new System.Drawing.Size(56, 32);
            this.lblOrdersVal.TabIndex = 1;
            this.lblOrdersVal.Text = "142";

            // lblOrdersTitle
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOrdersTitle.ForeColor = SwevenColors.TextColor;
            this.lblOrdersTitle.Location = new System.Drawing.Point(15, 15);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(155, 17);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "📦 Reseller Total Orders";

            // pnlCardMargin
            this.pnlCardMargin.BackColor = System.Drawing.Color.White;
            this.pnlCardMargin.Controls.Add(this.lblMarginVal);
            this.pnlCardMargin.Controls.Add(this.lblMarginTitle);
            this.pnlCardMargin.Location = new System.Drawing.Point(800, 20);
            this.pnlCardMargin.Name = "pnlCardMargin";
            this.pnlCardMargin.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCardMargin.Size = new System.Drawing.Size(255, 100);
            this.pnlCardMargin.TabIndex = 3;

            // lblMarginVal
            this.lblMarginVal.AutoSize = true;
            this.lblMarginVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMarginVal.ForeColor = CuteColors.CuteMintGreen;
            this.lblMarginVal.Location = new System.Drawing.Point(15, 45);
            this.lblMarginVal.Name = "lblMarginVal";
            this.lblMarginVal.Size = new System.Drawing.Size(120, 32);
            this.lblMarginVal.TabIndex = 1;
            this.lblMarginVal.Text = "₱3,840.00";

            // lblMarginTitle
            this.lblMarginTitle.AutoSize = true;
            this.lblMarginTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMarginTitle.ForeColor = SwevenColors.TextColor;
            this.lblMarginTitle.Location = new System.Drawing.Point(15, 15);
            this.lblMarginTitle.Name = "lblMarginTitle";
            this.lblMarginTitle.Size = new System.Drawing.Size(158, 17);
            this.lblMarginTitle.TabIndex = 0;
            this.lblMarginTitle.Text = "💰 Estimated Net Margin";

            // lblWholesaleTitle
            this.lblWholesaleTitle.AutoSize = true;
            this.lblWholesaleTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWholesaleTitle.ForeColor = SwevenColors.TextColor;
            this.lblWholesaleTitle.Location = new System.Drawing.Point(20, 140);
            this.lblWholesaleTitle.Name = "lblWholesaleTitle";
            this.lblWholesaleTitle.Size = new System.Drawing.Size(320, 20);
            this.lblWholesaleTitle.TabIndex = 4;
            this.lblWholesaleTitle.Text = "📊 Reseller Wholesale Transactions Ledger:";

            // dgvResellerOrders
            this.dgvResellerOrders.AllowUserToAddRows = false;
            this.dgvResellerOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResellerOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvResellerOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResellerOrders.Location = new System.Drawing.Point(20, 170);
            this.dgvResellerOrders.Name = "dgvResellerOrders";
            this.dgvResellerOrders.ReadOnly = true;
            this.dgvResellerOrders.RowHeadersVisible = false;
            this.dgvResellerOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResellerOrders.Size = new System.Drawing.Size(1035, 480);
            this.dgvResellerOrders.TabIndex = 5;

            // ResellerDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.CardBg;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResellerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIP Reseller Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlResellerProfile.ResumeLayout(false);
            this.pnlResellerProfile.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlHubView.ResumeLayout(false);
            this.pnlHubView.PerformLayout();
            this.pnlCardWallet.ResumeLayout(false);
            this.pnlCardWallet.PerformLayout();
            this.pnlCardDiscount.ResumeLayout(false);
            this.pnlCardDiscount.PerformLayout();
            this.pnlCardOrders.ResumeLayout(false);
            this.pnlCardOrders.PerformLayout();
            this.pnlCardMargin.ResumeLayout(false);
            this.pnlCardMargin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResellerOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private CuteCardPanel pnlResellerProfile;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTier;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnNavHub;
        private System.Windows.Forms.Button btnNavBulkOrder;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnNavMargin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlHubView;
        private CuteCardPanel pnlCardWallet;
        private System.Windows.Forms.Label lblWalletVal;
        private System.Windows.Forms.Label lblWalletTitle;
        private CuteCardPanel pnlCardDiscount;
        private System.Windows.Forms.Label lblDiscountVal;
        private System.Windows.Forms.Label lblDiscountTitle;
        private CuteCardPanel pnlCardOrders;
        private System.Windows.Forms.Label lblOrdersVal;
        private System.Windows.Forms.Label lblOrdersTitle;
        private CuteCardPanel pnlCardMargin;
        private System.Windows.Forms.Label lblMarginVal;
        private System.Windows.Forms.Label lblMarginTitle;
        private System.Windows.Forms.Label lblWholesaleTitle;
        private System.Windows.Forms.DataGridView dgvResellerOrders;
    }
}
