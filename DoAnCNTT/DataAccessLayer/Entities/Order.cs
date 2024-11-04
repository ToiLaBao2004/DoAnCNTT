using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class Order
    {
        [Key]
        [StringLength(15)]
        public string Order_ID { get; set; }

        [Required]
        [StringLength(12)]
        [ForeignKey("Customer")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(5)]
        [ForeignKey("Employee")]
        public string EmployeeID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int Total { get; set; }

        [ForeignKey("Discount")]
        [StringLength(10)]
        public string DiscountCode { get; set; }

        public virtual Customer Customer { get; set; } // Mối quan hệ một-nhiều với Customer

        public virtual Employee Employee { get; set; } // Mối quan hệ một-nhiều với Employee

        public virtual Discount Discount { get; set; } // Mối quan hệ một-nhiều với Discount

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } // Mối quan hệ một-nhiều với các chi tiết đơn hàng (OrderDetails)

        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}
