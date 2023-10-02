
namespace GUI
{
    partial class GUI_QLTL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QLTL));
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSTL = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimTenTL = new System.Windows.Forms.TextBox();
            this.lbTimTenTL = new System.Windows.Forms.Label();
            this.txtTimMaLT = new System.Windows.Forms.TextBox();
            this.lbTimMaTL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.lbTenTL = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.lbMaTL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTL)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 415);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm thể loại";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa thông tin";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa thể loại:";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 3;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(789, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 439);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(789, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(789, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 415);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSTL);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 350);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thể loại:";
            // 
            // dgvDSTL
            // 
            this.dgvDSTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSTL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTL.Location = new System.Drawing.Point(3, 45);
            this.dgvDSTL.Name = "dgvDSTL";
            this.dgvDSTL.Size = new System.Drawing.Size(783, 302);
            this.dgvDSTL.TabIndex = 1;
            this.dgvDSTL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTL_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimTenTL);
            this.panel1.Controls.Add(this.lbTimTenTL);
            this.panel1.Controls.Add(this.txtTimMaLT);
            this.panel1.Controls.Add(this.lbTimMaTL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 28);
            this.panel1.TabIndex = 0;
            // 
            // txtTimTenTL
            // 
            this.txtTimTenTL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTimTenTL.Location = new System.Drawing.Point(350, 3);
            this.txtTimTenTL.Name = "txtTimTenTL";
            this.txtTimTenTL.Size = new System.Drawing.Size(173, 21);
            this.txtTimTenTL.TabIndex = 15;
            this.txtTimTenTL.TextChanged += new System.EventHandler(this.txtTimTenTL_TextChanged);
            // 
            // lbTimTenTL
            // 
            this.lbTimTenTL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTimTenTL.AutoSize = true;
            this.lbTimTenTL.Location = new System.Drawing.Point(275, 6);
            this.lbTimTenTL.Name = "lbTimTenTL";
            this.lbTimTenTL.Size = new System.Drawing.Size(71, 13);
            this.lbTimTenTL.TabIndex = 14;
            this.lbTimTenTL.Text = "Tìm theo tên:";
            // 
            // txtTimMaLT
            // 
            this.txtTimMaLT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTimMaLT.Location = new System.Drawing.Point(82, 3);
            this.txtTimMaLT.Name = "txtTimMaLT";
            this.txtTimMaLT.Size = new System.Drawing.Size(173, 21);
            this.txtTimMaLT.TabIndex = 13;
            this.txtTimMaLT.TextChanged += new System.EventHandler(this.txtTimMaLT_TextChanged);
            // 
            // lbTimMaTL
            // 
            this.lbTimMaTL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTimMaTL.AutoSize = true;
            this.lbTimMaTL.Location = new System.Drawing.Point(7, 6);
            this.lbTimMaTL.Name = "lbTimMaTL";
            this.lbTimMaTL.Size = new System.Drawing.Size(69, 13);
            this.lbTimMaTL.TabIndex = 12;
            this.lbTimMaTL.Text = "Tìm theo mã:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenTL);
            this.groupBox1.Controls.Add(this.lbTenTL);
            this.groupBox1.Controls.Add(this.txtMaTL);
            this.groupBox1.Controls.Add(this.lbMaTL);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thể loại:";
            // 
            // txtTenTL
            // 
            this.txtTenTL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenTL.Location = new System.Drawing.Point(470, 25);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(156, 21);
            this.txtTenTL.TabIndex = 19;
            // 
            // lbTenTL
            // 
            this.lbTenTL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenTL.AutoSize = true;
            this.lbTenTL.Location = new System.Drawing.Point(397, 28);
            this.lbTenTL.Name = "lbTenTL";
            this.lbTenTL.Size = new System.Drawing.Size(67, 13);
            this.lbTenTL.TabIndex = 18;
            this.lbTenTL.Text = "Tên thể loại:";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaTL.Location = new System.Drawing.Point(209, 25);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(156, 21);
            this.txtMaTL.TabIndex = 17;
            // 
            // lbMaTL
            // 
            this.lbMaTL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaTL.AutoSize = true;
            this.lbMaTL.Location = new System.Drawing.Point(140, 28);
            this.lbMaTL.Name = "lbMaTL";
            this.lbMaTL.Size = new System.Drawing.Size(63, 13);
            this.lbMaTL.TabIndex = 16;
            this.lbMaTL.Text = "Mã thể loại:";
            // 
            // GUI_QLTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 439);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_QLTL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QUẢN LÝ THỂ LOẠI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_QLTL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTL)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSTL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimTenTL;
        private System.Windows.Forms.Label lbTimTenTL;
        private System.Windows.Forms.TextBox txtTimMaLT;
        private System.Windows.Forms.Label lbTimMaTL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Label lbTenTL;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label lbMaTL;
    }
}