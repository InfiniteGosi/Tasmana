using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class SoanThongBao : Form
    {
        public SoanThongBao()
        {
            InitializeComponent();
        }
        //Di chuyển form
        int mov;
        int movX;
        int movY;
        private void SoanThongBao_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void SoanThongBao_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void SoanThongBao_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void BTN_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
