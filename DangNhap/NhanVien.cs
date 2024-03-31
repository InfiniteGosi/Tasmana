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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void BTN_themnhanvien_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan ttcn = new ThongTinCaNhan();
            ttcn.Show();
        }
    }
}
