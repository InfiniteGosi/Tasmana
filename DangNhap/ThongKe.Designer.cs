
namespace DangNhap
{
    partial class ThongKe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.elipse_blue = new Guna.UI.WinForms.GunaElipse(this.components);
            this.elipse_red = new Guna.UI.WinForms.GunaElipse(this.components);
            this.elipse_green = new Guna.UI.WinForms.GunaElipse(this.components);
            this.LB_ThongKeCV = new System.Windows.Forms.Label();
            this.LB_TuNgay = new System.Windows.Forms.Label();
            this.LB_ToiNgay = new System.Windows.Forms.Label();
            this.RBtn_PhongBan = new System.Windows.Forms.RadioButton();
            this.RBtn_NhanVien = new System.Windows.Forms.RadioButton();
            this.CBB_PhongBan = new System.Windows.Forms.ComboBox();
            this.CBB_NhanVien = new System.Windows.Forms.ComboBox();
            this.LB_PhongBan = new System.Windows.Forms.Label();
            this.LB_NhanVien = new System.Windows.Forms.Label();
            this.BTN_ThongKe = new Guna.UI.WinForms.GunaGradientButton();
            this.Btn_XuatDoThi = new Guna.UI.WinForms.GunaGradientButton();
            this.CBB_LoaiDoThi = new System.Windows.Forms.ComboBox();
            this.LB_LoaiDoThi = new System.Windows.Forms.Label();
            this.LB_ThongBao1 = new System.Windows.Forms.Label();
            this.RBtn_Congty = new System.Windows.Forms.RadioButton();
            this.GGC_ThongKe = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.DTP_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.DTP_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.C_ThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GGC_ThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_blue
            // 
            this.elipse_blue.Radius = 10;
            this.elipse_blue.TargetControl = this;
            // 
            // elipse_red
            // 
            this.elipse_red.Radius = 10;
            this.elipse_red.TargetControl = this;
            // 
            // elipse_green
            // 
            this.elipse_green.Radius = 10;
            this.elipse_green.TargetControl = this;
            // 
            // LB_ThongKeCV
            // 
            this.LB_ThongKeCV.AutoSize = true;
            this.LB_ThongKeCV.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ThongKeCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LB_ThongKeCV.Location = new System.Drawing.Point(12, 9);
            this.LB_ThongKeCV.Name = "LB_ThongKeCV";
            this.LB_ThongKeCV.Size = new System.Drawing.Size(333, 32);
            this.LB_ThongKeCV.TabIndex = 207;
            this.LB_ThongKeCV.Text = "THỐNG KÊ CÔNG VIỆC";
            // 
            // LB_TuNgay
            // 
            this.LB_TuNgay.AutoSize = true;
            this.LB_TuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TuNgay.ForeColor = System.Drawing.Color.White;
            this.LB_TuNgay.Location = new System.Drawing.Point(17, 72);
            this.LB_TuNgay.Name = "LB_TuNgay";
            this.LB_TuNgay.Size = new System.Drawing.Size(74, 22);
            this.LB_TuNgay.TabIndex = 208;
            this.LB_TuNgay.Text = "Từ ngày";
            // 
            // LB_ToiNgay
            // 
            this.LB_ToiNgay.AutoSize = true;
            this.LB_ToiNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ToiNgay.ForeColor = System.Drawing.Color.White;
            this.LB_ToiNgay.Location = new System.Drawing.Point(391, 73);
            this.LB_ToiNgay.Name = "LB_ToiNgay";
            this.LB_ToiNgay.Size = new System.Drawing.Size(80, 22);
            this.LB_ToiNgay.TabIndex = 209;
            this.LB_ToiNgay.Text = "Tới ngày";
            // 
            // RBtn_PhongBan
            // 
            this.RBtn_PhongBan.AutoSize = true;
            this.RBtn_PhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_PhongBan.ForeColor = System.Drawing.Color.White;
            this.RBtn_PhongBan.Location = new System.Drawing.Point(175, 133);
            this.RBtn_PhongBan.Name = "RBtn_PhongBan";
            this.RBtn_PhongBan.Size = new System.Drawing.Size(112, 26);
            this.RBtn_PhongBan.TabIndex = 210;
            this.RBtn_PhongBan.TabStop = true;
            this.RBtn_PhongBan.Text = "Phòng ban";
            this.RBtn_PhongBan.UseVisualStyleBackColor = true;
            this.RBtn_PhongBan.CheckedChanged += new System.EventHandler(this.RBtn_PhongBan_CheckedChanged);
            // 
            // RBtn_NhanVien
            // 
            this.RBtn_NhanVien.AutoSize = true;
            this.RBtn_NhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_NhanVien.ForeColor = System.Drawing.Color.White;
            this.RBtn_NhanVien.Location = new System.Drawing.Point(331, 133);
            this.RBtn_NhanVien.Name = "RBtn_NhanVien";
            this.RBtn_NhanVien.Size = new System.Drawing.Size(111, 26);
            this.RBtn_NhanVien.TabIndex = 212;
            this.RBtn_NhanVien.TabStop = true;
            this.RBtn_NhanVien.Text = "Nhân viên";
            this.RBtn_NhanVien.UseVisualStyleBackColor = true;
            this.RBtn_NhanVien.CheckedChanged += new System.EventHandler(this.RBtn_PhongBan_CheckedChanged);
            // 
            // CBB_PhongBan
            // 
            this.CBB_PhongBan.FormattingEnabled = true;
            this.CBB_PhongBan.Location = new System.Drawing.Point(602, 139);
            this.CBB_PhongBan.Name = "CBB_PhongBan";
            this.CBB_PhongBan.Size = new System.Drawing.Size(231, 24);
            this.CBB_PhongBan.TabIndex = 213;
            this.CBB_PhongBan.SelectedValueChanged += new System.EventHandler(this.CBB_PhongBan_SelectedValueChanged);
            // 
            // CBB_NhanVien
            // 
            this.CBB_NhanVien.FormattingEnabled = true;
            this.CBB_NhanVien.Location = new System.Drawing.Point(1024, 139);
            this.CBB_NhanVien.Name = "CBB_NhanVien";
            this.CBB_NhanVien.Size = new System.Drawing.Size(257, 24);
            this.CBB_NhanVien.TabIndex = 215;
            // 
            // LB_PhongBan
            // 
            this.LB_PhongBan.AutoSize = true;
            this.LB_PhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PhongBan.ForeColor = System.Drawing.Color.White;
            this.LB_PhongBan.Location = new System.Drawing.Point(484, 138);
            this.LB_PhongBan.Name = "LB_PhongBan";
            this.LB_PhongBan.Size = new System.Drawing.Size(75, 22);
            this.LB_PhongBan.TabIndex = 216;
            this.LB_PhongBan.Text = "Bộ phận";
            // 
            // LB_NhanVien
            // 
            this.LB_NhanVien.AutoSize = true;
            this.LB_NhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NhanVien.ForeColor = System.Drawing.Color.White;
            this.LB_NhanVien.Location = new System.Drawing.Point(890, 141);
            this.LB_NhanVien.Name = "LB_NhanVien";
            this.LB_NhanVien.Size = new System.Drawing.Size(92, 22);
            this.LB_NhanVien.TabIndex = 217;
            this.LB_NhanVien.Text = "Nhân Viên";
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
            this.BTN_ThongKe.Location = new System.Drawing.Point(1329, 135);
            this.BTN_ThongKe.Name = "BTN_ThongKe";
            this.BTN_ThongKe.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ThongKe.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.BTN_ThongKe.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_ThongKe.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_ThongKe.OnHoverImage = null;
            this.BTN_ThongKe.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_ThongKe.Radius = 5;
            this.BTN_ThongKe.Size = new System.Drawing.Size(136, 28);
            this.BTN_ThongKe.TabIndex = 219;
            this.BTN_ThongKe.Text = "Thống kê";
            this.BTN_ThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_ThongKe.Click += new System.EventHandler(this.BTN_ThongKe_Click);
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
            this.Btn_XuatDoThi.Location = new System.Drawing.Point(1329, 68);
            this.Btn_XuatDoThi.Name = "Btn_XuatDoThi";
            this.Btn_XuatDoThi.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_XuatDoThi.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.Btn_XuatDoThi.OnHoverBorderColor = System.Drawing.Color.White;
            this.Btn_XuatDoThi.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_XuatDoThi.OnHoverImage = null;
            this.Btn_XuatDoThi.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_XuatDoThi.Radius = 5;
            this.Btn_XuatDoThi.Size = new System.Drawing.Size(129, 26);
            this.Btn_XuatDoThi.TabIndex = 220;
            this.Btn_XuatDoThi.Text = "Xuất đồ thị";
            this.Btn_XuatDoThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_XuatDoThi.Click += new System.EventHandler(this.Btn_XuatDoThi_Click);
            // 
            // CBB_LoaiDoThi
            // 
            this.CBB_LoaiDoThi.FormattingEnabled = true;
            this.CBB_LoaiDoThi.Items.AddRange(new object[] {
            "Pie Chart",
            "Bar Chart",
            "Line Chart"});
            this.CBB_LoaiDoThi.Location = new System.Drawing.Point(1024, 70);
            this.CBB_LoaiDoThi.Name = "CBB_LoaiDoThi";
            this.CBB_LoaiDoThi.Size = new System.Drawing.Size(263, 24);
            this.CBB_LoaiDoThi.TabIndex = 221;
            // 
            // LB_LoaiDoThi
            // 
            this.LB_LoaiDoThi.AutoSize = true;
            this.LB_LoaiDoThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LoaiDoThi.ForeColor = System.Drawing.Color.White;
            this.LB_LoaiDoThi.Location = new System.Drawing.Point(890, 72);
            this.LB_LoaiDoThi.Name = "LB_LoaiDoThi";
            this.LB_LoaiDoThi.Size = new System.Drawing.Size(96, 22);
            this.LB_LoaiDoThi.TabIndex = 222;
            this.LB_LoaiDoThi.Text = "Loại đồ thị";
            // 
            // LB_ThongBao1
            // 
            this.LB_ThongBao1.AutoSize = true;
            this.LB_ThongBao1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ThongBao1.ForeColor = System.Drawing.Color.White;
            this.LB_ThongBao1.Location = new System.Drawing.Point(21, 779);
            this.LB_ThongBao1.Name = "LB_ThongBao1";
            this.LB_ThongBao1.Size = new System.Drawing.Size(90, 22);
            this.LB_ThongBao1.TabIndex = 223;
            this.LB_ThongBao1.Text = "Thông tin:";
            this.LB_ThongBao1.Visible = false;
            // 
            // RBtn_Congty
            // 
            this.RBtn_Congty.AutoSize = true;
            this.RBtn_Congty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtn_Congty.ForeColor = System.Drawing.Color.White;
            this.RBtn_Congty.Location = new System.Drawing.Point(12, 133);
            this.RBtn_Congty.Name = "RBtn_Congty";
            this.RBtn_Congty.Size = new System.Drawing.Size(131, 26);
            this.RBtn_Congty.TabIndex = 224;
            this.RBtn_Congty.TabStop = true;
            this.RBtn_Congty.Text = "Toàn công ty";
            this.RBtn_Congty.UseVisualStyleBackColor = true;
            this.RBtn_Congty.CheckedChanged += new System.EventHandler(this.RBtn_PhongBan_CheckedChanged);
            // 
            // GGC_ThongKe
            // 
            this.GGC_ThongKe.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.GGC_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGC_ThongKe.BackColor = System.Drawing.SystemColors.Window;
            this.GGC_ThongKe.Location = new System.Drawing.Point(52, 189);
            this.GGC_ThongKe.Name = "GGC_ThongKe";
            this.GGC_ThongKe.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.GGC_ThongKe.Size = new System.Drawing.Size(1585, 574);
            this.GGC_ThongKe.TabIndex = 225;
            this.GGC_ThongKe.Text = "gridGroupingControl1";
            this.GGC_ThongKe.UseRightToLeftCompatibleTextBox = true;
            this.GGC_ThongKe.VersionInfo = "25.1462.39";
            // 
            // DTP_TuNgay
            // 
            this.DTP_TuNgay.CustomFormat = "yyyy-MM-dd HH:MM";
            this.DTP_TuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_TuNgay.Location = new System.Drawing.Point(97, 73);
            this.DTP_TuNgay.Name = "DTP_TuNgay";
            this.DTP_TuNgay.Size = new System.Drawing.Size(248, 30);
            this.DTP_TuNgay.TabIndex = 226;
            // 
            // DTP_DenNgay
            // 
            this.DTP_DenNgay.CustomFormat = "yyyy-MM-dd HH:MM";
            this.DTP_DenNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DenNgay.Location = new System.Drawing.Point(504, 73);
            this.DTP_DenNgay.Name = "DTP_DenNgay";
            this.DTP_DenNgay.Size = new System.Drawing.Size(248, 30);
            this.DTP_DenNgay.TabIndex = 227;
            // 
            // C_ThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.C_ThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.C_ThongKe.Legends.Add(legend1);
            this.C_ThongKe.Location = new System.Drawing.Point(21, 189);
            this.C_ThongKe.Name = "C_ThongKe";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.C_ThongKe.Series.Add(series1);
            this.C_ThongKe.Size = new System.Drawing.Size(1585, 574);
            this.C_ThongKe.TabIndex = 228;
            this.C_ThongKe.Text = "chart1";
            this.C_ThongKe.Visible = false;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1634, 852);
            this.Controls.Add(this.C_ThongKe);
            this.Controls.Add(this.DTP_DenNgay);
            this.Controls.Add(this.DTP_TuNgay);
            this.Controls.Add(this.GGC_ThongKe);
            this.Controls.Add(this.RBtn_Congty);
            this.Controls.Add(this.LB_ThongBao1);
            this.Controls.Add(this.LB_LoaiDoThi);
            this.Controls.Add(this.CBB_LoaiDoThi);
            this.Controls.Add(this.Btn_XuatDoThi);
            this.Controls.Add(this.BTN_ThongKe);
            this.Controls.Add(this.LB_NhanVien);
            this.Controls.Add(this.LB_PhongBan);
            this.Controls.Add(this.CBB_NhanVien);
            this.Controls.Add(this.CBB_PhongBan);
            this.Controls.Add(this.RBtn_NhanVien);
            this.Controls.Add(this.RBtn_PhongBan);
            this.Controls.Add(this.LB_ToiNgay);
            this.Controls.Add(this.LB_TuNgay);
            this.Controls.Add(this.LB_ThongKeCV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GGC_ThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse elipse_blue;
        private Guna.UI.WinForms.GunaElipse elipse_red;
        private Guna.UI.WinForms.GunaElipse elipse_green;
        private System.Windows.Forms.Label LB_ThongKeCV;
        private System.Windows.Forms.RadioButton RBtn_PhongBan;
        private System.Windows.Forms.Label LB_ToiNgay;
        private System.Windows.Forms.Label LB_TuNgay;
        private System.Windows.Forms.RadioButton RBtn_NhanVien;
        private System.Windows.Forms.ComboBox CBB_NhanVien;
        private System.Windows.Forms.ComboBox CBB_PhongBan;
        private System.Windows.Forms.Label LB_NhanVien;
        private System.Windows.Forms.Label LB_PhongBan;
        private Guna.UI.WinForms.GunaGradientButton BTN_ThongKe;
        private Guna.UI.WinForms.GunaGradientButton Btn_XuatDoThi;
        private System.Windows.Forms.Label LB_ThongBao1;
        private System.Windows.Forms.Label LB_LoaiDoThi;
        private System.Windows.Forms.ComboBox CBB_LoaiDoThi;
        private System.Windows.Forms.RadioButton RBtn_Congty;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl GGC_ThongKe;
        private System.Windows.Forms.DateTimePicker DTP_DenNgay;
        private System.Windows.Forms.DateTimePicker DTP_TuNgay;
        private System.Windows.Forms.DataVisualization.Charting.Chart C_ThongKe;
    }
}