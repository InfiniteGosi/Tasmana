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
    }
}
