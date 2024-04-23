namespace DangNhap
{
    partial class ThongKeCanHo
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
            this.DTP_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.LB_TuNgay = new System.Windows.Forms.Label();
            this.LB_ToiNgay = new System.Windows.Forms.Label();
            this.DTP_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.GGC_ThongKe = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.LB_LoaiDoThi = new System.Windows.Forms.Label();
            this.CBB_LoaiDoThi = new System.Windows.Forms.ComboBox();
            this.Btn_XuatDoThi = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_ThongKe = new Guna.UI.WinForms.GunaGradientButton();
            this.CBB_DuLieuTK = new System.Windows.Forms.ComboBox();
            this.LB_MucTieuThongKe = new System.Windows.Forms.Label();
            this.LB_DuLieuThongKe = new System.Windows.Forms.Label();
            this.CBB_DuLieuMuonThongKe = new System.Windows.Forms.ComboBox();
            this.LB_TongHop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GGC_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP_TuNgay
            // 
            this.DTP_TuNgay.CustomFormat = "yyyy-MM-dd HH:MM";
            this.DTP_TuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_TuNgay.Location = new System.Drawing.Point(90, 30);
            this.DTP_TuNgay.Name = "DTP_TuNgay";
            this.DTP_TuNgay.Size = new System.Drawing.Size(248, 30);
            this.DTP_TuNgay.TabIndex = 261;
            // 
            // LB_TuNgay
            // 
            this.LB_TuNgay.AutoSize = true;
            this.LB_TuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TuNgay.ForeColor = System.Drawing.Color.White;
            this.LB_TuNgay.Location = new System.Drawing.Point(10, 29);
            this.LB_TuNgay.Name = "LB_TuNgay";
            this.LB_TuNgay.Size = new System.Drawing.Size(74, 22);
            this.LB_TuNgay.TabIndex = 247;
            this.LB_TuNgay.Text = "Từ ngày";
            // 
            // LB_ToiNgay
            // 
            this.LB_ToiNgay.AutoSize = true;
            this.LB_ToiNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ToiNgay.ForeColor = System.Drawing.Color.White;
            this.LB_ToiNgay.Location = new System.Drawing.Point(384, 30);
            this.LB_ToiNgay.Name = "LB_ToiNgay";
            this.LB_ToiNgay.Size = new System.Drawing.Size(80, 22);
            this.LB_ToiNgay.TabIndex = 248;
            this.LB_ToiNgay.Text = "Tới ngày";
            // 
            // DTP_DenNgay
            // 
            this.DTP_DenNgay.CustomFormat = "yyyy-MM-dd HH:MM";
            this.DTP_DenNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DenNgay.Location = new System.Drawing.Point(497, 30);
            this.DTP_DenNgay.Name = "DTP_DenNgay";
            this.DTP_DenNgay.Size = new System.Drawing.Size(248, 30);
            this.DTP_DenNgay.TabIndex = 262;
            // 
            // GGC_ThongKe
            // 
            this.GGC_ThongKe.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.GGC_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGC_ThongKe.BackColor = System.Drawing.SystemColors.Window;
            this.GGC_ThongKe.Location = new System.Drawing.Point(16, 146);
            this.GGC_ThongKe.Name = "GGC_ThongKe";
            this.GGC_ThongKe.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.GGC_ThongKe.Size = new System.Drawing.Size(1585, 583);
            this.GGC_ThongKe.TabIndex = 260;
            this.GGC_ThongKe.Text = "gridGroupingControl1";
            this.GGC_ThongKe.UseRightToLeftCompatibleTextBox = true;
            this.GGC_ThongKe.VersionInfo = "25.1462.39";
            // 
            // LB_LoaiDoThi
            // 
            this.LB_LoaiDoThi.AutoSize = true;
            this.LB_LoaiDoThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LoaiDoThi.ForeColor = System.Drawing.Color.White;
            this.LB_LoaiDoThi.Location = new System.Drawing.Point(883, 29);
            this.LB_LoaiDoThi.Name = "LB_LoaiDoThi";
            this.LB_LoaiDoThi.Size = new System.Drawing.Size(96, 22);
            this.LB_LoaiDoThi.TabIndex = 258;
            this.LB_LoaiDoThi.Text = "Loại đồ thị";
            // 
            // CBB_LoaiDoThi
            // 
            this.CBB_LoaiDoThi.FormattingEnabled = true;
            this.CBB_LoaiDoThi.Items.AddRange(new object[] {
            "Pie Chart",
            "Bar Chart",
            "Line Chart"});
            this.CBB_LoaiDoThi.Location = new System.Drawing.Point(1017, 27);
            this.CBB_LoaiDoThi.Name = "CBB_LoaiDoThi";
            this.CBB_LoaiDoThi.Size = new System.Drawing.Size(263, 24);
            this.CBB_LoaiDoThi.TabIndex = 257;
            // 
            // Btn_XuatDoThi
            // 
            this.Btn_XuatDoThi.Animated = true;
            this.Btn_XuatDoThi.AnimationHoverSpeed = 0.5F;
            this.Btn_XuatDoThi.AnimationSpeed = 0.03F;
            this.Btn_XuatDoThi.BackColor = System.Drawing.Color.Transparent;
            this.Btn_XuatDoThi.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.Btn_XuatDoThi.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_XuatDoThi.BorderColor = System.Drawing.Color.Black;
            this.Btn_XuatDoThi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_XuatDoThi.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_XuatDoThi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_XuatDoThi.ForeColor = System.Drawing.Color.White;
            this.Btn_XuatDoThi.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Btn_XuatDoThi.Image = null;
            this.Btn_XuatDoThi.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_XuatDoThi.Location = new System.Drawing.Point(1322, 25);
            this.Btn_XuatDoThi.Name = "Btn_XuatDoThi";
            this.Btn_XuatDoThi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_XuatDoThi.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.Btn_XuatDoThi.OnHoverBorderColor = System.Drawing.Color.White;
            this.Btn_XuatDoThi.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_XuatDoThi.OnHoverImage = null;
            this.Btn_XuatDoThi.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_XuatDoThi.Radius = 5;
            this.Btn_XuatDoThi.Size = new System.Drawing.Size(129, 26);
            this.Btn_XuatDoThi.TabIndex = 256;
            this.Btn_XuatDoThi.Text = "Xuất đồ thị";
            this.Btn_XuatDoThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_ThongKe
            // 
            this.BTN_ThongKe.Animated = true;
            this.BTN_ThongKe.AnimationHoverSpeed = 0.5F;
            this.BTN_ThongKe.AnimationSpeed = 0.03F;
            this.BTN_ThongKe.BackColor = System.Drawing.Color.Transparent;
            this.BTN_ThongKe.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.BTN_ThongKe.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ThongKe.BorderColor = System.Drawing.Color.Black;
            this.BTN_ThongKe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_ThongKe.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_ThongKe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ThongKe.ForeColor = System.Drawing.Color.White;
            this.BTN_ThongKe.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BTN_ThongKe.Image = null;
            this.BTN_ThongKe.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_ThongKe.Location = new System.Drawing.Point(1322, 100);
            this.BTN_ThongKe.Name = "BTN_ThongKe";
            this.BTN_ThongKe.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ThongKe.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.BTN_ThongKe.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_ThongKe.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_ThongKe.OnHoverImage = null;
            this.BTN_ThongKe.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_ThongKe.Radius = 5;
            this.BTN_ThongKe.Size = new System.Drawing.Size(129, 28);
            this.BTN_ThongKe.TabIndex = 255;
            this.BTN_ThongKe.Text = "Thống kê";
            this.BTN_ThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBB_DuLieuTK
            // 
            this.CBB_DuLieuTK.FormattingEnabled = true;
            this.CBB_DuLieuTK.Items.AddRange(new object[] {
            "Mã căn hộ",
            "Nhân viên",
            "Cư dân"});
            this.CBB_DuLieuTK.Location = new System.Drawing.Point(107, 107);
            this.CBB_DuLieuTK.Name = "CBB_DuLieuTK";
            this.CBB_DuLieuTK.Size = new System.Drawing.Size(231, 24);
            this.CBB_DuLieuTK.TabIndex = 251;
            this.CBB_DuLieuTK.SelectedValueChanged += new System.EventHandler(this.CBB_DuLieuTK_SelectedValueChanged);
            // 
            // LB_MucTieuThongKe
            // 
            this.LB_MucTieuThongKe.AutoSize = true;
            this.LB_MucTieuThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MucTieuThongKe.ForeColor = System.Drawing.Color.White;
            this.LB_MucTieuThongKe.Location = new System.Drawing.Point(12, 106);
            this.LB_MucTieuThongKe.Name = "LB_MucTieuThongKe";
            this.LB_MucTieuThongKe.Size = new System.Drawing.Size(82, 22);
            this.LB_MucTieuThongKe.TabIndex = 253;
            this.LB_MucTieuThongKe.Text = "Thống kê";
            // 
            // LB_DuLieuThongKe
            // 
            this.LB_DuLieuThongKe.AutoSize = true;
            this.LB_DuLieuThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DuLieuThongKe.ForeColor = System.Drawing.Color.White;
            this.LB_DuLieuThongKe.Location = new System.Drawing.Point(384, 106);
            this.LB_DuLieuThongKe.Name = "LB_DuLieuThongKe";
            this.LB_DuLieuThongKe.Size = new System.Drawing.Size(140, 22);
            this.LB_DuLieuThongKe.TabIndex = 264;
            this.LB_DuLieuThongKe.Text = "Dữ liệu thống kê";
            // 
            // CBB_DuLieuMuonThongKe
            // 
            this.CBB_DuLieuMuonThongKe.FormattingEnabled = true;
            this.CBB_DuLieuMuonThongKe.Items.AddRange(new object[] {
            "Mã căn hộ",
            "Nhân viên",
            "Cư dân"});
            this.CBB_DuLieuMuonThongKe.Location = new System.Drawing.Point(549, 104);
            this.CBB_DuLieuMuonThongKe.Name = "CBB_DuLieuMuonThongKe";
            this.CBB_DuLieuMuonThongKe.Size = new System.Drawing.Size(231, 24);
            this.CBB_DuLieuMuonThongKe.TabIndex = 265;
            // 
            // LB_TongHop
            // 
            this.LB_TongHop.AutoSize = true;
            this.LB_TongHop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TongHop.ForeColor = System.Drawing.Color.White;
            this.LB_TongHop.Location = new System.Drawing.Point(35, 758);
            this.LB_TongHop.Name = "LB_TongHop";
            this.LB_TongHop.Size = new System.Drawing.Size(74, 22);
            this.LB_TongHop.TabIndex = 266;
            this.LB_TongHop.Text = "Từ ngày";
            this.LB_TongHop.Visible = false;
            // 
            // ThongKeCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1634, 803);
            this.Controls.Add(this.LB_TongHop);
            this.Controls.Add(this.CBB_DuLieuMuonThongKe);
            this.Controls.Add(this.LB_DuLieuThongKe);
            this.Controls.Add(this.DTP_TuNgay);
            this.Controls.Add(this.LB_TuNgay);
            this.Controls.Add(this.LB_ToiNgay);
            this.Controls.Add(this.DTP_DenNgay);
            this.Controls.Add(this.GGC_ThongKe);
            this.Controls.Add(this.CBB_DuLieuTK);
            this.Controls.Add(this.LB_MucTieuThongKe);
            this.Controls.Add(this.LB_LoaiDoThi);
            this.Controls.Add(this.CBB_LoaiDoThi);
            this.Controls.Add(this.BTN_ThongKe);
            this.Controls.Add(this.Btn_XuatDoThi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeCanHo";
            this.Text = "ThongKeCanHo";
            ((System.ComponentModel.ISupportInitialize)(this.GGC_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_TuNgay;
        private System.Windows.Forms.Label LB_TuNgay;
        private System.Windows.Forms.Label LB_ToiNgay;
        private System.Windows.Forms.DateTimePicker DTP_DenNgay;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl GGC_ThongKe;
        private System.Windows.Forms.Label LB_LoaiDoThi;
        private System.Windows.Forms.ComboBox CBB_LoaiDoThi;
        private Guna.UI.WinForms.GunaGradientButton Btn_XuatDoThi;
        private Guna.UI.WinForms.GunaGradientButton BTN_ThongKe;
        private System.Windows.Forms.ComboBox CBB_DuLieuTK;
        private System.Windows.Forms.Label LB_MucTieuThongKe;
        private System.Windows.Forms.Label LB_DuLieuThongKe;
        private System.Windows.Forms.ComboBox CBB_DuLieuMuonThongKe;
        private System.Windows.Forms.Label LB_TongHop;
    }
}