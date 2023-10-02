using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_GDCHINH_NV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string tk;
        string mk;
        public GUI_GDCHINH_NV()
        {
            InitializeComponent();
        }
        public GUI_GDCHINH_NV(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

        void openForm(Type typeForm, string tk, string mk)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm, tk, mk);
            f.MdiParent = this;
            f.Show();
        }
        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        private void GUI_GDCHINH_NV_Load(object sender, EventArgs e)
        {
            ribbon.SelectedPage = ribbonPage2;
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            GUI_DangNhap dn = new GUI_DangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(GUI_THAYMK), tk, mk);
        }

        private void btnBanSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLBANSACH), tk, mk);
        }

        private void btnKhoSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLKHOSACH), tk, mk);
        }

        private void btnTKBan_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnTKDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}