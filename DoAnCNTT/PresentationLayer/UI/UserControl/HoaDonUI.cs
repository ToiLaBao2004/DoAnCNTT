﻿using BusinessAccessLayer;
using PresentationLayer.UI.Detail;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PresentationLayer.UI.UserControl
{
    public partial class HoaDonUI : Form
    {
        DBHoaDon dbhd;
        DataTable dtHoaDon = null;
        string HD = null;
        string mkh;
        string hd = null;
        string strMaNV = null;
        public HoaDonUI(string s)
        {
            this.strMaNV = s;
            InitializeComponent();
            if (strMaNV.Contains("BH"))
                DeleButton.Visible = false;
            dbhd = new DBHoaDon();
        }
        public void LoadData()
        {
            try
            {
                dgvHoaDon.DataSource = dbhd.LayHoaDon();

                HD = dgvHoaDon.Rows[0].Cells[0].Value.ToString().ToLower();
                LabelSoHoaDonn.Text = (dgvHoaDon.RowCount).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể truy cập!!!\n\nLỗi: " + ex.Message);
            }
        }

        private void HoaDonUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TaoHDForm a = new TaoHDForm(strMaNV);
            a.ShowDialog();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            HDDetail hd = new HDDetail(1, HD);
            hd.ShowDialog();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;

            HD = dgvHoaDon.Rows[r].Cells[0].Value.ToString().ToLower();
            MaHD.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            TenKhachHang.Text = dgvHoaDon.Rows[r].Cells[1].Value.ToString();
            TenNhanVien.Text = dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            Ngay.Text = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
            string a = (string.IsNullOrEmpty(dgvHoaDon.Rows[r].Cells[4].Value.ToString()) ? "0" : dgvHoaDon.Rows[r].Cells[4].Value.ToString());
            decimal value = Convert.ToDecimal(a);
            Total.Text = value.ToString("N0");
            ChietKhau.Text = dgvHoaDon.Rows[r].Cells[5].Value.ToString() + "%";
        }

        private void MHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mkh = txtMKH.Text;
                hd = MHD.Text;
                dgvHoaDon.DataSource = dbhd.TimHoaDon(hd, mkh);
                int r = dgvHoaDon.RowCount;
                if (r > 1)
                {
                    HD = dgvHoaDon.Rows[0].Cells[0].Value.ToString();
                    LabelSoHoaDonn.Text = (dgvHoaDon.RowCount).ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DeleButton_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                // Lấy chỉ số dòng hiện tại của DataGridView
                int rowIndex = dgvHoaDon.CurrentCell.RowIndex;

                // Lấy giá trị của ô trong cột đầu tiên của dòng hiện tại (giả sử đó là mã hóa đơn)
                string maHoaDon = dgvHoaDon.Rows[rowIndex].Cells[0].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không?", "Xác nhận xóa hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) // Nếu người dùng chọn "Có"
                {
                    // Thực hiện xóa hóa đơn từ cơ sở dữ liệu
                    bool f = dbhd.XoaHoaDon(ref err, maHoaDon);
                    if (f)
                    {
                        MessageBox.Show("Đã xóa hóa đơn thành công!");
                    }
                    else
                    {
                        if (err != "Maximum stored procedure, function, trigger, or view nesting level exceeded (limit 32).")
                        {
                            MessageBox.Show("Không xóa được hóa đơn!\n\rLỗi: " + err);
                        }
                        else
                        {
                            MessageBox.Show("Đã xóa hóa đơn thành công!");
                        }
                    }
                }
                else
                {
                    // Người dùng chọn "Không" hoặc đóng hộp thoại xác nhận
                    MessageBox.Show("Thao tác xóa hóa đơn đã bị hủy bởi người dùng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa hóa đơn: " + ex.Message);
            }
        }
    }
}