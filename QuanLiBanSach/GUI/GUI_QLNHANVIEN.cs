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
    public partial class GUI_QLNHANVIEN : DevExpress.XtraEditors.XtraForm
    {
        DTO_QLNhanVien nv = new DTO_QLNhanVien();
        BLL_QLNhanVien qlnv = new BLL_QLNhanVien();
        public GUI_QLNHANVIEN()
        {
            InitializeComponent();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void showNV()
        {
            dgvDSNV.DataSource = qlnv.showNV();
        }
        private void searchMaNV()
        {
            dgvDSNV.DataSource = qlnv.searchMaNV(txtTimMaNV.Text.Trim());
        }
        private void searchTenNV()
        {
            dgvDSNV.DataSource = qlnv.searchTenNV(txtTimTenNV.Text);
        }
        private void GUI_QLNHANVIEN_Load(object sender, EventArgs e)
        {
            showNV();
        }

        private void txtTimMaNV_TextChanged(object sender, EventArgs e)
        {
            searchMaNV();
        }

        private void txtTimTenNV_TextChanged(object sender, EventArgs e)
        {
            searchTenNV();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nv.maNV = txtMaNV.Text.Trim();
                nv.tenNV = txtTenNV.Text.Trim();
                nv.ngaySinh = dtpNgaySinh.Text.Trim();
                nv.cccd = txtCanCuoc.Text.Trim();
                nv.soDT = txtSDT.Text.Trim();
                nv.diaChi = txtDiaChi.Text.Trim();
                nv.lichLam = txtlichLam.Text.Trim();
                qlnv.addNV(nv);
                showNV();
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtCanCuoc.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
                txtlichLam.Clear();
            }
            catch
            {
                MessageBox.Show("Thêm nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nv.maNV = txtMaNV.Text.Trim();
                nv.tenNV = txtTenNV.Text.Trim();
                nv.ngaySinh = dtpNgaySinh.Text.Trim();
                nv.cccd = txtCanCuoc.Text.Trim();
                nv.soDT = txtSDT.Text.Trim();
                nv.diaChi = txtDiaChi.Text.Trim();
                nv.lichLam = txtlichLam.Text.Trim();
                qlnv.editNV(nv);
                showNV();
                MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtCanCuoc.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
                txtlichLam.Clear();
            }
            catch
            {
                MessageBox.Show("Sửa nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nv.maNV = txtMaNV.Text.Trim();
                nv.tenNV = txtTenNV.Text.Trim();
                nv.ngaySinh = dtpNgaySinh.Text.Trim();
                nv.cccd = txtCanCuoc.Text.Trim();
                nv.soDT = txtSDT.Text.Trim();
                nv.diaChi = txtDiaChi.Text.Trim();
                nv.lichLam = txtlichLam.Text.Trim();
                qlnv.deleteNV(nv);
                showNV();
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Clear();
                txtTenNV.Clear();
                txtCanCuoc.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();
                txtlichLam.Clear();
            }
            catch
            {
                MessageBox.Show("Xóa nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSNV.CurrentRow.Index;
            txtMaNV.Text = dgvDSNV.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvDSNV.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvDSNV.Rows[i].Cells[2].Value.ToString();
            txtCanCuoc.Text = dgvDSNV.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvDSNV.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvDSNV.Rows[i].Cells[5].Value.ToString();
            txtlichLam.Text = dgvDSNV.Rows[i].Cells[6].Value.ToString();
        }
    }
}