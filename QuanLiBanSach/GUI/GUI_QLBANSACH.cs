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
    public partial class GUI_QLBANSACH : DevExpress.XtraEditors.XtraForm
    {
        string tk, mk;
        DTO_QLBanSach hd = new DTO_QLBanSach();
        BLL_QLBanSach qlhd = new BLL_QLBanSach();
        public GUI_QLBANSACH()
        {
            InitializeComponent();
        }
        public GUI_QLBANSACH(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }
        private void showDSHD()
        {
            dgvDSHD.DataSource = qlhd.showHD();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void GUI_QLBANSACH_Load(object sender, EventArgs e)
        {
            showDSHD();
            txtMaNV.Text = qlhd.getMaNV(tk);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                hd.maHD = txtHoaDon.Text.Trim();
                hd.ngayBan = dtpNgayBan.Text.Trim();
                hd.maNV = txtMaNV.Text.Trim();
                hd.tongTien = int.Parse(txtTongTien.Text.Trim());
                qlhd.addHD(hd);
                showDSHD();
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoaDon.Clear();
                txtTongTien.Text = "0";
            }
            catch
            {
                MessageBox.Show("Thêm hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                hd.maHD = txtHoaDon.Text.Trim();
                hd.ngayBan = dtpNgayBan.Text.Trim();
                hd.maNV = txtMaNV.Text.Trim();
                hd.tongTien = int.Parse(txtTongTien.Text.Trim());
                qlhd.editHD(hd);
                showDSHD();
                MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoaDon.Clear();
                txtTongTien.Text = "0";
            }
            catch
            {
                MessageBox.Show("Sửa hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                hd.maHD = txtHoaDon.Text.Trim();
                hd.ngayBan = dtpNgayBan.Text.Trim();
                hd.maNV = txtMaNV.Text.Trim();
                hd.tongTien = int.Parse(txtTongTien.Text.Trim());
                qlhd.deleteHD(hd);
                showDSHD();
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoaDon.Clear();
                txtTongTien.Text = "0";
            }
            catch
            {
                MessageBox.Show("Xóa hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimMaHD_TextChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = qlhd.searchHD(txtTimMaHD.Text.Trim());
        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSHD.CurrentRow.Index;
            txtHoaDon.Text = dgvDSHD.Rows[i].Cells[0].Value.ToString();
            dtpNgayBan.Text = dgvDSHD.Rows[i].Cells[1].Value.ToString();
            txtTongTien.Text = dgvDSHD.Rows[i].Cells[3].Value.ToString();
        }

        private void btnInHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hd.maHD = txtHoaDon.Text.Trim();
            RP_INHD rp = new RP_INHD();
            rp.SetDataSource(qlhd.inHD(hd));
            GUI_RP RP = new GUI_RP();
            RP.cryRP.ReportSource = rp;
            RP.ShowDialog();
        }

        private void btnCTHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CTHOADON cthd = new GUI_CTHOADON(txtHoaDon.Text.Trim());
            cthd.ShowDialog();
            showDSHD();
        }
    }
}