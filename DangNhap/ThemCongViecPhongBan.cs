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
using System.Windows.Forms;

namespace DangNhap
{
    public partial class ThemCongViecPhongBan : Form
    {
        public ThemCongViecPhongBan()
        {
            InitializeComponent();
        }
        private List<Division> GetPhongBan()
        {
            List<Division> list = new List<Division>();
            list = DivisionBLL.Instance.GetDivisionList();
            return list;
        }
        private void ReadPhongBan()
        {
            CBB_phongban.Enabled = true;
            CBB_phongban.Items.Clear();
            List<Division> listPhongBan = GetPhongBan();
            for (int i = 0; i < listPhongBan.Count; i++)
            {
                CBB_phongban.Items.Add(listPhongBan[i].MaBoPhan + "-" + listPhongBan[i].TenBoPhan);
            }
        }
        // Tạo tham số cho bảng CongViec để truyền vào DataProvider
        private Dictionary<string, object> AddParameterCongViec()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@maCongViec", TXB_MaCongViec.Text},
                {"@noiDung", TXB_noidung.Text},
                {"@thoihan",  DTP_ngay.Value.ToString("yyyy-MM-dd") + " " + DTP_gio.Text.Split(' ')[0].ToString()},
                {"@ngayHoanThanh", null},
                {"@trangThai", "Chưa bắt đầu"},
                {"@ghiChu", null}
            };
            return dict;
        }
        // Tạo tham số cho bảng CongViec_NhanVien để truyền vào DataProvider
        private Dictionary<string, object> AddParameterCongViec_PhongBan()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@maCongViec", TXB_MaCongViec.Text},
                {"@maBoPhan", CBB_phongban.SelectedItem.ToString().Split('-')[0]}
            };
            return dict;
        }
        // Tạo tham số cho bảng YeuCau để truyền vào DataProvider
        private Dictionary<string, object> AddParameterYeuCau()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@maCongViec", TXB_MaCongViec.Text},
                {"@maCanHo", TXB_macanho.Text}
            };
            return dict;
        }

        private void CBB_phongban_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CBB_phongban.SelectedIndex != -1)
            {
                TXB_macanho.Enabled = true;
                TXB_MaCongViec.Enabled = true;
                TXB_noidung.Enabled = true;
                DTP_gio.Enabled = true;
                DTP_ngay.Enabled = true;
                BTN_ok.Enabled = true;
            }
        }

        private void ThemCongViecPhongBan_Load(object sender, EventArgs e)
        {
            ReadPhongBan();
        }

        private bool SaveCongViec()
        {
            if (JobBLL.Instance.AddJob(AddParameterCongViec()))
            {
                if (JobBLL.Instance.AddJob_Division(AddParameterCongViec_PhongBan()))
                {
                    if (JobBLL.Instance.AddRequestFromCustom(AddParameterYeuCau()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void BTN_ok_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TXB_noidung.Text))
            {
                MessageBox.Show("Vui lòng điền nội dung công việc");
            }
            if(string.IsNullOrEmpty(TXB_macanho.Text))
            {
                MessageBox.Show("Vui lòng điền mã căn hộ");
            }
            if (string.IsNullOrEmpty(TXB_MaCongViec.Text))
            {
                MessageBox.Show("Vui lòng điền mã công việc");
            }
            if (SaveCongViec())
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
