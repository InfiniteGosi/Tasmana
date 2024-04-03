using DangNhap.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class NhanVien : Form
    {
        private List<Employee> employees = new List<Employee>();
        public NhanVien()
        {
            InitializeComponent();
            AddEmployeeToDGV_hienthinhanvien();
        }

        private void GetEmployees()
        {
            string query = "select * from NhanVien";
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tasmana;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string maNhanVien = reader["maNhanVien"].ToString();
                        string email = reader["email"].ToString();
                        string ho = reader["ho"].ToString();
                        string ten = reader["ten"].ToString();
                        string soDienThoai = reader["SDT"].ToString();
                        DateTime ngaySinh = (DateTime)reader["ngaySinh"];
                        bool gioiTinh = (bool)reader["gioiTinh"];
                        string queQuan = reader["queQuan"].ToString();
                        string maDinhDanh = reader["maDinhDanh"].ToString();
                        string loaiNhanVien = reader["loaiNhanVien"].ToString();
                        string tinhTrangHonNhan = reader["tinhTrangHonNhan"].ToString();
                        string maSoBHXH = reader["maSoBHXH"].ToString();
                        bool daTungLamNV = (bool)reader["daTungLamNV"];
                        DateTime ngayKyHDLD = (DateTime)reader["ngayKyHDLD"];
                        DateTime ngayHetHDLD = (DateTime)reader["ngayHetHDLD"];
                        string diaChiThuongTru = reader["dChiThuongTru"].ToString();
                        string diaChiaTamTru = reader["dChiTamTru"].ToString();
                        string tinhTrangHDLD = reader["tinhTrangHDLD"].ToString();
                        string maNhom = reader["maNhom"].ToString();
                        Employee employee = new Employee(maNhanVien, email, ho, ten, soDienThoai, ngaySinh, gioiTinh, queQuan, maDinhDanh,
                                                         loaiNhanVien, tinhTrangHonNhan, maSoBHXH, daTungLamNV, ngayKyHDLD, ngayHetHDLD, 
                                                         diaChiThuongTru, diaChiaTamTru, tinhTrangHDLD, maNhom);
                        employees.Add(employee);
                    }
                    reader.Close();
                    cmd.Dispose();
                }
                catch
                {
                    MessageBox.Show("Connection error");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void AddEmployeeToDGV_hienthinhanvien()
        {
            GetEmployees();
            DGV_hienthinhanvien.Rows.Clear();
            foreach (var employee in employees)
            {
                int rowIndex = DGV_hienthinhanvien.Rows.Add();
                DGV_hienthinhanvien.Rows[rowIndex].Cells[0].Value = employee.MaNhanVien;
                DGV_hienthinhanvien.Rows[rowIndex].Cells[1].Value = employee.Ho;
                DGV_hienthinhanvien.Rows[rowIndex].Cells[2].Value = employee.Ten;
                DGV_hienthinhanvien.Rows[rowIndex].Cells[3].Value = employee.MaNhom;
                DGV_hienthinhanvien.Rows[rowIndex].Cells[4].Value = employee.SoDienThoai;
                DGV_hienthinhanvien.Rows[rowIndex].Cells[5].Value = employee.Email;
            }
            DGV_hienthinhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BTN_themnhanvien_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan ttcn = new ThongTinCaNhan();
            ttcn.Show();
        }

        private void BTN_refresh_Click(object sender, EventArgs e)
        {
            employees = new List<Employee>();
            AddEmployeeToDGV_hienthinhanvien();
        }
    }
}
