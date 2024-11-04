using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class ImportDetail
    {
        [Key]
        [Column(Order = 1)] // Xác định thứ tự của cột trong khóa chính
        [StringLength(10)]
        [ForeignKey("Import")]
        public string Import_ID { get; set; }

        [Key]
        [Column(Order = 2)] // Xác định thứ tự của cột trong khóa chính
        [StringLength(15)]
        [ForeignKey("Product")]
        public string Product_ID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Unitcost { get; set; }

        public virtual Import Import { get; set; } // Mối quan hệ một-nhiều với Import

        public virtual Product Product { get; set; } // Mối quan hệ một-nhiều với Product
    }
}
