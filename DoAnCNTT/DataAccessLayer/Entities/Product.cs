using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Product
    {
        [Key]
        [StringLength(15)]
        public string Product_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        public int UnitPrice { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey("Brand")]
        public string Brand_ID { get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey("Category")]
        public string Category_ID { get; set; }

        [ForeignKey("PictureProduct")]
        public int Picture_ID { get; set; }

        public virtual Brand Brand { get; set; } // Mối quan hệ một-nhiều với Brand

        public virtual Category Category { get; set; } // Mối quan hệ một-nhiều với Category

        public virtual PictureProduct PictureProduct { get; set; } // Mối quan hệ một-một với PictureProduct
    }
}
