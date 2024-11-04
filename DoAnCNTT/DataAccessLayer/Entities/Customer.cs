using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Customer
    {
        [Key]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string NameCustomer { get; set; }

        public DateTime? Birthday { get; set; }

        [Required]
        [StringLength(3)]
        public string Gender { get; set; }

        public int? Point { get; set; }

        public virtual ICollection<Order> Orders { get; set; } // Mối quan hệ một-nhiều với các đơn hàng (Orders)

        public Customer()
        {
            Orders = new HashSet<Order>();
        }
    }
}
