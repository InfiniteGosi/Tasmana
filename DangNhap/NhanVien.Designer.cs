
namespace DangNhap
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.BTN_themnhanvien = new Guna.UI.WinForms.GunaGradientButton();
            this.TXB_sotrang = new System.Windows.Forms.TextBox();
            this.BTN_trangtruoc = new System.Windows.Forms.Button();
            this.BTN_trangsau = new System.Windows.Forms.Button();
            this.BTN_in = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_PDF = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_excel = new Guna.UI.WinForms.GunaGradientButton();
            this.GGC_danhsachnv = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GGC_danhsachnv)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_themnhanvien
            // 
            this.BTN_themnhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_themnhanvien.Animated = true;
            this.BTN_themnhanvien.AnimationHoverSpeed = 1F;
            this.BTN_themnhanvien.AnimationSpeed = 0.03F;
            this.BTN_themnhanvien.BackColor = System.Drawing.Color.Transparent;
            this.BTN_themnhanvien.BaseColor1 = System.Drawing.Color.DarkGreen;
            this.BTN_themnhanvien.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTN_themnhanvien.BorderColor = System.Drawing.Color.White;
            this.BTN_themnhanvien.BorderSize = 1;
            this.BTN_themnhanvien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_themnhanvien.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_themnhanvien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_themnhanvien.ForeColor = System.Drawing.Color.White;
            this.BTN_themnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("BTN_themnhanvien.Image")));
            this.BTN_themnhanvien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_themnhanvien.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_themnhanvien.Location = new System.Drawing.Point(1273, 57);
            this.BTN_themnhanvien.Name = "BTN_themnhanvien";
            this.BTN_themnhanvien.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTN_themnhanvien.OnHoverBaseColor2 = System.Drawing.Color.DarkGreen;
            this.BTN_themnhanvien.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_themnhanvien.OnHoverForeColor = System.Drawing.Color.Black;
            this.BTN_themnhanvien.OnHoverImage = null;
            this.BTN_themnhanvien.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_themnhanvien.Size = new System.Drawing.Size(40, 40);
            this.BTN_themnhanvien.TabIndex = 94;
            this.BTN_themnhanvien.Click += new System.EventHandler(this.BTN_themnhanvien_Click);
            // 
            // TXB_sotrang
            // 
            this.TXB_sotrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TXB_sotrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TXB_sotrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_sotrang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_sotrang.ForeColor = System.Drawing.Color.White;
            this.TXB_sotrang.Location = new System.Drawing.Point(1246, 527);
            this.TXB_sotrang.Multiline = true;
            this.TXB_sotrang.Name = "TXB_sotrang";
            this.TXB_sotrang.Size = new System.Drawing.Size(30, 30);
            this.TXB_sotrang.TabIndex = 104;
            this.TXB_sotrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_trangtruoc
            // 
            this.BTN_trangtruoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_trangtruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_trangtruoc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_trangtruoc.ForeColor = System.Drawing.Color.White;
            this.BTN_trangtruoc.Location = new System.Drawing.Point(1209, 527);
            this.BTN_trangtruoc.Name = "BTN_trangtruoc";
            this.BTN_trangtruoc.Size = new System.Drawing.Size(30, 30);
            this.BTN_trangtruoc.TabIndex = 103;
            this.BTN_trangtruoc.Text = "<";
            this.BTN_trangtruoc.UseVisualStyleBackColor = true;
            // 
            // BTN_trangsau
            // 
            this.BTN_trangsau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_trangsau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_trangsau.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_trangsau.ForeColor = System.Drawing.Color.White;
            this.BTN_trangsau.Location = new System.Drawing.Point(1283, 527);
            this.BTN_trangsau.Name = "BTN_trangsau";
            this.BTN_trangsau.Size = new System.Drawing.Size(30, 30);
            this.BTN_trangsau.TabIndex = 102;
            this.BTN_trangsau.Text = ">";
            this.BTN_trangsau.UseVisualStyleBackColor = true;
            // 
            // BTN_in
            // 
            this.BTN_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_in.AnimationHoverSpeed = 0.07F;
            this.BTN_in.AnimationSpeed = 0.03F;
            this.BTN_in.BaseColor1 = System.Drawing.Color.Silver;
            this.BTN_in.BaseColor2 = System.Drawing.Color.DimGray;
            this.BTN_in.BorderColor = System.Drawing.Color.White;
            this.BTN_in.BorderSize = 1;
            this.BTN_in.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_in.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_in.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_in.ForeColor = System.Drawing.Color.White;
            this.BTN_in.Image = ((System.Drawing.Image)(resources.GetObject("BTN_in.Image")));
            this.BTN_in.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_in.Location = new System.Drawing.Point(291, 527);
            this.BTN_in.Name = "BTN_in";
            this.BTN_in.OnHoverBaseColor1 = System.Drawing.Color.DimGray;
            this.BTN_in.OnHoverBaseColor2 = System.Drawing.Color.Silver;
            this.BTN_in.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_in.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_in.OnHoverImage = null;
            this.BTN_in.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_in.Size = new System.Drawing.Size(89, 48);
            this.BTN_in.TabIndex = 109;
            this.BTN_in.Text = "In";
            this.BTN_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_PDF
            // 
            this.BTN_PDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_PDF.AnimationHoverSpeed = 0.07F;
            this.BTN_PDF.AnimationSpeed = 0.03F;
            this.BTN_PDF.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(131)))), ((int)(((byte)(18)))));
            this.BTN_PDF.BaseColor2 = System.Drawing.Color.Coral;
            this.BTN_PDF.BorderColor = System.Drawing.Color.White;
            this.BTN_PDF.BorderSize = 1;
            this.BTN_PDF.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_PDF.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_PDF.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PDF.ForeColor = System.Drawing.Color.White;
            this.BTN_PDF.Image = ((System.Drawing.Image)(resources.GetObject("BTN_PDF.Image")));
            this.BTN_PDF.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_PDF.Location = new System.Drawing.Point(178, 527);
            this.BTN_PDF.Name = "BTN_PDF";
            this.BTN_PDF.OnHoverBaseColor1 = System.Drawing.Color.Coral;
            this.BTN_PDF.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(131)))), ((int)(((byte)(18)))));
            this.BTN_PDF.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_PDF.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_PDF.OnHoverImage = null;
            this.BTN_PDF.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_PDF.Size = new System.Drawing.Size(107, 48);
            this.BTN_PDF.TabIndex = 108;
            this.BTN_PDF.Text = "PDF";
            this.BTN_PDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_excel
            // 
            this.BTN_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_excel.AnimationHoverSpeed = 0.07F;
            this.BTN_excel.AnimationSpeed = 0.03F;
            this.BTN_excel.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.BTN_excel.BaseColor2 = System.Drawing.Color.Green;
            this.BTN_excel.BorderColor = System.Drawing.Color.White;
            this.BTN_excel.BorderSize = 1;
            this.BTN_excel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_excel.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_excel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_excel.ForeColor = System.Drawing.Color.White;
            this.BTN_excel.Image = ((System.Drawing.Image)(resources.GetObject("BTN_excel.Image")));
            this.BTN_excel.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_excel.Location = new System.Drawing.Point(65, 527);
            this.BTN_excel.Name = "BTN_excel";
            this.BTN_excel.OnHoverBaseColor1 = System.Drawing.Color.Green;
            this.BTN_excel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.BTN_excel.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_excel.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_excel.OnHoverImage = null;
            this.BTN_excel.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_excel.Size = new System.Drawing.Size(107, 48);
            this.BTN_excel.TabIndex = 107;
            this.BTN_excel.Text = "Excel";
            this.BTN_excel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GGC_danhsachnv
            // 
            this.GGC_danhsachnv.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.GGC_danhsachnv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGC_danhsachnv.BackColor = System.Drawing.SystemColors.Window;
            this.GGC_danhsachnv.Location = new System.Drawing.Point(28, 55);
            this.GGC_danhsachnv.Name = "GGC_danhsachnv";
            this.GGC_danhsachnv.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.GGC_danhsachnv.Size = new System.Drawing.Size(1248, 404);
            this.GGC_danhsachnv.TabIndex = 112;
            this.GGC_danhsachnv.Text = "gridGroupingControl1";
            this.GGC_danhsachnv.UseRightToLeftCompatibleTextBox = true;
            this.GGC_danhsachnv.VersionInfo = "25.1462.39";
            this.GGC_danhsachnv.TableControlCellDoubleClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventHandler(this.GGC_danhsachnv_TableControlCellDoubleClick);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Animated = true;
            this.gunaGradientButton1.AnimationHoverSpeed = 1F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.White;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Silver;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaGradientButton1.BorderSize = 2;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(405, 22);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.Gray;
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(46, 27);
            this.gunaGradientButton1.TabIndex = 98;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 22);
            this.textBox1.TabIndex = 110;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1376, 782);
            this.Controls.Add(this.GGC_danhsachnv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTN_in);
            this.Controls.Add(this.BTN_PDF);
            this.Controls.Add(this.BTN_excel);
            this.Controls.Add(this.BTN_themnhanvien);
            this.Controls.Add(this.TXB_sotrang);
            this.Controls.Add(this.BTN_trangtruoc);
            this.Controls.Add(this.BTN_trangsau);
            this.Controls.Add(this.gunaGradientButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GGC_danhsachnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientButton BTN_themnhanvien;
        private System.Windows.Forms.TextBox TXB_sotrang;
        private System.Windows.Forms.Button BTN_trangtruoc;
        private System.Windows.Forms.Button BTN_trangsau;
        private Guna.UI.WinForms.GunaGradientButton BTN_in;
        private Guna.UI.WinForms.GunaGradientButton BTN_PDF;
        private Guna.UI.WinForms.GunaGradientButton BTN_excel;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl GGC_danhsachnv;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private System.Windows.Forms.TextBox textBox1;
    }
}