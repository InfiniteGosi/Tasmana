using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ResidentBLL
    {
        private static ResidentBLL instance;
        public static ResidentBLL Instance
        {
            get { if (instance == null) instance = new ResidentBLL(); return instance; }
            private set { instance = value; }
        }
        private ResidentBLL() { }
        public Resident GetResidentByApartmentId(string maCanHo)
        {
            DataTable dt = ResidentDAO.Instance.GetResidentByApartmentId(maCanHo);
            if (dt.Rows.Count > 0)
            {
                string maCuDan = dt.Rows[0]["maCuDan"].ToString();
                string hoTen = dt.Rows[0]["hoTen"].ToString();
                DateTime ngaySinh = (DateTime)dt.Rows[0]["ngaySinh"];
                string maDinhDanh = dt.Rows[0]["maDinhDanh"].ToString();
                string soDienThoai = dt.Rows[0]["SDT"].ToString();
                string email = dt.Rows[0]["email"].ToString();
                string soTheTamTru = dt.Rows[0]["soTheTamTru"].ToString();
                DateTime ngayChuyenVao = (DateTime)dt.Rows[0]["ngayChuyenVao"];
                DateTime ngayChuyenDi = (DateTime)dt.Rows[0]["ngayChuyenDi"];
                float soDienNuocHangThang = dt.Rows[0]["soDienNuocHangThang"] != DBNull.Value ? Convert.ToSingle(dt.Rows[0]["soDienNuocHangThang"]) : 0.0f;
                float tinhTrangCongNo = dt.Rows[0]["tinhTrangCongNo"] != DBNull.Value ? Convert.ToSingle(dt.Rows[0]["tinhTrangCongNo"]) : 0.0f;
                string duLieuDangKyThuNuoi = dt.Rows[0]["duLieuDangKyThuNuoi"].ToString();
                string quocTich = dt.Rows[0]["quocTich"].ToString();
                string maCuDanNguoiThan = dt.Rows[0]["maCuDanNguoiThan"].ToString();
                return new Resident(maCuDan, hoTen, ngaySinh, maDinhDanh, soDienThoai, email, soTheTamTru, ngayChuyenVao, ngayChuyenDi, soDienNuocHangThang, tinhTrangCongNo, duLieuDangKyThuNuoi, quocTich, maCuDanNguoiThan);
            }
            return null;
        }
        public string GetNameOfMaCuDan(string maCuDan)
        {
            DataTable dt = ResidentDAO.Instance.GetResidentByResidentId(maCuDan);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["hoTen"].ToString();
            return "";
        }
    }
}
