﻿namespace StockManagement.Models
{
    public class Users
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool? IsActive{ get; set; }
    }
}
