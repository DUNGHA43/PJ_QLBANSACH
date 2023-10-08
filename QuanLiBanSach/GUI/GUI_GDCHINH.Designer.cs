
namespace GUI
{
    partial class GUI_GDCHINH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_GDCHINH));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnQLND = new DevExpress.XtraBars.BarButtonItem();
            this.btnTMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNHAP = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLBAN = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNXB = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLTG = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKBan = new DevExpress.XtraBars.BarButtonItem();
            this.rbPQLHT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpPGQLND = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPGQLS = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPQLK = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPGQLNV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPTKBC = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbPTK_BC = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnTKSLT = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnQLND,
            this.btnTMK,
            this.btnQLNHAP,
            this.btnQLBAN,
            this.btnKhoSach,
            this.btnDangXuat,
            this.btnQLNV,
            this.btnQLNXB,
            this.btnQLTL,
            this.btnQLTG,
            this.btnTKNhap,
            this.btnTKBan,
            this.btnTKSLT});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPQLHT,
            this.ribbonPage2,
            this.rbPQLK,
            this.rbPTKBC});
            this.ribbonControl1.Size = new System.Drawing.Size(922, 158);
            // 
            // btnQLND
            // 
            this.btnQLND.Caption = "QUẢN LÍ NGƯỜI DÙNG";
            this.btnQLND.Id = 1;
            this.btnQLND.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLND.ImageOptions.Image")));
            this.btnQLND.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLND.ImageOptions.LargeImage")));
            this.btnQLND.Name = "btnQLND";
            this.btnQLND.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnQLND.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLND_ItemClick);
            // 
            // btnTMK
            // 
            this.btnTMK.Caption = "THAY MẬT KHẨU";
            this.btnTMK.Id = 2;
            this.btnTMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTMK.ImageOptions.Image")));
            this.btnTMK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTMK.ImageOptions.LargeImage")));
            this.btnTMK.Name = "btnTMK";
            this.btnTMK.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTMK_ItemClick);
            // 
            // btnQLNHAP
            // 
            this.btnQLNHAP.Caption = "NHẬP SÁCH";
            this.btnQLNHAP.Id = 4;
            this.btnQLNHAP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNHAP.ImageOptions.Image")));
            this.btnQLNHAP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLNHAP.ImageOptions.LargeImage")));
            this.btnQLNHAP.Name = "btnQLNHAP";
            this.btnQLNHAP.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnQLNHAP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNHAP_ItemClick);
            // 
            // btnQLBAN
            // 
            this.btnQLBAN.Caption = "BÁN SÁCH";
            this.btnQLBAN.Id = 5;
            this.btnQLBAN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLBAN.ImageOptions.Image")));
            this.btnQLBAN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLBAN.ImageOptions.LargeImage")));
            this.btnQLBAN.Name = "btnQLBAN";
            this.btnQLBAN.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnQLBAN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLBAN_ItemClick);
            // 
            // btnKhoSach
            // 
            this.btnKhoSach.Caption = "KHO SÁCH";
            this.btnKhoSach.Id = 6;
            this.btnKhoSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoSach.ImageOptions.Image")));
            this.btnKhoSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhoSach.ImageOptions.LargeImage")));
            this.btnKhoSach.Name = "btnKhoSach";
            this.btnKhoSach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnKhoSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoSach_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "ĐĂNG XUẤT";
            this.btnDangXuat.Id = 8;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Caption = "NHÂN VIÊN";
            this.btnQLNV.Id = 9;
            this.btnQLNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.ImageOptions.Image")));
            this.btnQLNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLNV.ImageOptions.LargeImage")));
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNV_ItemClick);
            // 
            // btnQLNXB
            // 
            this.btnQLNXB.Caption = "NHÀ XUẤT BẢN";
            this.btnQLNXB.Id = 10;
            this.btnQLNXB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNXB.ImageOptions.Image")));
            this.btnQLNXB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLNXB.ImageOptions.LargeImage")));
            this.btnQLNXB.Name = "btnQLNXB";
            this.btnQLNXB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNXB_ItemClick);
            // 
            // btnQLTL
            // 
            this.btnQLTL.Caption = "THỂ LOẠI";
            this.btnQLTL.Id = 11;
            this.btnQLTL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTL.ImageOptions.Image")));
            this.btnQLTL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLTL.ImageOptions.LargeImage")));
            this.btnQLTL.Name = "btnQLTL";
            this.btnQLTL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLTL_ItemClick);
            // 
            // btnQLTG
            // 
            this.btnQLTG.Caption = "TÁC GIẢ";
            this.btnQLTG.Id = 12;
            this.btnQLTG.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTG.ImageOptions.Image")));
            this.btnQLTG.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLTG.ImageOptions.LargeImage")));
            this.btnQLTG.Name = "btnQLTG";
            this.btnQLTG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLTG_ItemClick);
            // 
            // btnTKNhap
            // 
            this.btnTKNhap.Caption = "THỐNG KÊ NHẬP";
            this.btnTKNhap.Id = 13;
            this.btnTKNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKNhap.ImageOptions.Image")));
            this.btnTKNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTKNhap.ImageOptions.LargeImage")));
            this.btnTKNhap.Name = "btnTKNhap";
            this.btnTKNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTKNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTKNhap_ItemClick);
            // 
            // btnTKBan
            // 
            this.btnTKBan.Caption = "THỐNG KÊ BÁN";
            this.btnTKBan.Id = 14;
            this.btnTKBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKBan.ImageOptions.Image")));
            this.btnTKBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTKBan.ImageOptions.LargeImage")));
            this.btnTKBan.Name = "btnTKBan";
            this.btnTKBan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTKBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTKBan_ItemClick);
            // 
            // rbPQLHT
            // 
            this.rbPQLHT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpPGQLND});
            this.rbPQLHT.Name = "rbPQLHT";
            this.rbPQLHT.Text = "HỆ THỐNG";
            // 
            // rpPGQLND
            // 
            this.rpPGQLND.ItemLinks.Add(this.btnQLND, true);
            this.rpPGQLND.ItemLinks.Add(this.btnTMK, true);
            this.rpPGQLND.ItemLinks.Add(this.btnDangXuat, true);
            this.rpPGQLND.Name = "rpPGQLND";
            this.rpPGQLND.Text = "QUẢN LÝ HỆ THỐNG";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPGQLS});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "QUẢN LÝ CHÍNH";
            // 
            // rbPGQLS
            // 
            this.rbPGQLS.ItemLinks.Add(this.btnQLNHAP);
            this.rbPGQLS.ItemLinks.Add(this.btnQLBAN);
            this.rbPGQLS.ItemLinks.Add(this.btnKhoSach);
            this.rbPGQLS.Name = "rbPGQLS";
            this.rbPGQLS.Text = "QUẢN LÝ SÁCH";
            // 
            // rbPQLK
            // 
            this.rbPQLK.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPGQLNV,
            this.ribbonPageGroup1});
            this.rbPQLK.Name = "rbPQLK";
            this.rbPQLK.Text = "QUẢN LÝ DANH MỤC";
            // 
            // rbPGQLNV
            // 
            this.rbPGQLNV.AllowTextClipping = false;
            this.rbPGQLNV.ItemLinks.Add(this.btnQLNV);
            this.rbPGQLNV.Name = "rbPGQLNV";
            this.rbPGQLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLNXB, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLTL, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLTG, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "QUẢN LÝ KHÁC";
            // 
            // rbPTKBC
            // 
            this.rbPTKBC.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbPTK_BC});
            this.rbPTKBC.Name = "rbPTKBC";
            this.rbPTKBC.Text = "THỐNG KÊ VÀ BÁO CÁO";
            // 
            // rbPTK_BC
            // 
            this.rbPTK_BC.AllowTextClipping = false;
            this.rbPTK_BC.ItemLinks.Add(this.btnTKNhap, true);
            this.rbPTK_BC.ItemLinks.Add(this.btnTKBan, true);
            this.rbPTK_BC.ItemLinks.Add(this.btnTKSLT, true);
            this.rbPTK_BC.Name = "rbPTK_BC";
            this.rbPTK_BC.Text = "THỐNG KÊ BÁO CÁO";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // btnTKSLT
            // 
            this.btnTKSLT.Caption = "THỐNG KÊ SỐ LƯỢNG TỒN";
            this.btnTKSLT.Id = 16;
            this.btnTKSLT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnTKSLT.Name = "btnTKSLT";
            this.btnTKSLT.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTKSLT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTKSLT_ItemClick);
            // 
            // GUI_GDCHINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 632);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("GUI_GDCHINH.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "GUI_GDCHINH";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁN SÁCH";
            this.Load += new System.EventHandler(this.GUI_GDCHINH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPQLHT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpPGQLND;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGQLS;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPQLK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPGQLNV;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPTKBC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbPTK_BC;
        private DevExpress.XtraBars.BarButtonItem btnQLND;
        private DevExpress.XtraBars.BarButtonItem btnTMK;
        private DevExpress.XtraBars.BarButtonItem btnQLNHAP;
        private DevExpress.XtraBars.BarButtonItem btnQLBAN;
        private DevExpress.XtraBars.BarButtonItem btnKhoSach;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnQLNV;
        private DevExpress.XtraBars.BarButtonItem btnQLNXB;
        private DevExpress.XtraBars.BarButtonItem btnQLTL;
        private DevExpress.XtraBars.BarButtonItem btnQLTG;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnTKNhap;
        private DevExpress.XtraBars.BarButtonItem btnTKBan;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DevExpress.XtraBars.BarButtonItem btnTKSLT;
    }
}

