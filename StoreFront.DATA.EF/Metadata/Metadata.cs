using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF.Models
{
    //internal class Metadata
    //{
    //}

    #region Category
    public class CategoryMetadata
    {
        //Since this is a PK, we should never see it in a view, or have to enter a value when creating/editing.
        //For those reasons, we will not need to apply any metadata to a PK
        public int CategoryId { get; set; }
        
        [StringLength(50)]
        [Display(Name = "Category")]
        public string? CategoryName { get; set; }
        [StringLength(100)]
        [Display(Name = "Description")]

        public string? CategoryDescription { get; set; }
    }
    #endregion

    #region Customer
    public class CustomerMetadata
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage = " *First Name is Required")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string? CustomerFirstName { get; set; }
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string CustomerLastName { get; set; } = null!;
        [Required(ErrorMessage = " *Phone # is Required")]
        [StringLength(10)]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string? CustomerPhone { get; set; }
        [Required(ErrorMessage = " *Email is Required")]
        [StringLength(50)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string? CustomerEmail { get; set; }
        [StringLength(50)]
        [Display(Name = "Address")]
        public string CustomerAddress { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "City")]
        public string CustomerCity { get; set; } = null!;
        [Required(ErrorMessage = " *State is Required")]
        [StringLength(2)]
        [Display(Name = "State")]
        public string? CustomerState { get; set; }
        [StringLength(10)]
        [Display(Name = "Zip")]
        public string CustomerZip { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "Country")]
        public string CustomerCountry { get; set; } = null!;
    }

    #endregion

    #region Employee
    public class EmployeeMetadata
    {
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;
        
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
       
        
        public int EmployeeId { get; set; }
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage =" *Position is required")]
        [StringLength(30)]
        public string? Position { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]//0:d => MM/dd/yyyy
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }
        [Required(ErrorMessage =" *DOB is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]//0:d => MM/dd/yyyy
        [Display(Name = "DOB")]
        public DateTime? BirthDate { get; set; }
    }
    #endregion


    #region Order
    public class OrderMetadata
    {

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        [StringLength(50)]
        [Display(Name = "Address")]
        public string ShipAddress { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "City")]
        public string ShipCity { get; set; } = null!;
        [Required(ErrorMessage =" *State is required")]
        [StringLength(2)]
        [Display(Name = "State")]
        public string? ShipState { get; set; }
        [StringLength(50)]
        [Display(Name = "Zip")]
        [DataType(DataType.PostalCode)]
        public string ShipZip { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "Country")]
        public string ShipCountry { get; set; } = null!;
        [Required(ErrorMessage = " *Freight is required")]        
        [Display(Name = "Freight")]
        [DataType(DataType.Currency)]
        public decimal? Freight { get; set; }
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }


    }
    #endregion

    #region Product
    public class ProductMetadata
    {
        public int ProductId { get; set; }
        [StringLength(50)]
        [Display(Name ="Product")]
        public string ProductName { get; set; } = null!;
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }
        [StringLength(200)]
        [Display(Name = "Description")]
        public string ProductDescription { get; set; } = null!;
        [Display(Name = "Quantity")]
        [Required(ErrorMessage =" *Quantity is required")]
        public int? ProductQuantity { get; set; }
        [Display(Name = "Units on Order")]
        [Required(ErrorMessage = " *Units on Order is required")]
        public int? ProductOnOrder { get; set; }
        public int CategoryId { get; set; }
        //[Required(ErrorMessage = " *Image is required")]
        [StringLength(170)]
        [Display(Name = "Product Image")]
        public string? ProductImage { get; set; }
    }
    #endregion

    #region Supplier
    public class SupplierMetadata
    {
        public int SupplierId { get; set; }
        [StringLength(50)]
        [Display(Name = "Supplier")]
        public string SupplierName { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "Address")]
        public string Address { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "City")]
        public string City { get; set; } = null!;
        [Required(ErrorMessage = " *State is required")]
        [StringLength(2)]
        [Display(Name = "State")]
        public string? State { get; set; }
        [Required(ErrorMessage = " *Zip is required")]
        [StringLength(50)]
        [Display(Name = "Zip")]
        [DataType(DataType.PostalCode)]
        public string? Zip { get; set; }
        [Required(ErrorMessage = " *Country is required")]
        [StringLength(50)]
        [Display(Name = "Country")]
        public string? Country { get; set; }
    }
    #endregion

    #region UserDetails
    public class UserDetailMetadata
    {
        public int UserId { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
        [Required(ErrorMessage = " *Address is required")]
        [StringLength(150)]
        [Display(Name = "Address")]
        public string? Address { get; set; }
        [Required(ErrorMessage = " *City is required")]
        [StringLength(50)]
        [Display(Name = "City")]
        public string? City { get; set; }
        [Required(ErrorMessage = " *State is required")]
        [StringLength(2)]
        [Display(Name = "State")]
        public string? State { get; set; }
        [StringLength(5)]
        [Display(Name = "Zip")]
        [DataType(DataType.PostalCode)]
        public string? Zip { get; set; }
        [StringLength(24)]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
    }
    #endregion
}
