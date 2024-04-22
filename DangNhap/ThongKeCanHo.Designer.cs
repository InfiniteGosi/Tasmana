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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DTP_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.LB_TuNgay = new System.Windows.Forms.Label();
            this.C_ThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LB_ToiNgay = new System.Windows.Forms.Label();
            this.DTP_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.GGC_ThongKe = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.LB_LoaiDoThi = new System.Windows.Forms.Label();
            this.CBB_LoaiDoThi = new System.Windows.Forms.ComboBox();
            this.Btn_XuatDoThi = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_ThongKe = new Guna.UI.WinForms.GunaGradientButton();
            this.CBB_NhanVien = new System.Windows.Forms.ComboBox();
            this.LB_NhanVien = new System.Windows.Forms.Label();
            this.CBB_PhongBan = new System.Windows.Forms.ComboBox();
            this.LB_PhongBan = new System.Windows.Forms.Label();
            this.RBtn_NhanVien = new System.Windows.Forms.RadioButton();
            this.RBtn_PhongBan = new System.Windows.Forms.RadioButton();
            this.RBtn_Congty = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.C_ThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GGC_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP_TuNgay
            // 
            this.DTP_TuNgay.CustomFormat = "yyyy-MM-dd HH:MM";
            this.DTP_TuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_TuNgay.Location = new System.Drawing.Point(90, 53);
            this.DTP_TuNgay.Name = "DTP_TuNgay";
            this.DTP_TuNgay.Size = new System.Drawing.Size(248, 30);
            this.DTP_TuNgay.TabIndex = 261;
            // 
            // LB_TuNgay
            // 
            this.LB_TuNgay.AutoSize = true;
            this.LB_TuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TuNgay.ForeColor = System.Drawing.Color.White;
            this.LB_TuNgay.Location = new System.Drawing.Point(10, 52);
            this.LB_TuNgay.Name = "LB_TuNgay";
            this.LB_TuNgay.Size = new System.Drawing.Size(74, 22);
            this.LB_TuNgay.TabIndex = 247;
            this.LB_TuNgay.Text = "Từ ngày";
            // 
            // C_ThongKe
            // 
            chartArea2.Name = "ChartArea1";
            this.C_ThongKe.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.C_ThongKe.Legends.Add(legend2);
            this.C_ThongKe.Location = new System.Drawing.Point(14, 169);
            this.C_ThongKe.Name = "C_ThongKe";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "#.##";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.C_ThongKe.Series.Add(series2);
            this.C_ThongKe.Size = new System.Drawing.Size(1585, 574);
            this.C_ThongKe.TabIndex = 263;
            this.C_ThongKe.Text = "chart1";
            this.C_ThongKe.Visible = false;
            // 
            // LB_ToiNgay
            // 
            this.LB_ToiNgay.AutoSize = true;
            this.LB_ToiNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ToiNgay.ForeColor = System.Drawing.Color.White;
            this.LB_ToiNgay.Location = new System.Drawing.Point(384, 53);
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
            this.DTP_DenNgay.Location = new System.Drawing.Point(497, 53);
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
            this.GGC_ThongKe.Location = new System.Drawing.Point(45, 169);
            this.GGC_ThongKe.Name = "GGC_ThongKe";
            this.GGC_ThongKe.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.GGC_ThongKe.Size = new System.Drawing.Size(1585, 570);
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
            this.LB_LoaiDoThi.Location = new System.Drawing.Point(883, 52);
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
            this.CBB_LoaiDoThi.Location = new System.Drawing.Point(1017, 50);
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
            this.Btn_XuatDoThi.Location = new System.Drawing.Point(1322, 48);
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
            this.BTN_ThongKe.Location = new System.Drawing.Point(1322, 115);
            this.BTN_ThongKe.Name = "BTN_ThongKe";
            this.BTN_ThongKe.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ThongKe.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.BTN_ThongKe.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_ThongKe.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_ThongKe.OnHoverImage = null;
            this.BTN_ThongKe.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_ThongKe.Radius = 5;
            this.BTN_ThongKe.Size = new System.Drawing.Size(136, 28);
            this.BTN_ThongKe.TabIndex = 255;
            this.BTN_ThongKe.Text = "Thống kê";
            this.BTN_ThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBB_NhanVien
            // 
            this.CBB_NhanVien.FormattingEnabled = true;
            this.CBB_NhanVien.Location = new System.Drawing.Point(1017, 119);
            this.CBB_NhanVien.Name = "CBB_NhanVien";
            this.CBB_NhanVien.Size = new System.Drawing.Size(257, 24);
            this.CBB_NhanVien.TabIndex = 252;
            // 
            // LB_NhanVien
            // 
            this.LB_NhanVien.AutoSize = true;
            this.LB_NhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NhanVien.ForeColor = System.Drawing.Color.White;
            this.LB_NhanVien.Location = new System.Drawing.Point(883, 121);
            this.LB_NhanVien.Name = "LB_NhanVien";
            this.LB_NhanVien.Size = new System.Drawing.Size(92, 22);
            this.LB_NhanVien.TabIndex = 254;
            this.LB_NhanVien.Text = "Nhân Viên";
            // 
            // CBB_PhongBan
            // 
            this.CBB_PhongBan.FormattingEnabled = true;
            this.CBB_PhongBan.Location = new System.Drawing.Point(595, 119);
            this.CBB_PhongBan.Name = "CBB_PhongBan";
            this.CBB_PhongBan.Size = new System.Drawing.Size(231, 24);
            this.CBB_PhongBan.TabIndex = 251;
            // 
            // LB_PhongBan
            // 
            this.LB_PhongBan.AutoSize = true;
            this.LB_PhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhongBan.ForeColor = System.Drawing.Color.White;
            this.LB_PhongBan.Location = new System.Drawing.Point(477, 118);
            this.LB_PhongBan.Name = "LB_PhongBan";
            this.LB_PhongBan.Size = new System.Drawing.Size(75, 22);
            this.LB_PhongBan.TabIndex = 253;
            this.LB_PhongBan.Text = "Bộ phận";
            // 
            // RBtn_NhanVien
            // 
            this.RBtn_NhanVien.AutoSize = true;
            this.RBtn_NhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_NhanVien.ForeColor = System.Drawing.Color.White;
            this.RBtn_NhanVien.Location = new System.Drawing.Point(324, 113);
            this.RBtn_NhanVien.Name = "RBtn_NhanVien";
            this.RBtn_NhanVien.Size = new System.Drawing.Size(111, 26);
            this.RBtn_NhanVien.TabIndex = 250;
            this.RBtn_NhanVien.TabStop = true;
            this.RBtn_NhanVien.Text = "Nhân viên";
            this.RBtn_NhanVien.UseVisualStyleBackColor = true;
            // 
            // RBtn_PhongBan
            // 
            this.RBtn_PhongBan.AutoSize = true;
            this.RBtn_PhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_PhongBan.ForeColor = System.Drawing.Color.White;
            this.RBtn_PhongBan.Location = new System.Drawing.Point(168, 113);
            this.RBtn_PhongBan.Name = "RBtn_PhongBan";
            this.RBtn_PhongBan.Size = new System.Drawing.Size(112, 26);
            this.RBtn_PhongBan.TabIndex = 249;
            this.RBtn_PhongBan.TabStop = true;
            this.RBtn_PhongBan.Text = "Phòng ban";
            this.RBtn_PhongBan.UseVisualStyleBackColor = true;
            // 
            // RBtn_Congty
            // 
            this.RBtn_Congty.AutoSize = true;
            this.RBtn_Congty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_Congty.ForeColor = System.Drawing.Color.White;
            this.RBtn_Congty.Location = new System.Drawing.Point(5, 113);
            this.RBtn_Congty.Name = "RBtn_Congty";
            this.RBtn_Congty.Size = new System.Drawing.Size(131, 26);
            this.RBtn_Congty.TabIndex = 259;
            this.RBtn_Congty.TabStop = true;
            this.RBtn_Congty.Text = "Toàn công ty";
            this.RBtn_Congty.UseVisualStyleBackColor = true;
            // 
            // ThongKeCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1634, 790);
            this.Controls.Add(this.DTP_TuNgay);
            this.Controls.Add(this.LB_TuNgay);
            this.Controls.Add(this.C_ThongKe);
            this.Controls.Add(this.LB_ToiNgay);
            this.Controls.Add(this.DTP_DenNgay);
            this.Controls.Add(this.RBtn_PhongBan);
            this.Controls.Add(this.RBtn_NhanVien);
            this.Controls.Add(this.GGC_ThongKe);
            this.Controls.Add(this.CBB_PhongBan);
            this.Controls.Add(this.RBtn_Congty);
            this.Controls.Add(this.CBB_NhanVien);
            this.Controls.Add(this.LB_PhongBan);
            this.Controls.Add(this.LB_LoaiDoThi);
            this.Controls.Add(this.LB_NhanVien);
            this.Controls.Add(this.CBB_LoaiDoThi);
            this.Controls.Add(this.BTN_ThongKe);
            this.Controls.Add(this.Btn_XuatDoThi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeCanHo";
            this.Text = "ThongKeCanHo";
            ((System.ComponentModel.ISupportInitialize)(this.C_ThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GGC_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_TuNgay;
        private System.Windows.Forms.Label LB_TuNgay;
        private System.Windows.Forms.DataVisualization.Charting.Chart C_ThongKe;
        private System.Windows.Forms.Label LB_ToiNgay;
        private System.Windows.Forms.DateTimePicker DTP_DenNgay;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl GGC_ThongKe;
        private System.Windows.Forms.Label LB_LoaiDoThi;
        private System.Windows.Forms.ComboBox CBB_LoaiDoThi;
        private Guna.UI.WinForms.GunaGradientButton Btn_XuatDoThi;
        private Guna.UI.WinForms.GunaGradientButton BTN_ThongKe;
        private System.Windows.Forms.ComboBox CBB_NhanVien;
        private System.Windows.Forms.Label LB_NhanVien;
        private System.Windows.Forms.ComboBox CBB_PhongBan;
        private System.Windows.Forms.Label LB_PhongBan;
        private System.Windows.Forms.RadioButton RBtn_NhanVien;
        private System.Windows.Forms.RadioButton RBtn_PhongBan;
        private System.Windows.Forms.RadioButton RBtn_Congty;
    }
}