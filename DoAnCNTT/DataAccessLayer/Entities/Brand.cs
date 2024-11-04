using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Brand
    {
        [Key]
        [StringLength(10)]
        public string Brand_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string BrandName { get; set; }

        public virtual ICollection<Product> Products { get; set; } // Mối quan hệ một-nhiều với các sản phẩm (Products)

        public Brand()
        {
            Products = new HashSet<Product>();
        }
    }
}