using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuGiaoDich
    {
        public string MaCanHo {  get; set; }
        public string MaCuDanHienTai {  get; set; }
        public string MaCuDanTruoc{ get; set; }
        public DateTime LichSuNopPhiDichVu { get; set; }
        public DateTime LichSuDangKyDoXe {  get; set; }
        public int TinhTrangCongNo { get; set; }
        public LichSuGiaoDich(string maCanHo, string maCuDanHienTai, string maCuDanTruoc, DateTime lichSuNopPhiDichVu, DateTime lichSuDangKyDoXe, int tinhTrangCongNo)
        {
            MaCanHo = maCanHo;
            MaCuDanHienTai = maCuDanHienTai;
            MaCuDanTruoc = maCuDanTruoc;
            LichSuNopPhiDichVu = lichSuNopPhiDichVu;
            LichSuDangKyDoXe = lichSuDangKyDoXe;
            TinhTrangCongNo = tinhTrangCongNo;
        }
    }
}
