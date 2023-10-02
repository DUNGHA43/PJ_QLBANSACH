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
using DTO;
using BLL;
namespace GUI
{
    public partial class GUI_QLNGUOIDUNG : DevExpress.XtraEditors.XtraForm
    {
        BLL_QLNguoiDung qlnd = new BLL_QLNguoiDung();
        DTO_QLNguoiDung nd = new DTO_QLNguoiDung();
        string maNV = "";
        public GUI_QLNGUOIDUNG()
        {
            InitializeComponent();
        }

        private void showUser()
        {
            dgvDSNguoiDung.DataSource = qlnd.showUser();
        }

        private void showTenNV()
        {
            cbxNV.DisplayMember = "tenNV";
            cbxNV.DataSource = qlnd.showTenNV();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nd.iD = txtID.Text.Trim();
                nd.pW = txtPW.Text.Trim();
                nd.chucVu = cbxCV.Text.Trim();
                nd.maNV = maNV.Trim();
                qlnd.addUser(nd);
                showUser();
                MessageBox.Show("Thêm thành công!");
                txtID.Clear();
                txtPW.Clear();
                cbxCV.Text = "";
                cbxNV.Text = "";
            }
            catch
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nd.iD = txtID.Text.Trim();
                nd.pW = txtPW.Text.Trim();
                nd.chucVu = cbxCV.Text.Trim();
                nd.maNV = maNV.Trim();
                qlnd.editUser(nd);
                showUser();
                MessageBox.Show("Sửa thành công!");
                txtID.Clear();
                txtPW.Clear();
                cbxCV.Text = "";
                cbxNV.Text = "";
            }
            catch
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nd.iD = txtID.Text.Trim();
                qlnd.deleteUser(nd);
                showUser();
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }

        }

        private void GUI_QLNGUOIDUNG_Load(object sender, EventArgs e)
        {
            showUser();
            showTenNV();
        }

        private void cbxNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            maNV = qlnd.loadMaNV(cbxNV.Text.Trim());
        }

        private void dgvDSNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSNguoiDung.CurrentRow.Index;
            txtID.Text = dgvDSNguoiDung.Rows[i].Cells[0].Value.ToString();
            txtPW.Text = dgvDSNguoiDung.Rows[i].Cells[1].Value.ToString();
            cbxCV.Text = dgvDSNguoiDung.Rows[i].Cells[2].Value.ToString();
            cbxNV.Text = dgvDSNguoiDung.Rows[i].Cells[3].Value.ToString();
        }
    }
}