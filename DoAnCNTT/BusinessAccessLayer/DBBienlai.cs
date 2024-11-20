using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DataAccessLayer;
using System.Data.Entity;
using DataAccessLayer.Entities;

namespace BusinessAccessLayer // Declaring the BusinessAccessLayer namespace
{
    public class DBBienLai // Declaring the DBBienLai class
    {

        public DBBienLai() // Constructor for the DBBienLai class
        {

        }

        // Method to retrieve receipts
        public List<dynamic> LayBienLai()
        {
            using (var context = new QLCuaHang())
            {
                // Truy vấn danh sách biên lai từ cơ sở dữ liệu
                var query = from import in context.Imports.Include(o => o.Supplier)
                            select new
                            {
                                import.Import_ID,
                                import.ImportDay,
                                import.Total,
                                import.Supplier_ID,
                                import.Supplier.CompanyName
                            };
                // Trả về danh sách các biên lai dưới dạng danh sách các đối tượng dynamic
                return query.ToList<dynamic>();
            }
        }

        // Method to search for receipts by ID and date
        public List<dynamic> TimBienLai(string HD, string MKH)
        {
            using (var context = new QLCuaHang())
            {
                // Truy vấn danh sách biên lai từ cơ sở dữ liệu với điều kiện tìm kiếm
                var query = from import in context.Imports.Include(o => o.Supplier)
                            where import.Import_ID.ToLower().Contains(HD) && import.Supplier_ID.Contains(MKH)
                            select new
                            {
                                import.Import_ID,
                                import.ImportDay,
                                import.Total,
                                import.Supplier_ID,
                                import.Supplier.CompanyName
                            };
                // Trả về danh sách các biên lai dưới dạng danh sách các đối tượng dynamic
                return query.ToList<dynamic>();
            }
        }

        public List<dynamic> SPCuaBienLai(string HD)
        {
            using (var context = new QLCuaHang())
            {
                // Truy vấn thông tin chi tiết sản phẩm của một biên lai từ cơ sở dữ liệu
                var query = (from import in context.ImportDetails.Include(o => o.Product)
                             where import.Import_ID.ToLower().Contains(HD)
                             select new
                             {
                                 import.Product_ID,
                                 import.Product.ProductName,
                                 import.Quantity,
                                 import.Unitcost
                             });
                // Trả về danh sách các chi tiết sản phẩm của biên lai dưới dạng danh sách các đối tượng dynamic
                return query.ToList<dynamic>();
            }
        }

        public bool ThemBienLai(ref string err, string Import_ID, string Supplier_ID, DateTime ImportDay, int Total)
        {
            using (var context = new QLCuaHang())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra Supplier_ID có được cung cấp hay không
                        if (string.IsNullOrEmpty(Supplier_ID))
                        {
                            throw new ArgumentException("Vui lòng nhập chính xác, đầy đủ thông tin");
                        }

                        // Tạo đối tượng Import mới
                        var import = new Import
                        {
                            Import_ID = Import_ID,
                            Supplier_ID = Supplier_ID,
                            ImportDay = ImportDay.Date,
                            Total = Total
                        };

                        // Thêm đối tượng Import vào cơ sở dữ liệu và lưu thay đổi
                        context.Imports.Add(import);
                        context.SaveChanges();

                        // Commit transaction sau khi thêm thành công
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction nếu có lỗi xảy ra và ghi log lỗi
                        transaction.Rollback();
                        err = "Lỗi: " + ex.Message;
                        return false;
                    }
                }
            }
        }

        public bool ThemChiTietBienLai(ref string err, string Import_ID, string Product_ID, int Quantity, int Unitcost)
        {
            try
            {
                // Kiểm tra các thông tin cần thiết để thêm chi tiết biên lai
                if (string.IsNullOrEmpty(Import_ID) || string.IsNullOrEmpty(Product_ID) || Quantity <= 0 || Unitcost <= 0)
                {
                    throw new ArgumentException("Vui lòng nhập đầy đủ và chính xác thông tin chi tiết biên lai");
                }

                using (var context = new QLCuaHang())
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            // Tạo đối tượng ImportDetail mới
                            var importDetail = new ImportDetail
                            {
                                Import_ID = Import_ID,
                                Product_ID = Product_ID,
                                Quantity = Quantity,
                                Unitcost = Unitcost
                            };

                            // Lấy thông tin sản phẩm từ cơ sở dữ liệu
                            var product = context.Products.FirstOrDefault(p => p.Product_ID == Product_ID);
                            // Lấy thông tin biên lai từ cơ sở dữ liệu
                            var import = context.Imports.FirstOrDefault(i => i.Import_ID == Import_ID);

                            // Kiểm tra nếu sản phẩm và biên lai tồn tại
                            if (product != null && import != null)
                            {
                                // Thêm chi tiết biên lai vào cơ sở dữ liệu
                                context.ImportDetails.Add(importDetail);
                                // Cập nhật số lượng của sản phẩm
                                product.Quantity += Quantity;
                                // Cập nhật tổng giá trị của biên lai
                                import.Total += Quantity * Unitcost;

                                // Lưu các thay đổi vào cơ sở dữ liệu
                                context.SaveChanges();
                                // Commit transaction sau khi thực hiện thành công
                                transaction.Commit();
                                return true;
                            }
                            else
                            {
                                throw new InvalidOperationException("Không tìm thấy sản phẩm hoặc phiếu nhập phù hợp");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Rollback transaction nếu có lỗi xảy ra và ghi log lỗi
                            transaction.Rollback();
                            err = "Lỗi: " + ex.Message;
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu có lỗi xảy ra
                err = "Lỗi: " + ex.Message;
                return false;
            }
        }
    }
}