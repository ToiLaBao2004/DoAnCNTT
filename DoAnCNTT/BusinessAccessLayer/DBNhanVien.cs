using System;
using System.Linq;
using System.Data;
using DataAccessLayer;
using System.Security.Cryptography;
using System.Text;

namespace BusinessAccessLayer
{
    public class DBNhanVien
    {
        public DBNhanVien() { }

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
    }
}