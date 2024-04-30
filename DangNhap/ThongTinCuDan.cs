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
    public partial class ThongTinCuDan : Form
    {
        private CuDan parent;
        private ChuHo chuHo = null;
        private NguoiDcUyQuyenChuHo nguoiDcUyQuyen = null;
        private KhachNganNgay khachNganNgay = null;
        public ThongTinCuDan(CuDan parent, ChuHo chuHo)
        {
            InitializeComponent();
            this.parent = parent;
            this.chuHo = chuHo;
        }
        public ThongTinCuDan(CuDan parent, NguoiDcUyQuyenChuHo nguoiDcUyQuyen)
        {
            InitializeComponent();
            this.parent = parent;
            this.nguoiDcUyQuyen = nguoiDcUyQuyen;
        }
        public ThongTinCuDan(CuDan parent, KhachNganNgay khachNganNgay)
        {
            InitializeComponent();
            this.parent = parent;
            this.khachNganNgay = khachNganNgay;
        }
        public void DisplayChuHo()
        {
            TXB_macanho.Text = chuHo.MaCanHo;
            TXB_macd.Text = chuHo.MaCuDan;
            TXB_loaicd.Text = chuHo.LoaiCuDan;
            TXB_hovaten.Text = chuHo.HoTen;
            TXB_quoctich.Text = chuHo.QuocTich;
            DTP_ngaysinh.Value = chuHo.NgaySinh;
            TXB_madinhdanh.Text = chuHo.MaDinhDanh;
            TXB_sdt.Text = chuHo.SoDienThoai;
            TXB_email.Text = chuHo.Email;
            TXB_sothetamtru.Text = chuHo.SoTheTamTru;
            DTP_vao.Value = chuHo.NgayChuyenVao;
            if (chuHo.NgayChuyenDi != null)
            {
                DTP_di.Value = (DateTime)chuHo.NgayChuyenDi;
            }
            else
            {
                DTP_di.Visible = false;
            }
            DTP_bangiao.Value = chuHo.NgayNhanBanGiaoCanHo;
            TXB_diennuoc.Text = chuHo.SoDienNuocNgayBanGiao.ToString();
            TXB_tinhtrangcongno.Text = chuHo.TinhTrangCongNo.ToString();
            TXB_thunuoi.Text = chuHo.DuLieuDangKyThuNuoi;
            string cuDanLuuTruCung = ResidentBLL.Instance.GetNameOfMaCuDan(chuHo.MaCuDanLuuTruCung);
            if (!string.IsNullOrEmpty(cuDanLuuTruCung) )
            {
                TXB_nguoithan.Text = chuHo.MaCuDanLuuTruCung + "_" + cuDanLuuTruCung;
            }
            Vehicle phuongTien = VehicleBLL.Instance.GetVehicleByBienSo(chuHo.BienSoXeDangKy);
            TXB_bienso.Text = chuHo.BienSoXeDangKy;
            TXB_loaixe.Text = phuongTien.ChungLoai;
            TXB_tinhtrangxe.Text = phuongTien.TinhTrangSoHuu;
        }
        private void DisplayNguoiUyQuyen()
        {
            TXB_macanho.Text = nguoiDcUyQuyen.MaCanHo;
            TXB_macd.Text = nguoiDcUyQuyen.MaCuDan;
            TXB_loaicd.Text = nguoiDcUyQuyen.LoaiCuDan;
            TXB_hovaten.Text = nguoiDcUyQuyen.HoTen;
            TXB_quoctich.Text = nguoiDcUyQuyen.QuocTich;
            DTP_ngaysinh.Value = nguoiDcUyQuyen.NgaySinh;
            TXB_madinhdanh.Text = nguoiDcUyQuyen.MaDinhDanh;
            TXB_sdt.Text = nguoiDcUyQuyen.SoDienThoai;
            TXB_email.Text = nguoiDcUyQuyen.Email;
            TXB_sothetamtru.Text = nguoiDcUyQuyen.SoTheTamTru;
            DTP_vao.Value = nguoiDcUyQuyen.NgayChuyenVao;
            if (nguoiDcUyQuyen.NgayChuyenDi != null)
            {
                DTP_di.Value = (DateTime)nguoiDcUyQuyen.NgayChuyenDi;
            }
            else
            {
                DTP_di.Visible = false;
            }
            DTP_bangiao.Visible = false;
            TXB_diennuoc.Visible = false;
            TXB_tinhtrangcongno.Text = nguoiDcUyQuyen.TinhTrangCongNo.ToString();
            TXB_thunuoi.Text = nguoiDcUyQuyen.DuLieuDangKyThuNuoi;
            string cuDanLuuTruCung = ResidentBLL.Instance.GetNameOfMaCuDan(nguoiDcUyQuyen.MaCuDanLuuTruCung);
            if (!string.IsNullOrEmpty(cuDanLuuTruCung))
            {
                TXB_nguoithan.Text = nguoiDcUyQuyen.MaCuDanLuuTruCung + "_" + cuDanLuuTruCung;
            }
            Vehicle phuongTien = VehicleBLL.Instance.GetVehicleByBienSo(nguoiDcUyQuyen.BienSoXeDangKy);
            TXB_bienso.Text = nguoiDcUyQuyen.BienSoXeDangKy;
            TXB_loaixe.Text = phuongTien.ChungLoai;
            TXB_tinhtrangxe.Text = phuongTien.TinhTrangSoHuu;
        }
        private void DisplayKhachNganNgay()
        {
            TXB_macanho.Text = khachNganNgay.MaCanHo;
            TXB_macd.Text = khachNganNgay.MaCuDan;
            TXB_loaicd.Text = khachNganNgay.LoaiCuDan;
            TXB_hovaten.Text = khachNganNgay.HoTen;
            TXB_quoctich.Text = khachNganNgay.QuocTich;
            DTP_ngaysinh.Value = khachNganNgay.NgaySinh;
            TXB_madinhdanh.Text = khachNganNgay.MaDinhDanh;
            TXB_sdt.Text = khachNganNgay.SoDienThoai;
            TXB_email.Text = khachNganNgay.Email;
            TXB_sothetamtru.Text = khachNganNgay.SoTheTamTru;
            DTP_vao.Value = khachNganNgay.NgayChuyenVao;
            if (khachNganNgay.NgayChuyenDi != null)
            {
                DTP_di.Value = (DateTime)khachNganNgay.NgayChuyenDi;
            }
            else
            {
                DTP_di.Visible = false;
            }
            DTP_bangiao.Visible = false;
            TXB_diennuoc.Visible = false;
            TXB_tinhtrangcongno.Text = khachNganNgay.TinhTrangCongNo.ToString();
            TXB_thunuoi.Text = khachNganNgay.DuLieuDangKyThuNuoi;
            string cuDanLuuTruCung = ResidentBLL.Instance.GetNameOfMaCuDan(khachNganNgay.MaCuDanLuuTruCung);
            if (!string.IsNullOrEmpty(cuDanLuuTruCung))
            {
                TXB_nguoithan.Text = khachNganNgay.MaCuDanLuuTruCung + "_" + cuDanLuuTruCung;
            }
            Vehicle phuongTien = VehicleBLL.Instance.GetVehicleByBienSo(khachNganNgay.BienSoXeDangKy);
            TXB_bienso.Text = khachNganNgay.BienSoXeDangKy;
            TXB_loaixe.Text = phuongTien.ChungLoai;
            TXB_tinhtrangxe.Text = phuongTien.TinhTrangSoHuu;
        }

        private void BTN_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinCuDan_Load(object sender, EventArgs e)
        {
            if (chuHo != null && nguoiDcUyQuyen == null && khachNganNgay == null)
            {
                DisplayChuHo();
            }
            else if (chuHo == null && nguoiDcUyQuyen != null && khachNganNgay == null)
            {
                DisplayNguoiUyQuyen();
            }
            else if (chuHo == null && nguoiDcUyQuyen == null && khachNganNgay != null)
            {
                DisplayKhachNganNgay();
            }
        }

        private void BTN_xoa_Click(object sender, EventArgs e)
        {
            if (chuHo != null && nguoiDcUyQuyen == null && khachNganNgay == null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa cư dân này?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteMessage = ChuHoBLL.Instance.DeleteChuHo(chuHo.MaCuDan, chuHo.MaCanHo);
                    MessageBox.Show(deleteMessage);
                    Close();
                }
            }
            else if (chuHo == null && nguoiDcUyQuyen != null && khachNganNgay == null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa cư dân này?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteMessage = NguoiDcUyQuyenChuHoBLL.Instance.DeleteNguoiUyQuyen(nguoiDcUyQuyen.MaCuDan, nguoiDcUyQuyen.MaCanHo);
                    MessageBox.Show(deleteMessage);
                    Close();
                }
            }
            else if (chuHo == null && nguoiDcUyQuyen == null && khachNganNgay != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa cư dân này?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteMessage = KhachNganNgayBLL.Instance.DeleteKhachNganNgay(khachNganNgay.MaCuDan, khachNganNgay.MaCanHo);
                    MessageBox.Show(deleteMessage);
                    Close();
                }
            }
        }
    }
}
