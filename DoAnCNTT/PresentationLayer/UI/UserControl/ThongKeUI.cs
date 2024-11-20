using BusinessAccessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer.UI.UserControl
{
    public partial class ThongKeUI : Form
    {
        private DBThongKe model;

        public ThongKeUI()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            Btn7Date.Select();

            model = new DBThongKe();
            DisableCustomDates();
            LoadData();
        }

        private void LoadData()
        {
            // Tải dữ liệu từ model dựa trên ngày bắt đầu và ngày kết thúc được chọn
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);

            // Kiểm tra liệu việc tải dữ liệu thành công hay không
            if (refreshData == true)
            {
                // Hiển thị số lượng đơn hàng lên TextBox (SLDH)
                SLDH.Text = model.NumOrder.ToString();

                // Hiển thị tổng doanh thu lên Label (lbTotalRe) với định dạng số có dấu phân cách hàng nghìn
                lbTotalRe.Text = model.TotalRevenue.ToString("N0");

                // Hiển thị tổng lợi nhuận lên Label (lbTotalPro) với định dạng số có dấu phân cách hàng nghìn
                lbTotalPro.Text = model.TotalProfit.ToString("N0");

                // Hiển thị số lượng khách hàng lên TextBox (SLKH)
                SLKH.Text = model.NumCustommers.ToString();

                // Hiển thị số lượng nhà cung cấp lên TextBox (SLNCC)
                SLNCC.Text = model.NumSuppliers.ToString();

                // Hiển thị số lượng sản phẩm lên TextBox (SLSPham)
                SLSPham.Text = model.NumProduct.ToString();

                // Cập nhật dữ liệu biểu đồ Gross Revenue từ danh sách trong model
                chartGross.DataSource = model.GrossRevenueList;
                chartGross.Series[0].XValueMember = "Date";
                chartGross.Series[0].YValueMembers = "TotalAmount";
                chartGross.DataBind();

                // Cập nhật dữ liệu biểu đồ sản phẩm hàng đầu từ danh sách trong model
                chartProduct.DataSource = model.TopProductsList;
                chartProduct.Series[0].XValueMember = "Key";
                chartProduct.Series[0].YValueMembers = "Value";
                chartProduct.DataBind();

                // Hiển thị dữ liệu danh sách các mặt hàng thiếu trên DataGridView (dgvUnderstock)
                dgvUnderstock.DataSource = model.UnderstocksList;
            }
            else
            {
                // Hiển thị thông báo lỗi nếu không thể tải dữ liệu
                MessageBox.Show("Không thể tải dữ liệu.");
            }
        }
        private void DisableCustomDates()
        {
            // Vô hiệu hóa điều khiển chọn ngày bắt đầu (dtpStartDate)
            dtpStartDate.Enabled = false;

            // Vô hiệu hóa điều khiển chọn ngày kết thúc (dtpEndDate)
            dtpEndDate.Enabled = false;

            // Ẩn phần tử được đại diện bởi tick (có thể là một đối tượng kiểu Control, ví dụ là một đánh dấu hoặc biểu tượng)
            tick.Visible = false;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            // Đặt giá trị của điều khiển chọn ngày bắt đầu (dtpStartDate) là ngày hôm nay
            dtpStartDate.Value = DateTime.Today;

            // Đặt giá trị của điều khiển chọn ngày kết thúc (dtpEndDate) là ngày và giờ hiện tại
            dtpEndDate.Value = DateTime.Now;

            // Gọi phương thức LoadData() để tải dữ liệu dựa trên các giá trị ngày được đặt ở trên
            LoadData();

            // Gọi phương thức DisableCustomDates() để vô hiệu hóa các tùy chọn ngày tùy chỉnh khác
            DisableCustomDates();
        }

        private void Btn7Date_Click(object sender, EventArgs e)
        {
            // Đặt giá trị của điều khiển chọn ngày bắt đầu (dtpStartDate) là ngày hôm nay trừ đi 7 ngày
            dtpStartDate.Value = DateTime.Today.AddDays(-7);

            // Đặt giá trị của điều khiển chọn ngày kết thúc (dtpEndDate) là ngày và giờ hiện tại
            dtpEndDate.Value = DateTime.Now;

            // Gọi phương thức LoadData() để tải dữ liệu dựa trên các giá trị ngày được đặt ở trên
            LoadData();

            // Gọi phương thức DisableCustomDates() để vô hiệu hóa các tùy chọn ngày tùy chỉnh khác
            DisableCustomDates();
        }

        private void btnLast30_Click(object sender, EventArgs e)
        {
            // Đặt giá trị của điều khiển chọn ngày bắt đầu (dtpStartDate) là ngày hôm nay trừ đi 30 ngày
            dtpStartDate.Value = DateTime.Today.AddDays(-30);

            // Đặt giá trị của điều khiển chọn ngày kết thúc (dtpEndDate) là ngày và giờ hiện tại
            dtpEndDate.Value = DateTime.Now;

            // Gọi phương thức LoadData() để tải dữ liệu dựa trên các giá trị ngày được đặt ở trên
            LoadData();

            // Gọi phương thức DisableCustomDates() để vô hiệu hóa các tùy chọn ngày tùy chỉnh khác
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            // Đặt giá trị của điều khiển chọn ngày bắt đầu (dtpStartDate) là ngày đầu tiên của tháng hiện tại
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            // Đặt giá trị của điều khiển chọn ngày kết thúc (dtpEndDate) là ngày và giờ hiện tại
            dtpEndDate.Value = DateTime.Now;

            // Gọi phương thức LoadData() để tải dữ liệu dựa trên các giá trị ngày được đặt ở trên
            LoadData();

            // Gọi phương thức DisableCustomDates() để vô hiệu hóa các tùy chọn ngày tùy chỉnh khác
            DisableCustomDates();
        }

        private void btnOKCustom_Click(object sender, EventArgs e)
        {
            // Cho phép điều khiển chọn ngày bắt đầu (dtpStartDate) có thể được tương tác
            dtpStartDate.Enabled = true;

            // Cho phép điều khiển chọn ngày kết thúc (dtpEndDate) có thể được tương tác
            dtpEndDate.Enabled = true;

            // Hiển thị phần tử được đại diện bởi tick (có thể là một đối tượng kiểu Control) trên giao diện người dùng
            tick.Visible = true;
        }

        private void tick_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
