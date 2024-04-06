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
        public string NoiDung { get; set; }
        public DateTime ThoiHan {  get; set; }
        public DateTime NgayHoanThanh { get; set; }
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
    }
}
