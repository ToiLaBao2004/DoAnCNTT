using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Discount
    {
        [Key]
        [StringLength(10)]
        public string DiscountCode { get; set; }

        [Required]
        public int PercentageDiscount { get; set; }

        [Required]
        public DateTime StartDay { get; set; }

        [Required]
        public DateTime EndDay { get; set; }

        public virtual ICollection<Order> Orders { get; set; } // Mối quan hệ một-nhiều với các đơn hàng (Orders)

        public Discount()
        {
            Orders = new HashSet<Order>();
        }
    }
}
