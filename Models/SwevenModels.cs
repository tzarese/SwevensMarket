using System;
using System.Collections.Generic;

namespace SwevensMarket.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Role { get; set; } = "Customer"; // "Admin", "Staff", "Reseller", "Customer"
        public bool IsActive { get; set; } = true;
    }

    public class Product
    {
        public string Id { get; set; } = string.Empty;       // e.g. "P001"
        public string Name { get; set; } = string.Empty;     // e.g. "86 Diamonds"
        public string Category { get; set; } = string.Empty; // e.g. "Mobile Legends", "Valorant", "Roblox"
        public decimal Price { get; set; }                   // e.g. 50.00m
        public string Status { get; set; } = "Active";       // "Active" or "Inactive"
        public string Description { get; set; } = string.Empty;
    }

    public class Order
    {
        public string OrderId { get; set; } = string.Empty;              // e.g. "OR0001"
        public DateTime Date { get; set; }
        public string Customer { get; set; } = string.Empty;
        public string Product { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string GCashReferenceNo { get; set; } = string.Empty;     // 13-digit ref
        public string GCashStatus { get; set; } = "Pending";             // "Pending", "Verified", "Rejected"
        public string OrderStatus { get; set; } = "Pending";             // "Pending", "Processing", "Completed", "Cancelled"
        public string ProofImagePath { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
    }
}
