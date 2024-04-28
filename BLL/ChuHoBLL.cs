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
    public class ChuHoBLL
    {
        private static ChuHoBLL instance;
        public static ChuHoBLL Instance
        {
            get { if (instance == null) instance = new ChuHoBLL(); return instance; }
            private set { instance = value; }
        }
        private ChuHoBLL() { }
        public List<ChuHo> GetAllChuHo()
        {
            DataTable dt = ChuHoDAO.Instance.GetAllChuHo();
            List<ChuHo> list = new List<ChuHo>();
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
                DateTime ngayNhanBanGiaoCanHo = (DateTime)dt.Rows[i]["ngayNhanBanGiaoCanHo"];
                DateTime ngayChuyenVao = (DateTime)dt.Rows[i]["ngayChuyenVao"];
                DateTime? ngayChuyenDi = dt.Rows[0]["ngayChuyenDi"] != DBNull.Value
                ? (DateTime)dt.Rows[0]["ngayChuyenDi"]
                : (DateTime?)null;
                float soDienNuocNgayBanGiao = dt.Rows[i]["soDienNuocNgayBanGiao"] != DBNull.Value ? Convert.ToSingle(dt.Rows[i]["soDienNuocNgayBanGiao"]) : 0.0f;
                string bienSoXeDangKy = dt.Rows[i]["bienSoXeDangKy"].ToString();
                string maCuDanBanGiao = dt.Rows[i]["banGiao_maCuDan"].ToString();
                string maCuDanLuuTruCung = dt.Rows[i]["maCuDanLuuTruCung"].ToString();
                int tinhTrangCongNo = (int)dt.Rows[i]["tinhTrangCongNo"];
                string duLieuDangKyThuNuoi = dt.Rows[i]["duLieuDangKyThuNuoi"].ToString();
                list.Add(new ChuHo(maCuDan, maCanHo, loaiCuDan, hoTen, ngaySinh, maDinhDanh, soDienThoai,
                    email, quocTich, soTheTamTru, ngayNhanBanGiaoCanHo, ngayChuyenVao, ngayChuyenDi, soDienNuocNgayBanGiao,
                    bienSoXeDangKy, maCuDanBanGiao, maCuDanLuuTruCung,
                    tinhTrangCongNo, duLieuDangKyThuNuoi));
            }
            return list;
        }
    }
}
