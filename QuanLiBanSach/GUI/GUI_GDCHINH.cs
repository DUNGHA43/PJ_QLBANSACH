﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_GDCHINH : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string tk;
        string mk;
        public GUI_GDCHINH()
        {
            InitializeComponent();
        }
        public GUI_GDCHINH(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

        void openForm(Type typeForm, string tk, string mk)
        {
            foreach(var frm in MdiChildren)
            {
                if(frm.GetType() == typeForm)
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

        private void btnQLND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLNGUOIDUNG));
        }

        private void btnTMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_THAYMK), tk, mk);
        }

        private void btnQLNHAP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLNHAPSACH),tk, mk);
        }

        private void btnQLBAN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLBANSACH), tk, mk);
        }

        private void btnKhoSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLKHOSACH), tk, mk);
        }

        private void btnQLNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLNHANVIEN));
        }

        private void btnQLNXB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLNXB));
        }

        private void btnQLTL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLTL));
        }

        private void btnQLTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_QLTG));
        }

        private void btnTKNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_TKNHAP));
        }

        private void GUI_GDCHINH_Load(object sender, EventArgs e)
        {
            ribbonControl1.SelectedPage = ribbonPage2;
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            GUI_DangNhap dn = new GUI_DangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void btnTKBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_TKBAN));
        }

        private void btnTKSLT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openForm(typeof(GUI_TKSL));
        }
    }
}
