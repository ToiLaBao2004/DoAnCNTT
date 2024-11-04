using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Supplier
    {
        [Key]
        [StringLength(10)]
        public string Supplier_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string AddressSupplier { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual ICollection<Import> Imports { get; set; } // Mối quan hệ một-nhiều với Import

        public Supplier()
        {
            Imports = new HashSet<Import>();
        }
    }
}