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
    public partial class GUI_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        DTO_TaiKhoan dn = new DTO_TaiKhoan();
        BLL_TaiKhoan tk = new BLL_TaiKhoan();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void ckbShowPW_Click(object sender, EventArgs e)
        {
            if(ckbShowPW.Checked == true)
            {
                txtPW.PasswordChar = '\0';
            }    
            else
            {
                txtPW.PasswordChar = '*';
            }    
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            dn.tk = txtID.Text;
            string kt = tk.getCV(dn.tk);
            if(txtPW.Text == tk.DangNhap(dn) && kt == "Sếp".Trim())
            {
                GUI_GDCHINH gdc = new GUI_GDCHINH(txtID.Text,txtPW.Text);
                this.Hide();
                gdc.ShowDialog();
                this.Close();
            }
            else if(txtPW.Text == tk.DangNhap(dn) && kt == "Quản lý".Trim())
            {
                GUI_GDCHINH_QL gdc_ql = new GUI_GDCHINH_QL(txtID.Text, txtPW.Text);
                this.Hide();
                gdc_ql.ShowDialog();
                this.Close();
            }
            else if (txtPW.Text == tk.DangNhap(dn) && kt == "Nhân viên".Trim())
            {
                GUI_GDCHINH_NV gdc_nv = new GUI_GDCHINH_NV(txtID.Text, txtPW.Text);
                this.Hide();
                gdc_nv.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}