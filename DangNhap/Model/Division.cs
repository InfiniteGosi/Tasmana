using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhap.Model
{
    // Phòng ban
    public class Division
    {
        public string MaBoPhan {  get; set; }
        public string TenBoPhan { get; set; }
        public string MaTruongPhong { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public List<Group> DanhSachNhom {  get; set; }

        public Division(string maBoPhan, string tenBoPhan, string maTruongPhong, string soDienThoai, string email, List<Group> danhSachNhom)
        {
            MaBoPhan = maBoPhan;
            TenBoPhan = tenBoPhan;
            MaTruongPhong = maTruongPhong;
            SoDienThoai = soDienThoai;
            Email = email;
            DanhSachNhom = danhSachNhom;
        }
    }
}
