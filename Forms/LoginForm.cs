using System;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Utils;

namespace SwevensMarket.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
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

        private void BtnAdmin_Click(object? sender, EventArgs e)    { txtUsername.Text = "admin"; txtPassword.Text = "123"; }
        private void BtnStaff_Click(object? sender, EventArgs e)    { txtUsername.Text = "staff"; txtPassword.Text = "123"; }
        private void BtnReseller_Click(object? sender, EventArgs e) { txtUsername.Text = "reseller"; txtPassword.Text = "123"; }
        private void BtnCustomer_Click(object? sender, EventArgs e) { txtUsername.Text = "maria"; txtPassword.Text = "123"; }
    }
}
