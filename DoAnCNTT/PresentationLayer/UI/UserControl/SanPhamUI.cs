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
    public partial class SanPhamUI : Form
    {
        DBSanPham dbsp;
        DataTable dtSanPham = null;
        SPDetail detailForm = null;
        string Product_ID = null;
        string DMName = null;
        string THName = null;

        public SanPhamUI()
        {
            InitializeComponent();
            dbsp = new DBSanPham();
        }

        public void LoadData()
        {
            try
            {
                List<dynamic> danhMucList = dbsp.LoadDanhMuc();
                danhMucList.Insert(0, "");
                THCombox.DataSource = danhMucList;

                dtSanPham = new DataTable();
                dgvSanPham.DataSource = dbsp.LoadSanPham();
                SLSP.Text = (dgvSanPham.RowCount).ToString();


            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void SanPhamUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ButtonDM_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                DMName = clickedButton.Text;
                FindButton_Click(sender, e);
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                THName = THCombox.Text;
                Name = NameText.Text.ToLower();
                dgvSanPham.DataSource = dbsp.FindSanPham(Name, THName, DMName);
                int r = dgvSanPham.RowCount;
                if (r > 1)
                {
                    Product_ID = dgvSanPham.Rows[0].Cells[0].Value.ToString();
                    SLSP.Text = (dgvSanPham.RowCount).ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SanPhamUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtSanPham.Dispose();
            dtSanPham = null;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            int r = dgvSanPham.RowCount;
            if (r > 1)
            {
                SPDetail detailForm = new SPDetail(0, Product_ID);
                detailForm.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng chọn sản phẩm");
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSanPham.CurrentCell.RowIndex;
            Product_ID = dgvSanPham.Rows[r].Cells[0].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int r = dgvSanPham.RowCount;
            if (r > 1)
            {
                detailForm = new SPDetail(1, Product_ID);
                detailForm.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn sản phẩm");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            detailForm = new SPDetail(2, Product_ID);
            detailForm.Show();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            NameText.Text = null;
            DMName = null;
            THName = null;
            LoadData();
        }
    }
}
