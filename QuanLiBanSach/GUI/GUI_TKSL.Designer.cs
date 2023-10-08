
namespace GUI
{
    partial class GUI_TKSL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDSS = new System.Windows.Forms.DataGridView();
            this.btnIN = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTG = new System.Windows.Forms.ComboBox();
            this.cbxNXB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 48);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SÁCH";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDSS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 291);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbxTG);
            this.panel3.Controls.Add(this.cbxNXB);
            this.panel3.Controls.Add(this.btnIN);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnRF);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 138);
            this.panel3.TabIndex = 4;
            // 
            // dgvDSS
            // 
            this.dgvDSS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSS.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSS.Location = new System.Drawing.Point(0, 0);
            this.dgvDSS.Name = "dgvDSS";
            this.dgvDSS.ReadOnly = true;
            this.dgvDSS.Size = new System.Drawing.Size(749, 291);
            this.dgvDSS.TabIndex = 1;
            // 
            // btnIN
            // 
            this.btnIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIN.Image = global::GUI.Properties.Resources._39263_print_printer_icon;
            this.btnIN.Location = new System.Drawing.Point(454, 32);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(118, 74);
            this.btnIN.TabIndex = 11;
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Image = global::GUI.Properties.Resources._9104213_close_cross_remove_delete_icon;
            this.btnClose.Location = new System.Drawing.Point(654, 48);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 49);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRF
            // 
            this.btnRF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRF.Image = global::GUI.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.btnRF.Location = new System.Drawing.Point(592, 48);
            this.btnRF.Name = "btnRF";
            this.btnRF.Size = new System.Drawing.Size(46, 49);
            this.btnRF.TabIndex = 12;
            this.btnRF.UseVisualStyleBackColor = true;
            this.btnRF.Click += new System.EventHandler(this.btnRF_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "CHỌN TÁC GIẢ:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "CHỌN NHÀ XUẤT BẢN";
            // 
            // cbxTG
            // 
            this.cbxTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTG.FormattingEnabled = true;
            this.cbxTG.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cbxTG.Location = new System.Drawing.Point(252, 72);
            this.cbxTG.Name = "cbxTG";
            this.cbxTG.Size = new System.Drawing.Size(121, 23);
            this.cbxTG.TabIndex = 15;
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
            this.cbxNXB.Location = new System.Drawing.Point(252, 43);
            this.cbxNXB.Name = "cbxNXB";
            this.cbxNXB.Size = new System.Drawing.Size(121, 23);
            this.cbxNXB.TabIndex = 14;
            // 
            // GUI_TKSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUI_TKSL";
            this.Text = "THỐNG KÊ SỐ LƯỢNG";
            this.Load += new System.EventHandler(this.GUI_TKSL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDSS;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTG;
        private System.Windows.Forms.ComboBox cbxNXB;
    }
}