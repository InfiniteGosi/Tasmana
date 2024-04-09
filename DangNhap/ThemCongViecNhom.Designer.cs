
namespace DangNhap
{
    partial class ThemCongViecNhom
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
            this.DTP_gio = new System.Windows.Forms.DateTimePicker();
            this.CB_uyquyen = new System.Windows.Forms.CheckBox();
            this.CBB_nhom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBB_phongban = new System.Windows.Forms.ComboBox();
            this.BTN_file = new System.Windows.Forms.Button();
            this.RBTN_toancongty = new System.Windows.Forms.RadioButton();
            this.LB_quyentruycap = new System.Windows.Forms.Label();
            this.RBTN_bophan = new System.Windows.Forms.RadioButton();
            this.LB_maphongban = new System.Windows.Forms.Label();
            this.LB_noidung = new System.Windows.Forms.Label();
            this.BTN_huy = new Guna.UI.WinForms.GunaGradientButton();
            this.TXB_noidung = new System.Windows.Forms.TextBox();
            this.BTN_ok = new Guna.UI.WinForms.GunaGradientButton();
            this.LB_macanho = new System.Windows.Forms.Label();
            this.LB_thoihan = new System.Windows.Forms.Label();
            this.DTP_ngay = new System.Windows.Forms.DateTimePicker();
            this.LB_tepdinhkem = new System.Windows.Forms.Label();
            this.TXB_macanho = new System.Windows.Forms.TextBox();
            this.TXB_MaCongViec = new System.Windows.Forms.TextBox();
            this.LB_MaCongViec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTP_gio
            // 
            this.DTP_gio.CalendarMonthBackground = System.Drawing.Color.Black;
            this.DTP_gio.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DTP_gio.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DTP_gio.Enabled = false;
            this.DTP_gio.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_gio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_gio.Location = new System.Drawing.Point(390, 421);
            this.DTP_gio.Name = "DTP_gio";
            this.DTP_gio.Size = new System.Drawing.Size(121, 28);
            this.DTP_gio.TabIndex = 180;
            // 
            // CB_uyquyen
            // 
            this.CB_uyquyen.AutoSize = true;
            this.CB_uyquyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_uyquyen.ForeColor = System.Drawing.Color.White;
            this.CB_uyquyen.Location = new System.Drawing.Point(212, 663);
            this.CB_uyquyen.Name = "CB_uyquyen";
            this.CB_uyquyen.Size = new System.Drawing.Size(241, 26);
            this.CB_uyquyen.TabIndex = 179;
            this.CB_uyquyen.Text = "Công việc được ủy quyền?";
            this.CB_uyquyen.UseVisualStyleBackColor = true;
            // 
            // CBB_nhom
            // 
            this.CBB_nhom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CBB_nhom.Enabled = false;
            this.CBB_nhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBB_nhom.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_nhom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CBB_nhom.FormattingEnabled = true;
            this.CBB_nhom.Location = new System.Drawing.Point(53, 151);
            this.CBB_nhom.Name = "CBB_nhom";
            this.CBB_nhom.Size = new System.Drawing.Size(458, 28);
            this.CBB_nhom.TabIndex = 178;
            this.CBB_nhom.SelectedValueChanged += new System.EventHandler(this.CBB_nhom_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 177;
            this.label1.Text = "Nhóm";
            // 
            // CBB_phongban
            // 
            this.CBB_phongban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CBB_phongban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBB_phongban.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_phongban.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CBB_phongban.FormattingEnabled = true;
            this.CBB_phongban.Location = new System.Drawing.Point(53, 47);
            this.CBB_phongban.Name = "CBB_phongban";
            this.CBB_phongban.Size = new System.Drawing.Size(458, 28);
            this.CBB_phongban.TabIndex = 175;
            this.CBB_phongban.SelectedValueChanged += new System.EventHandler(this.CBB_phongban_SelectedValueChanged);
            // 
            // BTN_file
            // 
            this.BTN_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_file.ForeColor = System.Drawing.Color.White;
            this.BTN_file.Location = new System.Drawing.Point(212, 499);
            this.BTN_file.Name = "BTN_file";
            this.BTN_file.Size = new System.Drawing.Size(75, 33);
            this.BTN_file.TabIndex = 174;
            this.BTN_file.Text = "File";
            this.BTN_file.UseVisualStyleBackColor = true;
            // 
            // RBTN_toancongty
            // 
            this.RBTN_toancongty.AutoSize = true;
            this.RBTN_toancongty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_toancongty.ForeColor = System.Drawing.Color.White;
            this.RBTN_toancongty.Location = new System.Drawing.Point(323, 605);
            this.RBTN_toancongty.Name = "RBTN_toancongty";
            this.RBTN_toancongty.Size = new System.Drawing.Size(131, 26);
            this.RBTN_toancongty.TabIndex = 171;
            this.RBTN_toancongty.TabStop = true;
            this.RBTN_toancongty.Text = "Toàn công ty";
            this.RBTN_toancongty.UseVisualStyleBackColor = true;
            // 
            // LB_quyentruycap
            // 
            this.LB_quyentruycap.AutoSize = true;
            this.LB_quyentruycap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_quyentruycap.ForeColor = System.Drawing.Color.White;
            this.LB_quyentruycap.Location = new System.Drawing.Point(51, 607);
            this.LB_quyentruycap.Name = "LB_quyentruycap";
            this.LB_quyentruycap.Size = new System.Drawing.Size(128, 22);
            this.LB_quyentruycap.TabIndex = 172;
            this.LB_quyentruycap.Text = "Quyền truy cập";
            // 
            // RBTN_bophan
            // 
            this.RBTN_bophan.AutoSize = true;
            this.RBTN_bophan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_bophan.ForeColor = System.Drawing.Color.White;
            this.RBTN_bophan.Location = new System.Drawing.Point(212, 605);
            this.RBTN_bophan.Name = "RBTN_bophan";
            this.RBTN_bophan.Size = new System.Drawing.Size(96, 26);
            this.RBTN_bophan.TabIndex = 170;
            this.RBTN_bophan.TabStop = true;
            this.RBTN_bophan.Text = "Bộ phận";
            this.RBTN_bophan.UseVisualStyleBackColor = true;
            // 
            // LB_maphongban
            // 
            this.LB_maphongban.AutoSize = true;
            this.LB_maphongban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_maphongban.ForeColor = System.Drawing.Color.White;
            this.LB_maphongban.Location = new System.Drawing.Point(49, 22);
            this.LB_maphongban.Name = "LB_maphongban";
            this.LB_maphongban.Size = new System.Drawing.Size(91, 22);
            this.LB_maphongban.TabIndex = 161;
            this.LB_maphongban.Text = "Phòng ban";
            // 
            // LB_noidung
            // 
            this.LB_noidung.AutoSize = true;
            this.LB_noidung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_noidung.ForeColor = System.Drawing.Color.White;
            this.LB_noidung.Location = new System.Drawing.Point(49, 232);
            this.LB_noidung.Name = "LB_noidung";
            this.LB_noidung.Size = new System.Drawing.Size(82, 22);
            this.LB_noidung.TabIndex = 162;
            this.LB_noidung.Text = "Nội dung";
            // 
            // BTN_huy
            // 
            this.BTN_huy.Animated = true;
            this.BTN_huy.AnimationHoverSpeed = 0.5F;
            this.BTN_huy.AnimationSpeed = 0.03F;
            this.BTN_huy.BaseColor1 = System.Drawing.Color.Firebrick;
            this.BTN_huy.BaseColor2 = System.Drawing.Color.Red;
            this.BTN_huy.BorderColor = System.Drawing.Color.Black;
            this.BTN_huy.BorderSize = 2;
            this.BTN_huy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_huy.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_huy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_huy.ForeColor = System.Drawing.Color.Black;
            this.BTN_huy.Image = null;
            this.BTN_huy.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_huy.Location = new System.Drawing.Point(392, 742);
            this.BTN_huy.Name = "BTN_huy";
            this.BTN_huy.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.BTN_huy.OnHoverBaseColor2 = System.Drawing.Color.DarkRed;
            this.BTN_huy.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_huy.OnHoverImage = null;
            this.BTN_huy.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_huy.Size = new System.Drawing.Size(89, 42);
            this.BTN_huy.TabIndex = 169;
            this.BTN_huy.Text = "Hoàn tác";
            this.BTN_huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXB_noidung
            // 
            this.TXB_noidung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TXB_noidung.Enabled = false;
            this.TXB_noidung.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_noidung.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_noidung.Location = new System.Drawing.Point(53, 257);
            this.TXB_noidung.Multiline = true;
            this.TXB_noidung.Name = "TXB_noidung";
            this.TXB_noidung.Size = new System.Drawing.Size(298, 70);
            this.TXB_noidung.TabIndex = 163;
            // 
            // BTN_ok
            // 
            this.BTN_ok.Animated = true;
            this.BTN_ok.AnimationHoverSpeed = 0.5F;
            this.BTN_ok.AnimationSpeed = 0.03F;
            this.BTN_ok.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTN_ok.BaseColor2 = System.Drawing.Color.Green;
            this.BTN_ok.BorderColor = System.Drawing.Color.Black;
            this.BTN_ok.BorderSize = 2;
            this.BTN_ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_ok.Enabled = false;
            this.BTN_ok.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_ok.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BTN_ok.Image = null;
            this.BTN_ok.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_ok.Location = new System.Drawing.Point(487, 742);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.OnHoverBaseColor1 = System.Drawing.Color.Green;
            this.BTN_ok.OnHoverBaseColor2 = System.Drawing.Color.ForestGreen;
            this.BTN_ok.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_ok.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_ok.OnHoverImage = null;
            this.BTN_ok.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_ok.Size = new System.Drawing.Size(89, 42);
            this.BTN_ok.TabIndex = 168;
            this.BTN_ok.Text = "Lưu";
            this.BTN_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_ok.Click += new System.EventHandler(this.BTN_ok_Click);
            // 
            // LB_macanho
            // 
            this.LB_macanho.AutoSize = true;
            this.LB_macanho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_macanho.ForeColor = System.Drawing.Color.White;
            this.LB_macanho.Location = new System.Drawing.Point(386, 232);
            this.LB_macanho.Name = "LB_macanho";
            this.LB_macanho.Size = new System.Drawing.Size(92, 22);
            this.LB_macanho.TabIndex = 164;
            this.LB_macanho.Text = "Mã căn hộ";
            // 
            // LB_thoihan
            // 
            this.LB_thoihan.AutoSize = true;
            this.LB_thoihan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_thoihan.ForeColor = System.Drawing.Color.White;
            this.LB_thoihan.Location = new System.Drawing.Point(49, 424);
            this.LB_thoihan.Name = "LB_thoihan";
            this.LB_thoihan.Size = new System.Drawing.Size(80, 22);
            this.LB_thoihan.TabIndex = 165;
            this.LB_thoihan.Text = "Thời hạn";
            // 
            // DTP_ngay
            // 
            this.DTP_ngay.CalendarMonthBackground = System.Drawing.Color.Black;
            this.DTP_ngay.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DTP_ngay.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DTP_ngay.Enabled = false;
            this.DTP_ngay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_ngay.Location = new System.Drawing.Point(241, 421);
            this.DTP_ngay.Name = "DTP_ngay";
            this.DTP_ngay.Size = new System.Drawing.Size(110, 28);
            this.DTP_ngay.TabIndex = 166;
            // 
            // LB_tepdinhkem
            // 
            this.LB_tepdinhkem.AutoSize = true;
            this.LB_tepdinhkem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_tepdinhkem.ForeColor = System.Drawing.Color.White;
            this.LB_tepdinhkem.Location = new System.Drawing.Point(51, 503);
            this.LB_tepdinhkem.Name = "LB_tepdinhkem";
            this.LB_tepdinhkem.Size = new System.Drawing.Size(117, 22);
            this.LB_tepdinhkem.TabIndex = 167;
            this.LB_tepdinhkem.Text = "Tệp đính kèm";
            // 
            // TXB_macanho
            // 
            this.TXB_macanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TXB_macanho.Enabled = false;
            this.TXB_macanho.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_macanho.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_macanho.Location = new System.Drawing.Point(390, 257);
            this.TXB_macanho.Multiline = true;
            this.TXB_macanho.Name = "TXB_macanho";
            this.TXB_macanho.Size = new System.Drawing.Size(121, 28);
            this.TXB_macanho.TabIndex = 183;
            // 
            // TXB_MaCongViec
            // 
            this.TXB_MaCongViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TXB_MaCongViec.Enabled = false;
            this.TXB_MaCongViec.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_MaCongViec.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_MaCongViec.Location = new System.Drawing.Point(175, 355);
            this.TXB_MaCongViec.Multiline = true;
            this.TXB_MaCongViec.Name = "TXB_MaCongViec";
            this.TXB_MaCongViec.Size = new System.Drawing.Size(336, 28);
            this.TXB_MaCongViec.TabIndex = 185;
            // 
            // LB_MaCongViec
            // 
            this.LB_MaCongViec.AutoSize = true;
            this.LB_MaCongViec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MaCongViec.ForeColor = System.Drawing.Color.White;
            this.LB_MaCongViec.Location = new System.Drawing.Point(52, 355);
            this.LB_MaCongViec.Name = "LB_MaCongViec";
            this.LB_MaCongViec.Size = new System.Drawing.Size(123, 22);
            this.LB_MaCongViec.TabIndex = 184;
            this.LB_MaCongViec.Text = "Mã Công Việc";
            // 
            // ThemCongViecNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(595, 797);
            this.Controls.Add(this.TXB_MaCongViec);
            this.Controls.Add(this.LB_MaCongViec);
            this.Controls.Add(this.TXB_macanho);
            this.Controls.Add(this.DTP_gio);
            this.Controls.Add(this.CB_uyquyen);
            this.Controls.Add(this.CBB_nhom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBB_phongban);
            this.Controls.Add(this.BTN_file);
            this.Controls.Add(this.RBTN_toancongty);
            this.Controls.Add(this.LB_quyentruycap);
            this.Controls.Add(this.RBTN_bophan);
            this.Controls.Add(this.LB_maphongban);
            this.Controls.Add(this.LB_noidung);
            this.Controls.Add(this.BTN_huy);
            this.Controls.Add(this.TXB_noidung);
            this.Controls.Add(this.BTN_ok);
            this.Controls.Add(this.LB_macanho);
            this.Controls.Add(this.LB_thoihan);
            this.Controls.Add(this.DTP_ngay);
            this.Controls.Add(this.LB_tepdinhkem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemCongViecNhom";
            this.Text = "ThemCongViecNhom";
            this.Load += new System.EventHandler(this.ThemCongViecNhom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_gio;
        private System.Windows.Forms.CheckBox CB_uyquyen;
        private System.Windows.Forms.ComboBox CBB_nhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBB_phongban;
        private System.Windows.Forms.Button BTN_file;
        private System.Windows.Forms.RadioButton RBTN_toancongty;
        private System.Windows.Forms.Label LB_quyentruycap;
        private System.Windows.Forms.RadioButton RBTN_bophan;
        private System.Windows.Forms.Label LB_maphongban;
        private System.Windows.Forms.Label LB_noidung;
        private Guna.UI.WinForms.GunaGradientButton BTN_huy;
        private System.Windows.Forms.TextBox TXB_noidung;
        private Guna.UI.WinForms.GunaGradientButton BTN_ok;
        private System.Windows.Forms.Label LB_macanho;
        private System.Windows.Forms.Label LB_thoihan;
        private System.Windows.Forms.DateTimePicker DTP_ngay;
        private System.Windows.Forms.Label LB_tepdinhkem;
        private System.Windows.Forms.TextBox TXB_macanho;
        private System.Windows.Forms.TextBox TXB_MaCongViec;
        private System.Windows.Forms.Label LB_MaCongViec;
    }
}