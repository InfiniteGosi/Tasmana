using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Resident
    {
        public string MaCuDan {  get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string MaDinhDanh {  get; set; }
        public string SoDienThoai {  get; set; }
        public string Email { get; set; }
        public string SoTheTamTru { get; set; }
        public DateTime NgayChuyenVao { get; set; }
        public DateTime NgayChuyenDi {  get; set; }
        public float SoDienNuocHangThang {  get; set; }
        public float TinhTrangCongNo {  get; set; }
        public string DuLieuDangKyThuNuoi { get; set; }
        public string QuocTich {  get; set; }
        public string MaCuDanNguoiThan {  get; set; }
        public Resident(string maCuDan, string hoTen, DateTime ngaySinh, string maDinhDanh, string soDienThoai, string email, string soTheTamTru, DateTime ngayChuyenVao, DateTime ngayChuyenDi, float soDienNuocHangThang, float tinhTrangCongNo, string duLieuDangKyThuNuoi, string quocTich, string maCuDanNguoiThan)
        {
            MaCuDan = maCuDan;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            MaDinhDanh = maDinhDanh;
            SoDienThoai = soDienThoai;
            Email = email;
            SoTheTamTru = soTheTamTru;
            NgayChuyenVao = ngayChuyenVao;
            NgayChuyenDi = ngayChuyenDi;
            SoDienNuocHangThang = soDienNuocHangThang;
            TinhTrangCongNo = tinhTrangCongNo;
            DuLieuDangKyThuNuoi = duLieuDangKyThuNuoi;
            QuocTich = quocTich;
            MaCuDanNguoiThan = maCuDanNguoiThan;
        }
    }
}
