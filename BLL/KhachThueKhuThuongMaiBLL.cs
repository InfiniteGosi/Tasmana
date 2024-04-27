﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachThueKhuThuongMaiBLL
    {
        private static KhachThueKhuThuongMaiBLL instance;
        public static KhachThueKhuThuongMaiBLL Instance
        {
            get { if (instance == null) instance = new KhachThueKhuThuongMaiBLL(); return instance; }
            private set { instance = value; }
        }
        private KhachThueKhuThuongMaiBLL() { }
        public KhachThueKhuThuongMai GetKhachThueById(string maKhachDangThue)
        {
            DataTable dt = KhachThueKhuThuongMaiDAO.Instance.GetKhachThueById(maKhachDangThue);
            string tenCongTy = dt.Rows[0]["tenCongTy"].ToString();
            string hoTenNguoiDaiDien = dt.Rows[0]["hoTenNguoiDaiDien"].ToString();
            string maNhanVienPhuTrach = dt.Rows[0]["maNhanVienPhuTrach"].ToString();
            string soDienThoai = dt.Rows[0]["SDT"].ToString();
            string email = dt.Rows[0]["email"].ToString();
            DateTime ngayKyHopDongThue = (DateTime)dt.Rows[0]["ngayKyHopDongThue"];
            DateTime ngayChuyenVao = (DateTime)dt.Rows[0]["ngayChuyenVao"];
            DateTime? ngayChuyenDi = dt.Rows[0]["ngayChuyenDi"] != DBNull.Value
            ? (DateTime)dt.Rows[0]["ngayChuyenDi"]
            : (DateTime?)null;
            int phiQuanLy = (int)dt.Rows[0]["phiQuanLy"];
            string moTaKhuVucChoThue = dt.Rows[0]["moTaKhuVucChoThue"].ToString();
            string bienSoXeDangKy = dt.Rows[0]["bienSoXeDangKy"].ToString();
            return new KhachThueKhuThuongMai(maKhachDangThue, tenCongTy, hoTenNguoiDaiDien, maNhanVienPhuTrach, soDienThoai, email, ngayKyHopDongThue, ngayChuyenVao, ngayChuyenDi, phiQuanLy, moTaKhuVucChoThue, bienSoXeDangKy);
        }
    }
}