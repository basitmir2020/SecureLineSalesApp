using System;
using System.Collections.Generic;

namespace SecureLineSalesApp.Models
{
    public partial class User
    {
        public long Id { get; set; }
        public string Fname { get; set; } = null!;
        public string? Lname { get; set; }
        public string? Parentage { get; set; }
        public string? Address { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string MobileNumber { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
