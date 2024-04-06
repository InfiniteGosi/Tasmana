using BLL;
using DTO;
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
    public partial class TrangHienThi : Form
    {
        // Khởi tạo các giá trị, biến
        private int appTime; 
        public TrangHienThi()
        {
            InitializeComponent();
            LB_tendangnhap.Text = $"Xin chào, {DangNhap.currentAccount.EmployeeId} - {DangNhap.currentAccount.Level}";
            Timer_KTCongViec.Start();
            appTime = 0;
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

        private void BTN_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_thongtin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongTinCaNhan());
        }

        //MoveForm
        private int mov;
        private int movX;
        private int movY;
        private void TrangHienThi_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void TrangHienThi_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void TrangHienThi_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void BTN_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_square_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        // Thông báo khi sắp tới thời hạn hoàn thành công việc
        public DateTime tomorrowDay = DateTime.Today.AddDays(1); // Lấy thời gian là 1 ngày sau đó là mốc kiểm tra gaanf tới hạn hoàn thành
        int soCongViec = 0;
        private void Timer_KTCongViec_Tick(object sender, EventArgs e)
        {
            appTime++;

            if (appTime < Constraint.NotifyTime)
                return;

            string maNV = DangNhap.currentAccount.EmployeeId;
            List<Job> tomorowJobs = new List<Job>();
            tomorowJobs = JobBLL.Instance.GetJobOfEmployeeByDate(maNV, tomorrowDay.Date.ToString("yyyy-MM-dd"));
            if (tomorowJobs.Count > 0 && soCongViec != tomorowJobs.Count)
            {
                soCongViec = tomorowJobs.Count;
                NTFIcon_ThongBaoCV.ShowBalloonTip(Constraint.NotifyTimeOut, "Thông báo công việc chưa hoàn thành", string.Format("Bạn có {0} công việc sắp đến hạn vào ngày mai", soCongViec), ToolTipIcon.Info);
            }

            // reset timer
            appTime = 0;
        }
    }
}
