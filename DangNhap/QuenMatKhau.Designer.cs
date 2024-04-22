namespace DangNhap
{
    partial class QuenMatKhau
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
            this.TXB_employeId = new System.Windows.Forms.TextBox();
            this.TXB_verify = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_ok = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BTN_guima = new System.Windows.Forms.Button();
            this.TXB_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXB_employeId
            // 
            this.TXB_employeId.Location = new System.Drawing.Point(217, 92);
            this.TXB_employeId.Name = "TXB_employeId";
            this.TXB_employeId.Size = new System.Drawing.Size(371, 22);
            this.TXB_employeId.TabIndex = 1;
            // 
            // TXB_verify
            // 
            this.TXB_verify.Location = new System.Drawing.Point(220, 311);
            this.TXB_verify.Name = "TXB_verify";
            this.TXB_verify.Size = new System.Drawing.Size(368, 22);
            this.TXB_verify.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập mã xác nhận";
            // 
            // BTN_ok
            // 
            this.BTN_ok.Location = new System.Drawing.Point(492, 351);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.Size = new System.Drawing.Size(96, 52);
            this.BTN_ok.TabIndex = 5;
            this.BTN_ok.Text = "Xem mật khẩu cũ";
            this.BTN_ok.UseVisualStyleBackColor = true;
            this.BTN_ok.Click += new System.EventHandler(this.BTN_ok_Click);
            // 
            // BTN_guima
            // 
            this.BTN_guima.Location = new System.Drawing.Point(489, 206);
            this.BTN_guima.Name = "BTN_guima";
            this.BTN_guima.Size = new System.Drawing.Size(99, 52);
            this.BTN_guima.TabIndex = 6;
            this.BTN_guima.Text = "Gửi mã";
            this.BTN_guima.UseVisualStyleBackColor = true;
            this.BTN_guima.Click += new System.EventHandler(this.BTN_guima_Click);
            // 
            // TXB_email
            // 
            this.TXB_email.Enabled = false;
            this.TXB_email.Location = new System.Drawing.Point(217, 165);
            this.TXB_email.Name = "TXB_email";
            this.TXB_email.Size = new System.Drawing.Size(371, 22);
            this.TXB_email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXB_email);
            this.Controls.Add(this.BTN_guima);
            this.Controls.Add(this.BTN_ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_verify);
            this.Controls.Add(this.TXB_employeId);
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_employeId;
        private System.Windows.Forms.TextBox TXB_verify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_ok;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button BTN_guima;
        private System.Windows.Forms.TextBox TXB_email;
        private System.Windows.Forms.Label label3;
    }
}