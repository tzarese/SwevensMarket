using System;
using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public class CustomerDashboardForm : Form
    {
        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Label lblWelcome;

        public CustomerDashboardForm()
        {
            InitializeComponent();
            LoadChildForm(new CreateOrderGCashForm()); // default to order page
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
                Width = 220,
                BackColor = SwevenColors.MainPink
            };

            var lblLogo = new Label
            {
                Text = "🌸 SWEVEN'S 🌸\nCUSTOMER HUB",
                Font = new Font("Georgia", 13, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 80
            };
            pnlSidebar.Controls.Add(lblLogo);

            int btnY = 90;
            pnlSidebar.Controls.Add(CreateMenuButton("🎮 Top-Up & Buy", btnY, (s, e) => LoadChildForm(new CreateOrderGCashForm())));
            btnY += 50;
            pnlSidebar.Controls.Add(CreateMenuButton("📜 My Order History", btnY, (s, e) => LoadChildForm(new OrderHistoryForm())));
            btnY += 70;
            pnlSidebar.Controls.Add(CreateMenuButton("🚪 Logout", btnY, BtnLogout_Click));

            // Header
            pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 65,
                BackColor = Color.White
            };

            lblWelcome = new Label
            {
                Text = $"Hello, {UserSession.FullName}! ✨ Happy Gaming!",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                Location = new Point(20, 20),
                AutoSize = true
            };

            var btnClose = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(35, 35),
                Location = new Point(1010, 15),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Application.Exit();

            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(btnClose);

            // Dynamic Content
            pnlContent = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = SwevenColors.LightPink
            };

            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlHeader);
            this.Controls.Add(pnlSidebar);
        }

        private Button CreateMenuButton(string text, int y, EventHandler onClick)
        {
            var btn = new Button
            {
                Text = text,
                Location = new Point(10, y),
                Size = new Size(200, 42),
                BackColor = SwevenColors.MainPink,
                ForeColor = SwevenColors.TextColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += onClick;
            return btn;
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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            this.Hide();
            new LoginForm().Show();
        }
    }
}
