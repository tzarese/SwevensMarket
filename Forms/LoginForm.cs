using System;
using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Theme;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public class LoginForm : Form
    {
        private Panel pnlLeft;
        private Panel pnlRight;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblWelcome;
        private Label lblSubWelcome;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClose;
        private Button btnAdmin;
        private Button btnStaff;
        private Button btnReseller;
        private Button btnCustomer;
        private CheckBox chkRemember;
        private LinkLabel lnkForgot;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(900, 550);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = SwevenColors.LightPink;

            // Left Branding Panel
            pnlLeft = new Panel
            {
                Dock = DockStyle.Left,
                Width = 400,
                BackColor = SwevenColors.MainPink
            };

            lblTitle = new Label
            {
                Text = "SWEVEN'S\nMARKET",
                Font = new Font("Georgia", 24, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(20, 100),
                Size = new Size(360, 90)
            };

            lblSubtitle = new Label
            {
                Text = "Online Gaming Top-Up and Digital Services\nTransaction Management System",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular),
                ForeColor = SwevenColors.TextColor,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(20, 200),
                Size = new Size(360, 45)
            };

            var lblMascot = new Label
            {
                Text = "🎀  (=^･ω･^=)  🎮\nOfficial Store Portal",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(20, 300),
                Size = new Size(360, 80)
            };

            pnlLeft.Controls.Add(lblTitle);
            pnlLeft.Controls.Add(lblSubtitle);
            pnlLeft.Controls.Add(lblMascot);

            // Right Login Panel
            pnlRight = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = SwevenColors.LightPink,
                Padding = new Padding(40)
            };

            btnClose = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(36, 36),
                Location = new Point(450, 10),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Application.Exit();

            lblWelcome = new Label
            {
                Text = "Welcome Back!",
                Font = new Font("Georgia", 22, FontStyle.Bold),
                ForeColor = SwevenColors.DarkPink,
                Location = new Point(60, 50),
                AutoSize = true
            };

            lblSubWelcome = new Label
            {
                Text = "Please login to your account",
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = SwevenColors.TextGray,
                Location = new Point(63, 88),
                AutoSize = true
            };

            var lblUser = new Label { Text = "Username", Location = new Point(60, 130), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = SwevenColors.TextColor };
            txtUsername = new TextBox
            {
                Location = new Point(60, 155),
                Size = new Size(360, 32),
                Font = new Font("Segoe UI", 11),
                Text = "admin"
            };

            var lblPass = new Label { Text = "Password", Location = new Point(60, 195), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = SwevenColors.TextColor };
            txtPassword = new TextBox
            {
                Location = new Point(60, 220),
                Size = new Size(360, 32),
                Font = new Font("Segoe UI", 11),
                UseSystemPasswordChar = true,
                Text = "123"
            };

            chkRemember = new CheckBox
            {
                Text = "Remember me",
                Location = new Point(60, 260),
                AutoSize = true,
                Font = new Font("Segoe UI", 9),
                ForeColor = SwevenColors.TextColor
            };

            lnkForgot = new LinkLabel
            {
                Text = "Forgot password?",
                Location = new Point(310, 260),
                AutoSize = true,
                LinkColor = SwevenColors.DarkPink,
                Font = new Font("Segoe UI", 9)
            };

            btnLogin = new Button
            {
                Text = "LOGIN  ➔",
                Location = new Point(60, 295),
                Size = new Size(360, 44),
                BackColor = SwevenColors.DarkPink,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += BtnLogin_Click;

            var lblOr = new Label
            {
                Text = "─── OR AUTO-FILL TEST ROLE ───",
                Location = new Point(60, 360),
                Size = new Size(360, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = SwevenColors.TextGray,
                Font = new Font("Segoe UI", 8.5f)
            };

            btnAdmin = CreateRoleButton("👑 Admin", new Point(60, 390), (s, e) => { txtUsername.Text = "admin"; txtPassword.Text = "123"; });
            btnStaff = CreateRoleButton("👥 Staff", new Point(155, 390), (s, e) => { txtUsername.Text = "staff"; txtPassword.Text = "123"; });
            btnReseller = CreateRoleButton("🏪 Reseller", new Point(250, 390), (s, e) => { txtUsername.Text = "reseller"; txtPassword.Text = "123"; });
            btnCustomer = CreateRoleButton("🛍️ Customer", new Point(345, 390), (s, e) => { txtUsername.Text = "maria"; txtPassword.Text = "123"; });

            pnlRight.Controls.Add(btnClose);
            pnlRight.Controls.Add(lblWelcome);
            pnlRight.Controls.Add(lblSubWelcome);
            pnlRight.Controls.Add(lblUser);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(lblPass);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(chkRemember);
            pnlRight.Controls.Add(lnkForgot);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Controls.Add(lblOr);
            pnlRight.Controls.Add(btnAdmin);
            pnlRight.Controls.Add(btnStaff);
            pnlRight.Controls.Add(btnReseller);
            pnlRight.Controls.Add(btnCustomer);

            this.Controls.Add(pnlRight);
            this.Controls.Add(pnlLeft);
        }

        private Button CreateRoleButton(string text, Point loc, EventHandler onClick)
        {
            var btn = new Button
            {
                Text = text,
                Location = loc,
                Size = new Size(80, 50),
                BackColor = SwevenColors.MainPink,
                ForeColor = SwevenColors.TextColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            btn.Click += onClick;
            return btn;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = DataStore.Users.Find(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) 
                                              && u.Password == password && u.IsActive);

            if (user != null)
            {
                UserSession.UserId = user.Id;
                UserSession.Username = user.Username;
                UserSession.FullName = user.FullName;
                UserSession.Role = user.Role;

                this.Hide();

                if (user.Role == "Admin" || user.Role == "Staff")
                {
                    var adminDash = new AdminDashboardForm();
                    adminDash.FormClosed += (s, args) => this.Close();
                    adminDash.Show();
                }
                else
                {
                    var custDash = new CustomerDashboardForm();
                    custDash.FormClosed += (s, args) => this.Close();
                    custDash.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
