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
        private int mov;
        private int movX;
        private int movY;
        public Home()
        {
            InitializeComponent();
            LB_tendangnhap.Text = $"Xin chào {DangNhap.currentAccount.EmployeeId} bạn là {DangNhap.currentAccount.Level}";
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            currentFormChild?.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PN_main.Controls.Add(childForm);
            PN_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BTN_thongbao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongBao());
            BTN_thongbao.BackColor = Color.Gray;
            BTN_congviec.BackColor = Color.Transparent;
            BTN_thongke.BackColor = Color.Transparent;
            BTN_nhanvien.BackColor = Color.Transparent;
            BTN_cudan.BackColor = Color.Transparent;
            BTN_canho.BackColor = Color.Transparent;
        }

        private void BTN_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
            BTN_thongke.BackColor = Color.Gray;
            BTN_congviec.BackColor = Color.Transparent;
            BTN_thongbao.BackColor = Color.Transparent;
            BTN_nhanvien.BackColor = Color.Transparent;
            BTN_cudan.BackColor = Color.Transparent;
            BTN_canho.BackColor = Color.Transparent;
        }

        private void BTN_congviec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CongViecChung());
            BTN_congviec.BackColor = Color.Gray;
            BTN_thongbao.BackColor = Color.Transparent;
            BTN_thongke.BackColor = Color.Transparent;
            BTN_nhanvien.BackColor = Color.Transparent;
            BTN_cudan.BackColor = Color.Transparent;
            BTN_canho.BackColor = Color.Transparent;
        }

        private void BTN_canho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CanHo());
            BTN_canho.BackColor = Color.Gray;
            BTN_thongbao.BackColor = Color.Transparent;
            BTN_thongke.BackColor = Color.Transparent;
            BTN_nhanvien.BackColor = Color.Transparent;
            BTN_cudan.BackColor = Color.Transparent;
            BTN_congviec.BackColor = Color.Transparent;
        }

        private void BTN_cudan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CuDan());
            BTN_cudan.BackColor = Color.Gray;
            BTN_thongbao.BackColor = Color.Transparent;
            BTN_thongke.BackColor = Color.Transparent;
            BTN_nhanvien.BackColor = Color.Transparent;
            BTN_canho.BackColor = Color.Transparent;
            BTN_congviec.BackColor = Color.Transparent;
        }

        private void BTN_nhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
            BTN_nhanvien.BackColor = Color.Gray;
            BTN_thongbao.BackColor = Color.Transparent;
            BTN_thongke.BackColor = Color.Transparent;
            BTN_cudan.BackColor = Color.Transparent;
            BTN_canho.BackColor = Color.Transparent;
            BTN_congviec.BackColor = Color.Transparent;
        }

        private void BTN_thongtin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinCaNhan());
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
                WindowState = FormWindowState.Normal;
            }
        }

        private void BTN_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void LOGOishere_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
    }
}
