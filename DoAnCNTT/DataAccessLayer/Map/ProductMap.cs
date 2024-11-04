using DataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Map
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Thiết lập mối quan hệ: Một sản phẩm (Product) bắt buộc thuộc về một danh mục (Category)
            // và mối quan hệ: Một sản phẩm (Product) bắt buộc thuộc về một thương hiệu (Brand)

            this.HasRequired(p => p.Category) // Mối quan hệ bắt buộc với danh mục (Category)
                .WithMany() // Một danh mục có thể có nhiều sản phẩm
                .HasForeignKey(p => p.Category_ID); // Khóa ngoại sử dụng để tham chiếu đến danh mục của sản phẩm

            this.HasRequired(p => p.Brand) // Mối quan hệ bắt buộc với thương hiệu (Brand)
                .WithMany() // Một thương hiệu có thể có nhiều sản phẩm
                .HasForeignKey(p => p.Brand_ID); // Khóa ngoại sử dụng để tham chiếu đến thương hiệu của sản phẩm
        }
    }
}
