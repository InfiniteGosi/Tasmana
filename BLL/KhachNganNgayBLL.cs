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
    public class KhachNganNgayBLL
    {
        private static KhachNganNgayBLL instance;
        public static KhachNganNgayBLL Instance
        {
            get { if (instance == null) instance = new KhachNganNgayBLL(); return instance; }
            private set { instance = value; }
        }
        private KhachNganNgayBLL() { }
        public string GetNameByMaCuDan(string maCuDan)
        {
            DataTable dt = KhachNganNgayDAO.Instance.GetKhachByMaCuDan(maCuDan);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["hoTen"].ToString();
            return "";
        }
        public List<KhachNganNgay> GetAllKhachNganNgay()
        {
            DataTable dt = KhachNganNgayDAO.Instance.GetAllKhachNganNgay();
            List<KhachNganNgay> list = new List<KhachNganNgay>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maCuDan = dt.Rows[i]["maCuDan"].ToString();
                string maCanHo = dt.Rows[i]["maCanHo"].ToString();
                string loaiCuDan = dt.Rows[i]["loaiCuDan"].ToString();
                string hoTen = dt.Rows[i]["hoTen"].ToString();
                DateTime ngaySinh = (DateTime)dt.Rows[i]["ngayThangNamSinh"];
                string maDinhDanh = dt.Rows[i]["maDinhDanh"].ToString();
                string soDienThoai = dt.Rows[i]["SDT"].ToString();
                string email = dt.Rows[i]["email"].ToString();
                string quocTich = dt.Rows[i]["quocTich"].ToString();
                string soTheTamTru = dt.Rows[i]["soTheTamTru"].ToString();
                DateTime ngayChuyenVao = (DateTime)dt.Rows[i]["ngayChuyenVao"];
                DateTime? ngayChuyenDi = dt.Rows[i]["ngayChuyenDi"] != DBNull.Value
                ? (DateTime)dt.Rows[i]["ngayChuyenDi"]
                : (DateTime?)null;
                string bienSoXeDangKy = dt.Rows[i]["bienSoXeDangKy"].ToString();
                string maCuDanLuuTruCung = dt.Rows[i]["maCuDanLuuTruCung"].ToString();
                int tinhTrangCongNo = (int)dt.Rows[i]["tinhTrangCongNo"];
                string duLieuDangKyThuNuoi = dt.Rows[i]["duLieuDangKyThuNuoi"].ToString();
                list.Add(new KhachNganNgay(maCuDan, maCanHo, hoTen, ngaySinh, maDinhDanh, soDienThoai, email, quocTich, soTheTamTru, ngayChuyenVao, ngayChuyenDi, maCuDanLuuTruCung, bienSoXeDangKy, tinhTrangCongNo, duLieuDangKyThuNuoi, loaiCuDan));
            }
            return list;
        }
    }
}
