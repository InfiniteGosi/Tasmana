using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class ThongTinNhanVien : Form
    {
        private Employee employee;
        private Group group;
        private Division division;
        private readonly string employeeId;
        public ThongTinNhanVien(string employeeId)
        {
            this.employeeId = employeeId;
            InitializeComponent();
        }
        private void GetEmployeeByEmployeeId()
        {
            employee = EmployeeBLL.Instance.GetEmployeeByEmployeeId(employeeId);
        }
        private void GetGroupByEmployeeId()
        {
            group = EmployeeBLL.Instance.GetGroupByEmployeeId(employee.MaNhanVien);
        }
        private void GetDivisionByGroupId()
        {
            division = GroupBLL.Instance.GetDivsionByGroupId(group.MaNhom);
        }
        // Hiện loại nhân viên từ mảng loaiNV vào CBB_loainv
        private readonly string[] loaiNV = { "Intern / Trainne", "Part-time", "Full-time" };
        private void DisplayEmployeeeInfo()
        {
            // Hiện thông tin nhân viên
            GetGroupByEmployeeId();
            GetDivisionByGroupId();
            TXB_manv.Text = employee.MaNhanVien;
            TXB_ho.Text = employee.Ho;
            TXB_ten.Text = employee.Ten;
            DTP_ngaysinh.Value = employee.NgaySinh;
            if (employee.GioiTinh == true)
            {
                TXB_gioitinh.Text = "Nam";
            }
            else
            {
                TXB_gioitinh.Text = "Nữ";
            }
            TXB_honnhan.Text = employee.TinhTrangHonNhan;
            TXB_loainv.Text = employee.LoaiNhanVien;
            if (employee.DaTungLamNhanVien)
            {
                CHB_tunglanv.Checked = true;
            }
            TXB_phongban.Text = $"{division.MaBoPhan} - {division.TenBoPhan}";
            TXB_nhom.Text = group.MaNhom;
            DTP_ngayhetHDLD.Value = employee.NgayHetHDLD;
            DTP_ngaykyHDLD.Value = employee.NgayKyHDLD;
            TXB_tinhtrangHDLD.Text = employee.TinhTrangHDLD;
            TXB_sdt.Text = employee.SoDienThoai;
            TXB_email.Text = employee.Email;
            TXB_cccd.Text = employee.MaDinhDanh;
            TXB_bhxh.Text = employee.MaSoBHXH;
            TXB_quequan.Text = employee.QueQuan;
            TXB_thuongtru.Text = employee.DiaChiThuongTru;
            TXB_tamtru.Text = employee.DiaChiTamTru;

            // Hiện thông tin tài khoản
            Account account = employee.TaiKhoanNguoiDung;
            TXB_manguoidung.Text = account.UserId;
            TXB_matkhau.Text = account.Password;
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            GetEmployeeByEmployeeId();
            DisplayEmployeeeInfo();
        }
    }
}
