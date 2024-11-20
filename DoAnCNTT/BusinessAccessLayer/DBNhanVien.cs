using System;
using System.Linq;
using System.Data;
using DataAccessLayer;
using System.Security.Cryptography;
using System.Text;
using DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace BusinessAccessLayer
{
    public class DBNhanVien
    {
        public DBNhanVien() 
        {

        }

        // Hàm băm mật khẩu
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Hàm tìm nhân viên theo ID
        public dynamic TimNhanVienByID(string ID)
        {
            using (var context = new QLCuaHang())
            {
                var employee = context.Employees
                    .Where(p => p.EmployeeID == ID) // Tìm nhân viên theo ID chính xác
                    .Select(p => new
                    {
                        p.EmployeeID,
                        p.NameEmployee,
                        p.Birthday,
                        p.Gender,
                        p.AddressEmployee,
                        p.PhoneNumber,
                        p.RoleEmployee,
                        p.Active,
                        p.PassWordAccount
                    })
                    .FirstOrDefault(); // Lấy nhân viên đầu tiên hoặc null nếu không tìm thấy

                return employee;
            }
        }

        // Hàm kiểm tra đăng nhập
        public bool CheckLogin(string username, string password)
        {
            // Kiểm tra nếu username hoặc password là null, rỗng hoặc chỉ gồm khoảng trắng thì trả về false
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            // Gọi phương thức TimNhanVienByID(username) để tìm nhân viên dựa trên username
            var employee = TimNhanVienByID(username);

            // Kiểm tra nếu nhân viên không null
            if (employee != null)
            {
                string dbPassword = employee.PassWordAccount;
                int active = Int32.Parse(employee.Active);

                // Băm mật khẩu người dùng nhập vào
                string hashedPassword = HashPassword(password);

                // So sánh mật khẩu đã băm và trạng thái hoạt động của nhân viên
                return active == 1 && hashedPassword == dbPassword;
            }

            return false;
        }

        // Method to retrieve active employees
        public List<dynamic> LayNhanVien()
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để lấy thông tin các nhân viên trong cửa hàng
                var query = from p in context.Employees.Include(e => e.Orders)
                            where p.Active == "1"  // Chỉ lấy nhân viên đang hoạt động (Active == "1")
                            select new
                            {
                                p.EmployeeID,         // Mã nhân viên
                                p.NameEmployee,       // Tên nhân viên
                                p.Birthday,           // Ngày sinh
                                p.Gender,             // Giới tính
                                p.AddressEmployee,    // Địa chỉ
                                p.PhoneNumber,        // Số điện thoại
                                p.RoleEmployee,       // Vai trò (chức vụ) của nhân viên
                                Tong = p.Orders.Any() ? p.Orders.Sum(o => (int?)o.Total) : 0
                                // Tổng doanh thu từ các đơn hàng mà nhân viên đã thực hiện
                            };

                // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
                return query.ToList<dynamic>();
            }
        }

        // Method to retrieve all employees
        public List<dynamic> LayALLNhanVien()
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để lấy thông tin của tất cả nhân viên trong cửa hàng
                var query = from p in context.Employees.Include(e => e.Orders)
                            select new
                            {
                                p.EmployeeID,         // Mã nhân viên
                                p.NameEmployee,       // Tên nhân viên
                                p.Birthday,           // Ngày sinh
                                p.Gender,             // Giới tính
                                p.AddressEmployee,    // Địa chỉ
                                p.PhoneNumber,        // Số điện thoại
                                p.RoleEmployee,       // Vai trò (chức vụ) của nhân viên
                                p.Active,             // Trạng thái hoạt động của nhân viên
                                p.PassWordAccount,    // Mật khẩu tài khoản của nhân viên (lưu ý: không nên lưu mật khẩu theo dạng này)
                                Tong = p.Orders.Any() ? p.Orders.Sum(o => (int?)o.Total) : 0
                                // Tổng doanh thu từ các đơn hàng mà nhân viên đã thực hiện
                            };

                // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
                return query.ToList<dynamic>();
            }
        }

        public List<dynamic> TimNhanVien(string ID, string name)
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để tìm kiếm nhân viên dựa trên mã nhân viên (ID) và tên nhân viên (name)
                var query = from p in context.Employees.Include(e => e.Orders)
                            where p.EmployeeID.Contains(ID) && p.NameEmployee.Contains(name)
                            // Lọc những nhân viên có mã nhân viên (ID) chứa trong ID được cung cấp
                            // và tên nhân viên (name) chứa trong name được cung cấp
                            select new
                            {
                                p.EmployeeID,         // Mã nhân viên
                                p.NameEmployee,       // Tên nhân viên
                                p.Birthday,           // Ngày sinh
                                p.Gender,             // Giới tính
                                p.RoleEmployee,       // Vai trò (chức vụ) của nhân viên
                                Tong = p.Orders.Any() ? p.Orders.Sum(o => (int?)o.Total) : 0
                                // Tổng doanh thu từ các đơn hàng mà nhân viên đã thực hiện
                            };

                // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
                return query.ToList<dynamic>();
            }
        }

        // Method to search for all employees by ID
        public List<dynamic> TimAllNhanVien(string ID)
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để tìm kiếm tất cả nhân viên dựa trên mã nhân viên (ID) được cung cấp
                var query = from p in context.Employees.Include(e => e.Orders)
                            where p.EmployeeID.Contains(ID)
                            // Lọc những nhân viên có mã nhân viên (ID) chứa trong ID được cung cấp
                            select new
                            {
                                p.EmployeeID,         // Mã nhân viên
                                p.NameEmployee,       // Tên nhân viên
                                p.Birthday,           // Ngày sinh
                                p.Gender,             // Giới tính
                                p.AddressEmployee,    // Địa chỉ
                                p.PhoneNumber,        // Số điện thoại
                                p.RoleEmployee,       // Vai trò (chức vụ) của nhân viên
                                p.Active,             // Trạng thái hoạt động của nhân viên
                                p.PassWordAccount,    // Mật khẩu tài khoản của nhân viên
                                Tong = p.Orders.Any() ? p.Orders.Sum(o => (int?)o.Total) : 0
                                // Tổng doanh thu từ các đơn hàng mà nhân viên đã thực hiện
                            };

                // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
                return query.ToList<dynamic>();
            }
        }

        // Method to add a new employee
        public bool ThemNhanVien(ref string err, string id, string name, DateTime birthday, string gender, string address, string sdt, string role, int active, string password)
        {
            using (var context = new QLCuaHang())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Tạo đối tượng Employee mới với các thông tin được cung cấp
                        var newEmployee = new Employee
                        {
                            EmployeeID = id,                 // Mã nhân viên
                            NameEmployee = name,             // Tên nhân viên
                            Birthday = birthday.Date,        // Ngày sinh (lấy ngày của birthday)
                            Gender = gender,                 // Giới tính
                            AddressEmployee = address,       // Địa chỉ
                            PhoneNumber = sdt,               // Số điện thoại
                            RoleEmployee = role,             // Vai trò (chức vụ) của nhân viên
                            Active = active.ToString(),      // Trạng thái hoạt động (chuyển thành chuỗi)
                            PassWordAccount = password        // Mật khẩu tài khoản
                        };

                        // Thêm đối tượng Employee mới vào DbSet trong context
                        context.Employees.Add(newEmployee);

                        // Lưu các thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                        // Commit giao dịch
                        transaction.Commit();

                        return true;  // Trả về true nếu thêm nhân viên thành công
                    }
                    catch (Exception ex)
                    {
                        // Nếu có lỗi xảy ra, rollback giao dịch và ghi lại lỗi
                        transaction.Rollback();
                        err = ex.Message;  // Gán thông báo lỗi vào biến err
                        return false;      // Trả về false để báo lỗi khi thêm nhân viên
                    }
                }
            }
        }

        // Method to update an employee
        public bool CapNhatNhanVien(ref string err, string id, string name, DateTime birthday, string gender, string address, string sdt, string role, int active, string password)
        {
            using (var context = new QLCuaHang())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Tìm nhân viên cần cập nhật dựa trên mã nhân viên (id) được cung cấp
                        var employeeToUpdate = context.Employees.FirstOrDefault(e => e.EmployeeID == id);

                        if (employeeToUpdate != null)
                        {
                            // Cập nhật thông tin của nhân viên được tìm thấy
                            employeeToUpdate.NameEmployee = name;
                            employeeToUpdate.Birthday = birthday.Date;
                            employeeToUpdate.Gender = gender;
                            employeeToUpdate.AddressEmployee = address;
                            employeeToUpdate.PhoneNumber = sdt;
                            employeeToUpdate.RoleEmployee = role;
                            employeeToUpdate.Active = active.ToString();
                            employeeToUpdate.PassWordAccount = password;

                            // Lưu các thay đổi vào cơ sở dữ liệu
                            context.SaveChanges();

                            // Commit giao dịch
                            transaction.Commit();

                            return true;  // Trả về true nếu cập nhật nhân viên thành công
                        }
                        else
                        {
                            err = "Employee not found.";  // Thông báo lỗi nếu không tìm thấy nhân viên
                            return false;  // Trả về false để báo lỗi khi cập nhật nhân viên
                        }
                    }
                    catch (Exception ex)
                    {
                        // Nếu có lỗi xảy ra, rollback giao dịch và ghi lại lỗi
                        transaction.Rollback();
                        err = ex.Message;  // Gán thông báo lỗi vào biến err
                        return false;      // Trả về false để báo lỗi khi cập nhật nhân viên
                    }
                }
            }
        }

        public bool XoaNhanVien(ref string err, string id)
        {
            using (var context = new QLCuaHang())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Tìm nhân viên cần xóa dựa trên mã nhân viên (id) được cung cấp
                        var employeeToUpdate = context.Employees.FirstOrDefault(e => e.EmployeeID == id);

                        if (employeeToUpdate != null)
                        {
                            // Đánh dấu nhân viên là không hoạt động bằng cách cập nhật trường Active thành "0"
                            employeeToUpdate.Active = "0";

                            // Lưu các thay đổi vào cơ sở dữ liệu
                            context.SaveChanges();

                            // Commit giao dịch
                            transaction.Commit();

                            return true;  // Trả về true nếu xóa nhân viên thành công
                        }
                        else
                        {
                            err = "Employee not found.";  // Thông báo lỗi nếu không tìm thấy nhân viên
                            return false;  // Trả về false để báo lỗi khi xóa nhân viên
                        }
                    }
                    catch (Exception ex)
                    {
                        // Nếu có lỗi xảy ra, rollback giao dịch và ghi lại lỗi
                        transaction.Rollback();
                        err = ex.Message;  // Gán thông báo lỗi vào biến err
                        return false;      // Trả về false để báo lỗi khi xóa nhân viên
                    }
                }
            }
        }
    }
}