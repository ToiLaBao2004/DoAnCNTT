using DataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Map
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Thiết lập mối quan hệ: Một đơn hàng (Order) có nhiều chi tiết đơn hàng (OrderDetails)
            // VớiRequired(x => x.Order) xác định rằng mỗi chi tiết đơn hàng phải thuộc về một đơn hàng cụ thể
            // WillCascadeOnDelete(true) xác định rằng khi xóa đơn hàng, các chi tiết đơn hàng cũng sẽ bị xóa
            this.HasMany(e => e.OrderDetails).WithRequired(x => x.Order).WillCascadeOnDelete(true);
        }
    }
}
