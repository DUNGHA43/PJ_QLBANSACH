
namespace GUI
{
    partial class GUI_QLKHOSACH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QLKHOSACH));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTG = new System.Windows.Forms.Label();
            this.cbxTG = new System.Windows.Forms.ComboBox();
            this.lbNXB = new System.Windows.Forms.Label();
            this.cbxNXB = new System.Windows.Forms.ComboBox();
            this.lbTL = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lbGB = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.lbGN = new System.Windows.Forms.Label();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.lbSLT = new System.Windows.Forms.Label();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.lbTenS = new System.Windows.Forms.Label();
            this.cbxTL = new System.Windows.Forms.ComboBox();
            this.txtMaS = new System.Windows.Forms.TextBox();
            this.lbMaS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxTimTG = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTimTL = new System.Windows.Forms.ComboBox();
            this.txtTimTenS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimMaS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.btnDong,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm thông tin sách";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa thông tin sách";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa sách";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Làm mới";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(801, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 477);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(801, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 453);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(801, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 453);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTG);
            this.groupBox1.Controls.Add(this.cbxTG);
            this.groupBox1.Controls.Add(this.lbNXB);
            this.groupBox1.Controls.Add(this.cbxNXB);
            this.groupBox1.Controls.Add(this.lbTL);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.lbGB);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.lbGN);
            this.groupBox1.Controls.Add(this.txtSLTon);
            this.groupBox1.Controls.Add(this.lbSLT);
            this.groupBox1.Controls.Add(this.txtTenS);
            this.groupBox1.Controls.Add(this.lbTenS);
            this.groupBox1.Controls.Add(this.cbxTL);
            this.groupBox1.Controls.Add(this.txtMaS);
            this.groupBox1.Controls.Add(this.lbMaS);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách:";
            // 
            // lbTG
            // 
            this.lbTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTG.AutoSize = true;
            this.lbTG.Location = new System.Drawing.Point(518, 63);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(45, 13);
            this.lbTG.TabIndex = 15;
            this.lbTG.Text = "Tác giả:";
            // 
            // cbxTG
            // 
            this.cbxTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTG.FormattingEnabled = true;
            this.cbxTG.Location = new System.Drawing.Point(600, 56);
            this.cbxTG.Name = "cbxTG";
            this.cbxTG.Size = new System.Drawing.Size(100, 21);
            this.cbxTG.TabIndex = 14;
            this.cbxTG.TextChanged += new System.EventHandler(this.cbxTG_TextChanged);
            // 
            // lbNXB
            // 
            this.lbNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNXB.AutoSize = true;
            this.lbNXB.Location = new System.Drawing.Point(518, 90);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(76, 13);
            this.lbNXB.TabIndex = 13;
            this.lbNXB.Text = "Nhà xuất bản:";
            // 
            // cbxNXB
            // 
            this.cbxNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNXB.FormattingEnabled = true;
            this.cbxNXB.Location = new System.Drawing.Point(600, 83);
            this.cbxNXB.Name = "cbxNXB";
            this.cbxNXB.Size = new System.Drawing.Size(100, 21);
            this.cbxNXB.TabIndex = 12;
            this.cbxNXB.TextChanged += new System.EventHandler(this.cbxNXB_TextChanged);
            // 
            // lbTL
            // 
            this.lbTL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTL.AutoSize = true;
            this.lbTL.Location = new System.Drawing.Point(518, 32);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(48, 13);
            this.lbTL.TabIndex = 11;
            this.lbTL.Text = "Thể loại:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaBan.Location = new System.Drawing.Point(384, 56);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 21);
            this.txtGiaBan.TabIndex = 10;
            // 
            // lbGB
            // 
            this.lbGB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGB.AutoSize = true;
            this.lbGB.Location = new System.Drawing.Point(306, 59);
            this.lbGB.Name = "lbGB";
            this.lbGB.Size = new System.Drawing.Size(47, 13);
            this.lbGB.TabIndex = 9;
            this.lbGB.Text = "Giá bán:";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaNhap.Location = new System.Drawing.Point(384, 29);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(100, 21);
            this.txtGiaNhap.TabIndex = 8;
            // 
            // lbGN
            // 
            this.lbGN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGN.AutoSize = true;
            this.lbGN.Location = new System.Drawing.Point(306, 32);
            this.lbGN.Name = "lbGN";
            this.lbGN.Size = new System.Drawing.Size(53, 13);
            this.lbGN.TabIndex = 7;
            this.lbGN.Text = "Giá nhập:";
            // 
            // txtSLTon
            // 
            this.txtSLTon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSLTon.Location = new System.Drawing.Point(384, 83);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.ReadOnly = true;
            this.txtSLTon.Size = new System.Drawing.Size(100, 21);
            this.txtSLTon.TabIndex = 6;
            // 
            // lbSLT
            // 
            this.lbSLT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSLT.AutoSize = true;
            this.lbSLT.Location = new System.Drawing.Point(306, 86);
            this.lbSLT.Name = "lbSLT";
            this.lbSLT.Size = new System.Drawing.Size(72, 13);
            this.lbSLT.TabIndex = 5;
            this.lbSLT.Text = "Số lượng tồn:";
            // 
            // txtTenS
            // 
            this.txtTenS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenS.Location = new System.Drawing.Point(168, 56);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(100, 21);
            this.txtTenS.TabIndex = 4;
            // 
            // lbTenS
            // 
            this.lbTenS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenS.AutoSize = true;
            this.lbTenS.Location = new System.Drawing.Point(90, 59);
            this.lbTenS.Name = "lbTenS";
            this.lbTenS.Size = new System.Drawing.Size(54, 13);
            this.lbTenS.TabIndex = 3;
            this.lbTenS.Text = "Tên sách:";
            // 
            // cbxTL
            // 
            this.cbxTL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTL.FormattingEnabled = true;
            this.cbxTL.Location = new System.Drawing.Point(600, 29);
            this.cbxTL.Name = "cbxTL";
            this.cbxTL.Size = new System.Drawing.Size(100, 21);
            this.cbxTL.TabIndex = 2;
            this.cbxTL.TextChanged += new System.EventHandler(this.cbxTL_TextChanged);
            // 
            // txtMaS
            // 
            this.txtMaS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaS.Location = new System.Drawing.Point(168, 29);
            this.txtMaS.Name = "txtMaS";
            this.txtMaS.Size = new System.Drawing.Size(100, 21);
            this.txtMaS.TabIndex = 1;
            // 
            // lbMaS
            // 
            this.lbMaS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMaS.AutoSize = true;
            this.lbMaS.Location = new System.Drawing.Point(90, 32);
            this.lbMaS.Name = "lbMaS";
            this.lbMaS.Size = new System.Drawing.Size(50, 13);
            this.lbMaS.TabIndex = 0;
            this.lbMaS.Text = "Mã sách:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 330);
            this.panel1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSSach);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(801, 267);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sách:";
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSach.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSSach.Location = new System.Drawing.Point(3, 17);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.ReadOnly = true;
            this.dgvDSSach.Size = new System.Drawing.Size(795, 247);
            this.dgvDSSach.TabIndex = 0;
            this.dgvDSSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSach_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbxTimTG);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbxTimTL);
            this.groupBox2.Controls.Add(this.txtTimTenS);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTimMaS);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm sách:";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.Cornsilk;
            this.btnTim.Location = new System.Drawing.Point(691, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 38);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(534, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Tác giả:";
            // 
            // cbxTimTG
            // 
            this.cbxTimTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTimTG.FormattingEnabled = true;
            this.cbxTimTG.Location = new System.Drawing.Point(585, 26);
            this.cbxTimTG.Name = "cbxTimTG";
            this.cbxTimTG.Size = new System.Drawing.Size(100, 21);
            this.cbxTimTG.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Thể loại:";
            // 
            // cbxTimTL
            // 
            this.cbxTimTL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTimTL.FormattingEnabled = true;
            this.cbxTimTL.Location = new System.Drawing.Point(415, 26);
            this.cbxTimTL.Name = "cbxTimTL";
            this.cbxTimTL.Size = new System.Drawing.Size(100, 21);
            this.cbxTimTL.TabIndex = 12;
            // 
            // txtTimTenS
            // 
            this.txtTimTenS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimTenS.Location = new System.Drawing.Point(245, 26);
            this.txtTimTenS.Name = "txtTimTenS";
            this.txtTimTenS.Size = new System.Drawing.Size(100, 21);
            this.txtTimTenS.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tên sách:";
            // 
            // txtTimMaS
            // 
            this.txtTimMaS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimMaS.Location = new System.Drawing.Point(68, 26);
            this.txtTimMaS.Name = "txtTimMaS";
            this.txtTimMaS.Size = new System.Drawing.Size(100, 21);
            this.txtTimMaS.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã sách:";
            // 
            // GUI_QLKHOSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 477);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_QLKHOSACH";
            this.Text = "QUẢN LÝ KHO SÁCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_QLKHOSACH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxTL;
        private System.Windows.Forms.TextBox txtMaS;
        private System.Windows.Forms.Label lbMaS;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Label lbSLT;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.Label lbTenS;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lbGB;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label lbGN;
        private System.Windows.Forms.Label lbTL;
        private System.Windows.Forms.Label lbTG;
        private System.Windows.Forms.ComboBox cbxTG;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.ComboBox cbxNXB;
        private System.Windows.Forms.TextBox txtTimTenS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimMaS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxTimTL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxTimTG;
        private System.Windows.Forms.Button btnTim;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}