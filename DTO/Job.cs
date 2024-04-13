using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Công việc
    public class Job
    {
        public string MaCongViec {  get; set; }
        public string MaNhanVien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string NoiDung { get; set; }
        public string MaCanHo { get; set; }
        public DateTime NgayGiao { get; set; }
        public DateTime ThoiHan {  get; set; }
        public DateTime NgayHoanThanh { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu {  get; set; }
        public Job(string maCongViec, string noiDung, DateTime thoiHan, DateTime ngayHoanThanh ,string trangThai, string ghiChu)
        {
            MaCongViec = maCongViec;
            NoiDung = noiDung;
            ThoiHan = thoiHan;
            NgayHoanThanh = ngayHoanThanh;
            TrangThai = trangThai;
            GhiChu = ghiChu;
        }
        public Job(string maCongViec, string noiDung, DateTime ngayGiao, DateTime thoiHan, DateTime ngayHoanThanh, DateTime ngayCapNhat, string trangThai, string ghiChu)
        {
            MaCongViec = maCongViec;
            NoiDung = noiDung;
            NgayGiao = ngayGiao;
            ThoiHan = thoiHan;
            NgayHoanThanh = ngayHoanThanh;
            NgayCapNhat = ngayCapNhat;
            TrangThai = trangThai;
            GhiChu = ghiChu;
        }

        public Job(string maCongViec, string maNhanVien, string ho, string ten, string noiDung, string maCanHo, DateTime ngayGiao, DateTime ngayCapNhat, DateTime thoiHan, DateTime ngayHoanThanh, string trangThai, string ghiChu)
        {
            MaCongViec = maCongViec;
            MaNhanVien = maNhanVien;
            Ho = ho;
            Ten = ten;
            NoiDung = noiDung;
            MaCanHo = maCanHo;
            NgayGiao = ngayGiao;
            ThoiHan = thoiHan;
            NgayHoanThanh = ngayHoanThanh;
            NgayCapNhat = ngayCapNhat;
            TrangThai = trangThai;
            GhiChu = ghiChu;
        }
    }
}
