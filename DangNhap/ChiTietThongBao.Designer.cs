namespace DangNhap
{
    partial class ChiTietThongBao
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
            this.TXB_title = new System.Windows.Forms.TextBox();
            this.LB_author = new System.Windows.Forms.Label();
            this.TXB_content = new System.Windows.Forms.RichTextBox();
            this.LLB_hienfile = new System.Windows.Forms.LinkLabel();
            this.LB_filedinhkem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXB_title
            // 
            this.TXB_title.Enabled = false;
            this.TXB_title.Location = new System.Drawing.Point(12, 12);
            this.TXB_title.Name = "TXB_title";
            this.TXB_title.Size = new System.Drawing.Size(776, 22);
            this.TXB_title.TabIndex = 0;
            // 
            // LB_author
            // 
            this.LB_author.AutoSize = true;
            this.LB_author.Location = new System.Drawing.Point(12, 37);
            this.LB_author.Name = "LB_author";
            this.LB_author.Size = new System.Drawing.Size(44, 16);
            this.LB_author.TabIndex = 1;
            this.LB_author.Text = "label1";
            // 
            // TXB_content
            // 
            this.TXB_content.Enabled = false;
            this.TXB_content.Location = new System.Drawing.Point(12, 56);
            this.TXB_content.Name = "TXB_content";
            this.TXB_content.Size = new System.Drawing.Size(778, 350);
            this.TXB_content.TabIndex = 3;
            this.TXB_content.Text = "";
            // 
            // LLB_hienfile
            // 
            this.LLB_hienfile.AutoSize = true;
            this.LLB_hienfile.LinkColor = System.Drawing.Color.Black;
            this.LLB_hienfile.Location = new System.Drawing.Point(114, 425);
            this.LLB_hienfile.Name = "LLB_hienfile";
            this.LLB_hienfile.Size = new System.Drawing.Size(0, 16);
            this.LLB_hienfile.TabIndex = 4;
            this.LLB_hienfile.Visible = false;
            this.LLB_hienfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLB_hienfile_LinkClicked);
            // 
            // LB_filedinhkem
            // 
            this.LB_filedinhkem.AutoSize = true;
            this.LB_filedinhkem.Location = new System.Drawing.Point(9, 425);
            this.LB_filedinhkem.Name = "LB_filedinhkem";
            this.LB_filedinhkem.Size = new System.Drawing.Size(89, 16);
            this.LB_filedinhkem.TabIndex = 5;
            this.LB_filedinhkem.Text = "File đính kèm:";
            // 
            // ChiTietThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.LB_filedinhkem);
            this.Controls.Add(this.LLB_hienfile);
            this.Controls.Add(this.TXB_content);
            this.Controls.Add(this.LB_author);
            this.Controls.Add(this.TXB_title);
            this.Name = "ChiTietThongBao";
            this.Text = "ChiTietThongBao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_title;
        private System.Windows.Forms.Label LB_author;
        private System.Windows.Forms.RichTextBox TXB_content;
        private System.Windows.Forms.LinkLabel LLB_hienfile;
        private System.Windows.Forms.Label LB_filedinhkem;
    }
}