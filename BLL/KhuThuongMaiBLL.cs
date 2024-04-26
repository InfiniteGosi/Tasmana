using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace BLL
{
    public class KhuThuongMaiBLL
    {
        private static KhuThuongMaiBLL instance;
        public static KhuThuongMaiBLL Instance
        {
            get { if (instance == null) instance = new KhuThuongMaiBLL(); return instance; }
            private set { instance = value; }
        }
        private KhuThuongMaiBLL() { }
        private Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        public List<KhuThuongMai> GetAllKhuThuongMai()
        {
            DataTable dt = KhuThuongMaiDAO.Instance.GetAllKhuThuongMai();
            List<KhuThuongMai> arr = new List<KhuThuongMai>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maCanHo = dt.Rows[i]["maCanHo"].ToString();
                float dienTichGSA = dt.Rows[i]["dienTichGSA"] != DBNull.Value ? Convert.ToSingle(dt.Rows[i]["dienTichGSA"]) : 0.0f;
                float dienTichNSA = dt.Rows[i]["dienTichNSA"] != DBNull.Value ? Convert.ToSingle(dt.Rows[i]["dienTichNSA"]) : 0.0f;
                int viTriTang = (int)dt.Rows[i]["viTriTang"];
                int soLuongPhongNgu = (int)dt.Rows[i]["soLuongPhongNgu"];
                int soLuongToilet = (int)dt.Rows[i]["soLuongToilet"];
                Image soDoMatBang = dt.Rows[i]["soDoMatBang"] != DBNull.Value ? ConvertByteArrayToImage((byte[])dt.Rows[i]["soDoMatBang"]) : null;
                int mucPhiQLHangThang = (int)dt.Rows[i]["mucPhiQLHangThang"];
                int soLuongTheThangMay = (int)dt.Rows[i]["soLuongTheThangMay"];
                LichSuGiaoDichKhuThuongMai lichSuGiaoDich = LichSuGiaoDichKhuThuongMaiBLL.Instance.GetLichSuByKhuThuongMaiId(maCanHo);
                int tinhTrangThanhToan = (int)dt.Rows[i]["tinhTrangThanhToan"];
                string maKhachDangThue = dt.Rows[i]["maKhachDangThue"].ToString();
                KhuThuongMai khuThuongMai = new KhuThuongMai(maCanHo, dienTichGSA, dienTichNSA, viTriTang, soLuongPhongNgu, soLuongToilet, soDoMatBang, mucPhiQLHangThang, soLuongTheThangMay, lichSuGiaoDich, tinhTrangThanhToan, maKhachDangThue);
                arr.Add(khuThuongMai);
            }
            return arr;
        }
    }
}
