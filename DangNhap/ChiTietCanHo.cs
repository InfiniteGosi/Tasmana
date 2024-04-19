﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class ChiTietCanHo : Form
    {
        private CanHo parent;
        private string maCanHoHienTai;
        private Apartment canHoHienTai;
        private Resident cuDanCuaCanHo;
        private readonly string[] arrLoai = { "PENTHOUSE", "01", "02", "03", "04", "04", "05", "06", "07", "08", "09", "10", "11" };
        private readonly string[] arrTinhTrang = { "Chưa bán", "Đã bán", "Chưa bàn giao - Cư dân đang ở", "Đã bàn giao - trống" };
        public ChiTietCanHo()
        {
            InitializeComponent();
        }
        public ChiTietCanHo(CanHo parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        public ChiTietCanHo(CanHo parent, string maCanHo)
        {
            InitializeComponent();
            this.parent = parent;
            this.maCanHoHienTai = maCanHo;
            this.FormClosing += new FormClosingEventHandler(this.ChiTietCanHo_FormClosing);
            GetApartmentById(maCanHoHienTai);
        }
        private void GetApartmentById(string maCanHo)
        {
            canHoHienTai = ApartmentBLL.Instance.GetApartmentById(maCanHo);
        }
        private void GetResidentByApartmentId(string maCanHo)
        {
            cuDanCuaCanHo = ResidentBLL.Instance.GetResidentByApartmentId(maCanHo);
        }

        private Form currentFormChild;

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

        private void BTN_lichsu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LichSuCanHo());
            BTN_lichsu.BackColor = Color.FromArgb(51, 53, 55);
            BTN_chung.BackColor = Color.Transparent;
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

        private object[] values_ch;
        private void InitializeValues_CH()
        {
            values_ch = new object[]
            {
                TXB_macanho.Text,

            };
        }
        // Do not delete
        private void ChiTietCanHo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private int GetNoOfRoomsUsingApartmentId(string maCanHo)
        {
            // Lấy 2 ký tự cuối của mã căn hộ
            string last2Characters = maCanHo.Substring(Math.Max(0, maCanHo.Length - 2));
            switch (last2Characters)
            {
                case "01":
                case "02":
                case "07":
                case "08":
                case "11":
                    return 3;
                case "04":
                case "05":
                    return 2;
                case "03":
                case "09":
                case "10":
                    return 1;
                default:
                    return 5;
            }
        }
        private string GetApartmentType(string maCanHo)
        {
            string last2Characters = maCanHo.Substring(Math.Max(0, maCanHo.Length - 2));
            if (last2Characters == "HA" || last2Characters == "HB" ||
                last2Characters == "HC" || last2Characters == "HD")
            {
                return "PENTHOUSE";
            }
            return last2Characters;
        }
        private void DisplayApartmenInfo()
        {
            GetApartmentById(maCanHoHienTai);
            GetResidentByApartmentId(maCanHoHienTai);
            if (canHoHienTai != null)
            {
                TXB_macanho.Text = maCanHoHienTai;
                TXB_chuho.Text = cuDanCuaCanHo.HoTen;
                NUD_toilet.Value = canHoHienTai.SoLuongToilet;
                NUD_phongngu.Value = GetNoOfRoomsUsingApartmentId(maCanHoHienTai);
                NUD_thangmay.Value = canHoHienTai.SoLuongTheThangMay;
                TXB_phiql.Text = canHoHienTai.MucPhiQuanLyHangThang.ToString();
                CBB_loai.SelectedIndex = Array.IndexOf(arrLoai, GetApartmentType(maCanHoHienTai));
            }
        }

        private void ChiTietCanHo_Load(object sender, EventArgs e)
        {
            CBB_tinhtrang.DataSource = arrTinhTrang;
            CBB_loai.DataSource = arrLoai;
            CBB_tinhtrang.SelectedIndex = -1;
            CBB_loai.SelectedIndex = -1;
            if (canHoHienTai != null)
            {
                DisplayApartmenInfo();
            }
        }
        private void BTN_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //MoveForm
        int mov;
        int movX;
        int movY;

        private void ChiTietCanHo_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void ChiTietCanHo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void ChiTietCanHo_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
