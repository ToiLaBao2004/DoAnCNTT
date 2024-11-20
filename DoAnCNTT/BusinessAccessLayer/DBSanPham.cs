using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DataAccessLayer;
using DataAccessLayer.Entities;
using System.Data.Entity;

namespace BusinessAccessLayer // Declaring the BusinessAccessLayer namespace
{
    public class DBSanPham // Declaring the DBSanPham class
    {

        // Constructor for the DBSanPham class
        public DBSanPham()
        {

        }
        public List<dynamic> LoadSanPham()
        {
            // Sử dụng ngữ cảnh dataContext để làm việc với cơ sở dữ liệu
            using (var dataContext = new QLCuaHang())
            {
                // Truy vấn để lấy danh sách sản phẩm từ bảng Products
                var products = from p in dataContext.Products
                               select new
                               {
                                   p.Product_ID,        // Chọn trường Product_ID từ bảng Products
                                   p.ProductName,       // Chọn trường ProductName từ bảng Products
                                   p.UnitPrice,         // Chọn trường UnitPrice từ bảng Products
                                   p.Quantity           // Chọn trường Quantity từ bảng Products
                               };

                // Chuyển kết quả truy vấn thành danh sách động và trả về
                return products.ToList<dynamic>();
            }
        }

        public List<dynamic> LoadDanhMuc()
        {
            // Sử dụng ngữ cảnh dataContext để làm việc với cơ sở dữ liệu
            using (var dataContext = new QLCuaHang())
            {
                // Truy vấn để lấy danh sách các tên thương hiệu (BrandName) từ bảng Brands
                var brands = from p in dataContext.Brands
                             select p.BrandName;

                // Chuyển kết quả truy vấn thành danh sách động và trả về
                return brands.ToList<dynamic>();
            }
        }

        public List<dynamic> FindSanPham(string keyword, string brand, string cate)
        {
            using (var dataContext = new QLCuaHang())
            {
                // Tìm Brand_ID tương ứng với brand được cung cấp
                var b = (from p in dataContext.Brands
                         where p.BrandName == brand
                         select p.Brand_ID).FirstOrDefault();

                // Tìm Category_ID tương ứng với cate được cung cấp
                var c = (from p in dataContext.Categories
                         where p.CategoryName == cate
                         select p.Category_ID).FirstOrDefault();

                // Kiểm tra nếu không tìm thấy Brand_ID hoặc Category_ID thì gán bằng chuỗi rỗng
                if (b == null)
                {
                    b = "";
                }
                if (c == null)
                {
                    c = "";
                }

                // Truy vấn để lấy danh sách sản phẩm dựa trên keyword, Brand_ID và Category_ID
                var products = from p in dataContext.Products
                               where p.ProductName.ToLower().Contains(keyword)
                                     && p.Brand_ID.Contains(b)
                                     && p.Category_ID.Contains(c)
                               select new
                               {
                                   p.Product_ID,
                                   p.ProductName,
                                   p.UnitPrice,
                                   p.Quantity
                               };

                // Chuyển kết quả truy vấn thành danh sách động và trả về
                return products.ToList<dynamic>();
            }
        }

        public List<Product> ChiTietSP(string id)
        {
            using (var dataContext = new QLCuaHang())
            {
                // Truy vấn để lấy sản phẩm với Product_ID tương ứng
                var products = (from p in dataContext.Products
                                where p.Product_ID == id
                                select p)
                               .Include(p => p.Brand) // Kết nối dữ liệu Brand liên quan đến sản phẩm
                               .Include(p => p.Category) // Kết nối dữ liệu Category liên quan đến sản phẩm
                               .Include(p => p.PictureProduct) // Kết nối dữ liệu PictureProduct liên quan đến sản phẩm
                               .ToList();

                // Trả về danh sách các sản phẩm (có thể chỉ là một sản phẩm) đã lấy được từ truy vấn
                return products;
            }
        }

