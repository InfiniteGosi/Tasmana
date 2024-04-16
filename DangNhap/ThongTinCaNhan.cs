using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using DTO;

namespace DangNhap
{
    public partial class ThongTinCaNhan : Form
    {
        private readonly NhanVien parent;
        private List<Division> divisions = new List<Division>();
        private List<DTO.Group> groups = new List<DTO.Group>();
        private readonly Employee employee = null;
        private DTO.Group group;
        private Division division;
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }
        public ThongTinCaNhan(NhanVien parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public ThongTinCaNhan(NhanVien parent, Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.parent = parent;
            this.FormClosing += new FormClosingEventHandler(this.ThongTinCaNhan_FormClosing);
        }

        // Hàm khởi tạo danh sách giá trị truyền vào SP
        private object[] values_nv;
        private void InitializeValues_NV()
        {
            values_nv = new object[] 
            {
                TXB_manv.Text,
                TXB_email.Text,
                TXB_ho.Text,
                TXB_ten.Text,
                TXB_sdt.Text,
                DTP_ngaysinh.Value,
                Rad_nam.Checked ? 1 : 0,
                TXB_quequan.Text,
                TXB_cccd.Text,
                CBB_loainv.SelectedItem.ToString(),
                TXB_honnhan.Text,
                TXB_bhxh.Text,
                CHB_tunglanv.Checked ? 1 : 0,
                DTP_ngaykyHDLD.Value,
                DTP_ngayhetHDLD.Value,
                TXB_thuongtru.Text,
                TXB_tamtru.Text,
                TXB_tinhtrangHDLD.Text,
                CBB_nhom.SelectedItem.ToString()
            };
        }

        // Tạo dictionary để truyền vào DataProvider
        private Dictionary<string, object> AddParameter_NV()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                { "@maNhanVien", values_nv[0] },
                { "@email", values_nv[1] },
                { "@ho", values_nv[2] },
                { "@ten", values_nv[3] },
                { "@SDT", values_nv[4] },
                { "@ngaySinh", values_nv[5] },
                { "@gioiTinh", values_nv[6] },
                { "@queQuan", values_nv[7] },
                { "@maDinhDanh", values_nv[8] },
                { "@loaiNhanVien", values_nv[9] },
                { "@tinhTrangHonNhan", values_nv[10] },
                { "@maSoBHXH", values_nv[11] },
                { "@daTungLamNV", values_nv[12] },
                { "@ngayKyHDLD", values_nv[13] },
                { "@ngayHetHDLD", values_nv[14] },
                { "@dChiThuongTru", values_nv[15] },
                { "@dChiTamTru", values_nv[16] },
                { "@tinhTrangHDLD", values_nv[17] },
                { "@maNhom", values_nv[18] }
            };
            return dict;
        }
        private object[] values_tk;
        private void InitializeValues_TK()
        {
            values_tk = new object[]
            {
                TXB_manguoidung.Text,
                TXB_matkhau.Text,
                TXB_manv.Text,
                CHB_vohieuhoa.Checked ? 1 : 0 // Khi tạo tài khoản mặc định disabled là 0
            };
        }
        private Dictionary<string, object> AddParameter_TK()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                { "@maNguoiDung", values_tk[0] },
                { "@matKhau", values_tk[1] },
                { "@maNhanVien", values_tk[2] },
                { "@disable", values_tk[3] }
            };
            return dict;
        }
        // Thêm nhân viên vào CSDL
        private string AddEmployee(Dictionary<string, object> parameters)
        {
            return EmployeeBLL.Instance.AddEmployee(parameters);
        }
        private bool AddAccount(Dictionary<string, object> parameters)
        {
            return AccountBLL.Instance.AddAccount(parameters);
        }
        private bool UpdateAccount(Dictionary<string, object> parameters)
        {
            return AccountBLL.Instance.UpdateAccount(parameters);
        }
        // Cập nhật thông tin nhân viên vào CSDL
        private string UpdateEmployee(Dictionary<string, object> parameters)
        {
            return EmployeeBLL.Instance.UpdateEmployee(parameters);
        }
        // Lấy danh sách phòng ban
        private void GetDivisionList()
        {
            divisions = DivisionBLL.Instance.GetDivisionList();
        }
        // Hiện danh sách phòng ban lên CBB_phongban
        private void DisplayDivisionsToCBB_phongban()
        {
            CBB_phongban.Enabled = true;
            CBB_phongban.Items.Clear();
            GetDivisionList();
            foreach (var division in divisions)
            {
                CBB_phongban.Items.Add(division.MaBoPhan + "-" + division.TenBoPhan);
            }
        }
        // Lấy danh sách nhóm
        private void GetGroupList()
        {
            string maBoPhan = CBB_phongban.SelectedItem.ToString().Split('-')[0];
            groups = GroupBLL.Instance.GetGroupListByDivisionId(maBoPhan);
        }
        // Hiện danh sách nhóm lên CBB_nhom
        private void DisplayGroupToCBB_nhom()
        {
            CBB_nhom.Enabled = true;
            CBB_nhom.Items.Clear();
            GetGroupList();
            foreach (var group in groups)
            {
                CBB_nhom.Items.Add(group.MaNhom);
            }
        }
        //Chuyển tiếng Việt sang tiếng Anh cho tên nhân viên
        private string ConvertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        // Tạo userId theo quy tắc trong file QA
        private void GenerateUserId()
        {
            string ten = ConvertToUnSign3(TXB_ten.Text.Substring(TXB_ten.Text.LastIndexOf(' ') + 1).ToUpper());
            string output = $"{TXB_manv.Text.Trim()}.{ten.Trim()}.{TXB_sdt.Text.Trim()}";
            TXB_manguoidung.Text = output;
        }
        // Kiểm tra các trường hợp khi ấn nút lưu
        private void BTN_luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXB_manv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
                return;
            }
            if (string.IsNullOrEmpty(TXB_ho.Text))
            {
                MessageBox.Show("Vui lòng nhập họ");
                return;
            }
            if (string.IsNullOrEmpty(TXB_ten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }
            if (!Rad_nam.Checked && !Rad_nu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return;
            }
            if (string.IsNullOrEmpty(TXB_honnhan.Text))
            {
                MessageBox.Show("Vui lòng nhập tình trạng hôn nhân");
                return;
            }
            if (CBB_loainv.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại nhân viên");
                return;
            }
            if (CBB_phongban.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng ban");
                return;
            }
            if (CBB_phongban.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã nhóm");
                return;
            }
            if (string.IsNullOrEmpty(TXB_tinhtrangHDLD.Text))
            {
                MessageBox.Show("Vui lòng nhập tình trạng hợp đồng lao động");
                return;
            }
            if (string.IsNullOrEmpty(TXB_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            if (string.IsNullOrEmpty(TXB_email.Text))
            {
                MessageBox.Show("Vui lòng nhập email");
                return;
            }
            if (string.IsNullOrEmpty(TXB_cccd.Text))
            {
                MessageBox.Show("Vui lòng nhập mã định danh");
                return;
            }
            if (string.IsNullOrEmpty(TXB_bhxh.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số bảo hiểm xã hội");
                return;
            }
            if (string.IsNullOrEmpty(TXB_quequan.Text))
            {
                MessageBox.Show("Vui lòng nhập quê quán");
                return;
            }
            if (string.IsNullOrEmpty(TXB_thuongtru.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ thường trú");
                return;
            }
            if (string.IsNullOrEmpty(TXB_matkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cho tài khoản nhân viên");
                return;
            }
            // Địa chỉ tạm trú không cần check
            //if (string.IsNullOrEmpty(TXB_tamtru.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập địa chỉ tạm trú");
            //    return;
            //}
            InitializeValues_NV();
            InitializeValues_TK();
            // Trường hợp tạo nhân viên mới
            if (employee == null)
            {
                MessageBox.Show(AddEmployee(AddParameter_NV()));
                AddAccount(AddParameter_TK());
            }
            else // Trường hợp chỉnh sửa nhân viên
            {
                MessageBox.Show(UpdateEmployee(AddParameter_NV()));
                UpdateAccount(AddParameter_TK());
            }
        }
        private void TXB_manv_TextChanged(object sender, EventArgs e)
        {
            GenerateUserId();
        }

        private void TXB_ten_TextChanged(object sender, EventArgs e)
        {
            GenerateUserId();
        }

        private void TXB_sdt_TextChanged(object sender, EventArgs e)
        {
            GenerateUserId();
        }

        private void CBB_phongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_phongban.SelectedIndex != -1)
            {
                DisplayGroupToCBB_nhom();
            }
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
        // Hiện thông tin chỉnh sửa nhân viên và tài khoản của nhân viên này lên các input tương ứng
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
                Rad_nam.Checked = true;
            }
            else
            {
                Rad_nu.Checked = true;
            }
            TXB_honnhan.Text = employee.TinhTrangHonNhan;
            CBB_loainv.SelectedIndex = Array.IndexOf(loaiNV, employee.LoaiNhanVien);
            if (employee.DaTungLamNhanVien)
            {
                CHB_tunglanv.Checked = true;
            }
            CBB_phongban.SelectedIndex = CBB_phongban.Items.IndexOf(division.MaBoPhan + "-" + division.TenBoPhan);
            CBB_nhom.Enabled = true;
            CBB_nhom.SelectedIndex = CBB_nhom.Items.IndexOf(group.MaNhom);
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
            // Không cho chỉnh sửa mã nhân viên
            TXB_manv.Enabled = false;

            // Hiện thông tin tài khoản
            Account account = employee.TaiKhoanNguoiDung;
            if (account.IsDisabled)
            {
                CHB_vohieuhoa.Checked = true;
            }
            TXB_matkhau.Text = account.Password;
            TXB_matkhau.UseSystemPasswordChar = true;
        }
        
        private void DisplayEmployeeType()
        {
            CBB_loainv.DataSource = loaiNV;
            CBB_loainv.SelectedIndex = -1;
        }
        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            // Nếu double click
            DisplayDivisionsToCBB_phongban();
            DisplayEmployeeType();
            if (employee != null)
            {
                DisplayEmployeeeInfo();
                CHB_vohieuhoa.Enabled = true;
                CHB_vohieuhoa.Visible = true;
            }
        }

        private void ThongTinCaNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Refresh();
        }

        private void CHB_matkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_matkhau.Checked)
            {
                TXB_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                TXB_matkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
