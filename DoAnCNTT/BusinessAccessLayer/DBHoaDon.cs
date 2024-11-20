using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DataAccessLayer;
using System.Data.Entity;
using DataAccessLayer.Entities;

namespace BusinessAccessLayer // Declaring the BusinessAccessLayer namespace
{
    public class DBHoaDon // Declaring the DBHoaDon class
    {

        public DBHoaDon() // Constructor for the DBHoaDon class
        {

        }

        // Method to retrieve bills
        public List<dynamic> LayHoaDon()
        {
            using (var context = new QLCuaHang())
            {
                // Truy vấn cơ sở dữ liệu để lấy danh sách các hóa đơn
                var query = from order in context.Orders
                            .Include(o => o.Employee)  // Kết nối đến bảng Employee để lấy thông tin nhân viên
                            .Include(o => o.Customer)  // Kết nối đến bảng Customer để lấy thông tin khách hàng
                            .Include(o => o.Discount)  // Kết nối đến bảng Discount để lấy thông tin giảm giá (nếu có)
                            select new
                            {
                                order.Order_ID,  // Mã đơn hàng
                                order.Customer.NameCustomer,  // Tên khách hàng
                                order.Employee.NameEmployee,  // Tên nhân viên
                                order.OrderDate,  // Ngày đặt hàng
                                order.Total,  // Tổng giá trị đơn hàng
                                PercentageDiscount = order.Discount.DiscountCode != null ? order.Discount.PercentageDiscount : 0,  // Phần trăm giảm giá (nếu có)
                                order.PhoneNumber,  // Số điện thoại khách hàng
                                DiscountCode = order.Discount.DiscountCode != null ? order.Discount.DiscountCode : "",  // Mã giảm giá (nếu có)
                                order.EmployeeID  // Mã nhân viên thực hiện đơn hàng
                            };

                // Chuyển đổi kết quả truy vấn thành danh sách động (dynamic) và trả về
                return query.ToList<dynamic>();
            }
        }

        public int LayGiamGia(string discountCode)
        {
            using (var context = new QLCuaHang())
            {
                // Truy vấn cơ sở dữ liệu để lấy thông tin về tỉ lệ giảm giá dựa trên mã giảm giá (discountCode)
                var discounts = context.Discounts
                                    .Where(d => d.DiscountCode == discountCode)  // Lọc các bản ghi có mã giảm giá trùng với discountCode
                                    .Select(p => p.PercentageDiscount)  // Chọn trường PercentageDiscount của các bản ghi thỏa điều kiện
                                    .FirstOrDefault();  // Lấy giá trị đầu tiên hoặc mặc định (nếu không tìm thấy bản ghi nào)

                return discounts;  // Trả về tỉ lệ giảm giá tương ứng (hoặc giá trị mặc định nếu không tìm thấy)
            }
        }

        public bool KiemTraNgayThangHopLe(string discountCode, DateTime orderdate)
        {
            using (var context = new QLCuaHang())
            {
                // Lấy thông tin về mã giảm giá từ cơ sở dữ liệu dựa trên discountCode
                var discount = context.Discounts.FirstOrDefault(d => d.DiscountCode == discountCode);

                if (discount != null)
                {
                    // Kiểm tra ngày bắt đầu và ngày kết thúc của mã giảm giá
                    if (discount.StartDay <= orderdate && orderdate <= discount.EndDay)
                    {
                        return true; // Mã giảm giá hợp lệ về ngày tháng
                    }
                }

                return false; // Mã giảm giá không hợp lệ về ngày tháng
            }
        }

        public List<dynamic> TimHoaDon(string HD, string MKH)
        {
            // Tạo một ngữ cảnh (context) để làm việc với cơ sở dữ liệu của ứng dụng
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để lấy danh sách các đơn hàng từ cơ sở dữ liệu
                var query = from order in context.Orders
                            .Include(o => o.Employee)      // Nạp thông tin nhân viên cho mỗi đơn hàng
                            .Include(o => o.Customer)      // Nạp thông tin khách hàng cho mỗi đơn hàng
                            .Include(o => o.Discount)      // Nạp thông tin giảm giá cho mỗi đơn hàng
                            where order.Order_ID.ToLower().Contains(HD) && order.PhoneNumber.Contains(MKH)
                            // Lọc các đơn hàng theo mã hóa đơn (HD) và số điện thoại khách hàng (MKH)
                            select new
                            {
                                order.Order_ID,                     // Mã đơn hàng
                                order.Customer.NameCustomer,         // Tên khách hàng
                                order.Employee.NameEmployee,         // Tên nhân viên
                                order.OrderDate,                     // Ngày đặt hàng
                                order.Total,                         // Tổng giá trị đơn hàng
                                PercentageDiscount = order.Discount.DiscountCode != null ? order.Discount.PercentageDiscount : 0,
                                // Tính phần trăm giảm giá (nếu có) từ đối tượng giảm giá của đơn hàng
                                order.PhoneNumber,                   // Số điện thoại khách hàng
                                DiscountCode = order.Discount.DiscountCode != null ? order.Discount.DiscountCode : "",
                                // Mã giảm giá (nếu có) từ đối tượng giảm giá của đơn hàng
                                order.EmployeeID                     // ID của nhân viên
                            };

                // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
                return query.ToList<dynamic>();
            }
        }

