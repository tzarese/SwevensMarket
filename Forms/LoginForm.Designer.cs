using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class LoginForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblMascot = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubWelcome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnReseller = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();

            // pnlLeft
            this.pnlLeft.BackColor = SwevenColors.MainPink;
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Controls.Add(this.lblSubtitle);
            this.pnlLeft.Controls.Add(this.lblMascot);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(400, 550);
            this.pnlLeft.TabIndex = 0;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = SwevenColors.DarkPink;
            this.lblTitle.Location = new System.Drawing.Point(20, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SWEVEN'S\nMARKET";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = SwevenColors.TextColor;
            this.lblSubtitle.Location = new System.Drawing.Point(20, 200);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(360, 45);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Online Gaming Top-Up and Digital Services\nTransaction Management System";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblMascot
            this.lblMascot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMascot.ForeColor = SwevenColors.DarkPink;
            this.lblMascot.Location = new System.Drawing.Point(20, 300);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(360, 80);
            this.lblMascot.TabIndex = 2;
            this.lblMascot.Text = "🎀  (=^･ω･^=)  🎮\nOfficial Store Portal";
            this.lblMascot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlRight
            this.pnlRight.BackColor = SwevenColors.LightPink;
            this.pnlRight.Controls.Add(this.btnClose);
            this.pnlRight.Controls.Add(this.lblWelcome);
            this.pnlRight.Controls.Add(this.lblSubWelcome);
            this.pnlRight.Controls.Add(this.lblUser);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblPass);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.chkRemember);
            this.pnlRight.Controls.Add(this.lnkForgot);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.lblOr);
            this.pnlRight.Controls.Add(this.btnAdmin);
            this.pnlRight.Controls.Add(this.btnStaff);
            this.pnlRight.Controls.Add(this.btnReseller);
            this.pnlRight.Controls.Add(this.btnCustomer);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(400, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(500, 550);
            this.pnlRight.TabIndex = 1;

            // btnClose
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = SwevenColors.DarkPink;
            this.btnClose.Location = new System.Drawing.Point(450, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = SwevenColors.DarkPink;
            this.lblWelcome.Location = new System.Drawing.Point(60, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(262, 35);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Back!";

            // lblSubWelcome
            this.lblSubWelcome.AutoSize = true;
            this.lblSubWelcome.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubWelcome.ForeColor = SwevenColors.TextGray;
            this.lblSubWelcome.Location = new System.Drawing.Point(63, 88);
            this.lblSubWelcome.Name = "lblSubWelcome";
            this.lblSubWelcome.Size = new System.Drawing.Size(176, 17);
            this.lblSubWelcome.TabIndex = 2;
            this.lblSubWelcome.Text = "Please login to your account";

            // lblUser
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = SwevenColors.TextColor;
            this.lblUser.Location = new System.Drawing.Point(60, 130);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 15);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username";

            // txtUsername
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(60, 155);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(360, 27);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "admin";

            // lblPass
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPass.ForeColor = SwevenColors.TextColor;
            this.lblPass.Location = new System.Drawing.Point(60, 195);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(59, 15);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";

            // txtPassword
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(60, 220);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(360, 27);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "123";
            this.txtPassword.UseSystemPasswordChar = true;

            // chkRemember
            this.chkRemember.AutoSize = true;
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRemember.ForeColor = SwevenColors.TextColor;
            this.chkRemember.Location = new System.Drawing.Point(60, 260);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(104, 19);
            this.chkRemember.TabIndex = 7;
            this.chkRemember.Text = "Remember me";
            this.chkRemember.UseVisualStyleBackColor = true;

            // lnkForgot
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkForgot.LinkColor = SwevenColors.DarkPink;
            this.lnkForgot.Location = new System.Drawing.Point(310, 260);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(100, 15);
            this.lnkForgot.TabIndex = 8;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Forgot password?";

            // btnLogin
            this.btnLogin.BackColor = SwevenColors.DarkPink;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(60, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(360, 44);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN  ➔";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);

            // lblOr
            this.lblOr.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblOr.ForeColor = SwevenColors.TextGray;
            this.lblOr.Location = new System.Drawing.Point(60, 360);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(360, 20);
            this.lblOr.TabIndex = 10;
            this.lblOr.Text = "─── OR AUTO-FILL TEST ROLE ───";
            this.lblOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnAdmin
            this.btnAdmin.BackColor = SwevenColors.MainPink;
            this.btnAdmin.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = SwevenColors.TextColor;
            this.btnAdmin.Location = new System.Drawing.Point(60, 390);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(80, 50);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "👑 Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);

            // btnStaff
            this.btnStaff.BackColor = SwevenColors.MainPink;
            this.btnStaff.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnStaff.ForeColor = SwevenColors.TextColor;
            this.btnStaff.Location = new System.Drawing.Point(155, 390);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(80, 50);
            this.btnStaff.TabIndex = 12;
            this.btnStaff.Text = "👥 Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.BtnStaff_Click);

            // btnReseller
            this.btnReseller.BackColor = SwevenColors.MainPink;
            this.btnReseller.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnReseller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReseller.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnReseller.ForeColor = SwevenColors.TextColor;
            this.btnReseller.Location = new System.Drawing.Point(250, 390);
            this.btnReseller.Name = "btnReseller";
            this.btnReseller.Size = new System.Drawing.Size(80, 50);
            this.btnReseller.TabIndex = 13;
            this.btnReseller.Text = "🏪 Reseller";
            this.btnReseller.UseVisualStyleBackColor = false;
            this.btnReseller.Click += new System.EventHandler(this.BtnReseller_Click);

            // btnCustomer
            this.btnCustomer.BackColor = SwevenColors.MainPink;
            this.btnCustomer.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = SwevenColors.TextColor;
            this.btnCustomer.Location = new System.Drawing.Point(345, 390);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(80, 50);
            this.btnCustomer.TabIndex = 14;
            this.btnCustomer.Text = "🛍️ Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sweven\'s Market - Login";
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubWelcome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnReseller;
        private System.Windows.Forms.Button btnCustomer;
    }
}
