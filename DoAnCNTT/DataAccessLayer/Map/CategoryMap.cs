using DataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Map
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Thiết lập mối quan hệ: Một danh mục (Category) có nhiều sản phẩm (Products)
            // VớiRequired(x => x.Category) xác định rằng mỗi sản phẩm phải thuộc về một danh mục cụ thể
            this.HasMany(e => e.Products).WithRequired(x => x.Category);
        }
    }
}