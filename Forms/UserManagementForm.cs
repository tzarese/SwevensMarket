using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Models;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            RefreshUsers();
        }

        private void RefreshUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = DataStore.Users.ToList();
        }

        private void BtnAddUser_Click(object? sender, EventArgs e)
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
                Role = cmbRole.SelectedItem!.ToString() ?? "Staff",
                IsActive = chkActive.Checked
            });

            RefreshUsers();
            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUsername.Clear();
            txtPassword.Clear();
            txtFullName.Clear();
        }

        private void BtnToggleStatus_Click(object? sender, EventArgs e)
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
