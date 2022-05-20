using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
        public int EmployeeId { get; set; }
        public int PhoneNumber { get; set; }
        public string? Position { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
