
namespace Project
{
    partial class Exit
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
            this.LB_Exit = new System.Windows.Forms.Label();
            this.BT_KetThuc = new System.Windows.Forms.Button();
            this.BT_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Exit
            // 
            this.LB_Exit.AutoSize = true;
            this.LB_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Exit.Location = new System.Drawing.Point(95, 19);
            this.LB_Exit.Name = "LB_Exit";
            this.LB_Exit.Size = new System.Drawing.Size(180, 22);
            this.LB_Exit.TabIndex = 0;
            this.LB_Exit.Text = "Kết thúc chương trình";
            // 
            // BT_KetThuc
            // 
            this.BT_KetThuc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_KetThuc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_KetThuc.Location = new System.Drawing.Point(60, 80);
            this.BT_KetThuc.Name = "BT_KetThuc";
            this.BT_KetThuc.Size = new System.Drawing.Size(98, 44);
            this.BT_KetThuc.TabIndex = 1;
            this.BT_KetThuc.Text = "Kết Thúc";
            this.BT_KetThuc.UseVisualStyleBackColor = false;
            this.BT_KetThuc.Click += new System.EventHandler(this.BT_KetThuc_Click);
            // 
            // BT_Huy
            // 
            this.BT_Huy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_Huy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_Huy.Location = new System.Drawing.Point(218, 80);
            this.BT_Huy.Name = "BT_Huy";
            this.BT_Huy.Size = new System.Drawing.Size(98, 44);
            this.BT_Huy.TabIndex = 2;
            this.BT_Huy.Text = "Hủy";
            this.BT_Huy.UseVisualStyleBackColor = false;
            this.BT_Huy.Click += new System.EventHandler(this.BT_Huy_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 148);
            this.Controls.Add(this.BT_Huy);
            this.Controls.Add(this.BT_KetThuc);
            this.Controls.Add(this.LB_Exit);
            this.Name = "Exit";
            this.Text = "Exit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Exit;
        private System.Windows.Forms.Button BT_KetThuc;
        private System.Windows.Forms.Button BT_Huy;
    }
}