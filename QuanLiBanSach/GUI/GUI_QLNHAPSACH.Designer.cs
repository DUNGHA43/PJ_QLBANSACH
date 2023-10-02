
namespace GUI
{
    partial class GUI_QLNHAPSACH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QLNHAPSACH));
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaNXB = new System.Windows.Forms.Label();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbxMaNXB = new System.Windows.Forms.ComboBox();
            this.lbMaPN = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSPN = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTimMaNhap = new System.Windows.Forms.Label();
            this.txtTimMaNhap = new System.Windows.Forms.TextBox();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập nhật";
            this.btnCapNhat.Id = 5;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.LargeImage")));
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTongTien.Location = new System.Drawing.Point(289, 87);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(99, 21);
            this.txtTongTien.TabIndex = 9;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(202, 90);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(56, 13);
            this.lbTongTien.TabIndex = 8;
            this.lbTongTien.Text = "Tổng tiền:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(403, 63);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(75, 13);
            this.lbMaNV.TabIndex = 7;
            this.lbMaNV.Text = "Mã nhân viên:";
            // 
            // lbMaNXB
            // 
            this.lbMaNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaNXB.AutoSize = true;
            this.lbMaNXB.Location = new System.Drawing.Point(403, 32);
            this.lbMaNXB.Name = "lbMaNXB";
            this.lbMaNXB.Size = new System.Drawing.Size(92, 13);
            this.lbMaNXB.TabIndex = 5;
            this.lbMaNXB.Text = "Mã nhà xuất bản:";
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.Location = new System.Drawing.Point(202, 63);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(63, 13);
            this.lbNgayNhap.TabIndex = 4;
            this.lbNgayNhap.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(289, 57);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(99, 21);
            this.dtpNgayNhap.TabIndex = 3;
            // 
            // cbxMaNXB
            // 
            this.cbxMaNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxMaNXB.FormattingEnabled = true;
            this.cbxMaNXB.Location = new System.Drawing.Point(496, 29);
            this.cbxMaNXB.Name = "cbxMaNXB";
            this.cbxMaNXB.Size = new System.Drawing.Size(108, 21);
            this.cbxMaNXB.TabIndex = 2;
            // 
            // lbMaPN
            // 
            this.lbMaPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaPN.AutoSize = true;
            this.lbMaPN.Location = new System.Drawing.Point(202, 32);
            this.lbMaPN.Name = "lbMaPN";
            this.lbMaPN.Size = new System.Drawing.Size(81, 13);
            this.lbMaPN.TabIndex = 1;
            this.lbMaPN.Text = "Mã phiếu nhập:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaPN.Location = new System.Drawing.Point(289, 29);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(99, 21);
            this.txtMaPN.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoaPN,
            this.btnCTPN,
            this.btnCapNhat,
            this.btnDong,
            this.btnLamMoi});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 8;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaPN, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCTPN, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamMoi, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong, true)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm phiếu nhập";
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
            // btnXoaPN
            // 
            this.btnXoaPN.Caption = "Xóa phiếu nhập";
            this.btnXoaPN.Id = 6;
            this.btnXoaPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPN.ImageOptions.Image")));
            this.btnXoaPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaPN.ImageOptions.LargeImage")));
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoaPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaPN_ItemClick);
            // 
            // btnCTPN
            // 
            this.btnCTPN.Caption = "Chi tiết phiếu nhập";
            this.btnCTPN.Id = 4;
            this.btnCTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCTPN.ImageOptions.Image")));
            this.btnCTPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCTPN.ImageOptions.LargeImage")));
            this.btnCTPN.Name = "btnCTPN";
            this.btnCTPN.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCTPN_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(814, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 508);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(814, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 484);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(814, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 484);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa người dùng";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSPN);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu nhập:";
            // 
            // dgvDSPN
            // 
            this.dgvDSPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSPN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPN.Location = new System.Drawing.Point(3, 43);
            this.dgvDSPN.Name = "dgvDSPN";
            this.dgvDSPN.ReadOnly = true;
            this.dgvDSPN.Size = new System.Drawing.Size(808, 318);
            this.dgvDSPN.TabIndex = 1;
            this.dgvDSPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPN_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTimMaNhap);
            this.panel2.Controls.Add(this.txtTimMaNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 26);
            this.panel2.TabIndex = 0;
            // 
            // lbTimMaNhap
            // 
            this.lbTimMaNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTimMaNhap.AutoSize = true;
            this.lbTimMaNhap.Location = new System.Drawing.Point(10, 4);
            this.lbTimMaNhap.Name = "lbTimMaNhap";
            this.lbTimMaNhap.Size = new System.Drawing.Size(69, 13);
            this.lbTimMaNhap.TabIndex = 3;
            this.lbTimMaNhap.Text = "Tìm theo mã:";
            // 
            // txtTimMaNhap
            // 
            this.txtTimMaNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimMaNhap.Location = new System.Drawing.Point(85, 1);
            this.txtTimMaNhap.Name = "txtTimMaNhap";
            this.txtTimMaNhap.Size = new System.Drawing.Size(377, 21);
            this.txtTimMaNhap.TabIndex = 2;
            this.txtTimMaNhap.TextChanged += new System.EventHandler(this.txtTimMaNhap_TextChanged);
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 484);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.lbTongTien);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbMaNXB);
            this.groupBox1.Controls.Add(this.lbNgayNhap);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.cbxMaNXB);
            this.groupBox1.Controls.Add(this.lbMaPN);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.Location = new System.Drawing.Point(496, 60);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(108, 21);
            this.txtMaNV.TabIndex = 10;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 7;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // GUI_QLNHAPSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 508);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_QLNHAPSACH";
            this.Text = "QUẢN LÝ NHẬP SÁCH";
            this.Load += new System.EventHandler(this.GUI_QLNHAPSACH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaNXB;
        private System.Windows.Forms.Label lbNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cbxMaNXB;
        private System.Windows.Forms.Label lbMaPN;
        private System.Windows.Forms.TextBox txtMaPN;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnCTPN;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDSPN;
        private System.Windows.Forms.Label lbTimMaNhap;
        private System.Windows.Forms.TextBox txtTimMaNhap;
        private DevExpress.XtraBars.BarButtonItem btnXoaPN;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
    }
}