using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoreFront.DATA.EF.Models
{
    //internal class Partials
    //{
    //}

    #region Category
    [ModelMetadataType(typeof(CategoryMetadata))]
    public partial class Category { }
    #endregion

    #region Customer
    [ModelMetadataType(typeof(CustomerMetadata))]
    public partial class Customer { }
    #endregion

    #region Employee
    [ModelMetadataType(typeof(EmployeeMetadata))]
    public partial class Employee { }
    #endregion

    #region Order
    [ModelMetadataType(typeof(OrderMetadata))]
    public partial class Order { }
    #endregion

    #region Product
    [ModelMetadataType(typeof(ProductMetadata))]
    public partial class Product { }
    #endregion

    #region Supplier
    [ModelMetadataType(typeof(SupplierMetadata))]
    public partial class Supplier { }
    #endregion

    #region UserDetails
    [ModelMetadataType(typeof(UserDetailMetadata))]
    public partial class UserDetail { }
    #endregion

}
