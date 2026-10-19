using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public partial class ResellerDashboardForm : Form
    {
        private System.Windows.Forms.Timer clockTimer;

        public ResellerDashboardForm()
        {
            InitializeComponent();
            SetupResellerPortal();
        }

        private void SetupResellerPortal()
        {
            string name = string.IsNullOrEmpty(UserSession.FullName) ? "VIP Reseller" : UserSession.FullName;
            lblWelcome.Text = $"💎 Welcome, {name}! ✨";
            lblName.Text = name;
            lblRole.Text = $"🤝 Wholesale Partner Portal • ID: RSL-{UserSession.UserId:D4} • VIP Tier 2 (8% Discount Active)";

            CuteThemeHelper.ApplyCuteGrid(dgvResellerOrders);

            // Live Clock Timer
            lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy  hh:mm:ss tt");
            clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            clockTimer.Tick += (s, e) => lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy  hh:mm:ss tt");
            clockTimer.Start();

            LoadResellerHubData();
        }

        public void ShowHubHome()
        {
            pnlMainContainer.Controls.Clear();
            pnlMainContainer.Controls.Add(pnlHubView);
            LoadResellerHubData();
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

        private void LoadResellerHubData()
        {
            // Reseller transactions
            var clientOrders = DataStore.Orders
                .OrderByDescending(o => o.Date)
                .Take(10)
                .ToList();

            dgvResellerOrders.DataSource = null;
            dgvResellerOrders.DataSource = clientOrders;
        }

        private void SetActiveNav(Button activeBtn)
        {
            btnNavHub.BackColor = SwevenColors.LightPink;
            btnNavHub.ForeColor = SwevenColors.TextColor;
            btnNavBulkOrder.BackColor = SwevenColors.LightPink;
            btnNavBulkOrder.ForeColor = SwevenColors.TextColor;
            btnNavHistory.BackColor = SwevenColors.LightPink;
            btnNavHistory.ForeColor = SwevenColors.TextColor;
            btnNavMargin.BackColor = SwevenColors.LightPink;
            btnNavMargin.ForeColor = SwevenColors.TextColor;

            activeBtn.BackColor = SwevenColors.DarkPink;
            activeBtn.ForeColor = Color.White;
        }

        private void BtnClose_Click(object? sender, EventArgs e) => Application.Exit();

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            clockTimer?.Stop();
            UserSession.Clear();
            this.Hide();
            new LoginForm().Show();
        }

        private void BtnNavHub_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavHub);
            ShowHubHome();
        }

        private void BtnNavBulkOrder_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavBulkOrder);
            LoadChildForm(new CreateOrderGCashForm());
        }

        private void BtnNavHistory_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavHistory);
            LoadChildForm(new OrderHistoryForm());
        }

        private void BtnNavMargin_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavMargin);
            MessageBox.Show(
                "💰 VIP RESELLER WHOLESALE RATES & MARGINS\n\n" +
                "• Partner: VIP Reseller Partner (Tier 2)\n" +
                "• Active Wholesale Discount: 8.0% OFF on all game credits\n" +
                "• Deposit Balance Available: ₱12,450.00\n" +
                "• Tier Progression: Reach ₱50,000 monthly volume to upgrade to Tier 3 (12% OFF!)\n\n" +
                "Example Margins:\n" +
                "  - MLBB 706 Diamonds: Retail ₱400 ➔ Reseller Price ₱368.00 (Profit: ₱32.00)\n" +
                "  - Steam Wallet ₱500: Retail ₱540 ➔ Reseller Price ₱496.80 (Profit: ₱43.20)\n\n" +
                "Thank you for partnering with Sweven's Market! 💖",
                "Wholesale Rates & Margins", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
