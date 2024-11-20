using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DataAccessLayer;
using System.Data.Entity;
using DataAccessLayer.Entities;

namespace BusinessAccessLayer
{
    public class DBKhachHang
    {

        public DBKhachHang()
        {

        }
        public List<dynamic> LayKhachHang()
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để lấy thông tin khách hàng từ cơ sở dữ liệu
                var query = (from c in context.Customers.Include(p => p.Orders)
                                 // Lựa chọn các thuộc tính cần trả về cho mỗi khách hàng
                             select new
                             {
                                 c.PhoneNumber,       // Số điện thoại khách hàng
                                 c.NameCustomer,      // Tên khách hàng
                                 c.Birthday,          // Ngày sinh của khách hàng
                                 c.Gender,            // Giới tính của khách hàng
                                 c.Point,             // Điểm tích lũy của khách hàng
                                 Tong = c.Orders.Any() ? c.Orders.Sum(o => (int?)o.Total) : 0
                                 // Tổng số tiền của tất cả các đơn hàng của khách hàng (nếu có)
                             });

                return query.ToList<dynamic>();  // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
            }
        }

        public List<dynamic> TimKhachHang(string Phone, string Name)
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để tìm kiếm khách hàng từ cơ sở dữ liệu
                var query = (from c in context.Customers.Include(p => p.Orders)
                                 // Lọc khách hàng dựa trên tên và số điện thoại
                             where c.NameCustomer.ToLower().Contains(Name) && c.PhoneNumber.Contains(Phone)
                             // Chọn các thuộc tính cần trả về cho mỗi khách hàng thỏa mãn điều kiện lọc
                             select new
                             {
                                 c.PhoneNumber,       // Số điện thoại của khách hàng
                                 c.NameCustomer,      // Tên của khách hàng
                                 c.Birthday,          // Ngày sinh của khách hàng
                                 c.Gender,            // Giới tính của khách hàng
                                 c.Point,             // Điểm tích lũy của khách hàng
                                 Tong = c.Orders.Any() ? c.Orders.Sum(o => (int?)o.Total) : 0
                                 // Tổng số tiền của tất cả các đơn hàng của khách hàng (nếu có)
                             });

                return query.ToList<dynamic>();  // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
            }
        }

        public List<Product> SPcuaKhachHang(string phoneNumber)
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để lấy sản phẩm của khách hàng từ cơ sở dữ liệu
                var query = from od in context.OrderDetails
                                // Lọc các chi tiết đơn hàng dựa trên số điện thoại của khách hàng
                            where od.Order.Customer.PhoneNumber == phoneNumber
                            // Nhóm các chi tiết đơn hàng theo ID sản phẩm, tên sản phẩm và đơn giá
                            group od by new { od.Product.Product_ID, od.Product.ProductName, od.Product.UnitPrice } into grouped
                            // Chọn các thuộc tính cần trả về cho mỗi sản phẩm được nhóm
                            select new
                            {
                                Product_ID = grouped.Key.Product_ID,        // ID sản phẩm
                                ProductName = grouped.Key.ProductName,      // Tên sản phẩm
                                Quantity = grouped.Sum(x => x.Quantity),    // Tổng số lượng sản phẩm đã được đặt
                                UnitPrice = grouped.Key.UnitPrice           // Đơn giá của sản phẩm
                            };

                // Thực hiện truy vấn và chuyển kết quả thành danh sách các đối tượng
                var result = query.ToList().Select(x => new Product
                {
                    Product_ID = x.Product_ID,        // Gán ID sản phẩm cho đối tượng Product
                    ProductName = x.ProductName,      // Gán tên sản phẩm cho đối tượng Product
                    Quantity = x.Quantity,            // Gán số lượng sản phẩm cho đối tượng Product
                }).ToList();

                return result;  // Trả về danh sách các sản phẩm của khách hàng
            }
        }

        public bool ThemKhachHang(ref string err, string sdt, string name, DateTime birthday, string gender, int point)
        {
            using (var context = new QLCuaHang())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra tính hợp lệ của thông tin khách hàng
                        if (string.IsNullOrEmpty(name))
                        {
                            throw new ArgumentException("Vui lòng nhập đầy đủ thông tin.");
                        }

                        // Tạo đối tượng khách hàng mới
                        var customer = new Customer
                        {
                            PhoneNumber = sdt,          // Số điện thoại của khách hàng
                            NameCustomer = name,        // Tên của khách hàng
                            Birthday = birthday.Date,   // Ngày sinh của khách hàng (chỉ lấy ngày, không có thời gian)
                            Gender = gender,            // Giới tính của khách hàng
                            Point = point               // Điểm tích lũy của khách hàng
                        };

                        // Thêm khách hàng vào cơ sở dữ liệu
                        context.Customers.Add(customer);

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                        // Hoàn thành giao dịch (lưu thay đổi vào cơ sở dữ liệu)
                        transaction.Commit();

                        return true;  // Trả về true nếu thêm khách hàng thành công
                    }
                    catch (Exception ex)
                    {
                        // Quay lại trạng thái trước của cơ sở dữ liệu do có lỗi xảy ra
                        transaction.Rollback();

                        // Gán thông báo lỗi vào biến err
                        err = "Lỗi: " + ex.Message;

                        return false;  // Trả về false nếu có lỗi xảy ra khi thêm khách hàng
                    }
                }
            }
        }

        public bool CapNhatKhachHang(ref string err, string sdt, string name, DateTime birthday, string gender, int point)
        {
            using (var context = new QLCuaHang())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Tìm khách hàng trong cơ sở dữ liệu dựa trên số điện thoại
                        var customer = context.Customers.FirstOrDefault(c => c.PhoneNumber == sdt);

                        // Kiểm tra xem khách hàng có tồn tại hay không
                        if (customer == null)
                        {
                            err = "Không tìm thấy khách hàng có số điện thoại này.";
                            return false;
                        }

                        // Cập nhật thông tin của khách hàng
                        customer.NameCustomer = name;          // Cập nhật tên khách hàng
                        customer.Birthday = birthday.Date;     // Cập nhật ngày sinh khách hàng (chỉ lấy ngày, không có thời gian)
                        customer.Gender = gender;              // Cập nhật giới tính khách hàng
                        customer.Point = point;                // Cập nhật điểm tích lũy của khách hàng

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                        // Hoàn thành giao dịch (lưu thay đổi vào cơ sở dữ liệu)
                        transaction.Commit();

                        return true;  // Trả về true nếu cập nhật thành công
                    }
                    catch (Exception ex)
                    {
                        // Quay lại trạng thái trước của cơ sở dữ liệu do có lỗi xảy ra
                        transaction.Rollback();

                        // Gán thông báo lỗi vào biến err
                        err = "Lỗi: " + ex.Message;

                        return false;  // Trả về false nếu có lỗi xảy ra khi cập nhật khách hàng
                    }
                }
            }
        }
    }
}