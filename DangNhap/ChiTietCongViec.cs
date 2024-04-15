using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class ChiTietCongViec : Form
    {
        //
        int mov;
        int movX;
        int movY;
        public ChiTietCongViec()
        {
            InitializeComponent();
        }

        private void ChiTietCongViec_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void ChiTietCongViec_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void ChiTietCongViec_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void BTN_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_themcongviec_Click(object sender, EventArgs e)
        {
            ThemCongViecNhanVien tcv = new ThemCongViecNhanVien();
            tcv.Show();
        }

        private bool GetNgayHoanThanhCongViec()
        {
            if (CBB_TrangThai.Text.Equals("Hoàn thành"))
            {
                return true;
            }
            return false;
        }

        private Dictionary<string, object> AddParameterEdit_Job()
        {
            DateTime combinedDateTime = DTP_ngay.Value.Date + DTP_gio.Value.TimeOfDay;
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@maCongViec", TXB_MaCV.Text},
                {"@noiDung", TXB_noidung.Text},
                {"@thoiHan", combinedDateTime}, // Combine Date and Time components
                {"@ngayHoanThanh", GetNgayHoanThanhCongViec() ? (object)DateTime.UtcNow.ToLocalTime() : null}, // Use DateTime directly
                {"@ngayCapNhat", DateTime.UtcNow},
                {"trangThai", CBB_TrangThai.SelectedItem.ToString()},
                {"@ghiChu", TXB_GhiChu.Text}
            };
            return dict;
        }
        private void BTN_luu_Click(object sender, EventArgs e)
        {
            if (JobBLL.Instance.EditJobOfEmployee(AddParameterEdit_Job()))
            {
                MessageBox.Show("Chỉnh sửa thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại");
                //this.Close();
            }
        }

        private Dictionary<string, object> AddParameterDeleteJobOfEmployee()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@maCongViec", TXB_MaCV.Text},
            };
            return dict;
        }
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (JobBLL.Instance.DeleteJobOfEmployee(AddParameterDeleteJobOfEmployee()))
            {
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
