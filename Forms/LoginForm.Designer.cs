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
            pnlLeft = new Panel();
            picBow = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            picMascot = new PictureBox();
            lblMascotTag = new Label();
            pnlRight = new Panel();
            btnClose = new Button();
            pnlCard = new CuteCardPanel();
            lblWelcome = new Label();
            lblSubWelcome = new Label();
            lblUser = new Label();
            txtUsername = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            chkRemember = new CheckBox();
            lnkForgot = new LinkLabel();
            btnLogin = new CuteButton();
            lblOr = new Label();
            btnAdmin = new Button();
            btnStaff = new Button();
            btnReseller = new Button();
            btnCustomer = new Button();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMascot).BeginInit();
            pnlRight.SuspendLayout();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(253, 226, 228);
            pnlLeft.Controls.Add(picBow);
            pnlLeft.Controls.Add(lblTitle);
            pnlLeft.Controls.Add(lblSubtitle);
            pnlLeft.Controls.Add(picMascot);
            pnlLeft.Controls.Add(lblMascotTag);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(3, 4, 3, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(446, 733);
            pnlLeft.TabIndex = 0;
            pnlLeft.Paint += pnlLeft_Paint;
            // 
            // picBow
            // 
            picBow.Location = new Point(183, 33);
            picBow.Margin = new Padding(3, 4, 3, 4);
            picBow.Name = "picBow";
            picBow.Size = new Size(80, 67);
            picBow.SizeMode = PictureBoxSizeMode.Zoom;
            picBow.TabIndex = 0;
            picBow.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Georgia", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 77, 141);
            lblTitle.Location = new Point(17, 107);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(411, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "SWEVEN'S MARKET";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(94, 33, 69);
            lblSubtitle.Location = new Point(17, 167);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(411, 53);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "✨ Online Gaming Top-Up & Digital Services ✨\nCute & Secure System";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMascot
            // 
            picMascot.Location = new Point(131, 247);
            picMascot.Margin = new Padding(3, 4, 3, 4);
            picMascot.Name = "picMascot";
            picMascot.Size = new Size(183, 213);
            picMascot.SizeMode = PictureBoxSizeMode.Zoom;
            picMascot.TabIndex = 3;
            picMascot.TabStop = false;
            // 
            // lblMascotTag
            // 
            lblMascotTag.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMascotTag.ForeColor = Color.FromArgb(255, 77, 141);
            lblMascotTag.Location = new Point(17, 480);
            lblMascotTag.Name = "lblMascotTag";
            lblMascotTag.Size = new Size(411, 60);
            lblMascotTag.TabIndex = 4;
            lblMascotTag.Text = "🌸 Welcome, Gamer Cutie! 🌸\n(=^･ω･^=) 🎮";
            lblMascotTag.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(255, 240, 245);
            pnlRight.Controls.Add(btnClose);
            pnlRight.Controls.Add(pnlCard);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(446, 0);
            pnlRight.Margin = new Padding(3, 4, 3, 4);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(29, 33, 29, 33);
            pnlRight.Size = new Size(583, 733);
            pnlRight.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(255, 77, 141);
            btnClose.Location = new Point(526, 13);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 48);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += BtnClose_Click;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblWelcome);
            pnlCard.Controls.Add(lblSubWelcome);
            pnlCard.Controls.Add(lblUser);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblPass);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(chkRemember);
            pnlCard.Controls.Add(lnkForgot);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(lblOr);
            pnlCard.Controls.Add(btnAdmin);
            pnlCard.Controls.Add(btnStaff);
            pnlCard.Controls.Add(btnReseller);
            pnlCard.Controls.Add(btnCustomer);
            pnlCard.Location = new Point(40, 40);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(17, 20, 17, 20);
            pnlCard.Size = new Size(486, 653);
            pnlCard.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Georgia", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(255, 77, 141);
            lblWelcome.Location = new Point(40, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(447, 39);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back, Cutie! ✨";
            // 
            // lblSubWelcome
            // 
            lblSubWelcome.AutoSize = true;
            lblSubWelcome.Font = new Font("Segoe UI", 9.5F);
            lblSubWelcome.ForeColor = Color.FromArgb(158, 88, 127);
            lblSubWelcome.Location = new Point(43, 77);
            lblSubWelcome.Name = "lblSubWelcome";
            lblSubWelcome.Size = new Size(231, 21);
            lblSubWelcome.TabIndex = 1;
            lblSubWelcome.Text = "Please login to your account 💕";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUser.ForeColor = Color.FromArgb(94, 33, 69);
            lblUser.Location = new Point(40, 127);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(106, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "🎀 Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(40, 153);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(399, 32);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "admin";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPass.ForeColor = Color.FromArgb(94, 33, 69);
            lblPass.Location = new Point(40, 207);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(102, 20);
            lblPass.TabIndex = 4;
            lblPass.Text = "🔒 Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(40, 233);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(399, 32);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "123";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Segoe UI", 9F);
            chkRemember.ForeColor = Color.FromArgb(94, 33, 69);
            chkRemember.Location = new Point(40, 287);
            chkRemember.Margin = new Padding(3, 4, 3, 4);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(154, 24);
            chkRemember.TabIndex = 6;
            chkRemember.Text = "💖 Remember me";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // lnkForgot
            // 
            lnkForgot.AutoSize = true;
            lnkForgot.Font = new Font("Segoe UI", 9F);
            lnkForgot.LinkColor = Color.FromArgb(255, 77, 141);
            lnkForgot.Location = new Point(303, 287);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(152, 20);
            lnkForgot.TabIndex = 7;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Forgot password? 💭";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 77, 141);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 333);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(400, 61);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "💖 LOGIN TO STORE ➔";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lblOr
            // 
            lblOr.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblOr.ForeColor = Color.FromArgb(158, 88, 127);
            lblOr.Location = new Point(40, 420);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(400, 27);
            lblOr.TabIndex = 9;
            lblOr.Text = "─── 🐾 QUICK TEST ROLE 🐾 ───";
            lblOr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(253, 226, 228);
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.FromArgb(94, 33, 69);
            btnAdmin.Location = new Point(40, 460);
            btnAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(89, 67);
            btnAdmin.TabIndex = 10;
            btnAdmin.Text = "👑 Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += BtnAdmin_Click;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = Color.FromArgb(253, 226, 228);
            btnStaff.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnStaff.ForeColor = Color.FromArgb(94, 33, 69);
            btnStaff.Location = new Point(143, 460);
            btnStaff.Margin = new Padding(3, 4, 3, 4);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(89, 67);
            btnStaff.TabIndex = 11;
            btnStaff.Text = "👥 Staff";
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += BtnStaff_Click;
            // 
            // btnReseller
            // 
            btnReseller.BackColor = Color.FromArgb(253, 226, 228);
            btnReseller.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnReseller.FlatStyle = FlatStyle.Flat;
            btnReseller.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnReseller.ForeColor = Color.FromArgb(94, 33, 69);
            btnReseller.Location = new Point(246, 460);
            btnReseller.Margin = new Padding(3, 4, 3, 4);
            btnReseller.Name = "btnReseller";
            btnReseller.Size = new Size(89, 67);
            btnReseller.TabIndex = 12;
            btnReseller.Text = "🏪 Reseller";
            btnReseller.UseVisualStyleBackColor = false;
            btnReseller.Click += BtnReseller_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(253, 226, 228);
            btnCustomer.FlatAppearance.BorderColor = Color.FromArgb(255, 179, 198);
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnCustomer.ForeColor = Color.FromArgb(94, 33, 69);
            btnCustomer.Location = new Point(349, 460);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(91, 67);
            btnCustomer.TabIndex = 13;
            btnCustomer.Text = "🛍️ Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += BtnCustomer_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 240, 245);
            ClientSize = new Size(1029, 733);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sweven's Market - Login";
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMascot).EndInit();
            pnlRight.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picBow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox picMascot;
        private System.Windows.Forms.Label lblMascotTag;
        private System.Windows.Forms.Panel pnlRight;
        private SwevensMarket.Theme.CuteCardPanel pnlCard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubWelcome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private SwevensMarket.Theme.CuteButton btnLogin;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnReseller;
        private System.Windows.Forms.Button btnCustomer;
    }
}
