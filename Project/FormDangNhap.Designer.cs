
namespace Project
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.TB_MatKhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_DangNhap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.P_NgonNgu = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VB_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.TB_TaiKhoan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_NgonNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_MatKhau
            // 
            this.TB_MatKhau.Location = new System.Drawing.Point(116, 185);
            this.TB_MatKhau.Name = "TB_MatKhau";
            this.TB_MatKhau.Size = new System.Drawing.Size(245, 22);
            this.TB_MatKhau.TabIndex = 0;
            this.TB_MatKhau.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.BT_DangNhap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.P_NgonNgu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VB_HienMatKhau);
            this.panel1.Controls.Add(this.TB_TaiKhoan);
            this.panel1.Controls.Add(this.TB_MatKhau);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 352);
            this.panel1.TabIndex = 1;
            // 
            // BT_DangNhap
            // 
            this.BT_DangNhap.BackColor = System.Drawing.Color.Black;
            this.BT_DangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DangNhap.ForeColor = System.Drawing.SystemColors.Window;
            this.BT_DangNhap.Location = new System.Drawing.Point(119, 254);
            this.BT_DangNhap.Name = "BT_DangNhap";
            this.BT_DangNhap.Size = new System.Drawing.Size(242, 54);
            this.BT_DangNhap.TabIndex = 11;
            this.BT_DangNhap.Text = "Đăng Nhập";
            this.BT_DangNhap.UseVisualStyleBackColor = false;
            this.BT_DangNhap.Click += new System.EventHandler(this.BT_DangNhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(267, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quên mật khẩu";
            // 
            // P_NgonNgu
            // 
            this.P_NgonNgu.Image = ((System.Drawing.Image)(resources.GetObject("P_NgonNgu.Image")));
            this.P_NgonNgu.Location = new System.Drawing.Point(3, 327);
            this.P_NgonNgu.Name = "P_NgonNgu";
            this.P_NgonNgu.Size = new System.Drawing.Size(25, 22);
            this.P_NgonNgu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P_NgonNgu.TabIndex = 9;
            this.P_NgonNgu.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(117, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "TasMana Ver.0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(119, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(144, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(144, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã người dùng";
            // 
            // VB_HienMatKhau
            // 
            this.VB_HienMatKhau.AutoSize = true;
            this.VB_HienMatKhau.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VB_HienMatKhau.ForeColor = System.Drawing.Color.DimGray;
            this.VB_HienMatKhau.Location = new System.Drawing.Point(116, 213);
            this.VB_HienMatKhau.Name = "VB_HienMatKhau";
            this.VB_HienMatKhau.Size = new System.Drawing.Size(105, 19);
            this.VB_HienMatKhau.TabIndex = 3;
            this.VB_HienMatKhau.Text = "Hiện mật khẩu";
            this.VB_HienMatKhau.UseVisualStyleBackColor = true;
            this.VB_HienMatKhau.CheckedChanged += new System.EventHandler(this.VB_HienMatKhau_CheckedChanged);
            // 
            // TB_TaiKhoan
            // 
            this.TB_TaiKhoan.Location = new System.Drawing.Point(116, 125);
            this.TB_TaiKhoan.Name = "TB_TaiKhoan";
            this.TB_TaiKhoan.Size = new System.Drawing.Size(245, 22);
            this.TB_TaiKhoan.TabIndex = 1;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(492, 376);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_NgonNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TB_MatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox VB_HienMatKhau;
        private System.Windows.Forms.TextBox TB_TaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox P_NgonNgu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_DangNhap;
    }
}