        // Method to retrieve products associated with a bill
        public List<dynamic> SPCuaHoaDon(string HD)
        {
            // Tạo một ngữ cảnh (context) để làm việc với cơ sở dữ liệu của ứng dụng
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để lấy chi tiết các sản phẩm từ các đơn hàng trong cơ sở dữ liệu
                var query = (from order in context.OrderDetails.Include(o => o.Product)
                                 // Lọc các chi tiết đơn hàng dựa trên mã hóa đơn (HD) và nạp thông tin sản phẩm
                             where order.Order_ID.ToLower().Contains(HD)
                             // Chọn ra các thuộc tính cần trả về từ mỗi chi tiết đơn hàng
                             select new
                             {
                                 order.Product_ID,                // ID sản phẩm
                                 order.Product.ProductName,       // Tên sản phẩm
                                 order.Quantity,                  // Số lượng sản phẩm trong đơn hàng
                                 order.Product.UnitPrice,         // Đơn giá của sản phẩm
                             });

                // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
                return query.ToList<dynamic>();
            }
        }

        // Method to add a new bill
        public bool ThemHoaDon(ref string err, string order_ID, string sdt, string nv, DateTime orderdate, int Total, string magiam)
        {
            try
            {
                // Kiểm tra số điện thoại có rỗng không
                if (string.IsNullOrEmpty(sdt))
                {
                    throw new ArgumentException("Vui lòng nhập chính xác, đầy đủ thông tin");
                }

                using (var context = new QLCuaHang())
                {
                    using (var transaction = context.Database.BeginTransaction())  // Bắt đầu giao dịch trong cơ sở dữ liệu
                    {
                        try
                        {
                            // Kiểm tra mã giảm giá nếu có và xem nó có hợp lệ không
                            if (!string.IsNullOrEmpty(magiam) && !KiemTraNgayThangHopLe(magiam, orderdate))
                            {
                                throw new ArgumentException("Mã giảm giá không đúng hạn");
                            }

                            // Tạo đối tượng Order mới để thêm vào cơ sở dữ liệu
                            var order = new Order
                            {
                                Order_ID = order_ID,             // Mã đơn hàng
                                PhoneNumber = sdt,               // Số điện thoại khách hàng
                                EmployeeID = nv,                 // Mã nhân viên
                                OrderDate = orderdate,           // Ngày đặt hàng
                                Total = Total,                   // Tổng tiền đơn hàng
                                DiscountCode = string.IsNullOrEmpty(magiam) ? null : magiam
                                // Gán mã giảm giá (nếu có) cho đơn hàng, nếu không thì gán là null
                            };

                            context.Orders.Add(order);  // Thêm đơn hàng mới vào DbSet của ngữ cảnh
                            context.SaveChanges();      // Lưu thay đổi vào cơ sở dữ liệu
                            transaction.Commit();       // Hoàn thành giao dịch (lưu thay đổi vào cơ sở dữ liệu)
                            return true;                // Trả về true nếu thêm đơn hàng thành công
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();     // Quay lại trạng thái trước của cơ sở dữ liệu do có lỗi xảy ra
                            err = "Lỗi: " + ex.Message; // Gán thông báo lỗi vào biến err
                            return false;               // Trả về false do có lỗi xảy ra khi thêm đơn hàng
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                err = "Lỗi: " + ex.Message; // Gán thông báo lỗi vào biến err
                return false;               // Trả về false do có lỗi xảy ra khi thực hiện thêm đơn hàng
            }
        }

        public bool ThemChiTietHoaDon(ref string err, string Order_ID, string Product_ID, int Quantity)
        {
            try
            {
                // Kiểm tra Product_ID có rỗng không
                if (string.IsNullOrEmpty(Product_ID))
                {
                    throw new ArgumentException("Vui lòng nhập đầy đủ thông tin sản phẩm");
                }

                using (var context = new QLCuaHang())
                {
                    using (var transaction = context.Database.BeginTransaction())  // Bắt đầu giao dịch trong cơ sở dữ liệu
                    {
                        try
                        {
                            // Tạo đối tượng OrderDetail mới để thêm vào cơ sở dữ liệu
                            var orderDetail = new OrderDetail
                            {
                                Order_ID = Order_ID,        // Mã đơn hàng
                                Product_ID = Product_ID,    // Mã sản phẩm
                                Quantity = Quantity         // Số lượng sản phẩm
                            };

                            // Lấy thông tin sản phẩm từ cơ sở dữ liệu
                            var product = context.Products.FirstOrDefault(p => p.Product_ID == Product_ID);
                            // Lấy thông tin đơn hàng từ cơ sở dữ liệu
                            var order = context.Orders.FirstOrDefault(o => o.Order_ID == Order_ID);

                            // Kiểm tra đơn hàng và sản phẩm có tồn tại không
                            if (order != null && product != null)
                            {
                                int discountPercentage = 0;
                                // Nếu đơn hàng có mã giảm giá, lấy tỷ lệ giảm giá
                                if (!string.IsNullOrEmpty(order.DiscountCode))
                                {
                                    discountPercentage = LayGiamGia(order.DiscountCode);
                                }

                                // Kiểm tra số lượng sản phẩm đủ để thực hiện đơn hàng hay không
                                if (product.Quantity >= orderDetail.Quantity)
                                {
                                    // Giảm số lượng sản phẩm trong kho và cập nhật tổng tiền của đơn hàng
                                    product.Quantity -= orderDetail.Quantity;
                                    order.Total += product.UnitPrice * orderDetail.Quantity / 100 * (100 - discountPercentage);
                                }
                                else
                                {
                                    throw new InvalidOperationException("Số lượng sản phẩm không đủ");
                                }

                                // Thêm chi tiết đơn hàng vào DbSet của ngữ cảnh
                                context.OrderDetails.Add(orderDetail);

                                // Lấy thông tin khách hàng và cập nhật điểm tích lũy
                                var customer = context.Customers.Include(c => c.Orders).FirstOrDefault(c => c.PhoneNumber == order.PhoneNumber);
                                if (customer != null)
                                {
                                    customer.Point = customer.Orders.Sum(o => o.Total / 10000);
                                }

                                // Lưu các thay đổi vào cơ sở dữ liệu
                                context.SaveChanges();
                                transaction.Commit();  // Hoàn thành giao dịch (lưu thay đổi vào cơ sở dữ liệu)
                                return true;           // Trả về true nếu thêm chi tiết đơn hàng thành công
                            }
                            else
                            {
                                throw new InvalidOperationException("Không tìm thấy đơn hàng hoặc sản phẩm phù hợp");
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();     // Quay lại trạng thái trước của cơ sở dữ liệu do có lỗi xảy ra
                            err = "Lỗi: " + ex.Message; // Gán thông báo lỗi vào biến err
                            return false;               // Trả về false do có lỗi xảy ra khi thêm chi tiết đơn hàng
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                err = "Lỗi: " + ex.Message; // Gán thông báo lỗi vào biến err
                return false;               // Trả về false do có lỗi xảy ra khi thực hiện thêm chi tiết đơn hàng
            }
        }

        public bool XoaHoaDon(ref string err, string Order_ID)
        {
            using (var context = new QLCuaHang())
            {
                using (var transaction = context.Database.BeginTransaction())  // Bắt đầu giao dịch trong cơ sở dữ liệu
                {
                    try
                    {
                        // Lấy thông tin đơn hàng và các chi tiết đơn hàng từ cơ sở dữ liệu
                        var order = context.Orders.Include(o => o.OrderDetails).FirstOrDefault(o => o.Order_ID == Order_ID);
                        if (order == null)
                        {
                            err = "Không tìm thấy đơn hàng có ID " + Order_ID;
                            return false;
                        }

                        // Lưu tổng giá trị của đơn hàng để điều chỉnh lại điểm tích lũy của khách hàng sau khi xóa
                        int totalValueToRemove = order.Total;

                        // Khôi phục số lượng sản phẩm trong kho sau khi xóa đơn hàng
                        foreach (var orderDetail in order.OrderDetails)
                        {
                            var product = context.Products.FirstOrDefault(p => p.Product_ID == orderDetail.Product_ID);
                            if (product != null)
                            {
                                product.Quantity += orderDetail.Quantity;  // Tăng số lượng sản phẩm trong kho
                            }
                        }

                        // Giảm điểm tích lũy của khách hàng
                        var customer = context.Customers.FirstOrDefault(c => c.PhoneNumber == order.PhoneNumber);
                        if (customer != null)
                        {
                            customer.Point -= totalValueToRemove / 10000;  // Giảm điểm tích lũy dựa trên tổng giá trị của đơn hàng
                        }

                        // Xóa đơn hàng khỏi cơ sở dữ liệu
                        context.Orders.Remove(order);

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();
                        transaction.Commit();  // Hoàn thành giao dịch (lưu thay đổi vào cơ sở dữ liệu)
                        return true;           // Trả về true nếu xóa đơn hàng thành công
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();  // Quay lại trạng thái trước của cơ sở dữ liệu do có lỗi xảy ra
                        err = "Lỗi: " + ex.Message;  // Gán thông báo lỗi vào biến err
                        return false;  // Trả về false do có lỗi xảy ra khi xóa đơn hàng
                    }
                }
            }
        }
    }
}