using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhap.Model
{
    public class Employee
    {
        public string Email { get; set; }
        public string Ho {  get; set; }
        public string Ten { get; set; }
        public string MaNhanVien { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string QueQuan {  get; set; }
        public string MaDinhDanh { get; set; }
        public string LoaiNhanVien { get; set; }
        public string TinhTrangHonNhan {  get; set; }
        public string MaSoBHXH {  get; set; }
        public DateTime NgayKyHDLD { get; set; }
        public DateTime NgayHetHDLD { get; set; }
        public string DiaChiThuongTru {  get; set; }
        public string DiaChiTamTru { get; set; }
        public string TinhTranHDLD { get; set; }
        public string MaBoPhan {  get; set; }
        public string MaNhom {  get; set; }
        public Account TaiKhoanNguoiDung {  get; set; }
        public List<Job> CongViec {  get; set; }

    }
}
