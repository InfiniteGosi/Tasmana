using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BLL
{
    public class EmployeeBLL
    {
        private static EmployeeBLL instance;
        public static EmployeeBLL Instance
        {
            get { if (instance == null) instance = new EmployeeBLL(); return instance; }
            private set { instance = value; }
        }
        private EmployeeBLL() { }
        public string AddEmployee(Dictionary<string, object> parameters)
        {
            if (EmployeeDAO.Instance.AddEmployee(parameters))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public List<Employee> GetEmployeeLíst()
        {
            DataTable dt = EmployeeDAO.Instance.GetAllEmployee();

            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maNhanVien = dt.Rows[i]["maNhanVien"].ToString();
                string email = dt.Rows[i]["email"].ToString();
                string ho = dt.Rows[i]["ho"].ToString();
                string ten = dt.Rows[i]["ten"].ToString();
                string soDienThoai = dt.Rows[i]["SDT"].ToString();
                DateTime ngaySinh = (DateTime)dt.Rows[i]["ngaySinh"];
                bool gioiTinh = (bool)dt.Rows[i]["gioiTinh"];
                string queQuan = dt.Rows[i]["queQuan"].ToString();
                string maDinhDanh = dt.Rows[i]["maDinhDanh"].ToString();
                string loaiNhanVien = dt.Rows[i]["loaiNhanVien"].ToString();
                string tinhTrangHonNhan = dt.Rows[i]["tinhTrangHonNhan"].ToString();
                string maSoBHXH = dt.Rows[i]["maSoBHXH"].ToString();
                bool daTungLamNV = (bool)dt.Rows[i]["daTungLamNV"];
                DateTime ngayKyHDLD = (DateTime)dt.Rows[i]["ngayKyHDLD"];
                DateTime ngayHetHDLD = (DateTime)dt.Rows[i]["ngayHetHDLD"];
                string diaChiThuongTru = dt.Rows[i]["dChiThuongTru"].ToString();
                string diaChiaTamTru = dt.Rows[i]["dChiTamTru"].ToString();
                string tinhTrangHDLD = dt.Rows[i]["tinhTrangHDLD"].ToString();
                string maNhom = dt.Rows[i]["maNhom"].ToString();
                Employee employee = new Employee(maNhanVien, email, ho, ten, soDienThoai, ngaySinh, gioiTinh, queQuan, maDinhDanh,
                                                 loaiNhanVien, tinhTrangHonNhan, maSoBHXH, daTungLamNV, ngayKyHDLD, ngayHetHDLD,
                                                 diaChiThuongTru, diaChiaTamTru, tinhTrangHDLD, maNhom);
                employees.Add(employee);
            }
            return employees;
        }
        public Employee GetEmployeeByEmployeeId(string maNhanVien)
        {
            DataTable dt = EmployeeDAO.Instance.GetEmployeeByEmployeeId(maNhanVien);
            string email = dt.Rows[0]["email"].ToString();
            string ho = dt.Rows[0]["ho"].ToString();
            string ten = dt.Rows[0]["ten"].ToString();
            string soDienThoai = dt.Rows[0]["SDT"].ToString();
            DateTime ngaySinh = (DateTime)dt.Rows[0]["ngaySinh"];
            bool gioiTinh = (bool)dt.Rows[0]["gioiTinh"];
            string queQuan = dt.Rows[0]["queQuan"].ToString();
            string maDinhDanh = dt.Rows[0]["maDinhDanh"].ToString();
            string loaiNhanVien = dt.Rows[0]["loaiNhanVien"].ToString();
            string tinhTrangHonNhan = dt.Rows[0]["tinhTrangHonNhan"].ToString();
            string maSoBHXH = dt.Rows[0]["maSoBHXH"].ToString();
            bool daTungLamNV = (bool)dt.Rows[0]["daTungLamNV"];
            DateTime ngayKyHDLD = (DateTime)dt.Rows[0]["ngayKyHDLD"];
            DateTime ngayHetHDLD = (DateTime)dt.Rows[0]["ngayHetHDLD"];
            string diaChiThuongTru = dt.Rows[0]["dChiThuongTru"].ToString();
            string diaChiaTamTru = dt.Rows[0]["dChiTamTru"].ToString();
            string tinhTrangHDLD = dt.Rows[0]["tinhTrangHDLD"].ToString();
            string maNhom = dt.Rows[0]["maNhom"].ToString();
            Employee employee = new Employee(maNhanVien, email, ho, ten, soDienThoai, ngaySinh, gioiTinh, queQuan, maDinhDanh,
                                             loaiNhanVien, tinhTrangHonNhan, maSoBHXH, daTungLamNV, ngayKyHDLD, ngayHetHDLD,
                                             diaChiThuongTru, diaChiaTamTru, tinhTrangHDLD, maNhom);
            return employee;
        }
        public Group GetGroupByEmployeeId(string maNhanVien)
        {
            DataTable dt = EmployeeDAO.Instance.GetGroupByEmployeeId(maNhanVien);
            string maNhom = dt.Rows[0]["maNhom"].ToString();
            string maTruongNhom = dt.Rows[0]["maTruongNhom"].ToString();
            string maBoPhan = dt.Rows[0]["maBoPhan"].ToString();
            Group group = new Group(maNhom, maTruongNhom, maBoPhan);
            return group;
        }
        public string UpdateEmployee(Dictionary<string, object> parameters)
        {
            if (EmployeeDAO.Instance.UpdateEmployee(parameters))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
        public List<Employee> GetEmployeesByGoup(string maNhom)
        {
            DataTable dt = EmployeeDAO.Instance.GetEmployeeByGroup(maNhom);

            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maNhanVien = dt.Rows[i]["maNhanVien"].ToString();
                string email = dt.Rows[i]["email"].ToString();
                string ho = dt.Rows[i]["ho"].ToString();
                string ten = dt.Rows[i]["ten"].ToString();
                string soDienThoai = dt.Rows[i]["SDT"].ToString();
                DateTime ngaySinh = (DateTime)dt.Rows[i]["ngaySinh"];
                bool gioiTinh = (bool)dt.Rows[i]["gioiTinh"];
                string queQuan = dt.Rows[i]["queQuan"].ToString();
                string maDinhDanh = dt.Rows[i]["maDinhDanh"].ToString();
                string loaiNhanVien = dt.Rows[i]["loaiNhanVien"].ToString();
                string tinhTrangHonNhan = dt.Rows[i]["tinhTrangHonNhan"].ToString();
                string maSoBHXH = dt.Rows[i]["maSoBHXH"].ToString();
                bool daTungLamNV = (bool)dt.Rows[i]["daTungLamNV"];
                DateTime ngayKyHDLD = (DateTime)dt.Rows[i]["ngayKyHDLD"];
                DateTime ngayHetHDLD = (DateTime)dt.Rows[i]["ngayHetHDLD"];
                string diaChiThuongTru = dt.Rows[i]["dChiThuongTru"].ToString();
                string diaChiaTamTru = dt.Rows[i]["dChiTamTru"].ToString();
                string tinhTrangHDLD = dt.Rows[i]["tinhTrangHDLD"].ToString();
                string maNhom2 = dt.Rows[i]["maNhom"].ToString();
                Employee employee = new Employee(maNhanVien, email, ho, ten, soDienThoai, ngaySinh, gioiTinh, queQuan, maDinhDanh,
                                                 loaiNhanVien, tinhTrangHonNhan, maSoBHXH, daTungLamNV, ngayKyHDLD, ngayHetHDLD,
                                                 diaChiThuongTru, diaChiaTamTru, tinhTrangHDLD, maNhom2);
                employees.Add(employee);
            }
            return employees;
        }
    }
}
