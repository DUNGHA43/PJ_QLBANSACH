using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class GUI_QLNXB : DevExpress.XtraEditors.XtraForm
    {
        DTO_QLNXB nxb = new DTO_QLNXB();
        BLL_QLNXB qlnxb = new BLL_QLNXB();
        public GUI_QLNXB()
        {
            InitializeComponent();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void showNXB()
        {
            dgvDSNXB.DataSource = qlnxb.showNXB();
        }
        private void searchMaNXB()
        {
            dgvDSNXB.DataSource = qlnxb.searchMaNXB(txtTimMaNXB.Text.Trim());
        }
        private void searchTenNXB()
        {
            dgvDSNXB.DataSource = qlnxb.searchTenNXB(txtTimTenNXB.Text.Trim());
        }

        private void GUI_QLNXB_Load(object sender, EventArgs e)
        {
            showNXB();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nxb.maNXB = txtMaNXB.Text.Trim();
                nxb.tenNXB = txtTenNXB.Text.Trim();
                nxb.dienThoai = txtSDT.Text.Trim();
                nxb.diaChi = txtDiaChi.Text.Trim();
                qlnxb.addNXB(nxb);
                showNXB();
                MessageBox.Show("Thêm nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNXB.Clear();
                txtTenNXB.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
            }
            catch
            {
                MessageBox.Show("Thêm nhà xuất bản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nxb.maNXB = txtMaNXB.Text.Trim();
                nxb.tenNXB = txtTenNXB.Text.Trim();
                nxb.dienThoai = txtSDT.Text.Trim();
                nxb.diaChi = txtDiaChi.Text.Trim();
                qlnxb.editNXB(nxb);
                showNXB();
                MessageBox.Show("Sửa nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNXB.Clear();
                txtTenNXB.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
            }
            catch
            {
                MessageBox.Show("Sửa nhà xuất bản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nxb.maNXB = txtMaNXB.Text.Trim();
                nxb.tenNXB = txtTenNXB.Text.Trim();
                nxb.dienThoai = txtSDT.Text.Trim();
                nxb.diaChi = txtDiaChi.Text.Trim();
                qlnxb.deleteNXB(nxb);
                showNXB();
                MessageBox.Show("Xóa nhà xuất bản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNXB.Clear();
                txtTenNXB.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
            }
            catch
            {
                MessageBox.Show("Xóa nhà xuất bản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimMaNXB_TextChanged(object sender, EventArgs e)
        {
            searchMaNXB();
        }

        private void txtTimTenNXB_TextChanged(object sender, EventArgs e)
        {
            searchTenNXB();
        }

        private void dgvDSNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSNXB.CurrentRow.Index;
            txtMaNXB.Text = dgvDSNXB.Rows[i].Cells[0].Value.ToString();
            txtTenNXB.Text = dgvDSNXB.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dgvDSNXB.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDSNXB.Rows[i].Cells[3].Value.ToString();
        }
    }
}