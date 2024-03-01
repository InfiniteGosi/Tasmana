
namespace Project
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.P_AVT = new System.Windows.Forms.PictureBox();
            this.P_NgonNgu = new System.Windows.Forms.PictureBox();
            this.LB_ChaoMung = new System.Windows.Forms.Label();
            this.TB_TimKiem = new System.Windows.Forms.TextBox();
            this.P_Search = new System.Windows.Forms.PictureBox();
            this.P_LOGO = new System.Windows.Forms.PictureBox();
            this.LB_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.P_AVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_NgonNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_LOGO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_AVT
            // 
            this.P_AVT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.P_AVT.Image = ((System.Drawing.Image)(resources.GetObject("P_AVT.Image")));
            this.P_AVT.Location = new System.Drawing.Point(1333, -1);
            this.P_AVT.Name = "P_AVT";
            this.P_AVT.Size = new System.Drawing.Size(42, 46);
            this.P_AVT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P_AVT.TabIndex = 2;
            this.P_AVT.TabStop = false;
            this.P_AVT.Click += new System.EventHandler(this.P_AVT_Click);
            // 
            // P_NgonNgu
            // 
            this.P_NgonNgu.Image = ((System.Drawing.Image)(resources.GetObject("P_NgonNgu.Image")));
            this.P_NgonNgu.Location = new System.Drawing.Point(1298, 12);
            this.P_NgonNgu.Name = "P_NgonNgu";
            this.P_NgonNgu.Size = new System.Drawing.Size(25, 22);
            this.P_NgonNgu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P_NgonNgu.TabIndex = 10;
            this.P_NgonNgu.TabStop = false;
            // 
            // LB_ChaoMung
            // 
            this.LB_ChaoMung.AutoSize = true;
            this.LB_ChaoMung.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ChaoMung.ForeColor = System.Drawing.SystemColors.Window;
            this.LB_ChaoMung.Location = new System.Drawing.Point(1184, 15);
            this.LB_ChaoMung.Name = "LB_ChaoMung";
            this.LB_ChaoMung.Size = new System.Drawing.Size(110, 16);
            this.LB_ChaoMung.TabIndex = 6;
            this.LB_ChaoMung.Text = "Xin Chào, Khánh!";
            // 
            // TB_TimKiem
            // 
            this.TB_TimKiem.Location = new System.Drawing.Point(740, 12);
            this.TB_TimKiem.Name = "TB_TimKiem";
            this.TB_TimKiem.Size = new System.Drawing.Size(374, 22);
            this.TB_TimKiem.TabIndex = 2;
            // 
            // P_Search
            // 
            this.P_Search.Image = ((System.Drawing.Image)(resources.GetObject("P_Search.Image")));
            this.P_Search.Location = new System.Drawing.Point(1117, 12);
            this.P_Search.Name = "P_Search";
            this.P_Search.Size = new System.Drawing.Size(25, 23);
            this.P_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P_Search.TabIndex = 11;
            this.P_Search.TabStop = false;
            // 
            // P_LOGO
            // 
            this.P_LOGO.Image = ((System.Drawing.Image)(resources.GetObject("P_LOGO.Image")));
            this.P_LOGO.Location = new System.Drawing.Point(0, 0);
            this.P_LOGO.Name = "P_LOGO";
            this.P_LOGO.Size = new System.Drawing.Size(44, 46);
            this.P_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.P_LOGO.TabIndex = 12;
            this.P_LOGO.TabStop = false;
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.Location = new System.Drawing.Point(43, 16);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(113, 19);
            this.LB_Name.TabIndex = 0;
            this.LB_Name.Text = "TasMana Ver.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.LB_Name);
            this.panel1.Controls.Add(this.P_LOGO);
            this.panel1.Controls.Add(this.P_Search);
            this.panel1.Controls.Add(this.TB_TimKiem);
            this.panel1.Controls.Add(this.LB_ChaoMung);
            this.panel1.Controls.Add(this.P_NgonNgu);
            this.panel1.Controls.Add(this.P_AVT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 45);
            this.panel1.TabIndex = 0;
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 643);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            ((System.ComponentModel.ISupportInitialize)(this.P_AVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_NgonNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_LOGO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox P_AVT;
        private System.Windows.Forms.PictureBox P_NgonNgu;
        private System.Windows.Forms.Label LB_ChaoMung;
        private System.Windows.Forms.TextBox TB_TimKiem;
        private System.Windows.Forms.PictureBox P_Search;
        private System.Windows.Forms.PictureBox P_LOGO;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Panel panel1;
    }
}