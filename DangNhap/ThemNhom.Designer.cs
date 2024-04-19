namespace DangNhap
{
    partial class ThemNhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemNhom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CBB_nhanvien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBB_phongban = new System.Windows.Forms.ComboBox();
            this.LB_maphongban = new System.Windows.Forms.Label();
            this.BTN_ok = new Guna.UI.WinForms.GunaGradientButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LB_MaNhom = new System.Windows.Forms.Label();
            this.TXB_maNhom = new System.Windows.Forms.TextBox();
            this.PN_main = new System.Windows.Forms.Panel();
            this.BTN_xoa = new Guna.UI.WinForms.GunaGradientButton();
            this.LB_themmoi = new System.Windows.Forms.Label();
            this.BTN_nhanvien = new System.Windows.Forms.Button();
            this.BTN_phongban = new System.Windows.Forms.Button();
            this.BTN_thoat = new Guna.UI.WinForms.GunaGradientButton();
            this.PN_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(847, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 462);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 1);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 460);
            this.panel4.TabIndex = 1;
            // 
            // CBB_nhanvien
            // 
            this.CBB_nhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.CBB_nhanvien.Enabled = false;
            this.CBB_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBB_nhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_nhanvien.ForeColor = System.Drawing.Color.White;
            this.CBB_nhanvien.FormattingEnabled = true;
            this.CBB_nhanvien.Location = new System.Drawing.Point(220, 133);
            this.CBB_nhanvien.Name = "CBB_nhanvien";
            this.CBB_nhanvien.Size = new System.Drawing.Size(419, 30);
            this.CBB_nhanvien.TabIndex = 205;
            this.CBB_nhanvien.SelectedValueChanged += new System.EventHandler(this.CBB_nhanvien_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 204;
            this.label1.Text = "Mã trưởng nhóm";
            // 
            // CBB_phongban
            // 
            this.CBB_phongban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.CBB_phongban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBB_phongban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_phongban.ForeColor = System.Drawing.Color.White;
            this.CBB_phongban.FormattingEnabled = true;
            this.CBB_phongban.Location = new System.Drawing.Point(220, 36);
            this.CBB_phongban.Name = "CBB_phongban";
            this.CBB_phongban.Size = new System.Drawing.Size(419, 30);
            this.CBB_phongban.TabIndex = 203;
            this.CBB_phongban.SelectedValueChanged += new System.EventHandler(this.CBB_phongban_SelectedValueChanged);
            // 
            // LB_maphongban
            // 
            this.LB_maphongban.AutoSize = true;
            this.LB_maphongban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_maphongban.ForeColor = System.Drawing.Color.White;
            this.LB_maphongban.Location = new System.Drawing.Point(50, 40);
            this.LB_maphongban.Name = "LB_maphongban";
            this.LB_maphongban.Size = new System.Drawing.Size(91, 22);
            this.LB_maphongban.TabIndex = 202;
            this.LB_maphongban.Text = "Phòng ban";
            // 
            // BTN_ok
            // 
            this.BTN_ok.Animated = true;
            this.BTN_ok.AnimationHoverSpeed = 0.5F;
            this.BTN_ok.AnimationSpeed = 0.03F;
            this.BTN_ok.BackColor = System.Drawing.Color.Transparent;
            this.BTN_ok.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.BTN_ok.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ok.BorderColor = System.Drawing.Color.Black;
            this.BTN_ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_ok.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_ok.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ok.ForeColor = System.Drawing.Color.White;
            this.BTN_ok.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTN_ok.Image = null;
            this.BTN_ok.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_ok.Location = new System.Drawing.Point(702, 345);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ok.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ok.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_ok.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_ok.OnHoverImage = null;
            this.BTN_ok.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_ok.Radius = 5;
            this.BTN_ok.Size = new System.Drawing.Size(129, 35);
            this.BTN_ok.TabIndex = 207;
            this.BTN_ok.Text = "Lưu";
            this.BTN_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_ok.Click += new System.EventHandler(this.BTN_ok_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(15, 329);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(816, 1);
            this.panel5.TabIndex = 210;
            // 
            // LB_MaNhom
            // 
            this.LB_MaNhom.AutoSize = true;
            this.LB_MaNhom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaNhom.ForeColor = System.Drawing.Color.White;
            this.LB_MaNhom.Location = new System.Drawing.Point(50, 234);
            this.LB_MaNhom.Name = "LB_MaNhom";
            this.LB_MaNhom.Size = new System.Drawing.Size(83, 22);
            this.LB_MaNhom.TabIndex = 212;
            this.LB_MaNhom.Text = "Mã nhóm";
            // 
            // TXB_maNhom
            // 
            this.TXB_maNhom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.TXB_maNhom.Enabled = false;
            this.TXB_maNhom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_maNhom.ForeColor = System.Drawing.Color.White;
            this.TXB_maNhom.Location = new System.Drawing.Point(220, 230);
            this.TXB_maNhom.Multiline = true;
            this.TXB_maNhom.Name = "TXB_maNhom";
            this.TXB_maNhom.Size = new System.Drawing.Size(419, 30);
            this.TXB_maNhom.TabIndex = 213;
            // 
            // PN_main
            // 
            this.PN_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.PN_main.Controls.Add(this.BTN_xoa);
            this.PN_main.Controls.Add(this.LB_maphongban);
            this.PN_main.Controls.Add(this.TXB_maNhom);
            this.PN_main.Controls.Add(this.CBB_phongban);
            this.PN_main.Controls.Add(this.LB_MaNhom);
            this.PN_main.Controls.Add(this.label1);
            this.PN_main.Controls.Add(this.panel5);
            this.PN_main.Controls.Add(this.CBB_nhanvien);
            this.PN_main.Controls.Add(this.BTN_ok);
            this.PN_main.Location = new System.Drawing.Point(1, 64);
            this.PN_main.Name = "PN_main";
            this.PN_main.Size = new System.Drawing.Size(847, 397);
            this.PN_main.TabIndex = 214;
            // 
            // BTN_xoa
            // 
            this.BTN_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_xoa.Animated = true;
            this.BTN_xoa.AnimationHoverSpeed = 1F;
            this.BTN_xoa.AnimationSpeed = 0.03F;
            this.BTN_xoa.BackColor = System.Drawing.Color.Transparent;
            this.BTN_xoa.BaseColor1 = System.Drawing.Color.Transparent;
            this.BTN_xoa.BaseColor2 = System.Drawing.Color.Transparent;
            this.BTN_xoa.BorderColor = System.Drawing.Color.Red;
            this.BTN_xoa.BorderSize = 1;
            this.BTN_xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_xoa.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_xoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_xoa.ForeColor = System.Drawing.Color.Red;
            this.BTN_xoa.Image = null;
            this.BTN_xoa.ImageSize = new System.Drawing.Size(10, 10);
            this.BTN_xoa.Location = new System.Drawing.Point(557, 345);
            this.BTN_xoa.Name = "BTN_xoa";
            this.BTN_xoa.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.BTN_xoa.OnHoverBaseColor2 = System.Drawing.Color.Red;
            this.BTN_xoa.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_xoa.OnHoverImage = null;
            this.BTN_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_xoa.Radius = 5;
            this.BTN_xoa.Size = new System.Drawing.Size(129, 35);
            this.BTN_xoa.TabIndex = 225;
            this.BTN_xoa.Text = "Xóa";
            this.BTN_xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_themmoi
            // 
            this.LB_themmoi.AutoSize = true;
            this.LB_themmoi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_themmoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LB_themmoi.Location = new System.Drawing.Point(16, 16);
            this.LB_themmoi.Name = "LB_themmoi";
            this.LB_themmoi.Size = new System.Drawing.Size(196, 32);
            this.LB_themmoi.TabIndex = 206;
            this.LB_themmoi.Text = "THÊM NHÓM";
            // 
            // BTN_nhanvien
            // 
            this.BTN_nhanvien.AutoSize = true;
            this.BTN_nhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.BTN_nhanvien.FlatAppearance.BorderSize = 0;
            this.BTN_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_nhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_nhanvien.ForeColor = System.Drawing.Color.White;
            this.BTN_nhanvien.Location = new System.Drawing.Point(513, 16);
            this.BTN_nhanvien.Name = "BTN_nhanvien";
            this.BTN_nhanvien.Size = new System.Drawing.Size(125, 47);
            this.BTN_nhanvien.TabIndex = 215;
            this.BTN_nhanvien.Text = "Nhân Viên";
            this.BTN_nhanvien.UseVisualStyleBackColor = false;
            this.BTN_nhanvien.Click += new System.EventHandler(this.BTN_nhanvien_Click);
            // 
            // BTN_phongban
            // 
            this.BTN_phongban.AutoSize = true;
            this.BTN_phongban.BackColor = System.Drawing.Color.Transparent;
            this.BTN_phongban.FlatAppearance.BorderSize = 0;
            this.BTN_phongban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_phongban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_phongban.ForeColor = System.Drawing.Color.White;
            this.BTN_phongban.Location = new System.Drawing.Point(644, 16);
            this.BTN_phongban.Name = "BTN_phongban";
            this.BTN_phongban.Size = new System.Drawing.Size(125, 47);
            this.BTN_phongban.TabIndex = 216;
            this.BTN_phongban.Text = "Phòng Ban";
            this.BTN_phongban.UseVisualStyleBackColor = false;
            this.BTN_phongban.Click += new System.EventHandler(this.BTN_phongban_Click);
            // 
            // BTN_thoat
            // 
            this.BTN_thoat.AnimationHoverSpeed = 0.5F;
            this.BTN_thoat.AnimationSpeed = 0.03F;
            this.BTN_thoat.BackColor = System.Drawing.Color.Transparent;
            this.BTN_thoat.BaseColor1 = System.Drawing.Color.Transparent;
            this.BTN_thoat.BaseColor2 = System.Drawing.Color.Transparent;
            this.BTN_thoat.BorderColor = System.Drawing.Color.Transparent;
            this.BTN_thoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_thoat.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_thoat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_thoat.ForeColor = System.Drawing.Color.Black;
            this.BTN_thoat.Image = ((System.Drawing.Image)(resources.GetObject("BTN_thoat.Image")));
            this.BTN_thoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_thoat.ImageSize = new System.Drawing.Size(10, 10);
            this.BTN_thoat.Location = new System.Drawing.Point(788, 0);
            this.BTN_thoat.Name = "BTN_thoat";
            this.BTN_thoat.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.BTN_thoat.OnHoverBaseColor2 = System.Drawing.Color.Red;
            this.BTN_thoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTN_thoat.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_thoat.OnHoverImage = null;
            this.BTN_thoat.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_thoat.Size = new System.Drawing.Size(60, 30);
            this.BTN_thoat.TabIndex = 217;
            this.BTN_thoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_thoat.Click += new System.EventHandler(this.BTN_thoat_Click);
            // 
            // ThemNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(848, 462);
            this.Controls.Add(this.BTN_phongban);
            this.Controls.Add(this.BTN_nhanvien);
            this.Controls.Add(this.LB_themmoi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PN_main);
            this.Controls.Add(this.BTN_thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNhom";
            this.Load += new System.EventHandler(this.ThemNhom_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThemNhom_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThemNhom_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThemNhom_MouseUp);
            this.PN_main.ResumeLayout(false);
            this.PN_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox CBB_nhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBB_phongban;
        private System.Windows.Forms.Label LB_maphongban;
        private Guna.UI.WinForms.GunaGradientButton BTN_ok;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LB_MaNhom;
        public System.Windows.Forms.TextBox TXB_maNhom;
        private System.Windows.Forms.Panel PN_main;
        private System.Windows.Forms.Label LB_themmoi;
        private System.Windows.Forms.Button BTN_nhanvien;
        private System.Windows.Forms.Button BTN_phongban;
        private Guna.UI.WinForms.GunaGradientButton BTN_xoa;
        private Guna.UI.WinForms.GunaGradientButton BTN_thoat;
    }
}