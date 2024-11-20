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
    public partial class KhachHangUI : Form
    {
        DBKhachHang dbkh;
        DataTable dtKhachHang = null;
        KHDetail ChiTietKhachHang = null;
        TaoKHForm TaoKhachHang = null;
        string Phone = null;
        public KhachHangUI()
        {
            InitializeComponent();
            dbkh = new DBKhachHang();
        }

        public void LoadData()
        {
            try
            {
                dgvKhachHang.DataSource = dbkh.LayKhachHang();

                Phone = dgvKhachHang.Rows[0].Cells[0].Value.ToString();
                LabelSLKH.Text = (dgvKhachHang.RowCount).ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG.Lỗi rồi!!!");
            }
        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string SoDienThoai = txtSoDT.Text;
                string Name = txtName.Text.ToLower();
                dgvKhachHang.DataSource = dbkh.TimKhachHang(SoDienThoai, Name);
                int r = dgvKhachHang.RowCount;
                if (r > 1)
                {
                    Phone = dgvKhachHang.Rows[0].Cells[0].Value.ToString();
                    LabelSLKH.Text = (dgvKhachHang.RowCount).ToString();
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            ChiTietKhachHang = new KHDetail(1, Phone);
            ChiTietKhachHang.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ChiTietKhachHang = new KHDetail(2, Phone);
            ChiTietKhachHang.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TaoKhachHang = new TaoKHForm();
            TaoKhachHang.ShowDialog();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            Phone = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            SDT.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            Ten.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            GT.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            NS.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            Diem.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
            string a = (string.IsNullOrEmpty(dgvKhachHang.Rows[r].Cells[5].Value.ToString()) ? "0" : dgvKhachHang.Rows[r].Cells[5].Value.ToString());
            decimal value = Convert.ToDecimal(a);
            Total.Text = value.ToString("N0");
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            txtSoDT.Text = null;
            txtName.Text = null;
            LoadData();
        }

        private void KhachHangUI_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
