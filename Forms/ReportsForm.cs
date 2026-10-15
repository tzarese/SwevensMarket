using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwevensMarket.Data;
using SwevensMarket.Theme;

namespace SwevensMarket.Forms
{
    public class ReportsForm : Form
    {
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnGenerate;
        private Label lblTotalRev;
        private Label lblTotalOrd;
        private Label lblAvgVal;
        private DataGridView dgvReport;

        public ReportsForm()
        {
            InitializeComponent();
            GenerateReport();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(1060, 650);
            this.BackColor = SwevenColors.LightPink;

            var lblHeader = new Label
            {
                Text = "📊 Financial Reports & Sales Analytics",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = SwevenColors.TextColor,
                Location = new Point(20, 15),
                AutoSize = true
            };

            var lblFrom = new Label { Text = "From:", Location = new Point(20, 58), AutoSize = true, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold) };
            dtpStart = new DateTimePicker { Location = new Point(70, 55), Width = 130, Format = DateTimePickerFormat.Short, Value = DateTime.Now.AddDays(-30) };

            var lblTo = new Label { Text = "To:", Location = new Point(220, 58), AutoSize = true, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold) };
            dtpEnd = new DateTimePicker { Location = new Point(255, 55), Width = 130, Format = DateTimePickerFormat.Short, Value = DateTime.Now };

            btnGenerate = new Button
            {
                Text = "🔍 Generate Report",
                Location = new Point(410, 53),
                Size = new Size(150, 32),
                BackColor = SwevenColors.DarkPink,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.Click += (s, e) => GenerateReport();

            // 3 Stat Cards
            var pnlRev = CreateReportCard("Total Revenue", "₱0.00", SwevenColors.DarkPink, 20, 100, 320, 80, out lblTotalRev);
            var pnlOrd = CreateReportCard("Verified Orders", "0", Color.Teal, 360, 100, 320, 80, out lblTotalOrd);
            var pnlAvg = CreateReportCard("Average Transaction", "₱0.00", SwevenColors.SuccessGreen, 700, 100, 320, 80, out lblAvgVal);

            // Report Grid
            dgvReport = new DataGridView
            {
                Location = new Point(20, 200),
                Size = new Size(1000, 420),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            this.Controls.Add(lblHeader);
            this.Controls.Add(lblFrom);
            this.Controls.Add(dtpStart);
            this.Controls.Add(lblTo);
            this.Controls.Add(dtpEnd);
            this.Controls.Add(btnGenerate);
            this.Controls.Add(pnlRev);
            this.Controls.Add(pnlOrd);
            this.Controls.Add(pnlAvg);
            this.Controls.Add(dgvReport);
        }

        private Panel CreateReportCard(string title, string def, Color color, int x, int y, int w, int h, out Label valLabel)
        {
            var pnl = new Panel { Location = new Point(x, y), Size = new Size(w, h), BackColor = Color.White };
            var bar = new Panel { Dock = DockStyle.Left, Width = 6, BackColor = color };
            var lblT = new Label { Text = title, Location = new Point(16, 12), AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = SwevenColors.TextGray };
            valLabel = new Label { Text = def, Location = new Point(14, 34), AutoSize = true, Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = SwevenColors.TextColor };
            pnl.Controls.Add(bar);
            pnl.Controls.Add(lblT);
            pnl.Controls.Add(valLabel);
            return pnl;
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
    }
}
