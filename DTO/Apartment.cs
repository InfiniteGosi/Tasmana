using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Apartment
    {
        public string MaCanHo {  get; set; }
        public float DienTich { get; set; }
        public int ViTriTang { get; set; }
        public int SoLuongToilet { get; set; }
        public int SoLuongPhongNgu { get; set; }
        public float SoDoMatBang { get; set; }
        public float MucPhiQuanLyHangThang {  get; set; }
        public int SoLuongTheThangMay {  get; set; }
        public string TinhTrangGiaoDichHienTai { get; set; }
        public string MaCuDan {  get; set; }
        public string MaKhuVucThue {  get; set; }

        public Apartment(string maCanHo, float dienTich, int viTriTang, int soLuongToilet, int soLuongPhongNgu, float soDoMatBang, float mucPhiQuanLyHangThang, int soLuongTheThangMay, string tinhTrangGiaoDichHienTai, string maCuDan, string maKhuVucThue)
        {
            MaCanHo = maCanHo;
            DienTich = dienTich;
            ViTriTang = viTriTang;
            SoLuongToilet = soLuongToilet;
            SoLuongPhongNgu = soLuongPhongNgu;
            SoDoMatBang = soDoMatBang;
            MucPhiQuanLyHangThang = mucPhiQuanLyHangThang;
            SoLuongTheThangMay = soLuongTheThangMay;
            TinhTrangGiaoDichHienTai = tinhTrangGiaoDichHienTai;
            MaCuDan = maCuDan;
            MaKhuVucThue = maKhuVucThue;
        }
    }
}
