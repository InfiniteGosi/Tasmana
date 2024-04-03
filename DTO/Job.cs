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
        public string TrangThai { get; set; }
        public Job(string maCongViec, string noiDung, DateTime thoiHan, string trangThai)
        {
            MaCongViec = maCongViec;
            NoiDung = noiDung;
            ThoiHan = thoiHan;
            TrangThai = trangThai;
        }
    }
}
