using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
            ProductStatuses = new HashSet<ProductStatus>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; } = null!;
        public int? ProductQuantity { get; set; }
        public int? ProductOnOrder { get; set; }
        public int CategoryId { get; set; }
        public string? ProductImage { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductStatus> ProductStatuses { get; set; }
    }
}
