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
using BLL;

namespace DangNhap
{
    public partial class ChiTietKhuThuongMai : Form
    {
        private CanHo parent;
        private string maKhuThuongMaiHienTai;
        private KhuThuongMai khuThuongMai;
        private KhachThueKhuThuongMai khachThue;
        public ChiTietKhuThuongMai()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        public ChiTietKhuThuongMai(CanHo parent, string maCanHo)
        {
            InitializeComponent();
            this.parent = parent;
            this.maKhuThuongMaiHienTai = maCanHo;
            this.FormClosing += new FormClosingEventHandler(this.ChiTietKhuThuongMai_FormClosing);
            GetKhuThuongMaiById(maKhuThuongMaiHienTai);
        }
        private void GetKhuThuongMaiById(string maKhuThuongMai)
        {
            khuThuongMai = KhuThuongMaiBLL.Instance.GetKhuThuongMaiById(maKhuThuongMai);
        }
        private void GetKhachThueById(string maKhachDangThue)
        {
            khachThue = KhachThueKhuThuongMaiBLL.Instance.GetKhachThueById(maKhachDangThue);
        }
        private void DisplayKTMInfo()
        {
            GetKhuThuongMaiById(maKhuThuongMaiHienTai);
            GetKhachThueById(khuThuongMai.MaKhachDangThue);
            TXB_macanho.Text = maKhuThuongMaiHienTai;
            NUD_vitritang.Value = khuThuongMai.ViTriTang;
            NUD_vitritang.Value = khuThuongMai.ViTriTang;
            NUD_toilet.Value = khuThuongMai.SoLuongToilet;
            NUD_phongngu.Value = khuThuongMai.SoLuongPhongNgu;
            NUD_thangmay.Value = khuThuongMai.SoLuongTheThangMay;
            NUD_mucphiql.Value = khuThuongMai.MucPhiQuanLyHangThang;
            NUD_thanhtoan.Value = khuThuongMai.TinhTrangThanhToan;
            TXB_GSA.Text = khuThuongMai.DienTichGSA.ToString();
            TXB_NSA.Text = khuThuongMai.DienTichNSA.ToString();
            TXB_khachdangthue.Text = khuThuongMai.MaKhachDangThue + "_" + khachThue.HoTenNguoiDaiDien;
            if (khuThuongMai.SoDoMatBang != null)
                PB_hinhcanho.Image = khuThuongMai.SoDoMatBang;
            else
                PB_hinhcanho.Image = Properties.Resources.DefaulCanHoImage;
        }

        private void OpenChildForm(Form childForm)
        {
            currentFormChild?.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PN_hienthi.Controls.Add(childForm);
            PN_hienthi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //MoveForm
        int mov;
        int movX;
        int movY;
        private void KhuThuongMai_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void KhuThuongMai_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void KhuThuongMai_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void BTN_chung_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            BTN_chung.BackColor = Color.FromArgb(51, 53, 55);
            BTN_lichsu.BackColor = Color.Transparent;
        }

        private void BTN_lichsu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LichSuKhuThuongMai(khuThuongMai));
            BTN_lichsu.BackColor = Color.FromArgb(51, 53, 55);
            BTN_chung.BackColor = Color.Transparent;
        }

        private void ChiTietKhuThuongMai_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BTN_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChiTietKhuThuongMai_Load(object sender, EventArgs e)
        {
            DisplayKTMInfo();
        }
    }
}
