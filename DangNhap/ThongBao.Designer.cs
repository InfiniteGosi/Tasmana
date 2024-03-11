
namespace DangNhap
{
    partial class ThongBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongBao));
            this.btn_compose = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_inbox = new Guna.UI.WinForms.GunaButton();
            this.btn_sent = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_compose
            // 
            this.btn_compose.Animated = true;
            this.btn_compose.AnimationHoverSpeed = 0.5F;
            this.btn_compose.AnimationSpeed = 0.03F;
            this.btn_compose.BackColor = System.Drawing.Color.Transparent;
            this.btn_compose.BaseColor1 = System.Drawing.Color.WhiteSmoke;
            this.btn_compose.BaseColor2 = System.Drawing.Color.LightGray;
            this.btn_compose.BorderColor = System.Drawing.Color.Black;
            this.btn_compose.BorderSize = 3;
            this.btn_compose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_compose.FocusedColor = System.Drawing.Color.Empty;
            this.btn_compose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_compose.Image = ((System.Drawing.Image)(resources.GetObject("btn_compose.Image")));
            this.btn_compose.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_compose.Location = new System.Drawing.Point(12, 28);
            this.btn_compose.Name = "btn_compose";
            this.btn_compose.OnHoverBaseColor1 = System.Drawing.Color.Gray;
            this.btn_compose.OnHoverBaseColor2 = System.Drawing.Color.Silver;
            this.btn_compose.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_compose.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_compose.OnHoverImage = null;
            this.btn_compose.OnPressedColor = System.Drawing.Color.Black;
            this.btn_compose.Radius = 15;
            this.btn_compose.Size = new System.Drawing.Size(160, 42);
            this.btn_compose.TabIndex = 0;
            this.btn_compose.Text = "Biên soạn";
            // 
            // btn_inbox
            // 
            this.btn_inbox.Animated = true;
            this.btn_inbox.AnimationHoverSpeed = 0.5F;
            this.btn_inbox.AnimationSpeed = 0.03F;
            this.btn_inbox.BackColor = System.Drawing.Color.Transparent;
            this.btn_inbox.BaseColor = System.Drawing.Color.Transparent;
            this.btn_inbox.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inbox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_inbox.FocusedColor = System.Drawing.Color.Empty;
            this.btn_inbox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inbox.ForeColor = System.Drawing.Color.White;
            this.btn_inbox.Image = ((System.Drawing.Image)(resources.GetObject("btn_inbox.Image")));
            this.btn_inbox.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_inbox.Location = new System.Drawing.Point(12, 94);
            this.btn_inbox.Name = "btn_inbox";
            this.btn_inbox.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_inbox.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_inbox.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_inbox.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_inbox.OnHoverImage")));
            this.btn_inbox.OnPressedColor = System.Drawing.Color.Black;
            this.btn_inbox.Radius = 10;
            this.btn_inbox.Size = new System.Drawing.Size(160, 42);
            this.btn_inbox.TabIndex = 1;
            this.btn_inbox.Text = "Hộp thư đến";
            // 
            // btn_sent
            // 
            this.btn_sent.Animated = true;
            this.btn_sent.AnimationHoverSpeed = 0.5F;
            this.btn_sent.AnimationSpeed = 0.03F;
            this.btn_sent.BackColor = System.Drawing.Color.Transparent;
            this.btn_sent.BaseColor = System.Drawing.Color.Transparent;
            this.btn_sent.BorderColor = System.Drawing.Color.Transparent;
            this.btn_sent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sent.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sent.ForeColor = System.Drawing.Color.White;
            this.btn_sent.Image = ((System.Drawing.Image)(resources.GetObject("btn_sent.Image")));
            this.btn_sent.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_sent.Location = new System.Drawing.Point(12, 152);
            this.btn_sent.Name = "btn_sent";
            this.btn_sent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sent.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_sent.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btn_sent.OnHoverImage")));
            this.btn_sent.OnPressedColor = System.Drawing.Color.Black;
            this.btn_sent.Radius = 10;
            this.btn_sent.Size = new System.Drawing.Size(160, 42);
            this.btn_sent.TabIndex = 2;
            this.btn_sent.Text = "Đã gửi";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.AutoScroll = true;
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.DimGray;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(183, 12);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1116, 624);
            this.gunaElipsePanel1.TabIndex = 3;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.btn_compose);
            this.gunaGradientPanel1.Controls.Add(this.gunaElipsePanel1);
            this.gunaGradientPanel1.Controls.Add(this.btn_inbox);
            this.gunaGradientPanel1.Controls.Add(this.btn_sent);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1321, 648);
            this.gunaGradientPanel1.TabIndex = 4;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1311, 648);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "ThongBao";
            this.Text = "ThongBao";
            this.gunaGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btn_compose;
        private Guna.UI.WinForms.GunaButton btn_inbox;
        private Guna.UI.WinForms.GunaButton btn_sent;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
    }
}