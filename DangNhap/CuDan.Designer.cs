
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuDan));
            this.TM_nhanvien = new System.Windows.Forms.Timer(this.components);
            this.DGV_hienthicudan = new System.Windows.Forms.DataGridView();
            this.BTN_themcudan = new Guna.UI.WinForms.GunaGradientButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TXB_sotrang = new System.Windows.Forms.TextBox();
            this.BTN_trangtruoc = new System.Windows.Forms.Button();
            this.BTN_trangsau = new System.Windows.Forms.Button();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.BTN_in = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_PDF = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_excel = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_hienthicudan)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_hienthicudan
            // 
            this.DGV_hienthicudan.AllowUserToAddRows = false;
            this.DGV_hienthicudan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_hienthicudan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_hienthicudan.ColumnHeadersHeight = 35;
            this.DGV_hienthicudan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_hienthicudan.EnableHeadersVisualStyles = false;
            this.DGV_hienthicudan.Location = new System.Drawing.Point(65, 120);
            this.DGV_hienthicudan.Name = "DGV_hienthicudan";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_hienthicudan.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_hienthicudan.RowHeadersVisible = false;
            this.DGV_hienthicudan.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_hienthicudan.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_hienthicudan.RowTemplate.Height = 24;
            this.DGV_hienthicudan.Size = new System.Drawing.Size(1248, 401);
            this.DGV_hienthicudan.TabIndex = 117;
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
            this.BTN_themcudan.Location = new System.Drawing.Point(1273, 57);
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 116;
            this.comboBox1.Text = "All";
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
            this.TXB_sotrang.TabIndex = 115;
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
            this.BTN_trangtruoc.TabIndex = 114;
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
            this.BTN_trangsau.TabIndex = 113;
            this.BTN_trangsau.Text = ">";
            this.BTN_trangsau.UseVisualStyleBackColor = true;
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
            this.gunaGradientButton1.Location = new System.Drawing.Point(573, 67);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.Gray;
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(46, 27);
            this.gunaGradientButton1.TabIndex = 111;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.White;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(319, 67);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 27);
            this.comboBox6.TabIndex = 110;
            this.comboBox6.Text = "All";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.ForeColor = System.Drawing.Color.White;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(192, 67);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 27);
            this.comboBox5.TabIndex = 109;
            this.comboBox5.Text = "All";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.White;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(65, 67);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 27);
            this.comboBox4.TabIndex = 108;
            this.comboBox4.Text = "All";
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
            this.BTN_in.TabIndex = 120;
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
            this.BTN_PDF.TabIndex = 119;
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
            this.BTN_excel.TabIndex = 118;
            this.BTN_excel.Text = "Excel";
            this.BTN_excel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CuDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1376, 782);
            this.Controls.Add(this.BTN_in);
            this.Controls.Add(this.BTN_PDF);
            this.Controls.Add(this.BTN_excel);
            this.Controls.Add(this.DGV_hienthicudan);
            this.Controls.Add(this.BTN_themcudan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TXB_sotrang);
            this.Controls.Add(this.BTN_trangtruoc);
            this.Controls.Add(this.BTN_trangsau);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuDan";
            this.Text = "CuDan";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_hienthicudan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TM_nhanvien;
        private System.Windows.Forms.DataGridView DGV_hienthicudan;
        private Guna.UI.WinForms.GunaGradientButton BTN_themcudan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TXB_sotrang;
        private System.Windows.Forms.Button BTN_trangtruoc;
        private System.Windows.Forms.Button BTN_trangsau;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private Guna.UI.WinForms.GunaGradientButton BTN_in;
        private Guna.UI.WinForms.GunaGradientButton BTN_PDF;
        private Guna.UI.WinForms.GunaGradientButton BTN_excel;
    }
}