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
            new Product { Id = "P001", Name = "86 Diamonds", Category = "Mobile Legends", Price = 50.00m, Status = "Active", Description = "Instant top-up for MLBB" },
            new Product { Id = "P002", Name = "172 Diamonds", Category = "Mobile Legends", Price = 100.00m, Status = "Active", Description = "Instant top-up for MLBB" },
            new Product { Id = "P003", Name = "Valorant Points", Category = "Valorant", Price = 299.00m, Status = "Active", Description = "Riot Games Valorant Points" },
            new Product { Id = "P004", Name = "CODM CP", Category = "Call of Duty Mobile", Price = 100.00m, Status = "Active", Description = "Call of Duty Mobile CP Points" },
            new Product { Id = "P005", Name = "Roblox Robux", Category = "Roblox", Price = 500.00m, Status = "Inactive", Description = "Roblox digital gift code" },
            new Product { Id = "P006", Name = "Netflix Gift Card", Category = "Digital Service", Price = 200.00m, Status = "Active", Description = "1 Month Subscription Pin" }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order { OrderId = "OR0001", Date = DateTime.Parse("2026-09-13 10:24"), Customer = "Maria Santos", Product = "86 Diamonds", Amount = 50.00m, GCashReferenceNo = "1234567890123", GCashStatus = "Verified", OrderStatus = "Completed" },
            new Order { OrderId = "OR0002", Date = DateTime.Parse("2026-09-13 09:15"), Customer = "Juan Dela Cruz", Product = "Valorant Points", Amount = 300.00m, GCashReferenceNo = "9876543210123", GCashStatus = "Pending", OrderStatus = "Processing" },
            new Order { OrderId = "OR0003", Date = DateTime.Parse("2026-09-12 16:30"), Customer = "Ana Lopez", Product = "CODM CP", Amount = 100.00m, GCashReferenceNo = "1122334455123", GCashStatus = "Pending", OrderStatus = "Pending" },
            new Order { OrderId = "OR0004", Date = DateTime.Parse("2026-09-12 11:20"), Customer = "Mark Reyes", Product = "Roblox Robux", Amount = 500.00m, GCashReferenceNo = "6677889900123", GCashStatus = "Verified", OrderStatus = "Completed" },
            new Order { OrderId = "OR0005", Date = DateTime.Parse("2026-09-11 15:12"), Customer = "Liza Cruz", Product = "Netflix Gift Card", Amount = 200.00m, GCashReferenceNo = "9988776655123", GCashStatus = "Rejected", OrderStatus = "Cancelled" }
        };
    }
}
