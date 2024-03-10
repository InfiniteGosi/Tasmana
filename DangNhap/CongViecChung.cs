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
    public partial class CongViecChung : Form
    {
        public CongViecChung()
        {
            InitializeComponent();
        }

        private void btn_themcv_Click(object sender, EventArgs e)
        {
            ThemCongViec tcv = new ThemCongViec();
            tcv.Show();
        }
    }
}
