
namespace DangNhap
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_DangNhap = new Guna.UI.WinForms.GunaButton();
            this.pic_apm = new System.Windows.Forms.PictureBox();
            this.LB_quenpw = new System.Windows.Forms.Label();
            this.VB_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.pic_lock = new System.Windows.Forms.PictureBox();
            this.pic_mail = new System.Windows.Forms.PictureBox();
            this.TB_MatKhau = new System.Windows.Forms.TextBox();
            this.TB_TaiKhoan = new System.Windows.Forms.TextBox();
            this.LB_pw = new System.Windows.Forms.Label();
            this.LB_id = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LB_tasmana = new System.Windows.Forms.Label();
            this.BTN_close = new Guna.UI.WinForms.GunaButton();
            this.LB_error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_apm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mail)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.LB_error);
            this.panel1.Controls.Add(this.BT_DangNhap);
            this.panel1.Controls.Add(this.pic_apm);
            this.panel1.Controls.Add(this.LB_quenpw);
            this.panel1.Controls.Add(this.VB_HienMatKhau);
            this.panel1.Controls.Add(this.pic_lock);
            this.panel1.Controls.Add(this.pic_mail);
            this.panel1.Controls.Add(this.TB_MatKhau);
            this.panel1.Controls.Add(this.TB_TaiKhoan);
            this.panel1.Controls.Add(this.LB_pw);
            this.panel1.Controls.Add(this.LB_id);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LB_tasmana);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 670);
            this.panel1.TabIndex = 0;
            // 
            // BT_DangNhap
            // 
            this.BT_DangNhap.Animated = true;
            this.BT_DangNhap.AnimationHoverSpeed = 0.5F;
            this.BT_DangNhap.AnimationSpeed = 0.03F;
            this.BT_DangNhap.BaseColor = System.Drawing.Color.Transparent;
            this.BT_DangNhap.BorderColor = System.Drawing.Color.DarkGray;
            this.BT_DangNhap.BorderSize = 3;
            this.BT_DangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BT_DangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.BT_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DangNhap.ForeColor = System.Drawing.Color.DarkGray;
            this.BT_DangNhap.Image = null;
            this.BT_DangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.BT_DangNhap.Location = new System.Drawing.Point(170, 557);
            this.BT_DangNhap.Name = "BT_DangNhap";
            this.BT_DangNhap.OnHoverBaseColor = System.Drawing.Color.White;
            this.BT_DangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BT_DangNhap.OnHoverForeColor = System.Drawing.Color.Black;
            this.BT_DangNhap.OnHoverImage = null;
            this.BT_DangNhap.OnPressedColor = System.Drawing.Color.DimGray;
            this.BT_DangNhap.Size = new System.Drawing.Size(160, 42);
            this.BT_DangNhap.TabIndex = 17;
            this.BT_DangNhap.Text = "Đăng Nhập";
            this.BT_DangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BT_DangNhap.Click += new System.EventHandler(this.BT_DangNhap_Click);
            // 
            // pic_apm
            // 
            this.pic_apm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pic_apm.Image = ((System.Drawing.Image)(resources.GetObject("pic_apm.Image")));
            this.pic_apm.Location = new System.Drawing.Point(428, -164);
            this.pic_apm.Name = "pic_apm";
            this.pic_apm.Size = new System.Drawing.Size(887, 958);
            this.pic_apm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_apm.TabIndex = 14;
            this.pic_apm.TabStop = false;
            // 
            // LB_quenpw
            // 
            this.LB_quenpw.AutoSize = true;
            this.LB_quenpw.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_quenpw.ForeColor = System.Drawing.Color.DarkGray;
            this.LB_quenpw.Location = new System.Drawing.Point(323, 452);
            this.LB_quenpw.Name = "LB_quenpw";
            this.LB_quenpw.Size = new System.Drawing.Size(100, 17);
            this.LB_quenpw.TabIndex = 13;
            this.LB_quenpw.Text = "Quên mật khẩu?";
            // 
            // VB_HienMatKhau
            // 
            this.VB_HienMatKhau.AutoSize = true;
            this.VB_HienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VB_HienMatKhau.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VB_HienMatKhau.ForeColor = System.Drawing.Color.Silver;
            this.VB_HienMatKhau.Location = new System.Drawing.Point(79, 464);
            this.VB_HienMatKhau.Name = "VB_HienMatKhau";
            this.VB_HienMatKhau.Size = new System.Drawing.Size(112, 21);
            this.VB_HienMatKhau.TabIndex = 12;
            this.VB_HienMatKhau.Text = "Hiện mật khẩu";
            this.VB_HienMatKhau.UseVisualStyleBackColor = true;
            // 
            // pic_lock
            // 
            this.pic_lock.Image = ((System.Drawing.Image)(resources.GetObject("pic_lock.Image")));
            this.pic_lock.Location = new System.Drawing.Point(398, 420);
            this.pic_lock.Name = "pic_lock";
            this.pic_lock.Size = new System.Drawing.Size(28, 26);
            this.pic_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_lock.TabIndex = 10;
            this.pic_lock.TabStop = false;
            // 
            // pic_mail
            // 
            this.pic_mail.Image = ((System.Drawing.Image)(resources.GetObject("pic_mail.Image")));
            this.pic_mail.Location = new System.Drawing.Point(397, 326);
            this.pic_mail.Name = "pic_mail";
            this.pic_mail.Size = new System.Drawing.Size(28, 22);
            this.pic_mail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_mail.TabIndex = 9;
            this.pic_mail.TabStop = false;
            // 
            // TB_MatKhau
            // 
            this.TB_MatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TB_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_MatKhau.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MatKhau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TB_MatKhau.Location = new System.Drawing.Point(78, 419);
            this.TB_MatKhau.Multiline = true;
            this.TB_MatKhau.Name = "TB_MatKhau";
            this.TB_MatKhau.Size = new System.Drawing.Size(345, 26);
            this.TB_MatKhau.TabIndex = 8;
            // 
            // TB_TaiKhoan
            // 
            this.TB_TaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TB_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_TaiKhoan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TaiKhoan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TB_TaiKhoan.Location = new System.Drawing.Point(78, 322);
            this.TB_TaiKhoan.Multiline = true;
            this.TB_TaiKhoan.Name = "TB_TaiKhoan";
            this.TB_TaiKhoan.Size = new System.Drawing.Size(342, 26);
            this.TB_TaiKhoan.TabIndex = 7;
            // 
            // LB_pw
            // 
            this.LB_pw.AutoSize = true;
            this.LB_pw.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_pw.ForeColor = System.Drawing.Color.DarkGray;
            this.LB_pw.Location = new System.Drawing.Point(74, 385);
            this.LB_pw.Name = "LB_pw";
            this.LB_pw.Size = new System.Drawing.Size(77, 21);
            this.LB_pw.TabIndex = 6;
            this.LB_pw.Text = "Mật khẩu";
            // 
            // LB_id
            // 
            this.LB_id.AutoSize = true;
            this.LB_id.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_id.ForeColor = System.Drawing.Color.DarkGray;
            this.LB_id.Location = new System.Drawing.Point(74, 286);
            this.LB_id.Name = "LB_id";
            this.LB_id.Size = new System.Drawing.Size(119, 21);
            this.LB_id.TabIndex = 5;
            this.LB_id.Text = "Mã người dùng";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(76, 448);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(348, 1);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 1);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 1);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 1);
            this.panel9.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(78, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 3;
            // 
            // LB_tasmana
            // 
            this.LB_tasmana.AutoSize = true;
            this.LB_tasmana.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_tasmana.ForeColor = System.Drawing.Color.White;
            this.LB_tasmana.Location = new System.Drawing.Point(71, 178);
            this.LB_tasmana.Name = "LB_tasmana";
            this.LB_tasmana.Size = new System.Drawing.Size(237, 49);
            this.LB_tasmana.TabIndex = 1;
            this.LB_tasmana.Text = "TASMANA";
            // 
            // BTN_close
            // 
            this.BTN_close.AnimationHoverSpeed = 0.07F;
            this.BTN_close.AnimationSpeed = 0.03F;
            this.BTN_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BTN_close.BorderColor = System.Drawing.Color.Black;
            this.BTN_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_close.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_close.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_close.ForeColor = System.Drawing.Color.White;
            this.BTN_close.Image = null;
            this.BTN_close.ImageSize = new System.Drawing.Size(20, 20);
            this.BTN_close.Location = new System.Drawing.Point(1107, 0);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.OnHoverBaseColor = System.Drawing.Color.Red;
            this.BTN_close.OnHoverBorderColor = System.Drawing.Color.Maroon;
            this.BTN_close.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_close.OnHoverImage = null;
            this.BTN_close.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_close.Size = new System.Drawing.Size(20, 20);
            this.BTN_close.TabIndex = 1;
            this.BTN_close.Text = "X";
            this.BTN_close.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_close.Click += new System.EventHandler(this.BTN_close_Click);
            // 
            // LB_error
            // 
            this.LB_error.AutoSize = true;
            this.LB_error.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_error.ForeColor = System.Drawing.Color.Maroon;
            this.LB_error.Location = new System.Drawing.Point(76, 488);
            this.LB_error.Name = "LB_error";
            this.LB_error.Size = new System.Drawing.Size(0, 17);
            this.LB_error.TabIndex = 18;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1129, 691);
            this.Controls.Add(this.BTN_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DangNhap_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DangNhap_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DangNhap_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_apm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mail)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_tasmana;
        private System.Windows.Forms.PictureBox pic_lock;
        private System.Windows.Forms.PictureBox pic_mail;
        private System.Windows.Forms.TextBox TB_MatKhau;
        private System.Windows.Forms.TextBox TB_TaiKhoan;
        private System.Windows.Forms.Label LB_pw;
        private System.Windows.Forms.Label LB_id;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox VB_HienMatKhau;
        private System.Windows.Forms.Label LB_quenpw;
        private System.Windows.Forms.PictureBox pic_apm;
        private Guna.UI.WinForms.GunaButton BT_DangNhap;
        private Guna.UI.WinForms.GunaButton BTN_close;
        private System.Windows.Forms.Label LB_error;
    }
}

