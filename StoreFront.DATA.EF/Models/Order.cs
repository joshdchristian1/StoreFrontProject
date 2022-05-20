using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ShipAddress { get; set; } = null!;
        public string ShipCity { get; set; } = null!;
        public string? ShipState { get; set; }
        public string ShipZip { get; set; } = null!;
        public string ShipCountry { get; set; } = null!;
        public decimal? Freight { get; set; }
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
        public virtual UserDetail User { get; set; } = null!;
    }
}
