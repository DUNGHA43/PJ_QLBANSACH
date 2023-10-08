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
    public partial class GUI_QLKHOSACH : DevExpress.XtraEditors.XtraForm
    {
        BLL_QLSach qls = new BLL_QLSach();
        DTO_QLSach s = new DTO_QLSach();
        BLL_TaiKhoan qltk = new BLL_TaiKhoan();
        string tk, mk;
        string maTL = "";
        string maTG = "";
        string maNXB = "";
        public GUI_QLKHOSACH()
        {
            InitializeComponent();
        }
        public GUI_QLKHOSACH(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void showS()
        {
            dgvDSSach.DataSource = qls.showSach();
        }
        private void loadTenTG()
        {
            cbxTG.DisplayMember = "tenTG";
            cbxTG.DataSource = qls.loadTenTG();
            cbxTimTG.DisplayMember = "tenTG";
            cbxTimTG.DataSource = qls.loadTenTG();
        }
        private void loadTenTL()
        {
            cbxTL.DisplayMember = "tenTL";
            cbxTL.DataSource = qls.loadTenTL();
            cbxTimTL.DisplayMember = "tenTL";
            cbxTimTL.DataSource = qls.loadTenTL();
        }
        private void loadTenNXB()
        {
            cbxNXB.DisplayMember = "tenNXB";
            cbxNXB.DataSource = qls.loadTenNXB();
        }
        private void GUI_QLKHOSACH_Load(object sender, EventArgs e)
        {
            showS();
            loadTenTL();
            loadTenTG();
            loadTenNXB();
            cbxTimTL.Text = "";
            cbxTimTG.Text = "";
            string kt = qltk.getCV(tk);
            if (kt == "Sếp".Trim())
            {
                txtGiaNhap.ReadOnly = false;
                txtGiaBan.ReadOnly = false;
            }
            else if (kt == "Quản lý".Trim())
            {
                txtGiaBan.ReadOnly = true;
                txtGiaNhap.ReadOnly = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }    
            else if (kt == "Nhân viên".Trim())
            {
                txtGiaBan.ReadOnly = true;
                txtGiaNhap.ReadOnly = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }    
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                s.maS = txtMaS.Text.Trim();
                s.tenS = txtTenS.Text.Trim();
                s.soLuongTon = 0;
                s.giaNhap = int.Parse(txtGiaNhap.Text.Trim());
                s.giaBan = int.Parse(txtGiaBan.Text.Trim());
                s.maTL = maTL;
                s.maTG = maTG;
                s.maNXB = maNXB;
                qls.addSach(s);
                showS();
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaS.Clear();
                txtTenS.Clear();
                txtSLTon.Clear();
                txtGiaNhap.Clear();
                txtGiaBan.Clear();
                cbxNXB.Text = "";
                cbxTG.Text = "";
                cbxTL.Text = "";
            }
            catch
            {
                MessageBox.Show("Thêm sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                s.maS = txtMaS.Text.Trim();
                s.tenS = txtTenS.Text.Trim();
                s.soLuongTon = Convert.ToInt32(txtSLTon.Text.Trim());
                s.giaNhap = int.Parse(txtGiaNhap.Text.Trim());
                s.giaBan = int.Parse(txtGiaBan.Text.Trim());
                s.maTL = maTL;
                s.maTG = maTG;
                s.maNXB = maNXB;
                qls.editSach(s);
                showS();
                MessageBox.Show("Sửa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaS.Clear();
                txtTenS.Clear();
                txtSLTon.Clear();
                txtGiaNhap.Clear();
                txtGiaBan.Clear();
                cbxNXB.Text = "";
                cbxTG.Text = "";
                cbxTL.Text = "";
            }
            catch
            {
                MessageBox.Show("Sửa sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                s.maS = txtMaS.Text.Trim();
                s.tenS = txtTenS.Text.Trim();
                s.soLuongTon = int.Parse(txtSLTon.Text.Trim());
                s.giaNhap = int.Parse(txtGiaNhap.Text.Trim());
                s.giaBan = int.Parse(txtGiaBan.Text.Trim());
                s.maTL = maTL;
                s.maTG = maTG;
                s.maNXB = maNXB;
                qls.deleteSach(s);
                showS();
                MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaS.Clear();
                txtTenS.Clear();
                txtSLTon.Clear();
                txtGiaNhap.Clear();
                txtGiaBan.Clear();
                cbxNXB.Text = "";
                cbxTG.Text = "";
                cbxTL.Text = "";
            }
            catch
            {
                MessageBox.Show("Xóa sách không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvDSSach.DataSource = qls.searchSach(txtTimMaS.Text.Trim(), txtTimTenS.Text.Trim(), cbxTimTL.Text.Trim(), cbxTimTG.Text.Trim());
            cbxTimTL.Text = "";
            cbxTimTG.Text = "";
        }

        private void dgvDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSSach.CurrentRow.Index;
            txtMaS.Text = dgvDSSach.Rows[i].Cells[0].Value.ToString();
            txtTenS.Text = dgvDSSach.Rows[i].Cells[1].Value.ToString();
            txtSLTon.Text = dgvDSSach.Rows[i].Cells[2].Value.ToString();
            txtGiaNhap.Text = dgvDSSach.Rows[i].Cells[3].Value.ToString();
            txtGiaBan.Text = dgvDSSach.Rows[i].Cells[4].Value.ToString();
            cbxTL.Text = dgvDSSach.Rows[i].Cells[5].Value.ToString();
            cbxTG.Text = dgvDSSach.Rows[i].Cells[6].Value.ToString();
            cbxNXB.Text = dgvDSSach.Rows[i].Cells[7].Value.ToString();
            dgvDSSach.ClearSelection();
        }

        private void cbxNXB_TextChanged(object sender, EventArgs e)
        {
                maNXB = qls.loadMaNXB(cbxNXB.Text.Trim());
        }

        private void cbxTG_TextChanged(object sender, EventArgs e)
        {
                maTG = qls.loadMaTG(cbxTG.Text.Trim());
        }

        private void cbxTL_TextChanged(object sender, EventArgs e)
        {
                maTL = qls.loadMaTL(cbxTL.Text.Trim());
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showS();
            txtMaS.Clear();
            txtTenS.Clear();
            txtSLTon.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtTimMaS.Clear();
            txtTimTenS.Clear();
            cbxTimTL.Text = "";
            cbxTimTG.Text = "";
        }
    }
}