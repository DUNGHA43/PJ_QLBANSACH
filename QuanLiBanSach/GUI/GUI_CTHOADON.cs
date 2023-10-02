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
    public partial class GUI_CTHOADON : DevExpress.XtraEditors.XtraForm
    {
        string maHD;
        BLL_CTHoaDon qlcthd = new BLL_CTHoaDon();
        DTO_CTHoaDon cthd = new DTO_CTHoaDon();
        public GUI_CTHOADON()
        {
            InitializeComponent();
        }
        public GUI_CTHOADON(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }
        private void showSach()
        {
            dgvDSS.DataSource = qlcthd.showSach();
        }
        private void showCTHD()
        {
            dgvCTHD.DataSource = qlcthd.showCTHD(maHD);
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtMaS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoLuong.Text = "1";
                txtGiaTien.Text = qlcthd.getGiaBan(int.Parse(txtSoLuong.Text.Trim()), txtMaS.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Mã sách không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cthd.maHD = txtMaHD.Text.Trim();
                cthd.maS = txtMaS.Text.Trim();
                cthd.sL = int.Parse(txtSoLuong.Text.Trim());
                cthd.giaTien = int.Parse(txtGiaTien.Text.Trim());
                qlcthd.addS(cthd);
                qlcthd.updateTongHD(cthd);
                showCTHD();
                showSach();
                txtMaS.Clear();
                txtSoLuong.Clear();
                txtGiaTien.Clear();
            }
            catch
            {
                MessageBox.Show("Thêm sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cthd.maHD = txtMaHD.Text.Trim();
                cthd.maS = txtMaS.Text.Trim();
                cthd.sL = int.Parse(txtSoLuong.Text.Trim());
                cthd.giaTien = int.Parse(txtGiaTien.Text.Trim());
                qlcthd.deleteS(cthd);
                qlcthd.updateTongHD(cthd);
                showCTHD();
                showSach();
                txtMaS.Clear();
                txtSoLuong.Clear();
                txtGiaTien.Clear();
            }
            catch
            {
                showCTHD();
                showSach();
                MessageBox.Show("Bạn đã xóa hết sách trong hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaS.Clear();
                txtSoLuong.Clear();
                txtGiaTien.Clear();
                qlcthd.updateTongHD(txtMaHD.Text.Trim(), 0);
            }
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            dgvDSS.DataSource = qlcthd.searchTenS(txtTimTen.Text.Trim());
        }

        private void dgvDSS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCTHD.ClearSelection();
            int i = dgvDSS.CurrentRow.Index;
            txtMaS.Text = dgvDSS.Rows[i].Cells[0].Value.ToString();
            dgvDSS.ClearSelection();
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSS.ClearSelection();
            int i = dgvCTHD.CurrentRow.Index;
            txtMaS.Text = dgvCTHD.Rows[i].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvCTHD.Rows[i].Cells[2].Value.ToString();
            txtGiaTien.Text = dgvCTHD.Rows[i].Cells[3].Value.ToString();
            dgvCTHD.ClearSelection();
        }

        private void GUI_CTHOADON_Load(object sender, EventArgs e)
        {
            showCTHD();
            showSach();
            txtMaHD.Text = maHD;
        }

        private void btnThemQR_Click(object sender, EventArgs e)
        {
            try
            {
                cthd.maHD = txtMaHD.Text.Trim();
                cthd.maS = txtMaS.Text.Trim();
                cthd.sL = int.Parse(txtSoLuong.Text.Trim());
                cthd.giaTien = int.Parse(txtGiaTien.Text.Trim());
                qlcthd.addS(cthd);
                qlcthd.updateTongHD(cthd);
                showCTHD();
                showSach();
                txtMaS.Clear();
                txtSoLuong.Clear();
                txtGiaTien.Clear();
            }
            catch
            {
                MessageBox.Show("Thêm sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}