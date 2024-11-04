using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Category
    {
        [Key]
        [StringLength(10)]
        public string Category_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; } // Mối quan hệ một-nhiều với các sản phẩm (Products)

        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
