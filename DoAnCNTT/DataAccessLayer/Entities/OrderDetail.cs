using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        [ForeignKey("Order")]
        public string Order_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        [ForeignKey("Product")]
        public string Product_ID { get; set; }

        [Required]
        public int Quantity { get; set; }

        public virtual Order Order { get; set; } // Mối quan hệ một-nhiều với Order

        public virtual Product Product { get; set; } // Mối quan hệ một-nhiều với Product
    }
}
