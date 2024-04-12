namespace DangNhap
{
    partial class DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_mkhientai = new System.Windows.Forms.TextBox();
            this.TXB_mkmoi = new System.Windows.Forms.TextBox();
            this.TXB_xacnhanmk = new System.Windows.Forms.TextBox();
            this.BTN_luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu mới";
            // 
            // TXB_mkhientai
            // 
            this.TXB_mkhientai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TXB_mkhientai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_mkhientai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_mkhientai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_mkhientai.Location = new System.Drawing.Point(181, 74);
            this.TXB_mkhientai.Name = "TXB_mkhientai";
            this.TXB_mkhientai.Size = new System.Drawing.Size(419, 30);
            this.TXB_mkhientai.TabIndex = 55;
            // 
            // TXB_mkmoi
            // 
            this.TXB_mkmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TXB_mkmoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_mkmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_mkmoi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_mkmoi.Location = new System.Drawing.Point(181, 206);
            this.TXB_mkmoi.Name = "TXB_mkmoi";
            this.TXB_mkmoi.Size = new System.Drawing.Size(419, 30);
            this.TXB_mkmoi.TabIndex = 56;
            // 
            // TXB_xacnhanmk
            // 
            this.TXB_xacnhanmk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TXB_xacnhanmk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_xacnhanmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_xacnhanmk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TXB_xacnhanmk.Location = new System.Drawing.Point(181, 319);
            this.TXB_xacnhanmk.Name = "TXB_xacnhanmk";
            this.TXB_xacnhanmk.Size = new System.Drawing.Size(419, 30);
            this.TXB_xacnhanmk.TabIndex = 57;
            // 
            // BTN_luu
            // 
            this.BTN_luu.Location = new System.Drawing.Point(637, 372);
            this.BTN_luu.Name = "BTN_luu";
            this.BTN_luu.Size = new System.Drawing.Size(96, 49);
            this.BTN_luu.TabIndex = 58;
            this.BTN_luu.Text = "Lưu";
            this.BTN_luu.UseVisualStyleBackColor = true;
            this.BTN_luu.Click += new System.EventHandler(this.BTN_luu_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_luu);
            this.Controls.Add(this.TXB_xacnhanmk);
            this.Controls.Add(this.TXB_mkmoi);
            this.Controls.Add(this.TXB_mkhientai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_mkhientai;
        private System.Windows.Forms.TextBox TXB_mkmoi;
        private System.Windows.Forms.TextBox TXB_xacnhanmk;
        private System.Windows.Forms.Button BTN_luu;
    }
}