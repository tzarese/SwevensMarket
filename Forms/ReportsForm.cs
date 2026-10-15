using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            GenerateReport();
        }

        private void GenerateReport()
        {
            var verifiedOrders = DataStore.Orders
                .Where(o => o.GCashStatus == "Verified" && o.Date.Date >= dtpStart.Value.Date && o.Date.Date <= dtpEnd.Value.Date)
                .ToList();

            decimal totalRevenue = verifiedOrders.Sum(o => o.Amount);
            int count = verifiedOrders.Count;
            decimal avg = count > 0 ? totalRevenue / count : 0;

            lblTotalRev.Text = $"₱{totalRevenue:N2}";
            lblTotalOrd.Text = count.ToString();
            lblAvgVal.Text = $"₱{avg:N2}";

            dgvReport.DataSource = null;
            dgvReport.DataSource = verifiedOrders;
        }

        private void BtnGenerate_Click(object? sender, EventArgs e) => GenerateReport();
    }
}
