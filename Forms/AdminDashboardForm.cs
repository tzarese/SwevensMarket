using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public class AdminDashboardForm : Form
    {
        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlMainContainer;
        private Panel pnlDashboardView;
        private Label lblDateTime;
        private Label lblWelcome;
        private Label lblRole;
        private System.Windows.Forms.Timer clockTimer;

        // Stat Card Labels
        private Label lblSalesVal;
        private Label lblOrdersVal;
        private Label lblPendingVal;
        private Label lblCompletedVal;
        private DataGridView dgvRecentOrders;

        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(1280, 720);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = SwevenColors.LightPink;

            // Sidebar
            pnlSidebar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 210,
                BackColor = SwevenColors.MainPink
            };

            var lblLogo = new Label
            {
                Text = "🎀 SWEVEN'S 🎀\nMARKET",
                Font = new Font("Georgia", 13, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 80
            };
            pnlSidebar.Controls.Add(lblLogo);

            int btnY = 90;
            pnlSidebar.Controls.Add(CreateSidebarButton("📊 Dashboard", btnY, (s, e) => ShowDashboardHome()));
            btnY += 46;
            pnlSidebar.Controls.Add(CreateSidebarButton("🛍️ Products", btnY, (s, e) => LoadChildForm(new ProductManagementForm())));
            btnY += 46;
            pnlSidebar.Controls.Add(CreateSidebarButton("📦 Orders", btnY, (s, e) => LoadChildForm(new OrderManagementForm())));
            btnY += 46;
            pnlSidebar.Controls.Add(CreateSidebarButton("💳 GCash Verification", btnY, (s, e) => LoadChildForm(new PaymentVerificationForm())));
            btnY += 46;
            pnlSidebar.Controls.Add(CreateSidebarButton("👥 Users", btnY, (s, e) => LoadChildForm(new UserManagementForm())));
            btnY += 46;
            pnlSidebar.Controls.Add(CreateSidebarButton("📈 Reports", btnY, (s, e) => LoadChildForm(new ReportsForm())));
            btnY += 70;
            pnlSidebar.Controls.Add(CreateSidebarButton("🚪 Logout", btnY, BtnLogout_Click));

            // Top Header Panel
            pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 65,
                BackColor = Color.White
            };

            lblWelcome = new Label
            {
                Text = $"Welcome, {UserSession.FullName}!",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(20, 12),
                AutoSize = true
            };

            lblRole = new Label
            {
                Text = $"Role: {UserSession.Role}",
                Font = new Font("Segoe UI", 9),
                ForeColor = SwevenColors.DarkPink,
                Location = new Point(21, 36),
                AutoSize = true
            };

            lblDateTime = new Label
            {
                Font = new Font("Segoe UI", 10),
                ForeColor = SwevenColors.TextGray,
                Location = new Point(780, 20),
                Size = new Size(220, 25),
                TextAlign = ContentAlignment.MiddleRight
            };

            var btnClose = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(35, 35),
                Location = new Point(1020, 15),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Application.Exit();

            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblRole);
            pnlHeader.Controls.Add(lblDateTime);
            pnlHeader.Controls.Add(btnClose);

            // Container for views
            pnlMainContainer = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = SwevenColors.LightPink
            };

            // Default Dashboard View (Stat cards & recent table)
            BuildDashboardHomeView();

            this.Controls.Add(pnlMainContainer);
            this.Controls.Add(pnlHeader);
            this.Controls.Add(pnlSidebar);

            clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            clockTimer.Tick += (s, e) => lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy  hh:mm:ss tt");
            clockTimer.Start();
        }

        private Button CreateSidebarButton(string text, int y, EventHandler onClick)
        {
            var btn = new Button
            {
                Text = text,
                Location = new Point(10, y),
                Size = new Size(190, 40),
                BackColor = SwevenColors.MainPink,
                ForeColor = SwevenColors.TextColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += onClick;
            return btn;
        }

        private void BuildDashboardHomeView()
        {
            pnlDashboardView = new Panel { Dock = DockStyle.Fill, BackColor = SwevenColors.LightPink, Padding = new Padding(20) };

            // 4 Stat Cards
            int cardW = 240, cardH = 95, gap = 15;
            pnlDashboardView.Controls.Add(CreateStatCard("Total Sales", "₱25,450.00", "▲ 18% this month", SwevenColors.DarkPink, 20, 20, cardW, cardH, out lblSalesVal));
            pnlDashboardView.Controls.Add(CreateStatCard("Total Orders", "156", "▲ 12% this month", Color.Teal, 20 + (cardW + gap), 20, cardW, cardH, out lblOrdersVal));
            pnlDashboardView.Controls.Add(CreateStatCard("Pending", "28", "⚠ Needs Attention", SwevenColors.WarningYellow, 20 + (cardW + gap) * 2, 20, cardW, cardH, out lblPendingVal));
            pnlDashboardView.Controls.Add(CreateStatCard("Completed", "118", "✔ Successfully Delivered", SwevenColors.SuccessGreen, 20 + (cardW + gap) * 3, 20, cardW, cardH, out lblCompletedVal));

            // Recent Orders Header & Grid
            var lblRecent = new Label
            {
                Text = "Recent Orders & Status",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(20, 140),
                AutoSize = true
            };
            pnlDashboardView.Controls.Add(lblRecent);

            dgvRecentOrders = new DataGridView
            {
                Location = new Point(20, 175),
                Size = new Size(1015, 440),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            pnlDashboardView.Controls.Add(dgvRecentOrders);

            pnlMainContainer.Controls.Add(pnlDashboardView);
        }

        private Panel CreateStatCard(string title, string defVal, string subtitle, Color barColor, int x, int y, int w, int h, out Label valLabel)
        {
            var pnl = new Panel { Location = new Point(x, y), Size = new Size(w, h), BackColor = Color.White };
            var colorBar = new Panel { Dock = DockStyle.Left, Width = 6, BackColor = barColor };
            var lblT = new Label { Text = title, Location = new Point(16, 12), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = SwevenColors.TextGray };
            valLabel = new Label { Text = defVal, Location = new Point(14, 32), AutoSize = true, Font = new Font("Segoe UI", 15, FontStyle.Bold), ForeColor = SwevenColors.TextColor };
            var lblSub = new Label { Text = subtitle, Location = new Point(16, 66), AutoSize = true, Font = new Font("Segoe UI", 8), ForeColor = barColor };

            pnl.Controls.Add(colorBar);
            pnl.Controls.Add(lblT);
            pnl.Controls.Add(valLabel);
            pnl.Controls.Add(lblSub);
            return pnl;
        }

        public void ShowDashboardHome()
        {
            pnlMainContainer.Controls.Clear();
            pnlMainContainer.Controls.Add(pnlDashboardView);
            LoadDashboardData();
        }

        public void LoadChildForm(Form childForm)
        {
            pnlMainContainer.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMainContainer.Controls.Add(childForm);
            childForm.Show();
        }

        private void LoadDashboardData()
        {
            decimal totalSales = DataStore.Orders.Where(o => o.GCashStatus == "Verified").Sum(o => o.Amount);
            int totalOrders = DataStore.Orders.Count;
            int pending = DataStore.Orders.Count(o => o.OrderStatus == "Pending");
            int completed = DataStore.Orders.Count(o => o.OrderStatus == "Completed");

            lblSalesVal.Text = $"₱{totalSales:N2}";
            lblOrdersVal.Text = totalOrders.ToString();
            lblPendingVal.Text = pending.ToString();
            lblCompletedVal.Text = completed.ToString();

            dgvRecentOrders.DataSource = null;
            dgvRecentOrders.DataSource = DataStore.Orders.OrderByDescending(o => o.Date).ToList();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            this.Hide();
            new LoginForm().Show();
        }
    }
}
