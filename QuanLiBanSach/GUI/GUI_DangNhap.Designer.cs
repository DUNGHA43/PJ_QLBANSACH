
namespace GUI
{
    partial class GUI_DangNhap
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
            this.btnDN = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lbPW = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ckbShowPW = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDN.Location = new System.Drawing.Point(127, 165);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(85, 38);
            this.btnDN.TabIndex = 1;
            this.btnDN.Text = "ĐĂNG NHẬP";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDong.Location = new System.Drawing.Point(230, 165);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 38);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbID.Location = new System.Drawing.Point(58, 80);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(103, 19);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "TÀI KHOẢN";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(181, 82);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 21);
            this.txtID.TabIndex = 4;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(181, 115);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(185, 21);
            this.txtPW.TabIndex = 6;
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.BackColor = System.Drawing.Color.Transparent;
            this.lbPW.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPW.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbPW.Location = new System.Drawing.Point(58, 113);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(98, 19);
            this.lbPW.TabIndex = 5;
            this.lbPW.Text = "MẬT KHẨU";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTitle.Location = new System.Drawing.Point(65, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(316, 23);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "PHẦN MỀM QUẢN LÝ BÁN SÁCH";
            // 
            // ckbShowPW
            // 
            this.ckbShowPW.AutoSize = true;
            this.ckbShowPW.BackColor = System.Drawing.Color.Transparent;
            this.ckbShowPW.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShowPW.ForeColor = System.Drawing.Color.Black;
            this.ckbShowPW.Location = new System.Drawing.Point(181, 138);
            this.ckbShowPW.Name = "ckbShowPW";
            this.ckbShowPW.Size = new System.Drawing.Size(109, 17);
            this.ckbShowPW.TabIndex = 9;
            this.ckbShowPW.Text = "Hiển thị mật khẩu";
            this.ckbShowPW.UseVisualStyleBackColor = false;
            this.ckbShowPW.Click += new System.EventHandler(this.ckbShowPW_Click);
            // 
            // GUI_DangNhap
            // 
            this.AcceptButton = this.btnDN;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::GUI.Properties.Resources.coffee_2511065_640;
            this.ClientSize = new System.Drawing.Size(442, 254);
            this.ControlBox = false;
            this.Controls.Add(this.ckbShowPW);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.lbPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDN);
            this.Name = "GUI_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.CheckBox ckbShowPW;
    }
}