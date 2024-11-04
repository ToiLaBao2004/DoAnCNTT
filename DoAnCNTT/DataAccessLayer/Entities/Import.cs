using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class Import
    {
        [Key]
        [StringLength(10)]
        public string Import_ID { get; set; }

        [Required]
        [ForeignKey("Supplier")]
        [StringLength(10)]
        public string Supplier_ID { get; set; }

        [Required]
        public DateTime ImportDay { get; set; }

        [Required]
        public int Total { get; set; }

        public virtual Supplier Supplier { get; set; } // Mối quan hệ một-nhiều với Supplier

        public virtual ICollection<ImportDetail> ImportDetails { get; set; } // Mối quan hệ một-nhiều với các chi tiết nhập hàng (ImportDetails)

        public Import()
        {
            ImportDetails = new HashSet<ImportDetail>();
        }
    }
}
