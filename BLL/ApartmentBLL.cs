using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Drawing;
using System.IO;

namespace BLL
{
    public class ApartmentBLL
    {
        private static ApartmentBLL instance;
        public static ApartmentBLL Instance
        {
            get { if (instance == null) instance = new ApartmentBLL(); return instance; }
            private set { instance = value; }
        }
        private ApartmentBLL() { }
        private Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        public List<Apartment> GetApartmentList()
        {
            DataTable dt = ApartmentDAO.Instance.GetAllApartments();
            List<Apartment> apartments = new List<Apartment>();
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
                LichSuGiaoDich lichSuGiaoDich = LichSuGiaoDichBLL.Instance.GetLichSuByApartmentId(maCanHo);
                string tinhTrangGDHienTai = dt.Rows[i]["tinhTrangGDHienTai"].ToString();
                int tinhTrangThanhToan = (int)dt.Rows[i]["tinhTrangThanhToan"];
                string maCuDan = dt.Rows[i]["maCuDan"].ToString();
                Apartment apartment = new Apartment(maCanHo, dienTichGSA, dienTichNSA, viTriTang, soLuongToilet, soLuongPhongNgu, soDoMatBang, mucPhiQLHangThang, soLuongTheThangMay, lichSuGiaoDich, tinhTrangGDHienTai, tinhTrangThanhToan, maCuDan);
                apartments.Add(apartment);
            }
            return apartments;
        }
        public Apartment GetApartmentById(string maCanHo)
        {
            DataTable dt = ApartmentDAO.Instance.GetApartmentById(maCanHo);
            float dienTichGSA = dt.Rows[0]["dienTichGSA"] != DBNull.Value ? Convert.ToSingle(dt.Rows[0]["dienTichGSA"]) : 0.0f;
            float dienTichNSA = dt.Rows[0]["dienTichNSA"] != DBNull.Value ? Convert.ToSingle(dt.Rows[0]["dienTichNSA"]) : 0.0f;
            int viTriTang = (int)dt.Rows[0]["viTriTang"];
            int soLuongPhongNgu = (int)dt.Rows[0]["soLuongPhongNgu"];
            int soLuongToilet = (int)dt.Rows[0]["soLuongToilet"];
            Image soDoMatBang = dt.Rows[0]["soDoMatBang"] != DBNull.Value ? ConvertByteArrayToImage((byte[])dt.Rows[0]["soDoMatBang"]) : null;
            int mucPhiQLHangThang = (int)dt.Rows[0]["mucPhiQLHangThang"];
            int soLuongTheThangMay = (int)dt.Rows[0]["soLuongTheThangMay"];
            LichSuGiaoDich lichSuGiaoDich = LichSuGiaoDichBLL.Instance.GetLichSuByApartmentId(maCanHo);
            string tinhTrangGDHienTai = dt.Rows[0]["tinhTrangGDHienTai"].ToString();
            int tinhTrangThanhToan = (int)dt.Rows[0]["tinhTrangThanhToan"];
            string maCuDan = dt.Rows[0]["maCuDan"].ToString();
            Apartment apartment = new Apartment(maCanHo, dienTichGSA, dienTichNSA, viTriTang, soLuongToilet, soLuongPhongNgu, soDoMatBang, mucPhiQLHangThang, soLuongTheThangMay, lichSuGiaoDich, tinhTrangGDHienTai, tinhTrangThanhToan, maCuDan);
            return apartment;
        }
        public string UpdateApartment(Dictionary<string, object> parameters)
        {
            if (ApartmentDAO.Instance.UpdateApartment(parameters))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
        public bool AddMonthlyBill(Dictionary<string, object> parameters)
        {
            return ApartmentDAO.Instance.AddMonthlyBill(parameters);
        }
        public DataTable GetMonthlyBill()
        {
            return ApartmentDAO.Instance.GetMonthlyBill();
        }
        public bool EditMonthlyBill(Dictionary<string, object> parameters)
        {
            return ApartmentDAO.Instance.EditMonthlyBill(parameters);
        }
    }
}
