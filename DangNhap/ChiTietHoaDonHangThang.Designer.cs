namespace DangNhap
{
    partial class ChiTietHoaDonHangThang
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
            this.TXB_phiQuanLy = new System.Windows.Forms.TextBox();
            this.LB_phiQuanLy = new System.Windows.Forms.Label();
            this.CBB_tinhTrangThanhToan = new System.Windows.Forms.ComboBox();
            this.LB_tinhTrangThanhToan = new System.Windows.Forms.Label();
            this.LB_NgayGhi = new System.Windows.Forms.Label();
            this.DTP_ngay = new System.Windows.Forms.DateTimePicker();
            this.TXB_soDienHangThang = new System.Windows.Forms.TextBox();
            this.LB_soDienHangThang = new System.Windows.Forms.Label();
            this.TXB_soNuocHangThang = new System.Windows.Forms.TextBox();
            this.LB_soNuocHangThang = new System.Windows.Forms.Label();
            this.LB_MaCanHo = new System.Windows.Forms.Label();
            this.BTN_Edit = new Guna.UI.WinForms.GunaGradientButton();
            this.LB_BillHangThang = new System.Windows.Forms.Label();
            this.TXB_MaCanHo = new System.Windows.Forms.TextBox();
            this.TXB_BilliD = new System.Windows.Forms.TextBox();
            this.LB_BillID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXB_phiQuanLy
            // 
            this.TXB_phiQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.TXB_phiQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_phiQuanLy.ForeColor = System.Drawing.Color.White;
            this.TXB_phiQuanLy.Location = new System.Drawing.Point(374, 410);
            this.TXB_phiQuanLy.Multiline = true;
            this.TXB_phiQuanLy.Name = "TXB_phiQuanLy";
            this.TXB_phiQuanLy.Size = new System.Drawing.Size(419, 30);
            this.TXB_phiQuanLy.TabIndex = 233;
            // 
            // LB_phiQuanLy
            // 
            this.LB_phiQuanLy.AutoSize = true;
            this.LB_phiQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_phiQuanLy.ForeColor = System.Drawing.Color.White;
            this.LB_phiQuanLy.Location = new System.Drawing.Point(136, 410);
            this.LB_phiQuanLy.Name = "LB_phiQuanLy";
            this.LB_phiQuanLy.Size = new System.Drawing.Size(186, 22);
            this.LB_phiQuanLy.TabIndex = 232;
            this.LB_phiQuanLy.Text = "Phí quản lý hàng tháng";
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
            this.CBB_tinhTrangThanhToan.Location = new System.Drawing.Point(374, 577);
            this.CBB_tinhTrangThanhToan.Name = "CBB_tinhTrangThanhToan";
            this.CBB_tinhTrangThanhToan.Size = new System.Drawing.Size(419, 30);
            this.CBB_tinhTrangThanhToan.TabIndex = 231;
            // 
            // LB_tinhTrangThanhToan
            // 
            this.LB_tinhTrangThanhToan.AutoSize = true;
            this.LB_tinhTrangThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_tinhTrangThanhToan.ForeColor = System.Drawing.Color.White;
            this.LB_tinhTrangThanhToan.Location = new System.Drawing.Point(136, 577);
            this.LB_tinhTrangThanhToan.Name = "LB_tinhTrangThanhToan";
            this.LB_tinhTrangThanhToan.Size = new System.Drawing.Size(174, 22);
            this.LB_tinhTrangThanhToan.TabIndex = 230;
            this.LB_tinhTrangThanhToan.Text = "Tình trạng thanh toán";
            // 
            // LB_NgayGhi
            // 
            this.LB_NgayGhi.AutoSize = true;
            this.LB_NgayGhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NgayGhi.ForeColor = System.Drawing.Color.White;
            this.LB_NgayGhi.Location = new System.Drawing.Point(136, 500);
            this.LB_NgayGhi.Name = "LB_NgayGhi";
            this.LB_NgayGhi.Size = new System.Drawing.Size(80, 22);
            this.LB_NgayGhi.TabIndex = 229;
            this.LB_NgayGhi.Text = "Ngày ghi";
            // 
            // DTP_ngay
            // 
            this.DTP_ngay.CalendarMonthBackground = System.Drawing.Color.Black;
            this.DTP_ngay.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DTP_ngay.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DTP_ngay.CustomFormat = "yyyy-MM-dd";
            this.DTP_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_ngay.Location = new System.Drawing.Point(374, 492);
            this.DTP_ngay.Name = "DTP_ngay";
            this.DTP_ngay.Size = new System.Drawing.Size(419, 30);
            this.DTP_ngay.TabIndex = 228;
            // 
            // TXB_soDienHangThang
            // 
            this.TXB_soDienHangThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.TXB_soDienHangThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_soDienHangThang.ForeColor = System.Drawing.Color.White;
            this.TXB_soDienHangThang.Location = new System.Drawing.Point(374, 239);
            this.TXB_soDienHangThang.Multiline = true;
            this.TXB_soDienHangThang.Name = "TXB_soDienHangThang";
            this.TXB_soDienHangThang.Size = new System.Drawing.Size(419, 30);
            this.TXB_soDienHangThang.TabIndex = 227;
            // 
            // LB_soDienHangThang
            // 
            this.LB_soDienHangThang.AutoSize = true;
            this.LB_soDienHangThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_soDienHangThang.ForeColor = System.Drawing.Color.White;
            this.LB_soDienHangThang.Location = new System.Drawing.Point(136, 242);
            this.LB_soDienHangThang.Name = "LB_soDienHangThang";
            this.LB_soDienHangThang.Size = new System.Drawing.Size(223, 22);
            this.LB_soDienHangThang.TabIndex = 226;
            this.LB_soDienHangThang.Text = "Số điện sử dụng hàng tháng";
            // 
            // TXB_soNuocHangThang
            // 
            this.TXB_soNuocHangThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.TXB_soNuocHangThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_soNuocHangThang.ForeColor = System.Drawing.Color.White;
            this.TXB_soNuocHangThang.Location = new System.Drawing.Point(374, 329);
            this.TXB_soNuocHangThang.Multiline = true;
            this.TXB_soNuocHangThang.Name = "TXB_soNuocHangThang";
            this.TXB_soNuocHangThang.Size = new System.Drawing.Size(419, 30);
            this.TXB_soNuocHangThang.TabIndex = 225;
            // 
            // LB_soNuocHangThang
            // 
            this.LB_soNuocHangThang.AutoSize = true;
            this.LB_soNuocHangThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_soNuocHangThang.ForeColor = System.Drawing.Color.White;
            this.LB_soNuocHangThang.Location = new System.Drawing.Point(136, 329);
            this.LB_soNuocHangThang.Name = "LB_soNuocHangThang";
            this.LB_soNuocHangThang.Size = new System.Drawing.Size(193, 22);
            this.LB_soNuocHangThang.TabIndex = 224;
            this.LB_soNuocHangThang.Text = "Chỉ số nước hàng tháng";
            // 
            // LB_MaCanHo
            // 
            this.LB_MaCanHo.AutoSize = true;
            this.LB_MaCanHo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaCanHo.ForeColor = System.Drawing.Color.White;
            this.LB_MaCanHo.Location = new System.Drawing.Point(136, 159);
            this.LB_MaCanHo.Name = "LB_MaCanHo";
            this.LB_MaCanHo.Size = new System.Drawing.Size(92, 22);
            this.LB_MaCanHo.TabIndex = 222;
            this.LB_MaCanHo.Text = "Mã căn hộ";
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Animated = true;
            this.BTN_Edit.AnimationHoverSpeed = 0.5F;
            this.BTN_Edit.AnimationSpeed = 0.03F;
            this.BTN_Edit.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Edit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.BTN_Edit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_Edit.BorderColor = System.Drawing.Color.Black;
            this.BTN_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_Edit.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_Edit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Edit.ForeColor = System.Drawing.Color.White;
            this.BTN_Edit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTN_Edit.Image = null;
            this.BTN_Edit.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_Edit.Location = new System.Drawing.Point(840, 641);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_Edit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_Edit.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_Edit.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_Edit.OnHoverImage = null;
            this.BTN_Edit.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_Edit.Radius = 5;
            this.BTN_Edit.Size = new System.Drawing.Size(129, 35);
            this.BTN_Edit.TabIndex = 221;
            this.BTN_Edit.Text = "Sửa";
            this.BTN_Edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // LB_BillHangThang
            // 
            this.LB_BillHangThang.AutoSize = true;
            this.LB_BillHangThang.BackColor = System.Drawing.Color.Transparent;
            this.LB_BillHangThang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BillHangThang.ForeColor = System.Drawing.Color.White;
            this.LB_BillHangThang.Location = new System.Drawing.Point(248, 8);
            this.LB_BillHangThang.Name = "LB_BillHangThang";
            this.LB_BillHangThang.Size = new System.Drawing.Size(473, 32);
            this.LB_BillHangThang.TabIndex = 220;
            this.LB_BillHangThang.Text = "CHI TIẾT HÓA ĐƠN HÀNG THÁNG";
            // 
            // TXB_MaCanHo
            // 
            this.TXB_MaCanHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.TXB_MaCanHo.Enabled = false;
            this.TXB_MaCanHo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_MaCanHo.ForeColor = System.Drawing.Color.White;
            this.TXB_MaCanHo.Location = new System.Drawing.Point(374, 159);
            this.TXB_MaCanHo.Multiline = true;
            this.TXB_MaCanHo.Name = "TXB_MaCanHo";
            this.TXB_MaCanHo.Size = new System.Drawing.Size(419, 30);
            this.TXB_MaCanHo.TabIndex = 234;
            // 
            // TXB_BilliD
            // 
            this.TXB_BilliD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.TXB_BilliD.Enabled = false;
            this.TXB_BilliD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_BilliD.ForeColor = System.Drawing.Color.White;
            this.TXB_BilliD.Location = new System.Drawing.Point(374, 82);
            this.TXB_BilliD.Multiline = true;
            this.TXB_BilliD.Name = "TXB_BilliD";
            this.TXB_BilliD.Size = new System.Drawing.Size(419, 30);
            this.TXB_BilliD.TabIndex = 236;
            // 
            // LB_BillID
            // 
            this.LB_BillID.AutoSize = true;
            this.LB_BillID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BillID.ForeColor = System.Drawing.Color.White;
            this.LB_BillID.Location = new System.Drawing.Point(136, 82);
            this.LB_BillID.Name = "LB_BillID";
            this.LB_BillID.Size = new System.Drawing.Size(104, 22);
            this.LB_BillID.TabIndex = 235;
            this.LB_BillID.Text = "Mã hóa đơn";
            // 
            // ChiTietHoaDonHangThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(999, 727);
            this.Controls.Add(this.TXB_BilliD);
            this.Controls.Add(this.LB_BillID);
            this.Controls.Add(this.TXB_MaCanHo);
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
            this.Controls.Add(this.LB_MaCanHo);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.LB_BillHangThang);
            this.Name = "ChiTietHoaDonHangThang";
            this.Text = "ChiTietHoaDonHangThang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_phiQuanLy;
        private System.Windows.Forms.Label LB_tinhTrangThanhToan;
        private System.Windows.Forms.Label LB_NgayGhi;
        private System.Windows.Forms.Label LB_soDienHangThang;
        private System.Windows.Forms.Label LB_soNuocHangThang;
        private System.Windows.Forms.Label LB_MaCanHo;
        private Guna.UI.WinForms.GunaGradientButton BTN_Edit;
        private System.Windows.Forms.Label LB_BillHangThang;
        public System.Windows.Forms.TextBox TXB_phiQuanLy;
        public System.Windows.Forms.ComboBox CBB_tinhTrangThanhToan;
        public System.Windows.Forms.DateTimePicker DTP_ngay;
        public System.Windows.Forms.TextBox TXB_soDienHangThang;
        public System.Windows.Forms.TextBox TXB_soNuocHangThang;
        public System.Windows.Forms.TextBox TXB_MaCanHo;
        public System.Windows.Forms.TextBox TXB_BilliD;
        private System.Windows.Forms.Label LB_BillID;
    }
}