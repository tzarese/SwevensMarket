using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public class UserManagementForm : Form
    {
        private DataGridView dgvUsers;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private ComboBox cmbRole;
        private CheckBox chkActive;
        private Button btnAddUser;
        private Button btnToggleStatus;

        public UserManagementForm()
        {
            InitializeComponent();
            RefreshUsers();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(1060, 650);
            this.BackColor = SwevenColors.LightPink;

            var lblHeader = new Label
            {
                Text = "👥 User Management",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(20, 15),
                AutoSize = true
            };

            // User Table
            dgvUsers = new DataGridView
            {
                Location = new Point(20, 55),
                Size = new Size(680, 570),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Create / Edit User Panel
            var pnlForm = new Panel
            {
                Location = new Point(720, 55),
                Size = new Size(320, 570),
                BackColor = Color.White,
                Padding = new Padding(20)
            };

            var lblFormTitle = new Label { Text = "Add New User Account", Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = SwevenColors.DarkPink, Location = new Point(15, 15), AutoSize = true };

            var lblU = new Label { Text = "Username", Location = new Point(15, 55), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            txtUsername = new TextBox { Location = new Point(15, 75), Size = new Size(290, 28) };

            var lblP = new Label { Text = "Password", Location = new Point(15, 115), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            txtPassword = new TextBox { Location = new Point(15, 135), Size = new Size(290, 28), UseSystemPasswordChar = true };

            var lblF = new Label { Text = "Full Name", Location = new Point(15, 175), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            txtFullName = new TextBox { Location = new Point(15, 195), Size = new Size(290, 28) };

            var lblR = new Label { Text = "Role", Location = new Point(15, 235), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            cmbRole = new ComboBox { Location = new Point(15, 255), Size = new Size(290, 28), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbRole.Items.AddRange(new string[] { "Admin", "Staff", "Reseller", "Customer" });
            cmbRole.SelectedIndex = 1;

            chkActive = new CheckBox { Text = "Account Active", Location = new Point(15, 295), Checked = true, AutoSize = true, Font = new Font("Segoe UI", 9) };

            btnAddUser = new Button
            {
                Text = "+ Create User",
                Location = new Point(15, 335),
                Size = new Size(290, 40),
                BackColor = SwevenColors.DarkPink,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.Click += BtnAddUser_Click;

            btnToggleStatus = new Button
            {
                Text = "🔄 Toggle Active Status",
                Location = new Point(15, 385),
                Size = new Size(290, 40),
                BackColor = SwevenColors.MainPink,
                ForeColor = SwevenColors.TextColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnToggleStatus.FlatAppearance.BorderColor = SwevenColors.DarkPink;
            btnToggleStatus.Click += BtnToggleStatus_Click;

            pnlForm.Controls.Add(lblFormTitle);
            pnlForm.Controls.Add(lblU);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblP);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(lblF);
            pnlForm.Controls.Add(txtFullName);
            pnlForm.Controls.Add(lblR);
            pnlForm.Controls.Add(cmbRole);
            pnlForm.Controls.Add(chkActive);
            pnlForm.Controls.Add(btnAddUser);
            pnlForm.Controls.Add(btnToggleStatus);

            this.Controls.Add(lblHeader);
            this.Controls.Add(dgvUsers);
            this.Controls.Add(pnlForm);
        }

        private void RefreshUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = DataStore.Users.ToList();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (DataStore.Users.Any(u => u.Username.Equals(txtUsername.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Username already exists!");
                return;
            }

            DataStore.Users.Add(new User
            {
                Id = DataStore.Users.Count + 1,
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString(),
                IsActive = chkActive.Checked
            });

            RefreshUsers();
            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUsername.Clear();
            txtPassword.Clear();
            txtFullName.Clear();
        }

        private void BtnToggleStatus_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow?.DataBoundItem is User u)
            {
                u.IsActive = !u.IsActive;
                RefreshUsers();
                MessageBox.Show($"Account for {u.Username} is now {(u.IsActive ? "ACTIVE" : "INACTIVE")}.");
            }
        }
    }
}
