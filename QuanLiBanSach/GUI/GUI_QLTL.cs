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
    public partial class GUI_QLTL : DevExpress.XtraEditors.XtraForm
    {
        DTO_QLTL tl = new DTO_QLTL();
        BLL_QLTL qltl = new BLL_QLTL();
        public GUI_QLTL()
        {
            InitializeComponent();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void showTL()
        {
            dgvDSTL.DataSource = qltl.showTL();
        }
        private void searchMaTL()
        {
            dgvDSTL.DataSource = qltl.searchMaTL(txtTimMaLT.Text.Trim());
        }
        private void searchTenTL()
        {
            dgvDSTL.DataSource = qltl.searchTenTL(txtTimTenTL.Text.Trim());
        }

        private void GUI_QLTL_Load(object sender, EventArgs e)
        {
            showTL();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tl.maTL = txtMaTL.Text.Trim();
                tl.tenTL = txtTenTL.Text.Trim();
                qltl.addTL(tl);
                showTL();
                MessageBox.Show("Thêm thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTL.Clear();
                txtTenTL.Clear();
            }
            catch
            {
                MessageBox.Show("Thêm thể loại không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tl.maTL = txtMaTL.Text.Trim();
                tl.tenTL = txtTenTL.Text.Trim();
                qltl.editTL(tl);
                showTL();
                MessageBox.Show("Sửa thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTL.Clear();
                txtTenTL.Clear();
            }
            catch
            {
                MessageBox.Show("Sửa thể loại không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tl.maTL = txtMaTL.Text.Trim();
                tl.tenTL = txtTenTL.Text.Trim();
                qltl.deleteTL(tl);
                showTL();
                MessageBox.Show("Xóa thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTL.Clear();
                txtTenTL.Clear();
            }
            catch
            {
                MessageBox.Show("Xóa thể loại không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimMaLT_TextChanged(object sender, EventArgs e)
        {
            searchMaTL();
        }

        private void txtTimTenTL_TextChanged(object sender, EventArgs e)
        {
            searchTenTL();
        }

        private void dgvDSTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSTL.CurrentRow.Index;
            txtMaTL.Text = dgvDSTL.Rows[i].Cells[0].Value.ToString();
            txtTenTL.Text = dgvDSTL.Rows[i].Cells[1].Value.ToString();
        }
    }
}