using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SwevensMarket.Theme
{
    public static class CuteColors
    {
        // 🌸 Cute Pastel Pink Theme Palette
        public static readonly Color BlushBg       = ColorTranslator.FromHtml("#FFF0F5"); // Lavender blush / soft pink background
        public static readonly Color CardBg        = ColorTranslator.FromHtml("#FFFFFF"); // Crisp white cards
        public static readonly Color PastelPink    = ColorTranslator.FromHtml("#FDE2E4"); // Soft pastel pink for sidebars & panels
        public static readonly Color SweetPink     = ColorTranslator.FromHtml("#FFB3C6"); // Medium pink accent
        public static readonly Color StrawberryHot = ColorTranslator.FromHtml("#FF4D8D"); // Vibrant cute strawberry pink for main buttons
        public static readonly Color DeepBerry     = ColorTranslator.FromHtml("#5E2145"); // Deep warm berry wine for text (super readable & cute)
        public static readonly Color MutedBerry    = ColorTranslator.FromHtml("#9E587F"); // Subtitle text
        public static readonly Color RibbonPink    = ColorTranslator.FromHtml("#FF85A2"); // Ribbon & mascot bow color
        public static readonly Color PeachGlow     = ColorTranslator.FromHtml("#FFE5EC"); // Hover & card highlights

        // Status Colors (Cute Pastels)
        public static readonly Color CuteMintGreen = ColorTranslator.FromHtml("#38B000"); // Verified / Completed
        public static readonly Color CuteBanana    = ColorTranslator.FromHtml("#FFB703"); // Pending
        public static readonly Color CuteRoseRed   = ColorTranslator.FromHtml("#E63946"); // Rejected / Cancelled
    }

    /// <summary>
    /// Smooth rounded button with gradient and cute hover effects.
    /// </summary>
    public class CuteButton : Button
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius { get; set; } = 20;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color NormalColor { get; set; } = CuteColors.StrawberryHot;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverColor { get; set; } = ColorTranslator.FromHtml("#FF6B9E");

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ClickColor { get; set; } = ColorTranslator.FromHtml("#E02B6F");

        private bool isHovered = false;
        private bool isPressed = false;

        public CuteButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(160, 42);
            this.BackColor = NormalColor;
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true;

            this.MouseEnter += (s, e) => { isHovered = true; Invalidate(); };
            this.MouseLeave += (s, e) => { isHovered = false; isPressed = false; Invalidate(); };
            this.MouseDown += (s, e) => { isPressed = true; Invalidate(); };
            this.MouseUp += (s, e) => { isPressed = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color currentBg = isPressed ? ClickColor : (isHovered ? HoverColor : NormalColor);

            using (var path = GetRoundPath(new Rectangle(0, 0, Width - 1, Height - 1), BorderRadius))
            using (var brush = new SolidBrush(currentBg))
            using (var borderPen = new Pen(Color.FromArgb(40, Color.White), 1.5f))
            {
                this.Region = new Region(path);
                g.FillPath(brush, path);
                g.DrawPath(borderPen, path);
            }

            // Center Text with nice padding
            TextRenderer.DrawText(g, this.Text, this.Font, this.ClientRectangle, this.ForeColor,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        public static GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius;
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }
    }

    /// <summary>
    /// Cute rounded card panel with soft pastel border.
    /// </summary>
    public class CuteCardPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius { get; set; } = 18;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color CardBorderColor { get; set; } = CuteColors.SweetPink;

        public CuteCardPanel()
        {
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
            this.Padding = new Padding(15);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = CuteButton.GetRoundPath(new Rectangle(0, 0, Width - 1, Height - 1), BorderRadius))
            using (var brush = new SolidBrush(this.BackColor))
            using (var pen = new Pen(CardBorderColor, 1.5f))
            {
                this.Region = new Region(path);
                g.FillPath(brush, path);
                g.DrawPath(pen, path);
            }
        }
    }

    /// <summary>
    /// Utility methods to style DataGridViews and controls with cute aesthetics.
    /// </summary>
    public static class CuteThemeHelper
    {
        public static void ApplyCuteGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = ColorTranslator.FromHtml("#FFE5EC");
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowTemplate.Height = 36;
            dgv.Font = new Font("Segoe UI", 9.5f);

            // Header styling
            dgv.ColumnHeadersDefaultCellStyle.BackColor = CuteColors.PastelPink;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = CuteColors.DeepBerry;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 42;

            // Rows styling
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = CuteColors.DeepBerry;
            dgv.DefaultCellStyle.SelectionBackColor = CuteColors.PeachGlow;
            dgv.DefaultCellStyle.SelectionForeColor = CuteColors.DeepBerry;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFF9FB");
        }

        /// <summary>
        /// Draws a cute cat mascot with pink bow & gaming controller.
        /// </summary>
        public static Image GenerateCuteMascot(int width = 200, int height = 200)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                // Ears (White triangles with pink inner)
                using (var brushWhite = new SolidBrush(Color.White))
                using (var brushPink = new SolidBrush(CuteColors.SweetPink))
                using (var outlinePen = new Pen(CuteColors.DeepBerry, 2.5f))
                {
                    // Left ear
                    Point[] leftEar = { new Point(50, 80), new Point(70, 30), new Point(95, 70) };
                    g.FillPolygon(brushWhite, leftEar);
                    g.DrawPolygon(outlinePen, leftEar);
                    Point[] leftInner = { new Point(58, 75), new Point(72, 42), new Point(88, 70) };
                    g.FillPolygon(brushPink, leftInner);

                    // Right ear
                    Point[] rightEar = { new Point(105, 70), new Point(130, 30), new Point(150, 80) };
                    g.FillPolygon(brushWhite, rightEar);
                    g.DrawPolygon(outlinePen, rightEar);
                    Point[] rightInner = { new Point(112, 70), new Point(128, 42), new Point(142, 75) };
                    g.FillPolygon(brushPink, rightInner);

                    // Cat Head (soft round ellipse)
                    g.FillEllipse(brushWhite, 45, 55, 110, 95);
                    g.DrawEllipse(outlinePen, 45, 55, 110, 95);

                    // Cute Big Eyes
                    using (var eyeBrush = new SolidBrush(CuteColors.DeepBerry))
                    using (var glintBrush = new SolidBrush(Color.White))
                    {
                        g.FillEllipse(eyeBrush, 68, 85, 16, 22);
                        g.FillEllipse(eyeBrush, 116, 85, 16, 22);
                        // Eye sparkles
                        g.FillEllipse(glintBrush, 72, 88, 6, 8);
                        g.FillEllipse(glintBrush, 120, 88, 6, 8);
                        g.FillEllipse(glintBrush, 76, 98, 3, 3);
                        g.FillEllipse(glintBrush, 124, 98, 3, 3);
                    }

                    // Blush cheeks
                    using (var blushBrush = new SolidBrush(Color.FromArgb(140, 255, 182, 193)))
                    {
                        g.FillEllipse(blushBrush, 55, 102, 22, 14);
                        g.FillEllipse(blushBrush, 123, 102, 22, 14);
                    }

                    // Cute Nose & Smile (ω)
                    using (var noseBrush = new SolidBrush(CuteColors.StrawberryHot))
                    {
                        g.FillPolygon(noseBrush, new Point[] { new Point(97, 102), new Point(103, 102), new Point(100, 106) });
                    }
                    g.DrawArc(outlinePen, 92, 104, 8, 8, 0, 180);
                    g.DrawArc(outlinePen, 100, 104, 8, 8, 0, 180);

                    // Whiskers
                    using (var whiskerPen = new Pen(CuteColors.DeepBerry, 1.8f))
                    {
                        g.DrawLine(whiskerPen, 42, 98, 60, 102);
                        g.DrawLine(whiskerPen, 40, 108, 58, 108);
                        g.DrawLine(whiskerPen, 140, 102, 158, 98);
                        g.DrawLine(whiskerPen, 142, 108, 160, 108);
                    }

                    // Big Pink Ribbon Bow
                    using (var ribbonBrush = new SolidBrush(CuteColors.StrawberryHot))
                    {
                        // Left bow wing
                        g.FillEllipse(ribbonBrush, 78, 28, 22, 16);
                        // Right bow wing
                        g.FillEllipse(ribbonBrush, 100, 28, 22, 16);
                        // Center knot
                        using (var knotBrush = new SolidBrush(CuteColors.SweetPink))
                        {
                            g.FillEllipse(knotBrush, 93, 30, 14, 14);
                        }
                    }

                    // Gaming Controller (Held in paws)
                    using (var padBrush = new SolidBrush(CuteColors.SweetPink))
                    {
                        g.FillEllipse(padBrush, 70, 135, 60, 30);
                        g.DrawEllipse(outlinePen, 70, 135, 60, 30);

                        // Buttons & D-Pad on controller
                        using (var btnBrush = new SolidBrush(Color.White))
                        {
                            g.FillEllipse(btnBrush, 80, 146, 7, 7); // D-pad
                            g.FillEllipse(btnBrush, 112, 144, 6, 6); // A/B
                            g.FillEllipse(btnBrush, 118, 150, 6, 6);
                        }
                    }

                    // Paws holding controller
                    g.FillEllipse(brushWhite, 66, 140, 16, 16);
                    g.DrawEllipse(outlinePen, 66, 140, 16, 16);
                    g.FillEllipse(brushWhite, 118, 140, 16, 16);
                    g.DrawEllipse(outlinePen, 118, 140, 16, 16);
                }
            }
            return bmp;
        }

        /// <summary>
        /// Generates a cute pink bow ribbon graphic.
        /// </summary>
        public static Image GeneratePinkBow(int width = 80, int height = 60)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                using (var brush = new SolidBrush(CuteColors.StrawberryHot))
                using (var pen = new Pen(CuteColors.DeepBerry, 2f))
                using (var knotBrush = new SolidBrush(CuteColors.SweetPink))
                {
                    // Left loop
                    Point[] leftLoop = { new Point(40, 30), new Point(12, 12), new Point(8, 45), new Point(40, 32) };
                    g.FillPolygon(brush, leftLoop);
                    g.DrawPolygon(pen, leftLoop);

                    // Right loop
                    Point[] rightLoop = { new Point(40, 30), new Point(68, 12), new Point(72, 45), new Point(40, 32) };
                    g.FillPolygon(brush, rightLoop);
                    g.DrawPolygon(pen, rightLoop);

                    // Tails
                    Point[] leftTail = { new Point(36, 32), new Point(22, 56), new Point(32, 54), new Point(38, 34) };
                    g.FillPolygon(brush, leftTail);
                    g.DrawPolygon(pen, leftTail);

                    Point[] rightTail = { new Point(44, 32), new Point(58, 56), new Point(48, 54), new Point(42, 34) };
                    g.FillPolygon(brush, rightTail);
                    g.DrawPolygon(pen, rightTail);

                    // Center knot
                    g.FillEllipse(knotBrush, 33, 23, 16, 16);
                    g.DrawEllipse(pen, 33, 23, 16, 16);
                }
            }
            return bmp;
        }
    }
}
