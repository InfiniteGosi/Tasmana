
namespace DangNhap
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.PN_blue = new Guna.UI.WinForms.GunaGradientPanel();
            this.DT_ngaythong = new Guna.UI.WinForms.GunaDateTimePicker();
            this.PN_tk = new System.Windows.Forms.Panel();
            this.elipse_blue = new Guna.UI.WinForms.GunaElipse(this.components);
            this.elipse_red = new Guna.UI.WinForms.GunaElipse(this.components);
            this.elipse_green = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PN_tk2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PN_blue
            // 
            this.PN_blue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PN_blue.BackgroundImage")));
            this.PN_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_blue.GradientColor1 = System.Drawing.Color.Blue;
            this.PN_blue.GradientColor2 = System.Drawing.Color.Blue;
            this.PN_blue.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PN_blue.GradientColor4 = System.Drawing.Color.Aqua;
            this.PN_blue.Location = new System.Drawing.Point(33, 12);
            this.PN_blue.Name = "PN_blue";
            this.PN_blue.Size = new System.Drawing.Size(474, 221);
            this.PN_blue.TabIndex = 0;
            this.PN_blue.Text = "gunaGradientPanel1";
            // 
            // DT_ngaythong
            // 
            this.DT_ngaythong.BaseColor = System.Drawing.Color.White;
            this.DT_ngaythong.BorderColor = System.Drawing.Color.Silver;
            this.DT_ngaythong.CustomFormat = null;
            this.DT_ngaythong.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DT_ngaythong.FocusedColor = System.Drawing.Color.Black;
            this.DT_ngaythong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DT_ngaythong.ForeColor = System.Drawing.Color.Black;
            this.DT_ngaythong.Location = new System.Drawing.Point(33, 248);
            this.DT_ngaythong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DT_ngaythong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DT_ngaythong.Name = "DT_ngaythong";
            this.DT_ngaythong.OnHoverBaseColor = System.Drawing.Color.White;
            this.DT_ngaythong.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DT_ngaythong.OnHoverForeColor = System.Drawing.Color.Black;
            this.DT_ngaythong.OnPressedColor = System.Drawing.Color.Black;
            this.DT_ngaythong.Size = new System.Drawing.Size(267, 27);
            this.DT_ngaythong.TabIndex = 3;
            this.DT_ngaythong.Text = "Saturday, March 9, 2024";
            this.DT_ngaythong.Value = new System.DateTime(2024, 3, 9, 1, 50, 45, 501);
            // 
            // PN_tk
            // 
            this.PN_tk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_tk.BackColor = System.Drawing.Color.Silver;
            this.PN_tk.Location = new System.Drawing.Point(538, 12);
            this.PN_tk.Name = "PN_tk";
            this.PN_tk.Size = new System.Drawing.Size(454, 542);
            this.PN_tk.TabIndex = 4;
            // 
            // elipse_blue
            // 
            this.elipse_blue.Radius = 10;
            this.elipse_blue.TargetControl = this.PN_blue;
            // 
            // elipse_red
            // 
            this.elipse_red.Radius = 10;
            this.elipse_red.TargetControl = this;
            // 
            // elipse_green
            // 
            this.elipse_green.Radius = 10;
            this.elipse_green.TargetControl = this;
            // 
            // PN_tk2
            // 
            this.PN_tk2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PN_tk2.BackColor = System.Drawing.Color.Silver;
            this.PN_tk2.Location = new System.Drawing.Point(33, 290);
            this.PN_tk2.Name = "PN_tk2";
            this.PN_tk2.Size = new System.Drawing.Size(474, 264);
            this.PN_tk2.TabIndex = 5;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1004, 566);
            this.Controls.Add(this.PN_tk2);
            this.Controls.Add(this.PN_tk);
            this.Controls.Add(this.DT_ngaythong);
            this.Controls.Add(this.PN_blue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel PN_blue;
        private Guna.UI.WinForms.GunaDateTimePicker DT_ngaythong;
        private System.Windows.Forms.Panel PN_tk;
        private Guna.UI.WinForms.GunaElipse elipse_blue;
        private Guna.UI.WinForms.GunaElipse elipse_red;
        private Guna.UI.WinForms.GunaElipse elipse_green;
        private System.Windows.Forms.Panel PN_tk2;
    }
}