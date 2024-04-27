namespace DangNhap
{
    partial class ChiPhiHangThang
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
            this.GGC_BillHangThang = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.BTN_ThemBill = new Guna.UI.WinForms.GunaGradientButton();
            this.LB_BillHangThang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GGC_BillHangThang)).BeginInit();
            this.SuspendLayout();
            // 
            // GGC_BillHangThang
            // 
            this.GGC_BillHangThang.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.GGC_BillHangThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GGC_BillHangThang.BackColor = System.Drawing.SystemColors.Window;
            this.GGC_BillHangThang.Location = new System.Drawing.Point(114, 195);
            this.GGC_BillHangThang.Name = "GGC_BillHangThang";
            this.GGC_BillHangThang.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.GGC_BillHangThang.Size = new System.Drawing.Size(1211, 560);
            this.GGC_BillHangThang.TabIndex = 122;
            this.GGC_BillHangThang.Text = "gridGroupingControl1";
            this.GGC_BillHangThang.UseRightToLeftCompatibleTextBox = true;
            this.GGC_BillHangThang.VersionInfo = "25.1462.39";
            this.GGC_BillHangThang.TableControlCellDoubleClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventHandler(this.GGC_BillHangThang_TableControlCellDoubleClick);
            // 
            // BTN_ThemBill
            // 
            this.BTN_ThemBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ThemBill.Animated = true;
            this.BTN_ThemBill.AnimationHoverSpeed = 1F;
            this.BTN_ThemBill.AnimationSpeed = 0.03F;
            this.BTN_ThemBill.BackColor = System.Drawing.Color.Transparent;
            this.BTN_ThemBill.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.BTN_ThemBill.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ThemBill.BorderColor = System.Drawing.Color.White;
            this.BTN_ThemBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTN_ThemBill.FocusedColor = System.Drawing.Color.Empty;
            this.BTN_ThemBill.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ThemBill.ForeColor = System.Drawing.Color.White;
            this.BTN_ThemBill.Image = null;
            this.BTN_ThemBill.ImageSize = new System.Drawing.Size(15, 15);
            this.BTN_ThemBill.Location = new System.Drawing.Point(1196, 110);
            this.BTN_ThemBill.Name = "BTN_ThemBill";
            this.BTN_ThemBill.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BTN_ThemBill.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.BTN_ThemBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BTN_ThemBill.OnHoverForeColor = System.Drawing.Color.White;
            this.BTN_ThemBill.OnHoverImage = null;
            this.BTN_ThemBill.OnPressedColor = System.Drawing.Color.Black;
            this.BTN_ThemBill.Radius = 5;
            this.BTN_ThemBill.Size = new System.Drawing.Size(129, 35);
            this.BTN_ThemBill.TabIndex = 123;
            this.BTN_ThemBill.Text = "Thêm hóa đơn";
            this.BTN_ThemBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTN_ThemBill.Click += new System.EventHandler(this.BTN_ThemBill_Click);
            // 
            // LB_BillHangThang
            // 
            this.LB_BillHangThang.AutoSize = true;
            this.LB_BillHangThang.BackColor = System.Drawing.Color.Transparent;
            this.LB_BillHangThang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BillHangThang.ForeColor = System.Drawing.Color.White;
            this.LB_BillHangThang.Location = new System.Drawing.Point(108, 31);
            this.LB_BillHangThang.Name = "LB_BillHangThang";
            this.LB_BillHangThang.Size = new System.Drawing.Size(344, 32);
            this.LB_BillHangThang.TabIndex = 124;
            this.LB_BillHangThang.Text = "HÓA ĐƠN HÀNG THÁNG";
            // 
            // ChiPhiHangThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1442, 839);
            this.Controls.Add(this.LB_BillHangThang);
            this.Controls.Add(this.BTN_ThemBill);
            this.Controls.Add(this.GGC_BillHangThang);
            this.Name = "ChiPhiHangThang";
            this.Text = "ChiPhiHangThang";
            this.Load += new System.EventHandler(this.ChiPhiHangThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GGC_BillHangThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl GGC_BillHangThang;
        private Guna.UI.WinForms.GunaGradientButton BTN_ThemBill;
        private System.Windows.Forms.Label LB_BillHangThang;
    }
}