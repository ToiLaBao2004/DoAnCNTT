using DataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Map
{
    public class PictureProductMap : EntityTypeConfiguration<PictureProduct>
    {
        public PictureProductMap()
        {
            // Thiết lập mối quan hệ: Một hình ảnh sản phẩm (PictureProduct) được sử dụng bởi nhiều sản phẩm (Products)
            // VớiRequired(x => x.PictureProduct) xác định rằng mỗi sản phẩm phải có một hình ảnh sản phẩm tương ứng
            this.HasMany(e => e.Products).WithRequired(x => x.PictureProduct);
        }
    }
}
