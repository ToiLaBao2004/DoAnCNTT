using DataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Map
{
    public class ImportMap : EntityTypeConfiguration<Import>
    {
        public ImportMap()
        {
            // Thiết lập mối quan hệ: Một phiếu nhập hàng (Import) có nhiều chi tiết nhập hàng (ImportDetails)
            // VớiRequired(x => x.Import) xác định rằng mỗi chi tiết nhập hàng phải thuộc về một phiếu nhập hàng cụ thể
            this.HasMany(e => e.ImportDetails).WithRequired(x => x.Import);
        }
    }
}
