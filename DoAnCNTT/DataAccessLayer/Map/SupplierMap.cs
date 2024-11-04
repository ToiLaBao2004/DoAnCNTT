using DataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Map
{
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            // Thiết lập mối quan hệ: Một nhà cung cấp (Supplier) có thể có nhiều phiếu nhập hàng (Imports)
            // VớiRequired(x => x.Supplier) xác định rằng mỗi phiếu nhập hàng phải thuộc về một nhà cung cấp cụ thể
            this.HasMany(e => e.Imports).WithRequired(x => x.Supplier);
        }
    }
}
