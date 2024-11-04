using System.Data.Entity;
using DataAccessLayer.Entities;
using DataAccessLayer.Map;

namespace DataAccessLayer
{
    public class QLCuaHang : DbContext
    {
        // Constructor của lớp QLCuaHang, kế thừa từ DbContext của Entity Framework
        public QLCuaHang() : base("name=FinalProject")
        {

        }

        // DbSet để đại diện cho các bảng trong cơ sở dữ liệu
        // Mỗi DbSet sẽ tương ứng với một bảng trong cơ sở dữ liệu
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PictureProduct> PictureProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ImportDetail> ImportDetails { get; set; }

        // Phương thức này ghi đè để cấu hình các mapping giữa các entity và bảng trong cơ sở dữ liệu
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Đăng ký các EntityTypeConfiguration để ánh xạ các entity vào các bảng tương ứng
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new DiscountMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ImportMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new PictureProductMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new ProductMap());

            // Gọi phương thức cơ sở để hoàn thành việc cấu hình mapping
            base.OnModelCreating(modelBuilder);
        }
    }
}