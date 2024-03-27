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
    public partial class ThemCongViecNhanVien : Form
    {
        public ThemCongViecNhanVien()
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
            PN_hienthithemcongviec.Controls.Add(childForm);
            PN_hienthithemcongviec.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BTN_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_nhanvien_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            BTN_nhom.BackColor = Color.Silver;
            BTN_nhom.ForeColor = Color.Black;
            BTN_nhanvien.BackColor = Color.FromArgb(40, 40, 40);
            BTN_nhanvien.ForeColor = Color.White;
            BTN_phongban.BackColor = Color.FromArgb(40, 40, 40);
            BTN_phongban.ForeColor = Color.White;
        }

        private void BTN_phongban_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemCongViecPhongBan());
            BTN_phongban.BackColor = Color.Silver;
            BTN_phongban.ForeColor = Color.Black;
            BTN_nhanvien.BackColor = Color.FromArgb(40, 40, 40);
            BTN_nhanvien.ForeColor = Color.White;
            BTN_nhom.BackColor = Color.FromArgb(40, 40, 40);
            BTN_nhom.ForeColor = Color.White;
        }

        private void BTN_nhom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemCongViecNhom());
            BTN_nhom.BackColor = Color.Silver;
            BTN_nhom.ForeColor = Color.Black;
            BTN_phongban.BackColor = Color.FromArgb(40, 40, 40);
            BTN_phongban.ForeColor = Color.White;
            BTN_nhanvien.BackColor = Color.FromArgb(40, 40, 40);
            BTN_nhanvien.ForeColor = Color.White;
        }
    }
}
