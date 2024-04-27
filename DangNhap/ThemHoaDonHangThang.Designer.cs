namespace DangNhap
{
    partial class ThemHoaDonHangThang
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
            this.LB_BillHangThang = new System.Windows.Forms.Label();
            this.BTN_ok = new Guna.UI.WinForms.GunaGradientButton();
            this.LB_MaCanHo = new System.Windows.Forms.Label();
            this.CBB_MaCanHo = new System.Windows.Forms.ComboBox();
            this.LB_soNuocHangThang = new System.Windows.Forms.Label();
            this.TXB_soNuocHangThang = new System.Windows.Forms.TextBox();
            this.LB_soDienHangThang = new System.Windows.Forms.Label();
            this.TXB_soDienHangThang = new System.Windows.Forms.TextBox();
            this.DTP_ngay = new System.Windows.Forms.DateTimePicker();
            this.LB_NgayGhi = new System.Windows.Forms.Label();
            this.LB_tinhTrangThanhToan = new System.Windows.Forms.Label();
            this.CBB_tinhTrangThanhToan = new System.Windows.Forms.ComboBox();
            this.LB_phiQuanLy = new System.Windows.Forms.Label();
            this.TXB_phiQuanLy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_BillHangThang
            // 
            this.LB_BillHangThang.AutoSize = true;
            this.LB_BillHangThang.BackColor = System.Drawing.Color.Transparent;
            this.LB_BillHangThang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BillHangThang.ForeColor = System.Drawing.Color.White;
            this.LB_BillHangThang.Location = new System.Drawing.Point(192, 24);
            this.LB_BillHangThang.Name = "LB_BillHangThang";
            this.LB_BillHangThang.Size = new System.Drawing.Size(436, 32);
            this.LB_BillHangThang.TabIndex = 125;
            this.LB_BillHangThang.Text = "THÊM HÓA ĐƠN HÀNG THÁNG";
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
            this.BTN_ok.Location = new System.Drawing.Point(692, 616);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ok.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ok.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_ok.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_ok.OnHoverImage = null;
            this.BTN_ok.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_ok.Radius = 5;
            this.BTN_ok.Size = new System.Drawing.Size(129, 35);
            this.BTN_ok.TabIndex = 169;
            this.BTN_ok.Text = "Thêm";
            this.BTN_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_ok.Click += new System.EventHandler(this.BTN_ok_Click);
            // 
            // LB_MaCanHo
            // 
            this.LB_MaCanHo.AutoSize = true;
            this.LB_MaCanHo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaCanHo.ForeColor = System.Drawing.Color.White;
            this.LB_MaCanHo.Location = new System.Drawing.Point(66, 103);
            this.LB_MaCanHo.Name = "LB_MaCanHo";
            this.LB_MaCanHo.Size = new System.Drawing.Size(92, 22);
            this.LB_MaCanHo.TabIndex = 170;
            this.LB_MaCanHo.Text = "Mã căn hộ";
            // 
            // CBB_MaCanHo
            // 
            this.CBB_MaCanHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.CBB_MaCanHo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_MaCanHo.ForeColor = System.Drawing.Color.White;
            this.CBB_MaCanHo.FormattingEnabled = true;
            this.CBB_MaCanHo.Location = new System.Drawing.Point(304, 100);
            this.CBB_MaCanHo.Name = "CBB_MaCanHo";
            this.CBB_MaCanHo.Size = new System.Drawing.Size(419, 30);
            this.CBB_MaCanHo.TabIndex = 209;
            // 
            // LB_soNuocHangThang
            // 
            this.LB_soNuocHangThang.AutoSize = true;
            this.LB_soNuocHangThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_soNuocHangThang.ForeColor = System.Drawing.Color.White;
            this.LB_soNuocHangThang.Location = new System.Drawing.Point(66, 273);
            this.LB_soNuocHangThang.Name = "LB_soNuocHangThang";
            this.LB_soNuocHangThang.Size = new System.Drawing.Size(193, 22);
            this.LB_soNuocHangThang.TabIndex = 210;
            this.LB_soNuocHangThang.Text = "Chỉ số nước hàng tháng";
            // 
            // TXB_soNuocHangThang
            // 
            this.TXB_soNuocHangThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.TXB_soNuocHangThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_soNuocHangThang.ForeColor = System.Drawing.Color.White;
            this.TXB_soNuocHangThang.Location = new System.Drawing.Point(304, 273);
            this.TXB_soNuocHangThang.Multiline = true;
            this.TXB_soNuocHangThang.Name = "TXB_soNuocHangThang";
            this.TXB_soNuocHangThang.Size = new System.Drawing.Size(419, 30);
            this.TXB_soNuocHangThang.TabIndex = 211;
            // 
            // LB_soDienHangThang
            // 
            this.LB_soDienHangThang.AutoSize = true;
            this.LB_soDienHangThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_soDienHangThang.ForeColor = System.Drawing.Color.White;
            this.LB_soDienHangThang.Location = new System.Drawing.Point(66, 186);
            this.LB_soDienHangThang.Name = "LB_soDienHangThang";
            this.LB_soDienHangThang.Size = new System.Drawing.Size(223, 22);
            this.LB_soDienHangThang.TabIndex = 212;
            this.LB_soDienHangThang.Text = "Số điện sử dụng hàng tháng";
            // 
            // TXB_soDienHangThang
            // 
            this.TXB_soDienHangThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.TXB_soDienHangThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_soDienHangThang.ForeColor = System.Drawing.Color.White;
            this.TXB_soDienHangThang.Location = new System.Drawing.Point(304, 183);
            this.TXB_soDienHangThang.Multiline = true;
            this.TXB_soDienHangThang.Name = "TXB_soDienHangThang";
            this.TXB_soDienHangThang.Size = new System.Drawing.Size(419, 30);
            this.TXB_soDienHangThang.TabIndex = 213;
            // 
            // DTP_ngay
            // 
            this.DTP_ngay.CalendarMonthBackground = System.Drawing.Color.Black;
            this.DTP_ngay.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DTP_ngay.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DTP_ngay.CustomFormat = "yyyy-MM-dd";
            this.DTP_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_ngay.Location = new System.Drawing.Point(304, 436);
            this.DTP_ngay.Name = "DTP_ngay";
            this.DTP_ngay.Size = new System.Drawing.Size(419, 30);
            this.DTP_ngay.TabIndex = 214;
            // 
            // LB_NgayGhi
            // 
            this.LB_NgayGhi.AutoSize = true;
            this.LB_NgayGhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NgayGhi.ForeColor = System.Drawing.Color.White;
            this.LB_NgayGhi.Location = new System.Drawing.Point(66, 444);
            this.LB_NgayGhi.Name = "LB_NgayGhi";
            this.LB_NgayGhi.Size = new System.Drawing.Size(80, 22);
            this.LB_NgayGhi.TabIndex = 215;
            this.LB_NgayGhi.Text = "Ngày ghi";
            // 
            // LB_tinhTrangThanhToan
            // 
            this.LB_tinhTrangThanhToan.AutoSize = true;
            this.LB_tinhTrangThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_tinhTrangThanhToan.ForeColor = System.Drawing.Color.White;
            this.LB_tinhTrangThanhToan.Location = new System.Drawing.Point(66, 521);
            this.LB_tinhTrangThanhToan.Name = "LB_tinhTrangThanhToan";
            this.LB_tinhTrangThanhToan.Size = new System.Drawing.Size(174, 22);
            this.LB_tinhTrangThanhToan.TabIndex = 216;
            this.LB_tinhTrangThanhToan.Text = "Tình trạng thanh toán";
            // 
            // CBB_tinhTrangThanhToan
            // 
            this.CBB_tinhTrangThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.CBB_tinhTrangThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_tinhTrangThanhToan.ForeColor = System.Drawing.Color.White;
            this.CBB_tinhTrangThanhToan.FormattingEnabled = true;
            this.CBB_tinhTrangThanhToan.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.CBB_tinhTrangThanhToan.Location = new System.Drawing.Point(304, 521);
            this.CBB_tinhTrangThanhToan.Name = "CBB_tinhTrangThanhToan";
            this.CBB_tinhTrangThanhToan.Size = new System.Drawing.Size(419, 30);
            this.CBB_tinhTrangThanhToan.TabIndex = 217;
            // 
            // LB_phiQuanLy
            // 
            this.LB_phiQuanLy.AutoSize = true;
            this.LB_phiQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_phiQuanLy.ForeColor = System.Drawing.Color.White;
            this.LB_phiQuanLy.Location = new System.Drawing.Point(66, 354);
            this.LB_phiQuanLy.Name = "LB_phiQuanLy";
            this.LB_phiQuanLy.Size = new System.Drawing.Size(233, 28);
            this.LB_phiQuanLy.TabIndex = 218;
            this.LB_phiQuanLy.Text = "Phí quản lý hàng tháng";
            // 
            // TXB_phiQuanLy
            // 
            this.TXB_phiQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.TXB_phiQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_phiQuanLy.ForeColor = System.Drawing.Color.White;
            this.TXB_phiQuanLy.Location = new System.Drawing.Point(304, 354);
            this.TXB_phiQuanLy.Multiline = true;
            this.TXB_phiQuanLy.Name = "TXB_phiQuanLy";
            this.TXB_phiQuanLy.Size = new System.Drawing.Size(419, 30);
            this.TXB_phiQuanLy.TabIndex = 219;
            // 
            // ThemHoaDonHangThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(850, 688);
            this.Controls.Add(this.TXB_phiQuanLy);
            this.Controls.Add(this.LB_phiQuanLy);
            this.Controls.Add(this.CBB_tinhTrangThanhToan);
            this.Controls.Add(this.LB_tinhTrangThanhToan);
            this.Controls.Add(this.LB_NgayGhi);
            this.Controls.Add(this.DTP_ngay);
            this.Controls.Add(this.TXB_soDienHangThang);
            this.Controls.Add(this.LB_soDienHangThang);
            this.Controls.Add(this.TXB_soNuocHangThang);
            this.Controls.Add(this.LB_soNuocHangThang);
            this.Controls.Add(this.CBB_MaCanHo);
            this.Controls.Add(this.LB_MaCanHo);
            this.Controls.Add(this.BTN_ok);
            this.Controls.Add(this.LB_BillHangThang);
            this.Name = "ThemHoaDonHangThang";
            this.Text = "ThemHoaDonHangThang";
            this.Load += new System.EventHandler(this.ThemHoaDonHangThang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_BillHangThang;
        private Guna.UI.WinForms.GunaGradientButton BTN_ok;
        private System.Windows.Forms.Label LB_MaCanHo;
        private System.Windows.Forms.ComboBox CBB_MaCanHo;
        private System.Windows.Forms.Label LB_soNuocHangThang;
        private System.Windows.Forms.TextBox TXB_soNuocHangThang;
        private System.Windows.Forms.Label LB_soDienHangThang;
        private System.Windows.Forms.TextBox TXB_soDienHangThang;
        private System.Windows.Forms.DateTimePicker DTP_ngay;
        private System.Windows.Forms.Label LB_NgayGhi;
        private System.Windows.Forms.Label LB_tinhTrangThanhToan;
        private System.Windows.Forms.ComboBox CBB_tinhTrangThanhToan;
        private System.Windows.Forms.Label LB_phiQuanLy;
        private System.Windows.Forms.TextBox TXB_phiQuanLy;
    }
}