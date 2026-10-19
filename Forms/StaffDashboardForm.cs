using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public partial class StaffDashboardForm : Form
    {
        private System.Windows.Forms.Timer clockTimer;

        public StaffDashboardForm()
        {
            InitializeComponent();
            SetupStaffPortal();
        }

        private void SetupStaffPortal()
        {
            string name = string.IsNullOrEmpty(UserSession.FullName) ? "Store Staff" : UserSession.FullName;
            lblWelcome.Text = $"👔 Welcome, {name}! ✨";
            lblStaffName.Text = name;
            lblRole.Text = $"🛠️ Store Operations & Fulfillment Portal • Sweven's Market";

            CuteThemeHelper.ApplyCuteGrid(dgvStaffQueue);

            // Live Clock Timer
            lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy  hh:mm:ss tt");
            clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            clockTimer.Tick += (s, e) => lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy  hh:mm:ss tt");
            clockTimer.Start();

            LoadStaffHubData();
        }

        public void ShowHubHome()
        {
            pnlMainContainer.Controls.Clear();
            pnlMainContainer.Controls.Add(pnlHubView);
            LoadStaffHubData();
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

        private void LoadStaffHubData()
        {
            int pending = DataStore.Orders.Count(o => o.OrderStatus == "Pending");
            int processing = DataStore.Orders.Count(o => o.OrderStatus == "Processing");
            int completed = DataStore.Orders.Count(o => o.OrderStatus == "Completed");
            int products = DataStore.Products.Count(p => p.Status == "Active");

            lblPendingVal.Text = pending.ToString();
            lblProcessingVal.Text = processing.ToString();
            lblCompletedVal.Text = completed.ToString();
            lblProductsVal.Text = products.ToString();

            // Load active pending/processing queue for staff to fulfill
            var queue = DataStore.Orders
                .Where(o => o.OrderStatus == "Pending" || o.OrderStatus == "Processing")
                .OrderByDescending(o => o.Date)
                .ToList();

            dgvStaffQueue.DataSource = null;
            dgvStaffQueue.DataSource = queue;
        }

        private void SetActiveNav(Button activeBtn)
        {
            btnNavHub.BackColor = SwevenColors.LightPink;
            btnNavHub.ForeColor = SwevenColors.TextColor;
            btnNavPayments.BackColor = SwevenColors.LightPink;
            btnNavPayments.ForeColor = SwevenColors.TextColor;
            btnNavOrders.BackColor = SwevenColors.LightPink;
            btnNavOrders.ForeColor = SwevenColors.TextColor;
            btnNavProducts.BackColor = SwevenColors.LightPink;
            btnNavProducts.ForeColor = SwevenColors.TextColor;

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

        private void BtnNavPayments_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavPayments);
            LoadChildForm(new PaymentVerificationForm());
        }

        private void BtnNavOrders_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavOrders);
            LoadChildForm(new OrderManagementForm());
        }

        private void BtnNavProducts_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavProducts);
            LoadChildForm(new ProductManagementForm());
        }
    }
}
