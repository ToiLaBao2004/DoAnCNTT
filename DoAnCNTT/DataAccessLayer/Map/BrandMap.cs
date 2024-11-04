using System.Data.Entity.ModelConfiguration;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Map
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            // Thiết lập mối quan hệ: Một thương hiệu (Brand) có nhiều sản phẩm (Products)
            // VớiRequired(x => x.Brand) xác định rằng mỗi sản phẩm phải thuộc về một thương hiệu cụ thể
            this.HasMany(e => e.Products).WithRequired(x => x.Brand);
        }
    }
}