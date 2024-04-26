using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DTO
{
    public class KhuThuongMai : Apartment
    {
        public string MaNhanVienPhuTrach { get; set; }

        public KhuThuongMai(string maCanHo, float dienTichGSA, float dienTichNSA, int viTriTang, int soLuongPhongNgu, int soLuongToilet, Image soDoMatBang, int mucPhiQuanLyHangThang, int soLuongTheThangMay, LichSuGiaoDich lichSuGiaoDich, int tinhTrangThanhToan, string maCuDan, string maNhanVien)
            : base(maCanHo, dienTichGSA, dienTichNSA, viTriTang, soLuongPhongNgu, soLuongToilet, soDoMatBang, mucPhiQuanLyHangThang, soLuongTheThangMay, lichSuGiaoDich, tinhTrangThanhToan, maCuDan)
        {
            MaNhanVienPhuTrach = maNhanVien;
        }
        
    }
}
