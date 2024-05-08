namespace DangNhap
{
    partial class CauHoiThuongGap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CauHoiThuongGap));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_thoat = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(640, 1);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 789);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 790);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(641, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 790);
            this.panel1.TabIndex = 4;
            // 
            // BTN_thoat
            // 
            this.BTN_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_thoat.AnimationHoverSpeed = 0.5F;
            this.BTN_thoat.AnimationSpeed = 0.03F;
            this.BTN_thoat.BackColor = System.Drawing.Color.Transparent;
            this.BTN_thoat.BaseColor1 = System.Drawing.Color.Transparent;
            this.BTN_thoat.BaseColor2 = System.Drawing.Color.Transparent;
            this.BTN_thoat.BorderColor = System.Drawing.Color.DimGray;
            this.BTN_thoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_thoat.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_thoat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.BTN_thoat.ForeColor = System.Drawing.Color.Black;
            this.BTN_thoat.Image = ((System.Drawing.Image)(resources.GetObject("BTN_thoat.Image")));
            this.BTN_thoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_thoat.ImageSize = new System.Drawing.Size(10, 10);
            this.BTN_thoat.Location = new System.Drawing.Point(581, 1);
            this.BTN_thoat.Name = "BTN_thoat";
            this.BTN_thoat.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.BTN_thoat.OnHoverBaseColor2 = System.Drawing.Color.Red;
            this.BTN_thoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTN_thoat.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_thoat.OnHoverImage = null;
            this.BTN_thoat.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_thoat.Size = new System.Drawing.Size(60, 30);
            this.BTN_thoat.TabIndex = 125;
            this.BTN_thoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_thoat.Click += new System.EventHandler(this.BTN_thoat_Click);
            // 
            // CauHoiThuongGap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(642, 790);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CauHoiThuongGap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CauHoiThuongGap";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CauHoi_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CauHoi_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CauHoi_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientButton BTN_thoat;
    }
}