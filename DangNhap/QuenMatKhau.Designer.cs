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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TXB_employeId
            // 
            this.TXB_employeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.TXB_employeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXB_employeId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_employeId.Location = new System.Drawing.Point(51, 146);
            this.TXB_employeId.Name = "TXB_employeId";
            this.TXB_employeId.Size = new System.Drawing.Size(476, 23);
            this.TXB_employeId.TabIndex = 1;
            // 
            // TXB_verify
            // 
            this.TXB_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.TXB_verify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXB_verify.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_verify.Location = new System.Drawing.Point(51, 390);
            this.TXB_verify.Name = "TXB_verify";
            this.TXB_verify.Size = new System.Drawing.Size(476, 23);
            this.TXB_verify.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập mã xác nhận";
            // 
            // BTN_ok
            // 
            this.BTN_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ok.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ok.ForeColor = System.Drawing.Color.White;
            this.BTN_ok.Location = new System.Drawing.Point(165, 454);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.Size = new System.Drawing.Size(224, 52);
            this.BTN_ok.TabIndex = 5;
            this.BTN_ok.Text = "Xem mật khẩu cũ";
            this.BTN_ok.UseVisualStyleBackColor = true;
            this.BTN_ok.Click += new System.EventHandler(this.BTN_ok_Click);
            // 
            // BTN_guima
            // 
            this.BTN_guima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_guima.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_guima.ForeColor = System.Drawing.Color.White;
            this.BTN_guima.Location = new System.Drawing.Point(428, 268);
            this.BTN_guima.Name = "BTN_guima";
            this.BTN_guima.Size = new System.Drawing.Size(99, 31);
            this.BTN_guima.TabIndex = 6;
            this.BTN_guima.Text = "Gửi mã";
            this.BTN_guima.UseVisualStyleBackColor = true;
            this.BTN_guima.Click += new System.EventHandler(this.BTN_guima_Click);
            // 
            // TXB_email
            // 
            this.TXB_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.TXB_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXB_email.Enabled = false;
            this.TXB_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_email.Location = new System.Drawing.Point(51, 268);
            this.TXB_email.Name = "TXB_email";
            this.TXB_email.Size = new System.Drawing.Size(371, 23);
            this.TXB_email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(51, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 2);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(153, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 32);
            this.label4.TabIndex = 60;
            this.label4.Text = "Xem Lại Mật Khẩu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(51, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 2);
            this.panel2.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(51, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 2);
            this.panel3.TabIndex = 62;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(554, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}