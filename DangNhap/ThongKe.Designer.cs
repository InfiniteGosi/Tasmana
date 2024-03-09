
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
            this.pn_blue = new Guna.UI.WinForms.GunaGradientPanel();
            this.pn_red = new Guna.UI.WinForms.GunaGradientPanel();
            this.pn_green = new Guna.UI.WinForms.GunaGradientPanel();
            this.timeday = new Guna.UI.WinForms.GunaDateTimePicker();
            this.pn_tk = new System.Windows.Forms.Panel();
            this.elipse_blue = new Guna.UI.WinForms.GunaElipse(this.components);
            this.elipse_red = new Guna.UI.WinForms.GunaElipse(this.components);
            this.elipse_green = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // pn_blue
            // 
            this.pn_blue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_blue.BackgroundImage")));
            this.pn_blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_blue.GradientColor1 = System.Drawing.Color.Blue;
            this.pn_blue.GradientColor2 = System.Drawing.Color.Blue;
            this.pn_blue.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_blue.GradientColor4 = System.Drawing.Color.Aqua;
            this.pn_blue.Location = new System.Drawing.Point(33, 55);
            this.pn_blue.Name = "pn_blue";
            this.pn_blue.Size = new System.Drawing.Size(267, 133);
            this.pn_blue.TabIndex = 0;
            this.pn_blue.Text = "gunaGradientPanel1";
            // 
            // pn_red
            // 
            this.pn_red.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_red.BackgroundImage")));
            this.pn_red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_red.GradientColor1 = System.Drawing.Color.Red;
            this.pn_red.GradientColor2 = System.Drawing.Color.Maroon;
            this.pn_red.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pn_red.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pn_red.Location = new System.Drawing.Point(366, 55);
            this.pn_red.Name = "pn_red";
            this.pn_red.Size = new System.Drawing.Size(267, 133);
            this.pn_red.TabIndex = 1;
            this.pn_red.Text = "gunaGradientPanel2";
            // 
            // pn_green
            // 
            this.pn_green.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_green.BackgroundImage")));
            this.pn_green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_green.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pn_green.GradientColor2 = System.Drawing.Color.Green;
            this.pn_green.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pn_green.GradientColor4 = System.Drawing.Color.Lime;
            this.pn_green.Location = new System.Drawing.Point(705, 55);
            this.pn_green.Name = "pn_green";
            this.pn_green.Size = new System.Drawing.Size(267, 133);
            this.pn_green.TabIndex = 2;
            this.pn_green.Text = "gunaGradientPanel3";
            // 
            // timeday
            // 
            this.timeday.BaseColor = System.Drawing.Color.White;
            this.timeday.BorderColor = System.Drawing.Color.Silver;
            this.timeday.CustomFormat = null;
            this.timeday.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.timeday.FocusedColor = System.Drawing.Color.Black;
            this.timeday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeday.ForeColor = System.Drawing.Color.Black;
            this.timeday.Location = new System.Drawing.Point(33, 221);
            this.timeday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeday.Name = "timeday";
            this.timeday.OnHoverBaseColor = System.Drawing.Color.White;
            this.timeday.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timeday.OnHoverForeColor = System.Drawing.Color.Black;
            this.timeday.OnPressedColor = System.Drawing.Color.Black;
            this.timeday.Size = new System.Drawing.Size(267, 45);
            this.timeday.TabIndex = 3;
            this.timeday.Text = "Saturday, March 9, 2024";
            this.timeday.Value = new System.DateTime(2024, 3, 9, 1, 50, 45, 501);
            // 
            // pn_tk
            // 
            this.pn_tk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_tk.BackColor = System.Drawing.Color.Silver;
            this.pn_tk.Location = new System.Drawing.Point(34, 275);
            this.pn_tk.Name = "pn_tk";
            this.pn_tk.Size = new System.Drawing.Size(938, 279);
            this.pn_tk.TabIndex = 4;
            // 
            // elipse_blue
            // 
            this.elipse_blue.Radius = 10;
            this.elipse_blue.TargetControl = this.pn_blue;
            // 
            // elipse_red
            // 
            this.elipse_red.Radius = 10;
            this.elipse_red.TargetControl = this.pn_red;
            // 
            // elipse_green
            // 
            this.elipse_green.Radius = 10;
            this.elipse_green.TargetControl = this.pn_green;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1004, 566);
            this.Controls.Add(this.pn_tk);
            this.Controls.Add(this.timeday);
            this.Controls.Add(this.pn_green);
            this.Controls.Add(this.pn_red);
            this.Controls.Add(this.pn_blue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel pn_blue;
        private Guna.UI.WinForms.GunaGradientPanel pn_red;
        private Guna.UI.WinForms.GunaGradientPanel pn_green;
        private Guna.UI.WinForms.GunaDateTimePicker timeday;
        private System.Windows.Forms.Panel pn_tk;
        private Guna.UI.WinForms.GunaElipse elipse_blue;
        private Guna.UI.WinForms.GunaElipse elipse_red;
        private Guna.UI.WinForms.GunaElipse elipse_green;
    }
}