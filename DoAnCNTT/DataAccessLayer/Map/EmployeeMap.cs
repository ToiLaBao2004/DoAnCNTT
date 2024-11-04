using DataAccessLayer.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Map
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Thiết lập mối quan hệ: Một nhân viên (Employee) có nhiều đơn hàng (Orders)
            // VớiRequired(x => x.Employee) xác định rằng mỗi đơn hàng phải được xử lý bởi một nhân viên cụ thể
            this.HasMany(e => e.Orders).WithRequired(x => x.Employee);
        }
    }
}