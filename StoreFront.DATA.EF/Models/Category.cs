using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string CategoryName { get; set; } = null!;
        public string? CategoryDescription { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
