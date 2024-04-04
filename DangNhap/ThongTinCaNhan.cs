using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace DangNhap
{
    public partial class ThongTinCaNhan : Form
    {
        List<Division> divisions = new List<Division>();
        List<Group> groups = new List<Group>();
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }

        // Hàm khởi tạo danh sách giá trị truyền vào SP
        private object[] values;
        public void InitializeValues()
        {
            values = new object[] {
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
        private Dictionary<string, object> AddParameter()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                { "@maNhanVien", values[0] },
                { "@email", values[1] },
                { "@ho", values[2] },
                { "@ten", values[3] },
                { "@SDT", values[4] },
                { "@ngaySinh", values[5] },
                { "@gioiTinh", values[6] },
                { "@queQuan", values[7] },
                { "@maDinhDanh", values[8] },
                { "@loaiNhanVien", values[9] },
                { "@tinhTrangHonNhan", values[10] },
                { "@maSoBHXH", values[11] },
                { "@daTungLamNV", values[12] },
                { "@ngayKyHDLD", values[13] },
                { "@ngayHetHDLD", values[14] },
                { "@dChiThuongTru", values[15] },
                { "@dChiTamTru", values[16] },
                { "@tinhTrangHDLD", values[17] },
                { "@maNhom", values[18] }
            };
            return dict;
        }

        private string AddEmployee(Dictionary<string, object> parameters)
        {
            return EmployeeBLL.Instance.AddEmployee(parameters);
        }

        private void GetDivisionList()
        {
            divisions = DivisionBLL.Instance.GetDivisionList();
        }
        
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
        private void GetGroupList()
        {
            string maBoPhan = CBB_phongban.SelectedItem.ToString().Split('-')[0];
            groups = GroupBLL.Instance.GetGroupListByDivisionId(maBoPhan);
        }
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

        private void CreateAccountForEmployee()
        {
            
        }
        // Tạo userId theo quy tắc trong file QA
        private string GenerateUserId()
        {
            string ten = TXB_ten.Text.Substring(TXB_ten.Text.LastIndexOf(' ') + 1);
            return TXB_manv.Text + "." + ten + "." + TXB_sdt;
        }

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
            // Địa chỉ tạm trú không cần check
            //if (string.IsNullOrEmpty(TXB_tamtru.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập địa chỉ tạm trú");
            //    return;
            //}
            InitializeValues();
            MessageBox.Show(AddEmployee(AddParameter()));
        }

        private void TXB_manv_TextChanged(object sender, EventArgs e)
        {
            TXB_manguoidung.Text = GenerateUserId();
        }

        private void TXB_ten_TextChanged(object sender, EventArgs e)
        {
            TXB_manguoidung.Text = GenerateUserId();
        }

        private void TXB_sdt_TextChanged(object sender, EventArgs e)
        {
            TXB_manguoidung.Text = GenerateUserId();
        }

        private void CBB_phongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_phongban.SelectedIndex != -1)
            {
                DisplayGroupToCBB_nhom();
            }
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            DisplayDivisionsToCBB_phongban();
            string[] loaiNV = { "Intern / Trainne", "Part-time", "Full-time" };
            CBB_loainv.DataSource = loaiNV;
        }
    }
}
