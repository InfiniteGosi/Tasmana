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
    public partial class ThemNhom : Form
    {
        public ThemNhom()
        {
            InitializeComponent();
        }

        private void BTN_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Di chuyển form
        int mov;
        int movX;
        int movY;
        private void PN_nen_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void PN_nen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void PN_nen_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
