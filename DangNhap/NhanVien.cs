using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        private Employee nhanVienChiTiet;
        private List<Employee> employees = new List<Employee>();
        public NhanVien()
        {
            InitializeComponent();
            AddEmployeeToDGV_hienthinhanvien();
        }
        // Gọi hàm lấy nhân viên
        private void GetEmployees()
        {
            employees = EmployeeBLL.Instance.GetEmployeeLíst();
        }
        // Hiển thị nhân viên lên DGV
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
        // Nhấn nút thêm nhân viên sẽ mở cửa sổ thông tin nhân viên
        private void BTN_themnhanvien_Click(object sender, EventArgs e)
        {
            // Gọi timer để refresh lại dgv
            TM_nhanvien.Start();
            ThongTinCaNhan ttcn = new ThongTinCaNhan();
            ttcn.ShowDialog();
            TM_nhanvien.Stop();
        }
        // Lấy thông tin nhân viên bằng mã nhân viên
        private Employee GetEmployeeByEmployeeId(string maNhanVien)
        {
            return EmployeeBLL.Instance.GetEmployeeByEmployeeId(maNhanVien);
        }
        // Khi bấm vào ô chi tiết sẽ mở form thông tin nhân viên
        private void DGV_hienthinhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_hienthinhanvien.Columns["C_chitiet"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = DGV_hienthinhanvien.Rows[e.RowIndex];
                string maNhanVien = clickedRow.Cells[0].Value.ToString();
                nhanVienChiTiet = GetEmployeeByEmployeeId(maNhanVien);
                TM_nhanvien.Start();
                ThongTinCaNhan ttcn = new ThongTinCaNhan(nhanVienChiTiet);
                ttcn.ShowDialog();
                TM_nhanvien.Stop();
            }
        }
        // Set timer để tự động refresh lại dgv
        private void TM_nhanvien_Tick(object sender, EventArgs e)
        {
            employees = new List<Employee>();
            AddEmployeeToDGV_hienthinhanvien();
        }
    }
}
