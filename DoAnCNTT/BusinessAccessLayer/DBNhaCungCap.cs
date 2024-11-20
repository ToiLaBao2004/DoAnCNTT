using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DataAccessLayer;
using System.Data.Entity;
using DataAccessLayer.Entities;

namespace BusinessAccessLayer // Declaring the BusinessAccessLayer namespace
{
    public class DBNhaCungCap // Declaring the DBNhaCungCap class
    {

        public DBNhaCungCap()
        {

        }
        public List<dynamic> LayNhaCungCap()
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để lấy danh sách nhà cung cấp từ cơ sở dữ liệu
                var query = from c in context.Suppliers.Include(p => p.Imports)
                                // Bao gồm các nhập hàng (imports) liên quan đến từng nhà cung cấp
                            select new
                            {
                                c.Supplier_ID,          // Mã nhà cung cấp
                                c.CompanyName,          // Tên công ty
                                c.PhoneNumber,          // Số điện thoại
                                c.AddressSupplier,      // Địa chỉ
                                c.Email,                // Địa chỉ email
                                Tong = c.Imports.Any() ? c.Imports.Sum(o => (int)o.Total) : 0
                                // Tổng giá trị các đơn nhập hàng của nhà cung cấp này (nếu có)
                            };

                // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
                return query.ToList<dynamic>();
            }
        }

        public List<dynamic> TimNhaCungCap(string ID, string name)
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để tìm kiếm nhà cung cấp dựa trên mã và tên
                var query = from c in context.Suppliers.Include(p => p.Imports)
                            where c.CompanyName.Contains(name) && c.Supplier_ID.Contains(ID)
                            // Lọc các nhà cung cấp dựa trên tên công ty và mã nhà cung cấp
                            select new
                            {
                                c.Supplier_ID,          // Mã nhà cung cấp
                                c.CompanyName,          // Tên công ty
                                c.PhoneNumber,          // Số điện thoại
                                c.AddressSupplier,      // Địa chỉ
                                c.Email,                // Địa chỉ email
                                Tong = c.Imports.Any() ? c.Imports.Sum(o => (int)o.Total) : 0
                                // Tổng giá trị các đơn nhập hàng của nhà cung cấp này (nếu có)
                            };

                // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
                return query.ToList<dynamic>();
            }
        }

        public List<dynamic> SPCuaNhaCungCap(string ID)
        {
            using (var context = new QLCuaHang())
            {
                // Tạo truy vấn LINQ để lấy thông tin sản phẩm của nhà cung cấp dựa trên mã nhà cung cấp
                var query = from id in context.ImportDetails.Include(i => i.Import)
                            where id.Import.Supplier_ID == ID
                            // Lọc các chi tiết nhập hàng liên quan đến nhà cung cấp có mã tương ứng
                            group id by new { id.Product_ID, id.Product.ProductName, id.Unitcost, id.Quantity } into grouped
                            // Nhóm các chi tiết nhập hàng theo Product_ID, ProductName, Unitcost và Quantity
                            select new
                            {
                                Product_ID = grouped.Key.Product_ID,         // Mã sản phẩm
                                ProductName = grouped.Key.ProductName,       // Tên sản phẩm
                                Quantity = grouped.Sum(x => x.Quantity),     // Tổng số lượng nhập
                                Unitcost = grouped.Key.Unitcost              // Giá nhập của sản phẩm
                            };

                // Chuyển kết quả truy vấn thành danh sách các đối tượng dynamic và trả về
                return query.ToList<dynamic>();
            }
        }

        // Method to add a new supplier
        public bool ThemNhaCungCap(ref string err, string Supplier_ID, string CompanyName, string PhoneNumber, string AddressSupplier, string Email)
        {
            using (var context = new QLCuaHang())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (string.IsNullOrEmpty(CompanyName))
                        {
                            // Nếu tên công ty không hợp lệ (rỗng hoặc null), thông báo lỗi và trả về false
                            err = "Lỗi: Vui lòng nhập chính xác, đầy đủ thông tin";
                            return false;
                        }

                        // Tạo một đối tượng Supplier mới với các thông tin được cung cấp
                        var supplier = new Supplier
                        {
                            Supplier_ID = Supplier_ID,             // Mã nhà cung cấp
                            CompanyName = CompanyName,             // Tên công ty
                            PhoneNumber = PhoneNumber,             // Số điện thoại
                            AddressSupplier = AddressSupplier,     // Địa chỉ nhà cung cấp
                            Email = Email                          // Địa chỉ email
                        };

                        // Thêm đối tượng Supplier vào DbContext
                        context.Suppliers.Add(supplier);

                        // Lưu thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();

                        // Hoàn thành giao dịch
                        transaction.Commit();

                        // Trả về true để chỉ ra thành công khi thêm nhà cung cấp
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Nếu có lỗi xảy ra, rollback giao dịch và thông báo lỗi
                        transaction.Rollback();
                        err = "Lỗi: " + ex.Message;
                        return false;
                    }
                }
            }
        }

        // Method to update a supplier
        public bool CapNhatNhaCungCap(ref string err, string Supplier_ID, string CompanyName, string PhoneNumber, string AddressSupplier, string Email)
        {
            using (var context = new QLCuaHang())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Tìm nhà cung cấp cần cập nhật dựa trên Supplier_ID
                        var supplierToUpdate = context.Suppliers.FirstOrDefault(s => s.Supplier_ID == Supplier_ID);

                        if (supplierToUpdate != null)
                        {
                            // Cập nhật thông tin của nhà cung cấp
                            supplierToUpdate.CompanyName = CompanyName;
                            supplierToUpdate.PhoneNumber = PhoneNumber;
                            supplierToUpdate.AddressSupplier = AddressSupplier;
                            supplierToUpdate.Email = Email;

                            // Lưu các thay đổi vào cơ sở dữ liệu
                            context.SaveChanges();

                            // Hoàn thành giao dịch
                            transaction.Commit();

                            // Trả về true để chỉ ra thành công khi cập nhật nhà cung cấp
                            return true;
                        }
                        else
                        {
                            // Nếu không tìm thấy nhà cung cấp, thông báo lỗi và trả về false
                            err = "Không tìm thấy nhà cung cấp.";
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Nếu có lỗi xảy ra, rollback giao dịch và thông báo lỗi
                        transaction.Rollback();
                        err = "Lỗi: " + ex.Message;
                        return false;
                    }
                }
            }
        }
    }
}