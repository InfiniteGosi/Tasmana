
namespace DangNhap
{
    partial class CanHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanHo));
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_download = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_in = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.space = new System.Windows.Forms.ToolStripLabel();
            this.tS = new System.Windows.Forms.ToolStrip();
            this.pn_hienthicanho = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pn_hienthitungcanho = new System.Windows.Forms.Panel();
            this.TXB_yeucau = new System.Windows.Forms.TextBox();
            this.LB_yeucau = new System.Windows.Forms.Label();
            this.TXB_dinhky = new System.Windows.Forms.TextBox();
            this.LB_dinhky = new System.Windows.Forms.Label();
            this.TXB_phongngu = new System.Windows.Forms.TextBox();
            this.LB_phongngu = new System.Windows.Forms.Label();
            this.TXB_tinhtrang = new System.Windows.Forms.TextBox();
            this.LB_tinhtrang = new System.Windows.Forms.Label();
            this.TXB_chuho = new System.Windows.Forms.TextBox();
            this.LB_chuho = new System.Windows.Forms.Label();
            this.TXB_macanho = new System.Windows.Forms.TextBox();
            this.LB_macanho = new System.Windows.Forms.Label();
            this.PIC_canho = new System.Windows.Forms.PictureBox();
            this.BTN_chinhsua = new Guna.UI.WinForms.GunaGradientButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btn_timkiem = new Guna.UI.WinForms.GunaGradientButton();
            this.BTN_themcanho = new Guna.UI.WinForms.GunaGradientButton();
            this.tS.SuspendLayout();
            this.pn_hienthicanho.SuspendLayout();
            this.pn_hienthitungcanho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_canho)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_download
            // 
            this.btn_download.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_download.Image = ((System.Drawing.Image)(resources.GetObject("btn_download.Image")));
            this.btn_download.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(29, 24);
            this.btn_download.Text = "Download";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_in
            // 
            this.btn_in.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_in.Image = ((System.Drawing.Image)(resources.GetObject("btn_in.Image")));
            this.btn_in.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(29, 24);
            this.btn_in.Text = "Printer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // space
            // 
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(37, 24);
            this.space.Text = "       ";
            // 
            // tS
            // 
            this.tS.BackColor = System.Drawing.Color.Black;
            this.tS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.space,
            this.toolStripSeparator3,
            this.btn_in,
            this.toolStripSeparator1,
            this.btn_download,
            this.toolStripSeparator2});
            this.tS.Location = new System.Drawing.Point(0, 755);
            this.tS.Name = "tS";
            this.tS.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tS.Size = new System.Drawing.Size(1376, 27);
            this.tS.TabIndex = 13;
            this.tS.Text = "toolStrip1";
            // 
            // pn_hienthicanho
            // 
            this.pn_hienthicanho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_hienthicanho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_hienthicanho.BackgroundImage")));
            this.pn_hienthicanho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_hienthicanho.Controls.Add(this.pn_hienthitungcanho);
            this.pn_hienthicanho.GradientBottomLeft = System.Drawing.Color.Silver;
            this.pn_hienthicanho.GradientBottomRight = System.Drawing.Color.Gainsboro;
            this.pn_hienthicanho.GradientTopLeft = System.Drawing.Color.DarkGray;
            this.pn_hienthicanho.GradientTopRight = System.Drawing.Color.Silver;
            this.pn_hienthicanho.Location = new System.Drawing.Point(16, 64);
            this.pn_hienthicanho.Name = "pn_hienthicanho";
            this.pn_hienthicanho.Quality = 10;
            this.pn_hienthicanho.Size = new System.Drawing.Size(1348, 690);
            this.pn_hienthicanho.TabIndex = 11;
            // 
            // pn_hienthitungcanho
            // 
            this.pn_hienthitungcanho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_hienthitungcanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_hienthitungcanho.Controls.Add(this.TXB_yeucau);
            this.pn_hienthitungcanho.Controls.Add(this.LB_yeucau);
            this.pn_hienthitungcanho.Controls.Add(this.TXB_dinhky);
            this.pn_hienthitungcanho.Controls.Add(this.LB_dinhky);
            this.pn_hienthitungcanho.Controls.Add(this.TXB_phongngu);
            this.pn_hienthitungcanho.Controls.Add(this.LB_phongngu);
            this.pn_hienthitungcanho.Controls.Add(this.TXB_tinhtrang);
            this.pn_hienthitungcanho.Controls.Add(this.LB_tinhtrang);
            this.pn_hienthitungcanho.Controls.Add(this.TXB_chuho);
            this.pn_hienthitungcanho.Controls.Add(this.LB_chuho);
            this.pn_hienthitungcanho.Controls.Add(this.TXB_macanho);
            this.pn_hienthitungcanho.Controls.Add(this.LB_macanho);
            this.pn_hienthitungcanho.Controls.Add(this.PIC_canho);
            this.pn_hienthitungcanho.Controls.Add(this.BTN_chinhsua);
            this.pn_hienthitungcanho.Location = new System.Drawing.Point(7, 11);
            this.pn_hienthitungcanho.Name = "pn_hienthitungcanho";
            this.pn_hienthitungcanho.Size = new System.Drawing.Size(1333, 189);
            this.pn_hienthitungcanho.TabIndex = 0;
            // 
            // TXB_yeucau
            // 
            this.TXB_yeucau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXB_yeucau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_yeucau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_yeucau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_yeucau.Location = new System.Drawing.Point(821, 78);
            this.TXB_yeucau.Multiline = true;
            this.TXB_yeucau.Name = "TXB_yeucau";
            this.TXB_yeucau.Size = new System.Drawing.Size(416, 92);
            this.TXB_yeucau.TabIndex = 36;
            // 
            // LB_yeucau
            // 
            this.LB_yeucau.AutoSize = true;
            this.LB_yeucau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_yeucau.ForeColor = System.Drawing.Color.Silver;
            this.LB_yeucau.Location = new System.Drawing.Point(637, 80);
            this.LB_yeucau.Name = "LB_yeucau";
            this.LB_yeucau.Size = new System.Drawing.Size(175, 19);
            this.LB_yeucau.TabIndex = 35;
            this.LB_yeucau.Text = "Dịch vụ yêu cầu hiện tại:";
            // 
            // TXB_dinhky
            // 
            this.TXB_dinhky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXB_dinhky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_dinhky.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_dinhky.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_dinhky.Location = new System.Drawing.Point(821, 13);
            this.TXB_dinhky.Multiline = true;
            this.TXB_dinhky.Name = "TXB_dinhky";
            this.TXB_dinhky.Size = new System.Drawing.Size(416, 43);
            this.TXB_dinhky.TabIndex = 34;
            // 
            // LB_dinhky
            // 
            this.LB_dinhky.AutoSize = true;
            this.LB_dinhky.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_dinhky.ForeColor = System.Drawing.Color.Silver;
            this.LB_dinhky.Location = new System.Drawing.Point(637, 14);
            this.LB_dinhky.Name = "LB_dinhky";
            this.LB_dinhky.Size = new System.Drawing.Size(120, 19);
            this.LB_dinhky.TabIndex = 33;
            this.LB_dinhky.Text = "Dịch vụ định kỳ:";
            // 
            // TXB_phongngu
            // 
            this.TXB_phongngu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXB_phongngu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_phongngu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_phongngu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_phongngu.Location = new System.Drawing.Point(546, 12);
            this.TXB_phongngu.Name = "TXB_phongngu";
            this.TXB_phongngu.Size = new System.Drawing.Size(47, 27);
            this.TXB_phongngu.TabIndex = 32;
            // 
            // LB_phongngu
            // 
            this.LB_phongngu.AutoSize = true;
            this.LB_phongngu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_phongngu.ForeColor = System.Drawing.Color.Silver;
            this.LB_phongngu.Location = new System.Drawing.Point(449, 15);
            this.LB_phongngu.Name = "LB_phongngu";
            this.LB_phongngu.Size = new System.Drawing.Size(85, 19);
            this.LB_phongngu.TabIndex = 31;
            this.LB_phongngu.Text = "Phòng ngủ:";
            // 
            // TXB_tinhtrang
            // 
            this.TXB_tinhtrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXB_tinhtrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_tinhtrang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_tinhtrang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_tinhtrang.Location = new System.Drawing.Point(310, 142);
            this.TXB_tinhtrang.Name = "TXB_tinhtrang";
            this.TXB_tinhtrang.Size = new System.Drawing.Size(283, 27);
            this.TXB_tinhtrang.TabIndex = 24;
            // 
            // LB_tinhtrang
            // 
            this.LB_tinhtrang.AutoSize = true;
            this.LB_tinhtrang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_tinhtrang.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_tinhtrang.Location = new System.Drawing.Point(197, 145);
            this.LB_tinhtrang.Name = "LB_tinhtrang";
            this.LB_tinhtrang.Size = new System.Drawing.Size(82, 19);
            this.LB_tinhtrang.TabIndex = 23;
            this.LB_tinhtrang.Text = "Tình trạng:";
            // 
            // TXB_chuho
            // 
            this.TXB_chuho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXB_chuho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_chuho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_chuho.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_chuho.Location = new System.Drawing.Point(310, 77);
            this.TXB_chuho.Name = "TXB_chuho";
            this.TXB_chuho.Size = new System.Drawing.Size(283, 27);
            this.TXB_chuho.TabIndex = 22;
            // 
            // LB_chuho
            // 
            this.LB_chuho.AutoSize = true;
            this.LB_chuho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_chuho.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_chuho.Location = new System.Drawing.Point(197, 80);
            this.LB_chuho.Name = "LB_chuho";
            this.LB_chuho.Size = new System.Drawing.Size(62, 19);
            this.LB_chuho.TabIndex = 21;
            this.LB_chuho.Text = "Chủ hộ:";
            // 
            // TXB_macanho
            // 
            this.TXB_macanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXB_macanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_macanho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_macanho.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_macanho.Location = new System.Drawing.Point(310, 12);
            this.TXB_macanho.Name = "TXB_macanho";
            this.TXB_macanho.Size = new System.Drawing.Size(123, 27);
            this.TXB_macanho.TabIndex = 18;
            // 
            // LB_macanho
            // 
            this.LB_macanho.AutoSize = true;
            this.LB_macanho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_macanho.ForeColor = System.Drawing.Color.Gainsboro;
            this.LB_macanho.Location = new System.Drawing.Point(197, 15);
            this.LB_macanho.Name = "LB_macanho";
            this.LB_macanho.Size = new System.Drawing.Size(84, 19);
            this.LB_macanho.TabIndex = 17;
            this.LB_macanho.Text = "Mã căn hộ:";
            // 
            // PIC_canho
            // 
            this.PIC_canho.Image = ((System.Drawing.Image)(resources.GetObject("PIC_canho.Image")));
            this.PIC_canho.Location = new System.Drawing.Point(15, 18);
            this.PIC_canho.Name = "PIC_canho";
            this.PIC_canho.Size = new System.Drawing.Size(150, 150);
            this.PIC_canho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_canho.TabIndex = 16;
            this.PIC_canho.TabStop = false;
            // 
            // BTN_chinhsua
            // 
            this.BTN_chinhsua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_chinhsua.Animated = true;
            this.BTN_chinhsua.AnimationHoverSpeed = 1F;
            this.BTN_chinhsua.AnimationSpeed = 0.03F;
            this.BTN_chinhsua.BackColor = System.Drawing.Color.Transparent;
            this.BTN_chinhsua.BaseColor1 = System.Drawing.Color.White;
            this.BTN_chinhsua.BaseColor2 = System.Drawing.Color.Silver;
            this.BTN_chinhsua.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_chinhsua.BorderSize = 2;
            this.BTN_chinhsua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_chinhsua.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_chinhsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_chinhsua.ForeColor = System.Drawing.Color.Black;
            this.BTN_chinhsua.Image = ((System.Drawing.Image)(resources.GetObject("BTN_chinhsua.Image")));
            this.BTN_chinhsua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_chinhsua.ImageSize = new System.Drawing.Size(13, 13);
            this.BTN_chinhsua.Location = new System.Drawing.Point(1294, 147);
            this.BTN_chinhsua.Name = "BTN_chinhsua";
            this.BTN_chinhsua.OnHoverBaseColor1 = System.Drawing.Color.Cyan;
            this.BTN_chinhsua.OnHoverBaseColor2 = System.Drawing.Color.Blue;
            this.BTN_chinhsua.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_chinhsua.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_chinhsua.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("BTN_chinhsua.OnHoverImage")));
            this.BTN_chinhsua.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_chinhsua.Size = new System.Drawing.Size(27, 27);
            this.BTN_chinhsua.TabIndex = 15;
            this.BTN_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "All";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Text = "All";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(271, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.Text = "All";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Animated = true;
            this.btn_timkiem.AnimationHoverSpeed = 1F;
            this.btn_timkiem.AnimationSpeed = 0.03F;
            this.btn_timkiem.BackColor = System.Drawing.Color.Transparent;
            this.btn_timkiem.BaseColor1 = System.Drawing.Color.White;
            this.btn_timkiem.BaseColor2 = System.Drawing.Color.Silver;
            this.btn_timkiem.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_timkiem.BorderSize = 2;
            this.btn_timkiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_timkiem.FocusedColor = System.Drawing.Color.Empty;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_timkiem.ImageSize = new System.Drawing.Size(13, 13);
            this.btn_timkiem.Location = new System.Drawing.Point(409, 21);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_timkiem.OnHoverBaseColor2 = System.Drawing.Color.Gray;
            this.btn_timkiem.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_timkiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_timkiem.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.OnHoverImage")));
            this.btn_timkiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_timkiem.Size = new System.Drawing.Size(46, 27);
            this.btn_timkiem.TabIndex = 18;
            // 
            // BTN_themcanho
            // 
            this.BTN_themcanho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_themcanho.Animated = true;
            this.BTN_themcanho.AnimationHoverSpeed = 1F;
            this.BTN_themcanho.AnimationSpeed = 0.03F;
            this.BTN_themcanho.BackColor = System.Drawing.Color.Transparent;
            this.BTN_themcanho.BaseColor1 = System.Drawing.Color.White;
            this.BTN_themcanho.BaseColor2 = System.Drawing.Color.Silver;
            this.BTN_themcanho.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_themcanho.BorderSize = 2;
            this.BTN_themcanho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_themcanho.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_themcanho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_themcanho.ForeColor = System.Drawing.Color.Black;
            this.BTN_themcanho.Image = ((System.Drawing.Image)(resources.GetObject("BTN_themcanho.Image")));
            this.BTN_themcanho.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_themcanho.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_themcanho.Location = new System.Drawing.Point(1316, 21);
            this.BTN_themcanho.Name = "BTN_themcanho";
            this.BTN_themcanho.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.BTN_themcanho.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTN_themcanho.OnHoverBorderColor = System.Drawing.Color.White;
            this.BTN_themcanho.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_themcanho.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("BTN_themcanho.OnHoverImage")));
            this.BTN_themcanho.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_themcanho.Size = new System.Drawing.Size(47, 27);
            this.BTN_themcanho.TabIndex = 19;
            // 
            // CanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1376, 782);
            this.Controls.Add(this.BTN_themcanho);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tS);
            this.Controls.Add(this.pn_hienthicanho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CanHo";
            this.Text = "CanHo";
            this.tS.ResumeLayout(false);
            this.tS.PerformLayout();
            this.pn_hienthicanho.ResumeLayout(false);
            this.pn_hienthitungcanho.ResumeLayout(false);
            this.pn_hienthitungcanho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_canho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_download;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_in;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel space;
        private System.Windows.Forms.ToolStrip tS;
        private Bunifu.Framework.UI.BunifuGradientPanel pn_hienthicanho;
        private Guna.UI.WinForms.GunaGradientButton BTN_chinhsua;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private Guna.UI.WinForms.GunaGradientButton btn_timkiem;
        private System.Windows.Forms.Panel pn_hienthitungcanho;
        private System.Windows.Forms.PictureBox PIC_canho;
        private System.Windows.Forms.TextBox TXB_macanho;
        private System.Windows.Forms.Label LB_macanho;
        private System.Windows.Forms.TextBox TXB_chuho;
        private System.Windows.Forms.Label LB_chuho;
        private System.Windows.Forms.TextBox TXB_tinhtrang;
        private System.Windows.Forms.Label LB_tinhtrang;
        private System.Windows.Forms.TextBox TXB_phongngu;
        private System.Windows.Forms.Label LB_phongngu;
        private System.Windows.Forms.TextBox TXB_dinhky;
        private System.Windows.Forms.Label LB_dinhky;
        private System.Windows.Forms.TextBox TXB_yeucau;
        private System.Windows.Forms.Label LB_yeucau;
        private Guna.UI.WinForms.GunaGradientButton BTN_themcanho;
    }
}