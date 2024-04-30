using BLL;
using DAO;
using DTO;
using Spire.Xls;
using Syncfusion.Windows.Shared;
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
    public partial class ThongTinKhachThueKTM : Form
    {
        private CuDan parent;
        private KhachThueKhuThuongMai khachKTM = null;
        public ThongTinKhachThueKTM(CuDan parent, KhachThueKhuThuongMai khachKTM)
        {
            InitializeComponent();
            this.parent = parent;
            this.khachKTM = khachKTM;
        }
        private void DisplayKhachKTM()
        {
            TXB_makhachthue.Text = khachKTM.MaKhachDangThue;
            TXB_tencongty.Text = khachKTM.TenCongTy;
            TXB_hotendaidien.Text = khachKTM.HoTenNguoiDaiDien;
            TXB_sdt.Text = khachKTM.SoDienThoai;
            TXB_email.Text = khachKTM.Email;
            DTP_ngaykyhd.Value = khachKTM.NgayKyHopDongThue;
            DTP_vao.Value = khachKTM.NgayChuyenVao;
            if (khachKTM.NgayChuyenDi != null)
            {
                DTP_di.Value = (DateTime)khachKTM.NgayChuyenDi;
            }
            TXB_mota.Text = khachKTM.MoTaKhuVucChoThue;
            NUD_phiql.Value = khachKTM.PhiQuanLy;
            Vehicle phuongTien = VehicleBLL.Instance.GetVehicleByBienSo(khachKTM.BienSoXeDangKy);
            TXB_bienso.Text = khachKTM.BienSoXeDangKy;
            TXB_loaixe.Text = phuongTien.ChungLoai;
            TXB_tinhtrangxe.Text = phuongTien.TinhTrangSoHuu;
        }

        private void BTN_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinCuDan_Load(object sender, EventArgs e)
        {
            DisplayKhachKTM();
        }
    }
}
