using System.Data.Entity.ModelConfiguration;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Map
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Thiết lập mối quan hệ: Một khách hàng (Customer) có nhiều đơn hàng (Orders)
            // VớiRequired(e => e.Customer) xác định rằng mỗi đơn hàng phải thuộc về một khách hàng cụ thể
            this.HasMany(e => e.Orders).WithRequired(e => e.Customer);
        }
    }
}
