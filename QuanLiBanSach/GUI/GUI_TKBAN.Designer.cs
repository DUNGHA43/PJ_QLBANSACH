
namespace GUI
{
    partial class GUI_TKBAN
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIN = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRF = new System.Windows.Forms.Button();
            this.rdoTKCTHD = new System.Windows.Forms.RadioButton();
            this.rdoTKHD = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH BÁN SÁCH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 48);
            this.panel1.TabIndex = 1;
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDSHD.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSHD.Location = new System.Drawing.Point(0, 0);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            this.dgvDSHD.Size = new System.Drawing.Size(433, 308);
            this.dgvDSHD.TabIndex = 0;
            this.dgvDSHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCTHD);
            this.panel2.Controls.Add(this.dgvDSHD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 308);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnIN);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnRF);
            this.panel3.Controls.Add(this.rdoTKCTHD);
            this.panel3.Controls.Add(this.rdoTKHD);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbxNam);
            this.panel3.Controls.Add(this.cbxThang);
            this.panel3.Controls.Add(this.txtMaHD);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 121);
            this.panel3.TabIndex = 3;
            // 
            // btnIN
            // 
            this.btnIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIN.Image = global::GUI.Properties.Resources._39263_print_printer_icon;
            this.btnIN.Location = new System.Drawing.Point(508, 24);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(118, 74);
            this.btnIN.TabIndex = 4;
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Image = global::GUI.Properties.Resources._9104213_close_cross_remove_delete_icon;
            this.btnClose.Location = new System.Drawing.Point(682, 37);
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
            this.btnRF.Location = new System.Drawing.Point(630, 37);
            this.btnRF.Name = "btnRF";
            this.btnRF.Size = new System.Drawing.Size(46, 49);
            this.btnRF.TabIndex = 9;
            this.btnRF.UseVisualStyleBackColor = true;
            this.btnRF.Click += new System.EventHandler(this.btnRF_Click);
            // 
            // rdoTKCTHD
            // 
            this.rdoTKCTHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoTKCTHD.AutoSize = true;
            this.rdoTKCTHD.Location = new System.Drawing.Point(259, 81);
            this.rdoTKCTHD.Name = "rdoTKCTHD";
            this.rdoTKCTHD.Size = new System.Drawing.Size(174, 17);
            this.rdoTKCTHD.TabIndex = 7;
            this.rdoTKCTHD.TabStop = true;
            this.rdoTKCTHD.Text = "THỐNG KÊ CHI TIẾT BÁN SÁCH";
            this.rdoTKCTHD.UseVisualStyleBackColor = true;
            // 
            // rdoTKHD
            // 
            this.rdoTKHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoTKHD.AutoSize = true;
            this.rdoTKHD.Location = new System.Drawing.Point(103, 81);
            this.rdoTKHD.Name = "rdoTKHD";
            this.rdoTKHD.Size = new System.Drawing.Size(128, 17);
            this.rdoTKHD.TabIndex = 6;
            this.rdoTKHD.TabStop = true;
            this.rdoTKHD.Text = "THỐNG KÊ BÁN SÁCH";
            this.rdoTKHD.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "______________________________________________________________________";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 17);
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
            this.label2.Location = new System.Drawing.Point(124, 17);
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
            this.cbxNam.Location = new System.Drawing.Point(259, 37);
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
            this.cbxThang.Location = new System.Drawing.Point(103, 37);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(121, 23);
            this.cbxThang.TabIndex = 0;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHD.Location = new System.Drawing.Point(607, 57);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(10, 21);
            this.txtMaHD.TabIndex = 8;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCTHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCTHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.Location = new System.Drawing.Point(433, 0);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.Size = new System.Drawing.Size(316, 308);
            this.dgvCTHD.TabIndex = 3;
            // 
            // GUI_TKBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 477);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_TKBAN";
            this.Text = "THỐNG KÊ BÁN SÁCH";
            this.Load += new System.EventHandler(this.GUI_TKBAN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRF;
        private System.Windows.Forms.RadioButton rdoTKCTHD;
        private System.Windows.Forms.RadioButton rdoTKHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgvCTHD;
    }
}