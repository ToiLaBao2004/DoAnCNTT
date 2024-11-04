using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class PictureProduct
    {
        [Key]
        public int Picture_ID { get; set; }

        [StringLength(100)]
        public string Picture_Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } // Mối quan hệ một-nhiều với Product

        public PictureProduct()
        {
            Products = new HashSet<Product>();
        }
    }
}