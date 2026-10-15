using System.Drawing;
using System.Windows.Forms;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    partial class UserManagementForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblU = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblF = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnToggleStatus = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = SwevenColors.TextColor;
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(206, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "👥 User Management";

            // dgvUsers
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.Location = new System.Drawing.Point(20, 55);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(680, 570);
            this.dgvUsers.TabIndex = 1;

            // pnlForm
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Controls.Add(this.lblU);
            this.pnlForm.Controls.Add(this.txtUsername);
            this.pnlForm.Controls.Add(this.lblP);
            this.pnlForm.Controls.Add(this.txtPassword);
            this.pnlForm.Controls.Add(this.lblF);
            this.pnlForm.Controls.Add(this.txtFullName);
            this.pnlForm.Controls.Add(this.lblR);
            this.pnlForm.Controls.Add(this.cmbRole);
            this.pnlForm.Controls.Add(this.chkActive);
            this.pnlForm.Controls.Add(this.btnAddUser);
            this.pnlForm.Controls.Add(this.btnToggleStatus);
            this.pnlForm.Location = new System.Drawing.Point(720, 55);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(20);
            this.pnlForm.Size = new System.Drawing.Size(320, 570);
            this.pnlForm.TabIndex = 2;

            // lblFormTitle
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = SwevenColors.DarkPink;
            this.lblFormTitle.Location = new System.Drawing.Point(15, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(167, 20);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Add New User Account";

            // lblU
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblU.Location = new System.Drawing.Point(15, 55);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(64, 15);
            this.lblU.TabIndex = 1;
            this.lblU.Text = "Username";

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(15, 75);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(290, 23);
            this.txtUsername.TabIndex = 2;

            // lblP
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblP.Location = new System.Drawing.Point(15, 115);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(59, 15);
            this.lblP.TabIndex = 3;
            this.lblP.Text = "Password";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(15, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(290, 23);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;

            // lblF
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblF.Location = new System.Drawing.Point(15, 175);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(62, 15);
            this.lblF.TabIndex = 5;
            this.lblF.Text = "Full Name";

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(15, 195);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(290, 23);
            this.txtFullName.TabIndex = 6;

            // lblR
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblR.Location = new System.Drawing.Point(15, 235);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(32, 15);
            this.lblR.TabIndex = 7;
            this.lblR.Text = "Role";

            // cmbRole
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Reseller",
            "Customer"});
            this.cmbRole.Location = new System.Drawing.Point(15, 255);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(290, 23);
            this.cmbRole.TabIndex = 8;
            this.cmbRole.SelectedIndex = 1;

            // chkActive
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkActive.Location = new System.Drawing.Point(15, 295);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(104, 19);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "Account Active";
            this.chkActive.UseVisualStyleBackColor = true;

            // btnAddUser
            this.btnAddUser.BackColor = SwevenColors.DarkPink;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(15, 335);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(290, 40);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "+ Create User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);

            // btnToggleStatus
            this.btnToggleStatus.BackColor = SwevenColors.MainPink;
            this.btnToggleStatus.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            this.btnToggleStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnToggleStatus.ForeColor = SwevenColors.TextColor;
            this.btnToggleStatus.Location = new System.Drawing.Point(15, 385);
            this.btnToggleStatus.Name = "btnToggleStatus";
            this.btnToggleStatus.Size = new System.Drawing.Size(290, 40);
            this.btnToggleStatus.TabIndex = 11;
            this.btnToggleStatus.Text = "🔄 Toggle Active Status";
            this.btnToggleStatus.UseVisualStyleBackColor = false;
            this.btnToggleStatus.Click += new System.EventHandler(this.BtnToggleStatus_Click);

            // UserManagementForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = SwevenColors.LightPink;
            this.ClientSize = new System.Drawing.Size(1060, 650);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagementForm";
            this.Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnToggleStatus;
    }
}
