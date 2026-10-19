using System;
using System.Collections.Generic;
using SwevensMarket.Models;

namespace SwevensMarket.Data
{
    public static class DataStore
    {
        public static List<User> Users = new List<User>
        {
            new User { Id = 1, Username = "admin", Password = "123", FullName = "System Admin", Role = "Admin" },
            new User { Id = 2, Username = "staff", Password = "123", FullName = "Store Staff", Role = "Staff" },
            new User { Id = 3, Username = "reseller", Password = "123", FullName = "VIP Reseller", Role = "Reseller" },
            new User { Id = 4, Username = "maria", Password = "123", FullName = "Maria Santos", Role = "Customer" }
        };

        public static List<Product> Products = new List<Product>
        {
            // === MLBB CATEGORY ===
            new Product { Id = "P001", Name = "86 Diamonds", Category = "MLBB", Price = 50.00m, Status = "Active", Description = "Instant top-up for Mobile Legends (PH Server)" },
            new Product { Id = "P002", Name = "172 Diamonds", Category = "MLBB", Price = 100.00m, Status = "Active", Description = "Instant top-up for Mobile Legends (PH Server)" },
            new Product { Id = "P003", Name = "257 Diamonds", Category = "MLBB", Price = 150.00m, Status = "Active", Description = "Instant top-up for Mobile Legends (PH Server)" },
            new Product { Id = "P004", Name = "706 Diamonds", Category = "MLBB", Price = 400.00m, Status = "Active", Description = "Instant top-up for Mobile Legends (PH Server)" },
            new Product { Id = "P005", Name = "Weekly Diamond Pass", Category = "MLBB", Price = 110.00m, Status = "Active", Description = "Claim 30 diamonds daily for 7 days" },
            new Product { Id = "P006", Name = "Twilight Pass", Category = "MLBB", Price = 500.00m, Status = "Active", Description = "Seasonal MLBB Battle Pass unlock" },
            new Product { Id = "P007", Name = "Verified Squad Slot Rental", Category = "MLBB", Price = 250.00m, Status = "Active", Description = "30-Day Verified Squad tag and verification badge" },

            // === GAMES CATEGORY ===
            new Product { Id = "P008", Name = "Valorant (1,000 VP)", Category = "Games", Price = 400.00m, Status = "Active", Description = "Riot Games Valorant Points (PH/SEA Server)" },
            new Product { Id = "P009", Name = "Call of Duty Mobile (320 CP)", Category = "Games", Price = 150.00m, Status = "Active", Description = "Garena CODM Battle Points for crates and draws" },
            new Product { Id = "P010", Name = "Roblox (400 Robux)", Category = "Games", Price = 250.00m, Status = "Active", Description = "Roblox in-game digital avatar currency" },
            new Product { Id = "P011", Name = "Genshin Welkin Moon", Category = "Games", Price = 250.00m, Status = "Active", Description = "HoYoverse Genshin Impact 30-Day Blessing of the Welkin Moon" },
            new Product { Id = "P012", Name = "Honkai: Star Rail Express Pass", Category = "Games", Price = 250.00m, Status = "Active", Description = "Honkai: Star Rail 30-Day Express Supply Pass" },
            new Product { Id = "P013", Name = "Free Fire (210 Diamonds)", Category = "Games", Price = 100.00m, Status = "Active", Description = "Garena Free Fire instant top-up (PH)" },
            new Product { Id = "P014", Name = "Point Blank (1,000 PB Cash)", Category = "Games", Price = 100.00m, Status = "Active", Description = "Zepetto Point Blank PH in-game cash points" },
            new Product { Id = "P015", Name = "Arena Breakout (60 Bonds)", Category = "Games", Price = 60.00m, Status = "Active", Description = "Arena Breakout military bonds top-up" },
            new Product { Id = "P016", Name = "Growtopia (10 Diamond Locks)", Category = "Games", Price = 180.00m, Status = "Inactive", Description = "Ubisoft Growtopia World currency" },

            // === VOUCHER CATEGORY ===
            new Product { Id = "P017", Name = "Steam Wallet ₱100", Category = "Voucher", Price = 115.00m, Status = "Active", Description = "Valve Steam Wallet digital pin code (PHP)" },
            new Product { Id = "P018", Name = "Steam Wallet ₱500", Category = "Voucher", Price = 540.00m, Status = "Active", Description = "Valve Steam Wallet digital pin code (PHP)" },
            new Product { Id = "P019", Name = "Razer Gold PH ₱100", Category = "Voucher", Price = 105.00m, Status = "Active", Description = "Razer Gold electronic gaming pin code" },
            new Product { Id = "P020", Name = "UniPin Voucher ₱100", Category = "Voucher", Price = 100.00m, Status = "Active", Description = "UniPin Philippines electronic wallet voucher" },
            new Product { Id = "P021", Name = "PlayStation Store ₱500", Category = "Voucher", Price = 520.00m, Status = "Active", Description = "Sony PlayStation Network eShop wallet top-up code" },
            new Product { Id = "P022", Name = "Discord Nitro (1 Month)", Category = "Voucher", Price = 260.00m, Status = "Active", Description = "Discord Nitro full subscription gift link" },
            new Product { Id = "P023", Name = "Nintendo Switch Online (3 Mos)", Category = "Voucher", Price = 450.00m, Status = "Active", Description = "Nintendo eShop Membership code" },
            new Product { Id = "P024", Name = "Binance Gift Card (5 USDT)", Category = "Voucher", Price = 300.00m, Status = "Active", Description = "Binance crypto voucher redemption code" },

            // === ENTERTAINMENT CATEGORY ===
            new Product { Id = "P025", Name = "Bigo Live (210 Diamonds)", Category = "Entertainment", Price = 200.00m, Status = "Active", Description = "Bigo Live live-streaming diamonds top-up" },
            new Product { Id = "P026", Name = "Telegram Stars (50 Stars)", Category = "Entertainment", Price = 75.00m, Status = "Active", Description = "Telegram in-app reactions and bot payment stars" },
            new Product { Id = "P027", Name = "Litmatch (120 Diamonds)", Category = "Entertainment", Price = 100.00m, Status = "Active", Description = "Litmatch VIP party and chat diamonds" },
            new Product { Id = "P028", Name = "Smart / TNT Load ₱100", Category = "Entertainment", Price = 98.00m, Status = "Active", Description = "Smart and Talk 'N Text regular prepaid airtime load" },
            new Product { Id = "P029", Name = "Globe / TM Load ₱100", Category = "Entertainment", Price = 98.00m, Status = "Active", Description = "Globe and Touch Mobile regular prepaid airtime load" },
            new Product { Id = "P030", Name = "DITO Load ₱100", Category = "Entertainment", Price = 98.00m, Status = "Active", Description = "DITO Telecommunity regular prepaid airtime load" },
            new Product { Id = "P031", Name = "DramaBox VIP (1 Month)", Category = "Entertainment", Price = 199.00m, Status = "Active", Description = "DramaBox Short Drama Streaming VIP membership pass" }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order { OrderId = "OR0001", Date = DateTime.Now.AddDays(-5).AddHours(2), Customer = "Maria Santos", Product = "86 Diamonds", Amount = 50.00m, GCashReferenceNo = "1002345678901", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "Target ID: 12345678 (3001)" },
            new Order { OrderId = "OR0002", Date = DateTime.Now.AddDays(-4).AddHours(4), Customer = "Juan Dela Cruz", Product = "Valorant (1,000 VP)", Amount = 400.00m, GCashReferenceNo = "1008765432109", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "Riot ID: Juan#PH1" },
            new Order { OrderId = "OR0003", Date = DateTime.Now.AddDays(-3).AddHours(1), Customer = "Patrick Lance Paz", Product = "Call of Duty Mobile (320 CP)", Amount = 150.00m, GCashReferenceNo = "1009988776655", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "UID: 6748923011" },
            new Order { OrderId = "OR0004", Date = DateTime.Now.AddDays(-3).AddHours(6), Customer = "Angel Ann Fajardo", Product = "Genshin Welkin Moon", Amount = 250.00m, GCashReferenceNo = "1001122334455", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "UID: 801239841 (Asia)" },
            new Order { OrderId = "OR0005", Date = DateTime.Now.AddDays(-2).AddHours(3), Customer = "Ericca Marquez", Product = "Weekly Diamond Pass", Amount = 110.00m, GCashReferenceNo = "1005544332211", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "Target ID: 90234112 (3200)" },
            new Order { OrderId = "OR0006", Date = DateTime.Now.AddDays(-2).AddHours(7), Customer = "Marbhel Rucio", Product = "Steam Wallet ₱500", Amount = 540.00m, GCashReferenceNo = "1006677889900", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "Steam Profile: MarbhelPH" },
            new Order { OrderId = "OR0007", Date = DateTime.Now.AddDays(-1).AddHours(2), Customer = "Myzel Umali Ramos", Product = "Honkai: Star Rail Express Pass", Amount = 250.00m, GCashReferenceNo = "1007788990011", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "UID: 800923145 (Asia)" },
            new Order { OrderId = "OR0008", Date = DateTime.Now.AddDays(-1).AddHours(5), Customer = "Prinsesa Gabriela Calaolao", Product = "Discord Nitro (1 Month)", Amount = 260.00m, GCashReferenceNo = "1008899001122", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "Discord: gabriela#0001" },
            new Order { OrderId = "OR0009", Date = DateTime.Now.AddDays(-1).AddHours(8), Customer = "Charese Macalalad Jolo", Product = "706 Diamonds", Amount = 400.00m, GCashReferenceNo = "1009900112233", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "Target ID: 77239102 (3099)" },
            new Order { OrderId = "OR0010", Date = DateTime.Now.AddHours(-10), Customer = "Mark Reyes", Product = "Roblox (400 Robux)", Amount = 250.00m, GCashReferenceNo = "1001231231234", GCashStatus = "Verified", OrderStatus = "Completed", Remarks = "User: MarkRoblox" },
            new Order { OrderId = "OR0011", Date = DateTime.Now.AddHours(-6), Customer = "Liza Cruz", Product = "UniPin Voucher ₱100", Amount = 100.00m, GCashReferenceNo = "1009999888877", GCashStatus = "Rejected", OrderStatus = "Cancelled", Remarks = "Screenshot invalid / altered reference" },
            new Order { OrderId = "OR0012", Date = DateTime.Now.AddHours(-4), Customer = "Ana Lopez", Product = "Telegram Stars (50 Stars)", Amount = 75.00m, GCashReferenceNo = "1004455667788", GCashStatus = "Verified", OrderStatus = "Processing", Remarks = "Username: @analopez" },
            new Order { OrderId = "OR0013", Date = DateTime.Now.AddHours(-3), Customer = "Kenji Takahashi", Product = "Smart / TNT Load ₱100", Amount = 98.00m, GCashReferenceNo = "1003344556677", GCashStatus = "Pending", OrderStatus = "Processing", Remarks = "Mobile: 09191234567" },
            new Order { OrderId = "OR0014", Date = DateTime.Now.AddHours(-2), Customer = "Bea Alonzo", Product = "Bigo Live (210 Diamonds)", Amount = 200.00m, GCashReferenceNo = "1002233445566", GCashStatus = "Pending", OrderStatus = "Pending", Remarks = "Bigo ID: 88991122" },
            new Order { OrderId = "OR0015", Date = DateTime.Now.AddHours(-1), Customer = "Christian Bale", Product = "PlayStation Store ₱500", Amount = 520.00m, GCashReferenceNo = "1001122112233", GCashStatus = "Pending", OrderStatus = "Pending", Remarks = "PSN: DarkKnightPH" },
            new Order { OrderId = "OR0016", Date = DateTime.Now.AddMinutes(-20), Customer = "Maria Santos", Product = "172 Diamonds", Amount = 100.00m, GCashReferenceNo = "1007766554433", GCashStatus = "Pending", OrderStatus = "Pending", Remarks = "Target ID: 12345678 (3001)" }
        };
    }
}
