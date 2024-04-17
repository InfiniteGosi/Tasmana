using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Drawing;

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
        public List<Apartment> GetApartmentList()
        {
            DataTable dt = ApartmentDAO.Instance.GetAllApartments();
            List<Apartment> apartments = new List<Apartment>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maCanHo = dt.Rows[i]["maCanHo"].ToString();
                float dienTich = dt.Rows[i]["dienTich"] != DBNull.Value ? Convert.ToSingle(dt.Rows[i]["dienTich"]) : 0.0f;
                int viTriTang = (int)dt.Rows[i]["viTriTang"];
                int soLuongPhongNgu = (int)dt.Rows[i]["soLuongPhongNgu"];
                int soLuongToilet = (int)dt.Rows[i]["soLuongToilet"];
                Image soDoMatBang = dt.Rows[i]["soDoMatBang"] != DBNull.Value ? (Image)dt.Rows[i]["soDoMatBang"] : null;
                int mucPhiQLHangThang = (int)dt.Rows[i]["mucPhiQLHangThang"];
                int soLuongTheThangMay = (int)dt.Rows[i]["soLuongTheThangMay"];
                DateTime lichSuGiaoDich = (DateTime)dt.Rows[i]["lichSuGiaoDich"];
                string tinhTrangGDHienTai = dt.Rows[i]["tinhTrangGDHienTai"].ToString();
                string maCuDan = dt.Rows[i]["maCuDan"].ToString();
                Apartment apartment = new Apartment(maCanHo, dienTich, viTriTang, soLuongToilet, soLuongPhongNgu, soDoMatBang, mucPhiQLHangThang, soLuongTheThangMay, lichSuGiaoDich, tinhTrangGDHienTai, maCuDan);
                apartments.Add(apartment);
            }
            return apartments;
        }
        public Apartment GetApartmentById(string maCanHo)
        {
            DataTable dt = ApartmentDAO.Instance.GetApartmentById(maCanHo);
            float dienTich = dt.Rows[0]["dienTich"] != DBNull.Value ? Convert.ToSingle(dt.Rows[0]["dienTich"]) : 0.0f;
            int viTriTang = (int)dt.Rows[0]["viTriTang"];
            int soLuongPhongNgu = (int)dt.Rows[0]["soLuongPhongNgu"];
            int soLuongToilet = (int)dt.Rows[0]["soLuongToilet"];
            Image soDoMatBang = dt.Rows[0]["soDoMatBang"] != DBNull.Value ? (Image)dt.Rows[0]["soDoMatBang"] : null;
            int mucPhiQLHangThang = (int)dt.Rows[0]["mucPhiQLHangThang"];
            int soLuongTheThangMay = (int)dt.Rows[0]["soLuongTheThangMay"];
            DateTime lichSuGiaoDich = (DateTime)dt.Rows[0]["lichSuGiaoDich"];
            string tinhTrangGDHienTai = dt.Rows[0]["tinhTrangGDHienTai"].ToString();
            string maCuDan = dt.Rows[0]["maCuDan"].ToString();
            Apartment apartment = new Apartment(maCanHo, dienTich, viTriTang, soLuongToilet, soLuongPhongNgu, soDoMatBang, mucPhiQLHangThang, soLuongTheThangMay, lichSuGiaoDich, tinhTrangGDHienTai, maCuDan);
            return apartment;
        }
        public string AddApartment(Dictionary<string, object> parameters)
        {
            if (ApartmentDAO.Instance.AddApartment(parameters))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
    }
}
