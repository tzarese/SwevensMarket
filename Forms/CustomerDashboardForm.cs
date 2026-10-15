using System;
using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public partial class CustomerDashboardForm : Form
    {
        public CustomerDashboardForm()
        {
            InitializeComponent();
            lblWelcome.Text = $"Hello, {UserSession.FullName}! ✨ Happy Gaming!";
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

        private void BtnNavTopUp_Click(object? sender, EventArgs e) => LoadChildForm(new CreateOrderGCashForm());
        private void BtnNavHistory_Click(object? sender, EventArgs e) => LoadChildForm(new OrderHistoryForm());
    }
}
