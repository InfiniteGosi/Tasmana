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
    public partial class CanHo : Form
    {
        public CanHo()
        {
            InitializeComponent();
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            ChiTietCanHo ctch = new ChiTietCanHo();
            ctch.Show();
        }
    }
}
