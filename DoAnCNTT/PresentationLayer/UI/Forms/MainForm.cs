using PresentationLayer.UI.UserControl;
using System;
using System.Windows.Forms;

namespace PresentationLayer.UI.Forms
{
    public partial class MainForm : Form
    {
        SanPhamUI sanPhamUI = new SanPhamUI();
        KhachHangUI khachHangUI = new KhachHangUI();
        NhanVienUI nhanVienUI = new NhanVienUI();
        HoaDonUI hoaDonUI = new HoaDonUI();
        BienLaiUI bienLaiUI = new BienLaiUI();
        NhaCungCapUI nhaCungCapUI = new NhaCungCapUI();
        ThongKeUI thongKeUI = new ThongKeUI();
        public MainForm(string s)
        {
            InitializeComponent();
            addForm();
            sanPhamUI.Show();
            this.Closed += new EventHandler(MainForm_FormClosed);
        }

        private void ButtonSP_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            sanPhamUI.Show();
        }
        void addForm()
        {
            sanPhamUI.TopLevel = false;
            panel1.Controls.Add(sanPhamUI);

            khachHangUI.TopLevel = false;
            panel1.Controls.Add(khachHangUI);

            nhanVienUI.TopLevel = false;
            panel1.Controls.Add(nhanVienUI);

            hoaDonUI.TopLevel = false;
            panel1.Controls.Add(hoaDonUI);

            bienLaiUI.TopLevel = false;
            panel1.Controls.Add(bienLaiUI);

            nhaCungCapUI.TopLevel = false;
            panel1.Controls.Add(nhaCungCapUI);

            thongKeUI.TopLevel = false;
            panel1.Controls.Add(thongKeUI);
        }
        void TurnOffAllForm()
        {
            sanPhamUI.Hide();
            khachHangUI.Hide();
            nhanVienUI.Hide();
            hoaDonUI.Hide();
            bienLaiUI.Hide();
            nhaCungCapUI.Hide();
            thongKeUI.Hide();
        }

        private void MainForm_FormClosed(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonKH_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            khachHangUI.Show();
        }

        private void ButtonHDBH_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            hoaDonUI.Show();
        }

        private void ButtonNV_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            nhanVienUI.Show();
        }

        private void ButtonNCC_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            nhaCungCapUI.Show();
        }

        private void ButtonHDNH_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            bienLaiUI.Show();
        }

        private void ButtonTK_Click(object sender, EventArgs e)
        {
            TurnOffAllForm();
            thongKeUI.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất không", "Đăng xuất", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
