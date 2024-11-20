using BusinessAccessLayer;
using PresentationLayer.UI.Detail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UI.UserControl
{
    public partial class NhanVienUI : Form
    {
        DBNhanVien dbnv;
        DataTable dtNhanVien = null;
        NVDetail a = null;
        string ID = null;
        public NhanVienUI(string s)
        {
            InitializeComponent();
            dbnv = new DBNhanVien();
            if (s.Contains("BH"))
            {
                DeleBtn.Visible = false;
                ReadButton.Visible = false;
                UpdateButton.Visible = false;
                AddButton.Visible = false;
            }

        }
        public void LoadData()
        {
            try
            {
                dgvNhanVien.DataSource = dbnv.LayNhanVien();

                ID = dgvNhanVien.Rows[0].Cells[0].Value.ToString().ToLower();
                LabelSNV.Text = (dgvNhanVien.RowCount).ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung .Lỗi rồi!!!");
            }
        }

        private void NhanVienUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            a = new NVDetail(1, ID);
            a.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            a = new NVDetail(2, ID);
            a.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            a = new NVDetail(3, ID);
            a.ShowDialog();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            ID = dgvNhanVien.Rows[r].Cells[0].Value.ToString().ToLower();
            txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            txtGT.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            Ngay.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            string a = (string.IsNullOrEmpty(dgvNhanVien.Rows[r].Cells[7].Value.ToString()) ? "0" : dgvNhanVien.Rows[r].Cells[7].Value.ToString());
            decimal value = Convert.ToDecimal(a);
            txtTotal.Text = value.ToString("N0");
            txtChucVu.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
        }

        private void MNV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string hd = MNV.Text;
                string name = NameText.Text;
                dgvNhanVien.DataSource = dbnv.TimNhanVien(hd, name);
                int r = dgvNhanVien.RowCount;
                if (r > 1)
                {
                    ID = dgvNhanVien.Rows[0].Cells[0].Value.ToString();
                    LabelSNV.Text = (dgvNhanVien.RowCount).ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            MNV.Text = null;
            NameText.Text = null;
            LoadData();
        }

        private void DeleBtn_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                // Lấy mã nhân viên từ TextBox txtMaNV
                string maNV = txtMaNV.Text;

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên có mã " + maNV + " không?", "Xác nhận xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) // Nếu người dùng chọn "Có"
                {
                    // Thực hiện xóa nhân viên từ cơ sở dữ liệu
                    bool f = dbnv.XoaNhanVien(ref err, maNV);
                    if (f)
                    {
                        MessageBox.Show("Đã xóa nhân viên thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được nhân viên!\n\rLỗi: " + err);
                    }
                }
                else
                {
                    // Người dùng chọn "Không" hoặc đóng hộp thoại xác nhận
                    MessageBox.Show("Thao tác xóa nhân viên đã bị hủy bởi người dùng.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thực hiện được thao tác xóa nhân viên!\n\nLỗi: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa nhân viên: " + ex.Message);
            }
        }
    }
}
