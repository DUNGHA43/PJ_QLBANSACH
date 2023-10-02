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
    public partial class GUI_QLTG : DevExpress.XtraEditors.XtraForm
    {
        DTO_QLTG tg = new DTO_QLTG();
        BLL_QLTG qltg = new BLL_QLTG();
        public GUI_QLTG()
        {
            InitializeComponent();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void showTG()
        {
            dgvDSTG.DataSource = qltg.showTG();
        }
        private void searchMaTG()
        {
            dgvDSTG.DataSource = qltg.searchMaTG(txtTimMaTG.Text.Trim());
        }
        private void searchTenTG()
        {
            dgvDSTG.DataSource = qltg.searchTenTG(txtTimTenTG.Text.Trim());
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tg.maTG = txtMaTG.Text.Trim();
                tg.tenTG = txtTenTG.Text.Trim();
                tg.diaChi = txtDiaChi.Text.Trim();
                qltg.addTG(tg);
                showTG();
                MessageBox.Show("Thêm tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTG.Clear();
                txtTenTG.Clear();
                txtDiaChi.Clear();
            }
            catch
            {
                MessageBox.Show("Thêm tác giả không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tg.maTG = txtMaTG.Text.Trim();
                tg.tenTG = txtTenTG.Text.Trim();
                tg.diaChi = txtDiaChi.Text.Trim();
                qltg.editTG(tg);
                showTG();
                MessageBox.Show("Sửa tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTG.Clear();
                txtTenTG.Clear();
                txtDiaChi.Clear();
            }
            catch
            {
                MessageBox.Show("Sửa tác giả không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tg.maTG = txtMaTG.Text.Trim();
                tg.tenTG = txtTenTG.Text.Trim();
                tg.diaChi = txtDiaChi.Text.Trim();
                qltg.deleteTG(tg);
                showTG();
                MessageBox.Show("Xóa tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTG.Clear();
                txtTenTG.Clear();
                txtDiaChi.Clear();
            }
            catch
            {
                MessageBox.Show("Xóa tác giả không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimMaTG_TextChanged(object sender, EventArgs e)
        {
            searchMaTG();
        }

        private void txtTimTenTG_TextChanged(object sender, EventArgs e)
        {
            searchTenTG();
        }

        private void dgvDSTG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSTG.CurrentRow.Index;
            txtMaTG.Text = dgvDSTG.Rows[i].Cells[0].Value.ToString();
            txtTenTG.Text = dgvDSTG.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDSTG.Rows[i].Cells[2].Value.ToString();
        }

        private void GUI_QLTG_Load(object sender, EventArgs e)
        {
            showTG();
        }
    }
}