        public List<dynamic> LaySanPham()
        {
            using (var dataContext = new QLCuaHang())
            {
                // Truy vấn để lấy thông tin cơ bản của các sản phẩm từ bảng Products
                var products = from p in dataContext.Products
                               select new
                               {
                                   p.Product_ID,
                                   p.ProductName,
                                   p.UnitPrice,
                                   p.Quantity,
                               };

                // Chuyển kết quả truy vấn thành danh sách động và trả về
                return products.ToList<dynamic>();
            }
        }

        public List<dynamic> LaySanPhamChoFormBienLai()
        {
            using (var dataContext = new QLCuaHang())
            {
                // Truy vấn để lấy danh sách sản phẩm chỉ lấy Product_ID và ProductName
                var products = from p in dataContext.Products
                               select new
                               {
                                   p.Product_ID,
                                   p.ProductName,
                               };

                // Chuyển kết quả truy vấn thành danh sách động và trả về
                return products.ToList<dynamic>();
            }
        }

        public bool SuaHinhAnh(string name, int id)
        {
            using (var context = new QLCuaHang())
            {
                // Tìm kiếm hình ảnh theo id trong bảng PictureProducts
                var pictureProduct = context.PictureProducts.SingleOrDefault(p => p.Picture_ID == id);

                if (pictureProduct != null)
                {
                    // Nếu tìm thấy hình ảnh với id tương ứng
                    // Cập nhật tên hình ảnh thành giá trị mới được truyền vào
                    pictureProduct.Picture_Name = name;

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();
                    return true; // Trả về true để biểu thị quá trình sửa đổi thành công
                }

                return false; // Trả về false nếu không tìm thấy hình ảnh với id đã cho
            }
        }

        public bool ThemHinhAnh(string name)
        {
            using (var context = new QLCuaHang())
            {
                // Tạo một đối tượng PictureProduct mới với tên hình ảnh được cung cấp
                var pictureProduct = new PictureProduct { Picture_Name = name };

                // Kiểm tra pictureProduct có khác null hay không (dòng này không cần thiết vì đây là đối tượng mới)
                if (pictureProduct != null)
                {
                    // Thêm đối tượng PictureProduct vào DbSet PictureProducts trong DbContext
                    context.PictureProducts.Add(pictureProduct);

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();

                    // Trả về true để biểu thị rằng quá trình thêm hình ảnh đã thành công
                    return true;
                }

                // Trả về false nếu đối tượng pictureProduct là null (dòng này sẽ không xảy ra vì đối tượng được tạo mới)
                return false;
            }
        }

        // Method to retrieve categories
        public List<dynamic> LayDanhMuc()
        {
            using (var dataContext = new QLCuaHang())
            {
                // Truy vấn lấy danh sách các danh mục sản phẩm từ DbSet Categories trong dataContext
                var categories = from category in dataContext.Categories
                                 select category;

                // Chuyển kết quả của truy vấn thành một danh sách động (dynamic list) và trả về
                return categories.ToList<dynamic>();
            }
        }

        // Method to retrieve brands
        public List<dynamic> LayThuongHieu()
        {
            using (var dataContext = new QLCuaHang())
            {
                // Truy vấn lấy danh sách các thương hiệu từ DbSet Brands trong dataContext
                var brands = from brand in dataContext.Brands
                             select brand;

                // Chuyển kết quả của truy vấn thành một danh sách động (dynamic list) và trả về
                return brands.ToList<dynamic>();
            }
        }

