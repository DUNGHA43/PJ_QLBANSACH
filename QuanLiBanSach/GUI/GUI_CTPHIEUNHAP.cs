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
    public partial class GUI_CTPHIEUNHAP : DevExpress.XtraEditors.XtraForm
    {
        private string maPN;
        private int slf = 0;
        DTO_CTPhieuNhap ctpn = new DTO_CTPhieuNhap();
        BLL_CTPhieuNhap qlctpn = new BLL_CTPhieuNhap();
        public GUI_CTPHIEUNHAP()
        {
            InitializeComponent();
        }
        public GUI_CTPHIEUNHAP(string maPN)
        {
            InitializeComponent();
            this.maPN = maPN;
        }
        private void showS()
        {
            dgvDSSach.DataSource = qlctpn.showSach(txtMaPN.Text.Trim());
        }
        private void showCTPN()
        {
            dgvDSCTPN.DataSource = qlctpn.showCTPN(txtMaPN.Text.Trim());
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void GUI_CTPHIEUNHAP_Load(object sender, EventArgs e)
        {
            txtMaPN.Text = maPN;
            showCTPN();
            showS();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ctpn.maPN = txtMaPN.Text.Trim();
                ctpn.maS = txtMaS.Text.Trim();
                ctpn.soLuong = int.Parse(txtSL.Text.Trim());
                ctpn.giaNhap = int.Parse(txtGiaTien.Text.Trim());
                qlctpn.addS(ctpn);
                showCTPN();
                showS();
                qlctpn.updateTongPN(ctpn);
                txtSL.Text = "0";
                txtGiaTien.Clear();
            }
            catch
            {
                MessageBox.Show("Thêm vào không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ctpn.maPN = txtMaPN.Text.Trim();
                ctpn.maS = txtMaS.Text.Trim();
                ctpn.soLuong = int.Parse(txtSL.Text.Trim());
                ctpn.giaNhap = int.Parse(txtGiaTien.Text.Trim());
                qlctpn.deleteS(ctpn);
                showCTPN();
                showS();
                qlctpn.updateTongPN(ctpn);
                txtSL.Text = "0";
                txtGiaTien.Clear();
            }
            catch
            {
                MessageBox.Show("Bạn đã xóa hết sách khỏi phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                qlctpn.updateTongPN(txtMaPN.Text.Trim(), 0);
            }
        }
        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if(txtSL.Text == "")
            {
                MessageBox.Show("Không được để trống số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaTien.Clear();
            }
            else
            {
                txtGiaTien.Text = qlctpn.getGiaNhap(Convert.ToInt32(txtSL.Text.Trim()), txtMaS.Text.Trim());
            }
        }

        private void txtTimTenSach_TextChanged(object sender, EventArgs e)
        {
            dgvDSSach.DataSource = qlctpn.searchTenS(txtMaPN.Text.Trim(), txtTimTenSach.Text.Trim());
        }

        private void dgvDSSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSCTPN.ClearSelection();
            txtMaS.Clear();
            txtSL.Text = "0";
            int i = dgvDSSach.CurrentRow.Index;
            txtMaS.Text = dgvDSSach.Rows[i].Cells[0].Value.ToString();
        }

        private void dgvDSCTPN_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDSSach.ClearSelection();
            txtMaS.Clear();
            int i = dgvDSCTPN.CurrentRow.Index;
            txtMaPN.Text = dgvDSCTPN.Rows[i].Cells[0].Value.ToString();
            txtMaS.Text = dgvDSCTPN.Rows[i].Cells[1].Value.ToString();
            txtSL.Text = dgvDSCTPN.Rows[i].Cells[2].Value.ToString();
            slf = int.Parse(dgvDSCTPN.Rows[i].Cells[2].Value.ToString());
            txtGiaTien.Text = dgvDSCTPN.Rows[i].Cells[3].Value.ToString();
        }

        private void btnS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ctpn.maPN = txtMaPN.Text.Trim();
                ctpn.maS = txtMaS.Text.Trim();
                ctpn.soLuong = int.Parse(txtSL.Text.Trim());
                ctpn.giaNhap = int.Parse(txtGiaTien.Text.Trim());
                qlctpn.editS(ctpn, slf);
                showCTPN();
                showS();
                qlctpn.updateTongPN(ctpn);
                txtSL.Text = "0";
                txtGiaTien.Clear();
            }
            catch
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}