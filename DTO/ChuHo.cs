using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuHo
    {
        public string MaCuDan {  get; set; }
        public string MaCanHo { get; set; }
        public string LoaiCuDan { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string MaDinhDanh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email {  get; set; }
        public string QuocTich {  get; set; }
        public string SoTheTamTru { get; set; }
        public DateTime NgayNhanBanGiaoCanHo { get; set; }
        public DateTime NgayChuyenVao {  get; set; }
        public DateTime? NgayChuyenDi {  get; set; }
        public float SoDienNuocNgayBanGiao {  get; set; }
        public string BienSoXeDangKy {  get; set; }
        public string MaCuDanBanGiao { get; set; }
        public string MaCuDanLuuTruCung {  get; set; }
        public int TinhTrangCongNo {  get; set; }
        public string DuLieuDangKyThuNuoi { get; set; }
        public ChuHo(string maCuDan, string maCanHo, string loaiCuDan, string hoTen, DateTime ngaySinh, string maDinhDanh, string soDienThoai, string email, string quocTich, string soTheTamTru, DateTime ngayNhanBanGiaoCanHo, DateTime ngayChuyenVao, DateTime? ngayChuyenDi, float soDienNuocNgayBanGiao, string bienSoXeDangKy, string maCuDanBanGiao, string maCuDanLuuTruCung, int tinhTrangCongNo, string duLieuDangKyThuNuoi)
        {
            MaCuDan = maCuDan;
            MaCanHo = maCanHo;
            LoaiCuDan = loaiCuDan;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            MaDinhDanh = maDinhDanh;
            SoDienThoai = soDienThoai;
            Email = email;
            QuocTich = quocTich;
            SoTheTamTru = soTheTamTru;
            NgayNhanBanGiaoCanHo = ngayNhanBanGiaoCanHo;
            NgayChuyenVao = ngayChuyenVao;
            NgayChuyenDi = ngayChuyenDi;
            SoDienNuocNgayBanGiao = soDienNuocNgayBanGiao;
            BienSoXeDangKy = bienSoXeDangKy;
            MaCuDanBanGiao = maCuDanBanGiao;
            MaCuDanLuuTruCung = maCuDanLuuTruCung;
            TinhTrangCongNo = tinhTrangCongNo;
            DuLieuDangKyThuNuoi = duLieuDangKyThuNuoi;
        }
    }
}
