
namespace DangNhap
{
    partial class CuDan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuDan));
            this.TM_nhanvien = new System.Windows.Forms.Timer(this.components);
            this.BTN_themcudan = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_in = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_PDF = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_excel = new Guna.UI.WinForms.GunaGradientButton();
            this.GGC_cudan = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.CBB_choice = new System.Windows.Forms.ComboBox();
            this.LB_loai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GGC_cudan)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_themcudan
            // 
            this.BTN_themcudan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_themcudan.Animated = true;
            this.BTN_themcudan.AnimationHoverSpeed = 1F;
            this.BTN_themcudan.AnimationSpeed = 0.03F;
            this.BTN_themcudan.BackColor = System.Drawing.Color.Transparent;
            this.BTN_themcudan.BaseColor1 = System.Drawing.Color.DarkGreen;
            this.BTN_themcudan.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTN_themcudan.BorderColor = System.Drawing.Color.White;
            this.BTN_themcudan.BorderSize = 1;
            this.BTN_themcudan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_themcudan.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_themcudan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_themcudan.ForeColor = System.Drawing.Color.White;
            this.BTN_themcudan.Image = ((System.Drawing.Image)(resources.GetObject("BTN_themcudan.Image")));
            this.BTN_themcudan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_themcudan.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_themcudan.Location = new System.Drawing.Point(1252, 27);
            this.BTN_themcudan.Name = "BTN_themcudan";
            this.BTN_themcudan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTN_themcudan.OnHoverBaseColor2 = System.Drawing.Color.DarkGreen;
            this.BTN_themcudan.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_themcudan.OnHoverForeColor = System.Drawing.Color.Black;
            this.BTN_themcudan.OnHoverImage = null;
            this.BTN_themcudan.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_themcudan.Size = new System.Drawing.Size(40, 40);
            this.BTN_themcudan.TabIndex = 107;
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
            this.BTN_in.ImageSize = new System.Drawing.Size(15, 15);
            this.BTN_in.Location = new System.Drawing.Point(238, 690);
            this.BTN_in.Name = "BTN_in";
            this.BTN_in.OnHoverBaseColor1 = System.Drawing.Color.DimGray;
            this.BTN_in.OnHoverBaseColor2 = System.Drawing.Color.Silver;
            this.BTN_in.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTN_in.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_in.OnHoverImage = null;
            this.BTN_in.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_in.Size = new System.Drawing.Size(102, 37);
            this.BTN_in.TabIndex = 178;
            this.BTN_in.Text = "In";
            this.BTN_in.TextOffsetX = 3;
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
            this.BTN_PDF.ImageSize = new System.Drawing.Size(15, 15);
            this.BTN_PDF.Location = new System.Drawing.Point(130, 690);
            this.BTN_PDF.Name = "BTN_PDF";
            this.BTN_PDF.OnHoverBaseColor1 = System.Drawing.Color.Coral;
            this.BTN_PDF.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(131)))), ((int)(((byte)(18)))));
            this.BTN_PDF.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTN_PDF.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_PDF.OnHoverImage = null;
            this.BTN_PDF.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_PDF.Size = new System.Drawing.Size(102, 37);
            this.BTN_PDF.TabIndex = 177;
            this.BTN_PDF.Text = "PDF";
            this.BTN_PDF.TextOffsetX = 3;
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
            this.BTN_excel.ImageSize = new System.Drawing.Size(15, 15);
            this.BTN_excel.Location = new System.Drawing.Point(22, 690);
            this.BTN_excel.Name = "BTN_excel";
            this.BTN_excel.OnHoverBaseColor1 = System.Drawing.Color.Green;
            this.BTN_excel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.BTN_excel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTN_excel.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_excel.OnHoverImage = null;
            this.BTN_excel.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_excel.Size = new System.Drawing.Size(102, 37);
            this.BTN_excel.TabIndex = 176;
            this.BTN_excel.Text = "Excel";
            this.BTN_excel.TextOffsetX = 3;
            // 
            // GGC_cudan
            // 
            this.GGC_cudan.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.GGC_cudan.BackColor = System.Drawing.SystemColors.Window;
            this.GGC_cudan.Location = new System.Drawing.Point(100, 82);
            this.GGC_cudan.Name = "GGC_cudan";
            this.GGC_cudan.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.GGC_cudan.Size = new System.Drawing.Size(1211, 560);
            this.GGC_cudan.TabIndex = 179;
            this.GGC_cudan.Text = "gridGroupingControl1";
            this.GGC_cudan.UseRightToLeftCompatibleTextBox = true;
            this.GGC_cudan.VersionInfo = "25.1462.39";
            // 
            // CBB_choice
            // 
            this.CBB_choice.FormattingEnabled = true;
            this.CBB_choice.Items.AddRange(new object[] {
            "Chủ hộ",
            "Người được ủy quyền của chủ hộ",
            "Nhân viên của chủ hộ / Khách thuê / Khách vãng lai",
            "Khách thuê khu thương mại"});
            this.CBB_choice.Location = new System.Drawing.Point(159, 43);
            this.CBB_choice.Name = "CBB_choice";
            this.CBB_choice.Size = new System.Drawing.Size(278, 24);
            this.CBB_choice.TabIndex = 180;
            this.CBB_choice.SelectedIndexChanged += new System.EventHandler(this.CBB_choice_SelectedIndexChanged);
            // 
            // LB_loai
            // 
            this.LB_loai.AutoSize = true;
            this.LB_loai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LB_loai.ForeColor = System.Drawing.Color.White;
            this.LB_loai.Location = new System.Drawing.Point(169, 9);
            this.LB_loai.Name = "LB_loai";
            this.LB_loai.Size = new System.Drawing.Size(106, 16);
            this.LB_loai.TabIndex = 181;
            this.LB_loai.Text = "Chọn loại cư dân";
            // 
            // CuDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1376, 782);
            this.Controls.Add(this.LB_loai);
            this.Controls.Add(this.CBB_choice);
            this.Controls.Add(this.GGC_cudan);
            this.Controls.Add(this.BTN_in);
            this.Controls.Add(this.BTN_PDF);
            this.Controls.Add(this.BTN_excel);
            this.Controls.Add(this.BTN_themcudan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuDan";
            this.Text = "CuDan";
            this.Load += new System.EventHandler(this.CuDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GGC_cudan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TM_nhanvien;
        private Guna.UI.WinForms.GunaGradientButton BTN_themcudan;
        private Guna.UI.WinForms.GunaGradientButton BTN_in;
        private Guna.UI.WinForms.GunaGradientButton BTN_PDF;
        private Guna.UI.WinForms.GunaGradientButton BTN_excel;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl GGC_cudan;
        private System.Windows.Forms.ComboBox CBB_choice;
        private System.Windows.Forms.Label LB_loai;
    }
}