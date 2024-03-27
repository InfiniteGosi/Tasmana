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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PN_main.Controls.Add(childForm);
            PN_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BTN_trangchu_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
        private void BTN_thongbao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongBao());
        }
        private void BTN_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
        }
        private void BTN_congviec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CongViecChung());
        }
        private void BTN_canho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CanHo());
        }
        private void BTN_cudan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CuDan());
        }
        private void BTN_nhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
        }
        private void BTN_thongtin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinCaNhan());
        }
        private void BTN_xem_Click(object sender, EventArgs e)
        {
            HeThongBanDo htbd = new HeThongBanDo();
            htbd.Show();
        }

        private void BTN_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_square_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
    }
}
