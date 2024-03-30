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
    public partial class ThongBao : Form
    {
        public ThongBao()
        {
            InitializeComponent();
        }

        private void BTN_biensoan_Click(object sender, EventArgs e)
        {
            SoanThongBao stb = new SoanThongBao();
            stb.Show();
        }
    }
}
