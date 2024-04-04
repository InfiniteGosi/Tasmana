using BLL;
using DTO;
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
            employees = EmployeeBLL.Instance.GetEmployeeLíst();
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
