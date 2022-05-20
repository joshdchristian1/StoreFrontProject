using System;
using System.Collections.Generic;

namespace StoreFront.UI.MVC.Models
{
    public partial class ProductStatus
    {
        public bool? IsInStock { get; set; }
        public bool IsBackOrdered { get; set; }
        public bool IsDiscontinued { get; set; }
        public int ProductId { get; set; }
        public int ProductStatusId { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
