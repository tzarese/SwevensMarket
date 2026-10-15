namespace SwevensMarket.Utils
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; } = string.Empty;
        public static string FullName { get; set; } = string.Empty;
        public static string Role { get; set; } = string.Empty; // "Admin", "Staff", "Reseller", "Customer"

        public static void Clear()
        {
            UserId = 0;
            Username = string.Empty;
            FullName = string.Empty;
            Role = string.Empty;
        }
    }
}
