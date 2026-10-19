using System;
using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public partial class CustomerDashboardForm : Form
    {
        private System.Windows.Forms.Timer clockTimer;

        public CustomerDashboardForm()
        {
            InitializeComponent();
            SetupCustomerPortal();
        }

        private void SetupCustomerPortal()
        {
            string name = string.IsNullOrEmpty(UserSession.FullName) ? "Maria Santos" : UserSession.FullName;
            lblWelcome.Text = $"🌸 Welcome, {name}! ✨";
            lblCustName.Text = name;
            lblRole.Text = $"🛍️ Customer Portal • Member ID: CUST-{UserSession.UserId:D3} • Sweven's Market";

            // Live Clock Timer
            lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy  hh:mm:ss tt");
            clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            clockTimer.Tick += (s, e) => lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy  hh:mm:ss tt");
            clockTimer.Start();

            // Default child form: Top-Up and Buy
            LoadChildForm(new CreateOrderGCashForm());
        }

        public void LoadChildForm(Form childForm)
        {
            pnlContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void SetActiveNav(Button activeBtn)
        {
            btnNavTopUp.BackColor = SwevenColors.LightPink;
            btnNavTopUp.ForeColor = SwevenColors.TextColor;
            btnNavHistory.BackColor = SwevenColors.LightPink;
            btnNavHistory.ForeColor = SwevenColors.TextColor;
            btnNavPerks.BackColor = SwevenColors.LightPink;
            btnNavPerks.ForeColor = SwevenColors.TextColor;

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

        private void BtnNavTopUp_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavTopUp);
            LoadChildForm(new CreateOrderGCashForm());
        }

        private void BtnNavHistory_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavHistory);
            LoadChildForm(new OrderHistoryForm());
        }

        private void BtnNavPerks_Click(object? sender, EventArgs e)
        {
            SetActiveNav(btnNavPerks);
            MessageBox.Show(
                "🎁 SWEVEN'S GAMER REWARDS & PERKS\n\n" +
                $"• Member: {lblCustName.Text}\n" +
                $"• Account Status: Active VIP Gamer Level 2\n" +
                $"• Current Points: 150 Sweven Points (worth ₱15 discount)\n" +
                $"• Perks:\n" +
                $"  ✓ Free MLBB weekly raffle entry\n" +
                $"  ✓ Priority GCash verification queue\n" +
                $"  ✓ 1 Point earned for every ₱10 top-up\n\n" +
                "Keep gaming and top-up more to unlock Level 3 perks! 💖",
                "Gamer Perks", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
