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
    public partial class GUI_THAYMK : DevExpress.XtraEditors.XtraForm
    {
        string tk, mk;
        DTO_TaiKhoan dn = new DTO_TaiKhoan();
        BLL_TaiKhoan id = new BLL_TaiKhoan();
        public GUI_THAYMK(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }
        private void GUI_THAYMK_Load(object sender, EventArgs e)
        {
            lbTKDMK.Text = " ID: " + tk;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void chkShowMK_Click(object sender, EventArgs e)
        {
            if(chkShowMK.Checked == true)
            {
                txtMKCu.PasswordChar = '\0';
                txtMKMoi.PasswordChar = '\0';
            }
            else
            {
                txtMKCu.PasswordChar = '*';
                txtMKMoi.PasswordChar = '*';
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                dn.tk = tk;
                dn.mk = txtMKMoi.Text;
                if(txtMKCu.Text == mk)
                {
                    id.DoiMatKhau(dn);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    mk = txtMKMoi.Text;
                    txtMKCu.Text = "";
                    txtMKMoi.Text = "";
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ sai!");
                    txtMKCu.Text = null;
                    txtMKMoi.Text = null;
                }
            }
            catch
            {
                MessageBox.Show("Đổi mật khẩu không thành công!");
            }
        }
    }
}