namespace DangNhap
{
    partial class FaceDetectLogin
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
            this.PB_Camera = new System.Windows.Forms.PictureBox();
            this.PB_Capture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Opencam = new System.Windows.Forms.Button();
            this.BTN_save = new System.Windows.Forms.Button();
            this.BTN_detect = new System.Windows.Forms.Button();
            this.TXB_MatKhau = new System.Windows.Forms.TextBox();
            this.TXB_userId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Camera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Capture)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Camera
            // 
            this.PB_Camera.Location = new System.Drawing.Point(29, 37);
            this.PB_Camera.Name = "PB_Camera";
            this.PB_Camera.Size = new System.Drawing.Size(439, 291);
            this.PB_Camera.TabIndex = 0;
            this.PB_Camera.TabStop = false;
            // 
            // PB_Capture
            // 
            this.PB_Capture.Location = new System.Drawing.Point(509, 200);
            this.PB_Capture.Name = "PB_Capture";
            this.PB_Capture.Size = new System.Drawing.Size(170, 128);
            this.PB_Capture.TabIndex = 1;
            this.PB_Capture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAMERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CAPTURE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã người dùng";
            // 
            // BTN_Opencam
            // 
            this.BTN_Opencam.Location = new System.Drawing.Point(818, 54);
            this.BTN_Opencam.Name = "BTN_Opencam";
            this.BTN_Opencam.Size = new System.Drawing.Size(135, 66);
            this.BTN_Opencam.TabIndex = 6;
            this.BTN_Opencam.Text = "Mở camera";
            this.BTN_Opencam.UseVisualStyleBackColor = true;
            this.BTN_Opencam.Click += new System.EventHandler(this.BTN_Opencam_Click);
            // 
            // BTN_save
            // 
            this.BTN_save.Location = new System.Drawing.Point(818, 182);
            this.BTN_save.Name = "BTN_save";
            this.BTN_save.Size = new System.Drawing.Size(135, 66);
            this.BTN_save.TabIndex = 7;
            this.BTN_save.Text = "Lưu thông tin";
            this.BTN_save.UseVisualStyleBackColor = true;
            this.BTN_save.Click += new System.EventHandler(this.BTN_save_Click);
            // 
            // BTN_detect
            // 
            this.BTN_detect.Location = new System.Drawing.Point(818, 282);
            this.BTN_detect.Name = "BTN_detect";
            this.BTN_detect.Size = new System.Drawing.Size(135, 66);
            this.BTN_detect.TabIndex = 8;
            this.BTN_detect.Text = "Nhận dạng";
            this.BTN_detect.UseVisualStyleBackColor = true;
            this.BTN_detect.Click += new System.EventHandler(this.BTN_detect_Click);
            // 
            // TXB_MatKhau
            // 
            this.TXB_MatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.TXB_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXB_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_MatKhau.ForeColor = System.Drawing.Color.White;
            this.TXB_MatKhau.Location = new System.Drawing.Point(29, 424);
            this.TXB_MatKhau.Multiline = true;
            this.TXB_MatKhau.Name = "TXB_MatKhau";
            this.TXB_MatKhau.PasswordChar = '*';
            this.TXB_MatKhau.Size = new System.Drawing.Size(420, 26);
            this.TXB_MatKhau.TabIndex = 9;
            // 
            // TXB_userId
            // 
            this.TXB_userId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.TXB_userId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXB_userId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_userId.ForeColor = System.Drawing.Color.White;
            this.TXB_userId.Location = new System.Drawing.Point(29, 361);
            this.TXB_userId.Multiline = true;
            this.TXB_userId.Name = "TXB_userId";
            this.TXB_userId.Size = new System.Drawing.Size(420, 26);
            this.TXB_userId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu";
            // 
            // BTN_login
            // 
            this.BTN_login.Location = new System.Drawing.Point(818, 384);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(135, 66);
            this.BTN_login.TabIndex = 12;
            this.BTN_login.Text = "Đăng nhập";
            this.BTN_login.UseVisualStyleBackColor = true;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            // 
            // FaceDetectLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 479);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXB_userId);
            this.Controls.Add(this.TXB_MatKhau);
            this.Controls.Add(this.BTN_detect);
            this.Controls.Add(this.BTN_save);
            this.Controls.Add(this.BTN_Opencam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_Capture);
            this.Controls.Add(this.PB_Camera);
            this.Name = "FaceDetectLogin";
            this.Text = "FaceDetectLogin";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Camera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Capture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Camera;
        private System.Windows.Forms.PictureBox PB_Capture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Opencam;
        private System.Windows.Forms.Button BTN_save;
        private System.Windows.Forms.Button BTN_detect;
        private System.Windows.Forms.TextBox TXB_MatKhau;
        private System.Windows.Forms.TextBox TXB_userId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_login;
    }
}