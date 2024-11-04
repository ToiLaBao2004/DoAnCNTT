using DataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Map
{
    public class DiscountMap : EntityTypeConfiguration<Discount>
    {
        public DiscountMap()
        {
            // Thiết lập mối quan hệ: Một đợt giảm giá (Discount) có thể được áp dụng cho nhiều đơn hàng (Orders)
            // VớiOptional(x => x.Discount) xác định rằng mỗi đơn hàng có thể có hoặc không có đợt giảm giá
            this.HasMany(e => e.Orders).WithOptional(x => x.Discount);
        }
    }
}