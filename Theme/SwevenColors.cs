using System.Drawing;

namespace SwevensMarket.Theme
{
    public static class SwevenColors
    {
        // Primary Brand Colors from Design Specification
        public static readonly Color MainPink      = ColorTranslator.FromHtml("#FDE7F0"); // Left panels, cards
        public static readonly Color DarkPink      = ColorTranslator.FromHtml("#EC4899"); // Buttons, primary accents
        public static readonly Color LightPink     = ColorTranslator.FromHtml("#FFF5F8"); // Background of forms
        public static readonly Color CardBg        = ColorTranslator.FromHtml("#FFF5F8"); // Main content container background
        public static readonly Color TextColor     = ColorTranslator.FromHtml("#7B3F5E"); // Main title & body text
        public static readonly Color White         = ColorTranslator.FromHtml("#FFFFFF");

        // Status Badges & Action Colors
        public static readonly Color SuccessGreen  = ColorTranslator.FromHtml("#28A745"); // Verified / Completed
        public static readonly Color WarningYellow = ColorTranslator.FromHtml("#FFC107"); // Pending / Warning
        public static readonly Color DangerRed     = ColorTranslator.FromHtml("#DC3545"); // Rejected / Cancelled
        public static readonly Color InfoBlue      = ColorTranslator.FromHtml("#6366F1"); // Details / Info
        public static readonly Color TextGray      = ColorTranslator.FromHtml("#6C757D"); // Subtitles, borders
        public static readonly Color LightGray     = ColorTranslator.FromHtml("#F3F4F6"); // Disabled / ReadOnly text
    }
}
