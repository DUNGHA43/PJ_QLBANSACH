
namespace GUI
{
    partial class GUI_TKNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_TKNHAP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.dgvDSPN = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRF = new System.Windows.Forms.Button();
            this.rdoTKCTPN = new System.Windows.Forms.RadioButton();
            this.rdoTKPN = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.btnIN = new System.Windows.Forms.Button();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNXB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCTPN);
            this.panel2.Controls.Add(this.dgvDSPN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 308);
            this.panel2.TabIndex = 1;
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCTPN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCTPN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPN.Location = new System.Drawing.Point(539, 0);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.ReadOnly = true;
            this.dgvCTPN.Size = new System.Drawing.Size(196, 308);
            this.dgvCTPN.TabIndex = 2;
            // 
            // dgvDSPN
            // 
            this.dgvDSPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSPN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSPN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDSPN.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSPN.Location = new System.Drawing.Point(0, 0);
            this.dgvDSPN.Name = "dgvDSPN";
            this.dgvDSPN.ReadOnly = true;
            this.dgvDSPN.Size = new System.Drawing.Size(539, 308);
            this.dgvDSPN.TabIndex = 0;
            this.dgvDSPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPN_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cbxNXB);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnRF);
            this.panel3.Controls.Add(this.rdoTKCTPN);
            this.panel3.Controls.Add(this.rdoTKPN);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbxNam);
            this.panel3.Controls.Add(this.cbxThang);
            this.panel3.Controls.Add(this.btnIN);
            this.panel3.Controls.Add(this.txtMaPN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 107);
            this.panel3.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Image = global::GUI.Properties.Resources._9104213_close_cross_remove_delete_icon;
            this.btnClose.Location = new System.Drawing.Point(675, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 49);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRF
            // 
            this.btnRF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRF.Image = global::GUI.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.btnRF.Location = new System.Drawing.Point(623, 30);
            this.btnRF.Name = "btnRF";
            this.btnRF.Size = new System.Drawing.Size(46, 49);
            this.btnRF.TabIndex = 9;
            this.btnRF.UseVisualStyleBackColor = true;
            this.btnRF.Click += new System.EventHandler(this.btnRF_Click);
            // 
            // rdoTKCTPN
            // 
            this.rdoTKCTPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoTKCTPN.AutoSize = true;
            this.rdoTKCTPN.Location = new System.Drawing.Point(258, 74);
            this.rdoTKCTPN.Name = "rdoTKCTPN";
            this.rdoTKCTPN.Size = new System.Drawing.Size(184, 17);
            this.rdoTKCTPN.TabIndex = 7;
            this.rdoTKCTPN.TabStop = true;
            this.rdoTKCTPN.Text = "THỐNG KÊ CHI TIẾT PHIẾU NHẬP";
            this.rdoTKCTPN.UseVisualStyleBackColor = true;
            // 
            // rdoTKPN
            // 
            this.rdoTKPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoTKPN.AutoSize = true;
            this.rdoTKPN.Location = new System.Drawing.Point(15, 74);
            this.rdoTKPN.Name = "rdoTKPN";
            this.rdoTKPN.Size = new System.Drawing.Size(138, 17);
            this.rdoTKPN.TabIndex = 6;
            this.rdoTKPN.TabStop = true;
            this.rdoTKPN.Text = "THỐNG KÊ PHIẾU NHẬP";
            this.rdoTKPN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "_______________________________________________________________________________";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CHỌN NĂM";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHỌN THÁNG";
            // 
            // cbxNam
            // 
            this.cbxNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbxNam.Location = new System.Drawing.Point(351, 30);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(121, 23);
            this.cbxNam.TabIndex = 1;
            // 
            // cbxThang
            // 
            this.cbxThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxThang.Location = new System.Drawing.Point(195, 30);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(121, 23);
            this.cbxThang.TabIndex = 0;
            // 
            // btnIN
            // 
            this.btnIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIN.Image = global::GUI.Properties.Resources._39263_print_printer_icon;
            this.btnIN.Location = new System.Drawing.Point(501, 17);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(118, 74);
            this.btnIN.TabIndex = 4;
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // txtMaPN
            // 
            this.txtMaPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaPN.Location = new System.Drawing.Point(600, 50);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(10, 21);
            this.txtMaPN.TabIndex = 8;
            this.txtMaPN.TextChanged += new System.EventHandler(this.txtMaPN_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "CHỌN NHÀ XUẤT BẢN";
            // 
            // cbxNXB
            // 
            this.cbxNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNXB.FormattingEnabled = true;
            this.cbxNXB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxNXB.Location = new System.Drawing.Point(39, 31);
            this.cbxNXB.Name = "cbxNXB";
            this.cbxNXB.Size = new System.Drawing.Size(121, 23);
            this.cbxNXB.TabIndex = 11;
            // 
            // GUI_TKNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 463);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GUI_TKNHAP.IconOptions.SvgImage")));
            this.Name = "GUI_TKNHAP";
            this.Text = "THỐNG KÊ NHẬP SÁCH";
            this.Load += new System.EventHandler(this.GUI_TKNHAP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSPN;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoTKCTPN;
        private System.Windows.Forms.RadioButton rdoTKPN;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Button btnRF;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNXB;
    }
}