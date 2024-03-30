
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
            this.LB_error = new System.Windows.Forms.Label();
            this.BT_DangNhap = new Guna.UI.WinForms.GunaButton();
            this.LB_quenpw = new System.Windows.Forms.Label();
            this.VB_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.TB_MatKhau = new System.Windows.Forms.TextBox();
            this.TB_TaiKhoan = new System.Windows.Forms.TextBox();
            this.LB_pw = new System.Windows.Forms.Label();
            this.LB_id = new System.Windows.Forms.Label();
            this.LB_tasmana = new System.Windows.Forms.Label();
            this.BTN_close = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LB_error
            // 
            this.LB_error.AutoSize = true;
            this.LB_error.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_error.ForeColor = System.Drawing.Color.Maroon;
            this.LB_error.Location = new System.Drawing.Point(71, 437);
            this.LB_error.Name = "LB_error";
            this.LB_error.Size = new System.Drawing.Size(0, 17);
            this.LB_error.TabIndex = 18;
            // 
            // BT_DangNhap
            // 
            this.BT_DangNhap.Animated = true;
            this.BT_DangNhap.AnimationHoverSpeed = 0.5F;
            this.BT_DangNhap.AnimationSpeed = 0.03F;
            this.BT_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.BT_DangNhap.BaseColor = System.Drawing.Color.Transparent;
            this.BT_DangNhap.BorderColor = System.Drawing.Color.White;
            this.BT_DangNhap.BorderSize = 2;
            this.BT_DangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BT_DangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.BT_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DangNhap.ForeColor = System.Drawing.Color.White;
            this.BT_DangNhap.Image = null;
            this.BT_DangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.BT_DangNhap.Location = new System.Drawing.Point(74, 500);
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
            // LB_quenpw
            // 
            this.LB_quenpw.AutoSize = true;
            this.LB_quenpw.BackColor = System.Drawing.Color.Transparent;
            this.LB_quenpw.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_quenpw.ForeColor = System.Drawing.Color.White;
            this.LB_quenpw.Location = new System.Drawing.Point(325, 397);
            this.LB_quenpw.Name = "LB_quenpw";
            this.LB_quenpw.Size = new System.Drawing.Size(97, 15);
            this.LB_quenpw.TabIndex = 13;
            this.LB_quenpw.Text = "Quên mật khẩu?";
            // 
            // VB_HienMatKhau
            // 
            this.VB_HienMatKhau.AutoSize = true;
            this.VB_HienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.VB_HienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VB_HienMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VB_HienMatKhau.ForeColor = System.Drawing.Color.White;
            this.VB_HienMatKhau.Location = new System.Drawing.Point(74, 413);
            this.VB_HienMatKhau.Name = "VB_HienMatKhau";
            this.VB_HienMatKhau.Size = new System.Drawing.Size(124, 23);
            this.VB_HienMatKhau.TabIndex = 12;
            this.VB_HienMatKhau.Text = "Hiện mật khẩu";
            this.VB_HienMatKhau.UseVisualStyleBackColor = false;
            // 
            // TB_MatKhau
            // 
            this.TB_MatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.TB_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_MatKhau.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MatKhau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TB_MatKhau.Location = new System.Drawing.Point(73, 368);
            this.TB_MatKhau.Multiline = true;
            this.TB_MatKhau.Name = "TB_MatKhau";
            this.TB_MatKhau.Size = new System.Drawing.Size(345, 26);
            this.TB_MatKhau.TabIndex = 8;
            // 
            // TB_TaiKhoan
            // 
            this.TB_TaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.TB_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_TaiKhoan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TaiKhoan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TB_TaiKhoan.Location = new System.Drawing.Point(73, 271);
            this.TB_TaiKhoan.Multiline = true;
            this.TB_TaiKhoan.Name = "TB_TaiKhoan";
            this.TB_TaiKhoan.Size = new System.Drawing.Size(342, 26);
            this.TB_TaiKhoan.TabIndex = 7;
            // 
            // LB_pw
            // 
            this.LB_pw.AutoSize = true;
            this.LB_pw.BackColor = System.Drawing.Color.Transparent;
            this.LB_pw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_pw.ForeColor = System.Drawing.Color.White;
            this.LB_pw.Location = new System.Drawing.Point(69, 334);
            this.LB_pw.Name = "LB_pw";
            this.LB_pw.Size = new System.Drawing.Size(82, 22);
            this.LB_pw.TabIndex = 6;
            this.LB_pw.Text = "Mật khẩu";
            // 
            // LB_id
            // 
            this.LB_id.AutoSize = true;
            this.LB_id.BackColor = System.Drawing.Color.Transparent;
            this.LB_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_id.ForeColor = System.Drawing.Color.White;
            this.LB_id.Location = new System.Drawing.Point(69, 235);
            this.LB_id.Name = "LB_id";
            this.LB_id.Size = new System.Drawing.Size(130, 22);
            this.LB_id.TabIndex = 5;
            this.LB_id.Text = "Mã người dùng";
            // 
            // LB_tasmana
            // 
            this.LB_tasmana.AutoSize = true;
            this.LB_tasmana.BackColor = System.Drawing.Color.Transparent;
            this.LB_tasmana.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_tasmana.ForeColor = System.Drawing.Color.White;
            this.LB_tasmana.Location = new System.Drawing.Point(65, 128);
            this.LB_tasmana.Name = "LB_tasmana";
            this.LB_tasmana.Size = new System.Drawing.Size(237, 49);
            this.LB_tasmana.TabIndex = 1;
            this.LB_tasmana.Text = "TASMANA";
            // 
            // BTN_close
            // 
            this.BTN_close.AnimationHoverSpeed = 0.07F;
            this.BTN_close.AnimationSpeed = 0.03F;
            this.BTN_close.BackColor = System.Drawing.Color.Transparent;
            this.BTN_close.BaseColor = System.Drawing.Color.Transparent;
            this.BTN_close.BorderColor = System.Drawing.Color.Black;
            this.BTN_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_close.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_close.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_close.ForeColor = System.Drawing.Color.White;
            this.BTN_close.Image = ((System.Drawing.Image)(resources.GetObject("BTN_close.Image")));
            this.BTN_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_close.ImageSize = new System.Drawing.Size(15, 15);
            this.BTN_close.Location = new System.Drawing.Point(1109, 0);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.OnHoverBaseColor = System.Drawing.Color.Red;
            this.BTN_close.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.BTN_close.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_close.OnHoverImage = null;
            this.BTN_close.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_close.Size = new System.Drawing.Size(20, 20);
            this.BTN_close.TabIndex = 1;
            this.BTN_close.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_close.Click += new System.EventHandler(this.BTN_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(76, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 2);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(74, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 2);
            this.panel2.TabIndex = 20;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LB_error);
            this.Controls.Add(this.BTN_close);
            this.Controls.Add(this.BT_DangNhap);
            this.Controls.Add(this.LB_quenpw);
            this.Controls.Add(this.LB_tasmana);
            this.Controls.Add(this.VB_HienMatKhau);
            this.Controls.Add(this.LB_id);
            this.Controls.Add(this.TB_MatKhau);
            this.Controls.Add(this.LB_pw);
            this.Controls.Add(this.TB_TaiKhoan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DangNhap_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DangNhap_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DangNhap_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_tasmana;
        private System.Windows.Forms.TextBox TB_MatKhau;
        private System.Windows.Forms.TextBox TB_TaiKhoan;
        private System.Windows.Forms.Label LB_pw;
        private System.Windows.Forms.Label LB_id;
        private System.Windows.Forms.CheckBox VB_HienMatKhau;
        private System.Windows.Forms.Label LB_quenpw;
        private Guna.UI.WinForms.GunaButton BT_DangNhap;
        private Guna.UI.WinForms.GunaButton BTN_close;
        private System.Windows.Forms.Label LB_error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

