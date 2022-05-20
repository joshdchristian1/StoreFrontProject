using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string? CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; } = null!;
        public string? CustomerPhone { get; set; }
        public string? CustomerEmail { get; set; }
        public string CustomerAddress { get; set; } = null!;
        public string CustomerCity { get; set; } = null!;
        public string? CustomerState { get; set; }
        public string CustomerZip { get; set; } = null!;
        public string CustomerCountry { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
