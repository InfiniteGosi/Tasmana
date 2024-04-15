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
    public partial class ThemCongViecNhom : Form
    {
        public ThemCongViecNhom()
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

        private List<Group> GetGroups()
        {
            List <Group> list = new List<Group>();
            string maBoPhan = CBB_phongban.SelectedItem.ToString().Split('-')[0];
            list = GroupBLL.Instance.GetGroupListByDivisionId(maBoPhan);
            return list;
        }

        private void ReadNhom()
        {
            CBB_nhom.Enabled = true;
            CBB_nhom.Items.Clear();
            List<Group> listGroups = GetGroups();
            for (int i = 0;i < listGroups.Count;i++)
            {
                CBB_nhom.Items.Add(listGroups[i].MaNhom);
            }
        }

        private void CBB_phongban_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CBB_phongban.SelectedIndex != -1)
            {
                CBB_nhom.SelectedIndex = -1;
                ReadNhom();
            }
        }

        private string maCongViec;
        private void GetNewestJobID()
        {
            maCongViec = JobBLL.Instance.GetNewJobID();
            TXB_MaCongViec.Text = maCongViec;
        }
        private void CBB_nhom_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CBB_nhom.SelectedIndex != -1)
            {
                TXB_noidung.Enabled = true;
                TXB_macanho.Enabled = true;
                DTP_gio.Enabled = true;
                DTP_ngay.Enabled = true;
                BTN_ok.Enabled = true;
                GetNewestJobID();
                BTN_file.Enabled = true;
            }
        }

        // Tạo tham số cho bảng CongViec để truyền vào DataProvider
        private Dictionary<string, object> AddParameterCongViec()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@noiDung", TXB_noidung.Text},
                {"@ngayGiao", DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss")},
                {"@thoihan",  DTP_ngay.Value.ToString("yyyy-MM-dd") + " " + DTP_gio.Text.Split(' ')[0].ToString()},
                {"@ngayHoanThanh", null},
                {"@ngayCapNhat", DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss")},
                {"@trangThai", "Chưa bắt đầu"},
                {"@ghiChu", null}
            };
            return dict;
        }

        // Tạo tham số cho bảng CongViec_PhongBan để truyền vào DataProvider
        private Dictionary<string, object> AddParameterCongViec_Nhom()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@maNhom", CBB_nhom.SelectedItem.ToString()},
                {"@maCongViec",  TXB_MaCongViec.Text}
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
        private bool SaveCongViec()
        {
            if (JobBLL.Instance.AddJob(AddParameterCongViec()))
            {
                if (JobBLL.Instance.AddJob_Group(AddParameterCongViec_Nhom()))
                {
                    if(JobBLL.Instance.AddRequestFromCustom(AddParameterYeuCau()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void ThemCongViecNhom_Load(object sender, EventArgs e)
        {
            ReadPhongBan();
        }

        private void BTN_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXB_noidung.Text))
            {
                MessageBox.Show("Vui lòng điền nội dung công việc");
            }
            if (string.IsNullOrEmpty(TXB_macanho.Text))
            {
                MessageBox.Show("Vui lòng điền mã căn hộ");
            }
            if (string.IsNullOrEmpty(TXB_MaCongViec.Text))
            {
                MessageBox.Show("Vui lòng điền mã công việc");
            }
            if(SaveCongViec())
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void BTN_huy_Click(object sender, EventArgs e)
        {
            CBB_phongban.SelectedIndex = -1;
            CBB_nhom.SelectedIndex = -1;
            TXB_noidung.Clear();
            TXB_MaCongViec.Clear();
            TXB_macanho.Clear();
            CBB_nhom.Enabled = false;
            TXB_noidung.Enabled = false;
            TXB_macanho.Enabled = false;
            TXB_MaCongViec.Enabled = false;
            DTP_gio.Enabled = false;
            DTP_ngay.Enabled = false;
            BTN_file.Enabled = false;
        }
    }
}