        // Method to update product details
        public bool CapNhatSanPham(string ma, string ten, int gia, string th, string dm, int sl, int idImg)
        {
            using (var context = new QLCuaHang())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Lấy ID của thương hiệu (brand) từ tên thương hiệu (brand name)
                        var brandID = context.Brands
                            .Where(b => b.BrandName == th)
                            .Select(b => b.Brand_ID)
                            .FirstOrDefault();

                        // Lấy ID của danh mục (category) từ tên danh mục (category name)
                        var categoryID = context.Categories
                            .Where(c => c.CategoryName == dm)
                            .Select(c => c.Category_ID)
                            .FirstOrDefault();

                        // Kiểm tra tính hợp lệ của thông tin sản phẩm
                        if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || gia <= 0 || idImg <= 0 || string.IsNullOrEmpty(dm) || string.IsNullOrEmpty(th))
                        {
                            throw new ArgumentException("Vui lòng nhập đầy đủ và chính xác thông tin sản phẩm.");
                        }

                        // Tìm sản phẩm trong cơ sở dữ liệu dựa trên mã sản phẩm (ma)
                        var product = context.Products.FirstOrDefault(p => p.Product_ID == ma);
                        if (product != null)
                        {
                            // Cập nhật thông tin sản phẩm
                            product.ProductName = ten;
                            product.UnitPrice = gia;
                            product.Quantity = sl;
                            product.Brand_ID = brandID;
                            product.Category_ID = categoryID;
                            product.Picture_ID = idImg;

                            // Lưu các thay đổi vào cơ sở dữ liệu
                            context.SaveChanges();
                            dbContextTransaction.Commit();
                            return true; // Trả về true nếu cập nhật thành công
                        }
                        else
                        {
                            return false; // Trả về false nếu không tìm thấy sản phẩm
                        }
                    }
                    catch (Exception)
                    {
                        dbContextTransaction.Rollback();
                        return false; // Trả về false nếu có lỗi xảy ra trong quá trình cập nhật
                    }
                }
            }
        }

        // Method to add a new product
        public bool TaoSanPham(string ma, string ten, int gia, string th, string dm, int sl, string Img)
        {
            using (var context = new QLCuaHang())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Lấy ID của thương hiệu (brand) từ tên thương hiệu (brand name)
                        var brandID = context.Brands
                            .Where(b => b.BrandName.Contains(th)) // Tìm thương hiệu có tên chứa phần của tham số 'th'
                            .Select(b => b.Brand_ID)
                            .FirstOrDefault();

                        // Lấy ID của danh mục (category) từ tên danh mục (category name)
                        var categoryID = context.Categories
                            .Where(c => c.CategoryName.Contains(dm)) // Tìm danh mục có tên chứa phần của tham số 'dm'
                            .Select(c => c.Category_ID)
                            .FirstOrDefault();

                        // Lấy ID của hình ảnh sản phẩm từ tên hình ảnh (image name)
                        var picID = context.PictureProducts
                            .Where(p => p.Picture_Name.Contains(Img)) // Tìm hình ảnh có tên chứa phần của tham số 'Img'
                            .Select(p => p.Picture_ID)
                            .FirstOrDefault();

                        // Kiểm tra tính hợp lệ của thông tin sản phẩm
                        if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || gia <= 0 || string.IsNullOrEmpty(Img) || string.IsNullOrEmpty(th) || string.IsNullOrEmpty(dm))
                        {
                            throw new ArgumentException("Vui lòng nhập đầy đủ và chính xác thông tin sản phẩm.");
                        }

                        // Tạo đối tượng Product mới
                        var product = new Product
                        {
                            Product_ID = ma,
                            ProductName = ten,
                            UnitPrice = gia,
                            Quantity = sl,
                            Brand_ID = brandID,
                            Category_ID = categoryID,
                            Picture_ID = picID
                        };

                        // Thêm sản phẩm mới vào DbSet của cơ sở dữ liệu
                        context.Products.Add(product);
                        context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                        dbContextTransaction.Commit(); // Commit giao dịch
                        return true; // Trả về true nếu tạo sản phẩm thành công
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback(); // Rollback giao dịch nếu có lỗi xảy ra
                        return false; // Trả về false nếu có lỗi xảy ra trong quá trình tạo sản phẩm
                    }
                }
            }
        }
    }
}