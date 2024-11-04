using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Employee
    {
        [Key]
        [StringLength(5)]
        public string EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string NameEmployee { get; set; }

        public DateTime? Birthday { get; set; }

        [Required]
        [StringLength(3)]
        public string Gender { get; set; }

        [Required]
        [StringLength(100)]
        public string AddressEmployee { get; set; }

        [Required]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleEmployee { get; set; }

        [Required]
        [StringLength(1)]
        public string Active { get; set; }

        [Required]
        public string PassWordAccount { get; set; }

        public virtual ICollection<Order> Orders { get; set; } // Mối quan hệ một-nhiều với các đơn hàng (Orders)

        public Employee()
        {
            Orders = new HashSet<Order>();
        }
    }
}
