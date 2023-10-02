
namespace GUI
{
    partial class GUI_QLNGUOIDUNG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QLNGUOIDUNG));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxNV = new System.Windows.Forms.ComboBox();
            this.lbChonNV = new System.Windows.Forms.Label();
            this.lbChonCV = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lbNhapPW = new System.Windows.Forms.Label();
            this.cbxCV = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbNhapID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSNguoiDung = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguoiDung)).BeginInit();
            this.SuspendLayout();
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm người dùng";
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
            this.btnXoa.Caption = "Xóa người dùng";
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
            this.barDockControlTop.Size = new System.Drawing.Size(782, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 442);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(782, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 418);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(782, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 418);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxNV);
            this.groupBox1.Controls.Add(this.lbChonNV);
            this.groupBox1.Controls.Add(this.lbChonCV);
            this.groupBox1.Controls.Add(this.txtPW);
            this.groupBox1.Controls.Add(this.lbNhapPW);
            this.groupBox1.Controls.Add(this.cbxCV);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lbNhapID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng:";
            // 
            // cbxNV
            // 
            this.cbxNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNV.FormattingEnabled = true;
            this.cbxNV.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbxNV.Location = new System.Drawing.Point(479, 62);
            this.cbxNV.Name = "cbxNV";
            this.cbxNV.Size = new System.Drawing.Size(121, 21);
            this.cbxNV.TabIndex = 7;
            this.cbxNV.SelectedIndexChanged += new System.EventHandler(this.cbxNV_SelectedIndexChanged);
            // 
            // lbChonNV
            // 
            this.lbChonNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbChonNV.AutoSize = true;
            this.lbChonNV.Location = new System.Drawing.Point(387, 65);
            this.lbChonNV.Name = "lbChonNV";
            this.lbChonNV.Size = new System.Drawing.Size(86, 13);
            this.lbChonNV.TabIndex = 6;
            this.lbChonNV.Text = "Chọn nhân viên:";
            // 
            // lbChonCV
            // 
            this.lbChonCV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbChonCV.AutoSize = true;
            this.lbChonCV.Location = new System.Drawing.Point(387, 35);
            this.lbChonCV.Name = "lbChonCV";
            this.lbChonCV.Size = new System.Drawing.Size(77, 13);
            this.lbChonCV.TabIndex = 5;
            this.lbChonCV.Text = "Chọn chức vụ:";
            // 
            // txtPW
            // 
            this.txtPW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPW.Location = new System.Drawing.Point(216, 62);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(125, 21);
            this.txtPW.TabIndex = 4;
            // 
            // lbNhapPW
            // 
            this.lbNhapPW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNhapPW.AutoSize = true;
            this.lbNhapPW.Location = new System.Drawing.Point(155, 65);
            this.lbNhapPW.Name = "lbNhapPW";
            this.lbNhapPW.Size = new System.Drawing.Size(55, 13);
            this.lbNhapPW.TabIndex = 3;
            this.lbNhapPW.Text = "Nhập PW:";
            // 
            // cbxCV
            // 
            this.cbxCV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxCV.FormattingEnabled = true;
            this.cbxCV.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbxCV.Location = new System.Drawing.Point(479, 32);
            this.cbxCV.Name = "cbxCV";
            this.cbxCV.Size = new System.Drawing.Size(121, 21);
            this.cbxCV.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(216, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 21);
            this.txtID.TabIndex = 1;
            // 
            // lbNhapID
            // 
            this.lbNhapID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNhapID.AutoSize = true;
            this.lbNhapID.Location = new System.Drawing.Point(155, 36);
            this.lbNhapID.Name = "lbNhapID";
            this.lbNhapID.Size = new System.Drawing.Size(50, 13);
            this.lbNhapID.TabIndex = 0;
            this.lbNhapID.Text = "Nhập ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSNguoiDung);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 308);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách người dùng:";
            // 
            // dgvDSNguoiDung
            // 
            this.dgvDSNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSNguoiDung.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNguoiDung.Location = new System.Drawing.Point(3, 17);
            this.dgvDSNguoiDung.Name = "dgvDSNguoiDung";
            this.dgvDSNguoiDung.ReadOnly = true;
            this.dgvDSNguoiDung.Size = new System.Drawing.Size(776, 288);
            this.dgvDSNguoiDung.TabIndex = 0;
            this.dgvDSNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNguoiDung_CellContentClick);
            // 
            // GUI_QLNGUOIDUNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 442);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_QLNGUOIDUNG";
            this.Text = "QUẢN LÍ NGƯỜI DÙNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_QLNGUOIDUNG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSNguoiDung;
        private System.Windows.Forms.ComboBox cbxCV;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbNhapID;
        private System.Windows.Forms.Label lbNhapPW;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lbChonCV;
        private System.Windows.Forms.ComboBox cbxNV;
        private System.Windows.Forms.Label lbChonNV;
    }
}