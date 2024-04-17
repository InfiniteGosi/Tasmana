using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DTO
{
    public class Apartment
    {
        public string MaCanHo {  get; set; }
        public float DienTich { get; set; }
        public int ViTriTang { get; set; }
        public int SoLuongPhongNgu { get; set; }
        public int SoLuongToilet { get; set; }
        public Image SoDoMatBang { get; set; }
        public float MucPhiQuanLyHangThang {  get; set; }
        public int SoLuongTheThangMay {  get; set; }
        public DateTime LichSuGiaoDich {  get; set; }
        public string TinhTrangGiaoDichHienTai { get; set; }
        public string MaCuDan {  get; set; }

        public Apartment(string maCanHo, float dienTich, int viTriTang, int soLuongToilet, int soLuongPhongNgu, Image soDoMatBang, float mucPhiQuanLyHangThang, int soLuongTheThangMay, DateTime lichSuGiaoDich, string tinhTrangGiaoDichHienTai, string maCuDan)
        {
            MaCanHo = maCanHo;
            DienTich = dienTich;
            ViTriTang = viTriTang;
            SoLuongToilet = soLuongToilet;
            SoLuongPhongNgu = soLuongPhongNgu;
            SoDoMatBang = soDoMatBang;
            MucPhiQuanLyHangThang = mucPhiQuanLyHangThang;
            SoLuongTheThangMay = soLuongTheThangMay;
            LichSuGiaoDich = lichSuGiaoDich;
            TinhTrangGiaoDichHienTai = tinhTrangGiaoDichHienTai;
            MaCuDan = maCuDan;
        }
    }
}
