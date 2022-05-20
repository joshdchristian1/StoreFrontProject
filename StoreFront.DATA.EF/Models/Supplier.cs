using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Orders = new HashSet<Order>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
