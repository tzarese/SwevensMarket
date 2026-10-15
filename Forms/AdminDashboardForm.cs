using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            lblWelcome.Text = $"🌸 Welcome, {UserSession.FullName}! ✨";
            lblRole.Text = $"👑 Administrator Portal • Sweven's Market";

            CuteThemeHelper.ApplyCuteGrid(dgvRecentOrders);

            clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            clockTimer.Tick += (s, e) => lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy  hh:mm:ss tt");
            clockTimer.Start();

            LoadDashboardData();
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

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            UserSession.Clear();
            this.Hide();
            new LoginForm().Show();
        }

        private void BtnNavDashboard_Click(object? sender, EventArgs e) => ShowDashboardHome();
        private void BtnNavProducts_Click(object? sender, EventArgs e)  => LoadChildForm(new ProductManagementForm());
        private void BtnNavOrders_Click(object? sender, EventArgs e)    => LoadChildForm(new OrderManagementForm());
        private void BtnNavPayments_Click(object? sender, EventArgs e)  => LoadChildForm(new PaymentVerificationForm());
        private void BtnNavUsers_Click(object? sender, EventArgs e)     => LoadChildForm(new UserManagementForm());
        private void BtnNavReports_Click(object? sender, EventArgs e)   => LoadChildForm(new ReportsForm());
    }
}
