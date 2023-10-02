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
    public partial class GUI_QLNHAPSACH : DevExpress.XtraEditors.XtraForm
    {
        private string tk, mk;
        DTO_QLPhieuNhap pn = new DTO_QLPhieuNhap();
        BLL_QLPhieuNhap qlpn = new BLL_QLPhieuNhap();
        public GUI_QLNHAPSACH()
        {
            InitializeComponent();
        }
        public GUI_QLNHAPSACH(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void showDSPN()
        {
            dgvDSPN.DataSource = qlpn.showPN();
        }
        private void showTenNXB()
        {
            cbxMaNXB.DisplayMember = "tenNXB";
            cbxMaNXB.DataSource = qlpn.loadTenNXB();
        }
        private void GUI_QLNHAPSACH_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = qlpn.getMaNV(tk);
            showDSPN();
            showTenNXB();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pn.maPN = txtMaPN.Text.Trim();
                pn.ngayNhap = dtpNgayNhap.Text.Trim();
                pn.maNXB = qlpn.getMaNXB(cbxMaNXB.Text.Trim());
                pn.maNV = txtMaNV.Text.Trim();
                pn.tongTien = 0;
                qlpn.addPN(pn);
                showDSPN();
                MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPN.Clear();
                cbxMaNXB.Text = "";
                txtTongTien.Clear();
            }
            catch
            {
                MessageBox.Show("Thêm phiếu nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pn.maPN = txtMaPN.Text.Trim();
                pn.ngayNhap = dtpNgayNhap.Text.Trim();
                pn.maNXB = qlpn.getMaNXB(cbxMaNXB.Text.Trim());
                pn.maNV = txtMaNV.Text.Trim();
                pn.tongTien = int.Parse(txtTongTien.Text);
                qlpn.editPN(pn);
                showDSPN();
                MessageBox.Show("Sửa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPN.Clear();
                cbxMaNXB.Text = "";
                txtTongTien.Clear();
            }
            catch
            {
                MessageBox.Show("Sửa phiếu nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pn.maPN = txtMaPN.Text.Trim();
                qlpn.deletePN(pn);
                showDSPN();
                MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPN.Clear();
                cbxMaNXB.Text = "";
                txtTongTien.Clear();
            }
            catch
            {
                MessageBox.Show("Xóa phiếu nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDSPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSPN.CurrentRow.Index;
            txtMaPN.Text = dgvDSPN.Rows[i].Cells[0].Value.ToString();
            dtpNgayNhap.Value = (DateTime)dgvDSPN.Rows[i].Cells[1].Value;
            cbxMaNXB.Text = dgvDSPN.Rows[i].Cells[2].Value.ToString();
            txtMaNV.Text = dgvDSPN.Rows[i].Cells[3].Value.ToString();
            txtTongTien.Text = dgvDSPN.Rows[i].Cells[4].Value.ToString();
        }

        private void txtTimMaNhap_TextChanged(object sender, EventArgs e)
        {
            dgvDSPN.DataSource = qlpn.searchPN(txtTimMaNhap.Text.Trim());
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaPN.Clear();
            dtpNgayNhap.Refresh();
            cbxMaNXB.Text = "";
            txtMaNV.Text = qlpn.getMaNV(tk);
            txtTongTien.Clear();
            showDSPN();
        }

        private void btnCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CTPHIEUNHAP ctpn = new GUI_CTPHIEUNHAP(txtMaPN.Text.Trim());
            ctpn.ShowDialog();
            showDSPN();
        }
    }
}