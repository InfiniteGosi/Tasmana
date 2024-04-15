
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
            this.LB_welcometo = new System.Windows.Forms.Label();
            this.LB_dangnhap = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LB_error
            // 
            this.LB_error.AutoSize = true;
            this.LB_error.BackColor = System.Drawing.Color.Transparent;
            this.LB_error.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_error.ForeColor = System.Drawing.Color.Red;
            this.LB_error.Location = new System.Drawing.Point(630, 387);
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
            this.BT_DangNhap.BorderSize = 3;
            this.BT_DangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BT_DangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.BT_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DangNhap.ForeColor = System.Drawing.Color.White;
            this.BT_DangNhap.Image = null;
            this.BT_DangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.BT_DangNhap.Location = new System.Drawing.Point(773, 463);
            this.BT_DangNhap.Name = "BT_DangNhap";
            this.BT_DangNhap.OnHoverBaseColor = System.Drawing.Color.White;
            this.BT_DangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BT_DangNhap.OnHoverForeColor = System.Drawing.Color.Black;
            this.BT_DangNhap.OnHoverImage = null;
            this.BT_DangNhap.OnPressedColor = System.Drawing.Color.DimGray;
            this.BT_DangNhap.Size = new System.Drawing.Size(160, 56);
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
            this.LB_quenpw.Location = new System.Drawing.Point(958, 347);
            this.LB_quenpw.Name = "LB_quenpw";
            this.LB_quenpw.Size = new System.Drawing.Size(97, 15);
            this.LB_quenpw.TabIndex = 13;
            this.LB_quenpw.Text = "Quên mật khẩu?";
            // 
            // VB_HienMatKhau
            // 
            this.VB_HienMatKhau.AutoSize = true;
            this.VB_HienMatKhau.BackColor = System.Drawing.Color.Black;
            this.VB_HienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VB_HienMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VB_HienMatKhau.ForeColor = System.Drawing.Color.White;
            this.VB_HienMatKhau.Location = new System.Drawing.Point(633, 363);
            this.VB_HienMatKhau.Name = "VB_HienMatKhau";
            this.VB_HienMatKhau.Size = new System.Drawing.Size(124, 23);
            this.VB_HienMatKhau.TabIndex = 12;
            this.VB_HienMatKhau.Text = "Hiện mật khẩu";
            this.VB_HienMatKhau.UseVisualStyleBackColor = false;
            this.VB_HienMatKhau.CheckedChanged += new System.EventHandler(this.VB_HienMatKhau_CheckedChanged);
            // 
            // TB_MatKhau
            // 
            this.TB_MatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.TB_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_MatKhau.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MatKhau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TB_MatKhau.Location = new System.Drawing.Point(632, 318);
            this.TB_MatKhau.Multiline = true;
            this.TB_MatKhau.Name = "TB_MatKhau";
            this.TB_MatKhau.PasswordChar = '*';
            this.TB_MatKhau.Size = new System.Drawing.Size(420, 26);
            this.TB_MatKhau.TabIndex = 8;
            // 
            // TB_TaiKhoan
            // 
            this.TB_TaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.TB_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_TaiKhoan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TaiKhoan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TB_TaiKhoan.Location = new System.Drawing.Point(632, 221);
            this.TB_TaiKhoan.Multiline = true;
            this.TB_TaiKhoan.Name = "TB_TaiKhoan";
            this.TB_TaiKhoan.Size = new System.Drawing.Size(420, 26);
            this.TB_TaiKhoan.TabIndex = 7;
            // 
            // LB_pw
            // 
            this.LB_pw.AutoSize = true;
            this.LB_pw.BackColor = System.Drawing.Color.Transparent;
            this.LB_pw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_pw.ForeColor = System.Drawing.Color.White;
            this.LB_pw.Location = new System.Drawing.Point(623, 284);
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
            this.LB_id.Location = new System.Drawing.Point(623, 185);
            this.LB_id.Name = "LB_id";
            this.LB_id.Size = new System.Drawing.Size(130, 22);
            this.LB_id.TabIndex = 5;
            this.LB_id.Text = "Mã người dùng";
            // 
            // LB_tasmana
            // 
            this.LB_tasmana.AutoSize = true;
            this.LB_tasmana.BackColor = System.Drawing.Color.Transparent;
            this.LB_tasmana.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_tasmana.ForeColor = System.Drawing.Color.White;
            this.LB_tasmana.Location = new System.Drawing.Point(125, 238);
            this.LB_tasmana.Name = "LB_tasmana";
            this.LB_tasmana.Size = new System.Drawing.Size(327, 68);
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
            this.BTN_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_close.ForeColor = System.Drawing.Color.White;
            this.BTN_close.Image = ((System.Drawing.Image)(resources.GetObject("BTN_close.Image")));
            this.BTN_close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_close.ImageSize = new System.Drawing.Size(15, 15);
            this.BTN_close.Location = new System.Drawing.Point(1107, 3);
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
            this.panel1.Location = new System.Drawing.Point(635, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 2);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(633, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 2);
            this.panel2.TabIndex = 20;
            // 
            // LB_welcometo
            // 
            this.LB_welcometo.AutoSize = true;
            this.LB_welcometo.BackColor = System.Drawing.Color.Transparent;
            this.LB_welcometo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_welcometo.ForeColor = System.Drawing.Color.White;
            this.LB_welcometo.Location = new System.Drawing.Point(59, 145);
            this.LB_welcometo.Name = "LB_welcometo";
            this.LB_welcometo.Size = new System.Drawing.Size(207, 46);
            this.LB_welcometo.TabIndex = 21;
            this.LB_welcometo.Text = "Welcome to";
            // 
            // LB_dangnhap
            // 
            this.LB_dangnhap.AutoSize = true;
            this.LB_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.LB_dangnhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_dangnhap.ForeColor = System.Drawing.Color.White;
            this.LB_dangnhap.Location = new System.Drawing.Point(780, 75);
            this.LB_dangnhap.Name = "LB_dangnhap";
            this.LB_dangnhap.Size = new System.Drawing.Size(147, 32);
            this.LB_dangnhap.TabIndex = 22;
            this.LB_dangnhap.Text = "Đăng nhập";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 587);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1127, 2);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(2, 585);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1127, 2);
            this.panel5.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1127, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 583);
            this.panel6.TabIndex = 26;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 587);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LB_dangnhap);
            this.Controls.Add(this.LB_welcometo);
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
        private System.Windows.Forms.Label LB_welcometo;
        private System.Windows.Forms.Label LB_dangnhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

