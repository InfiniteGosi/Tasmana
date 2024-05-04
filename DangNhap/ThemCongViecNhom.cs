﻿using BLL;
using DTO;
using SixLabors.ImageSharp.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class ThemCongViecNhom : Form
    {
        private CongViecChung parent;
        public ThemCongViecNhom(CongViecChung parent)
        {
            InitializeComponent();
            this.parent = parent;
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
        private byte[] buffer = null;
        private string fileName = null;
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
                BTN_ok.Enabled = true;
                GetNewestJobID();
                BTN_file.Enabled = true;
                CBB_QuyenTruyCap.Enabled = true;
                TXB_ghiChu.Enabled = true;
                TXB_PhiDichVu.Enabled = true;
            }
        }

        private int GetQuyenTruyCap()
        {
            int ch = 0; // mặc định là riêng tư
            if (CBB_QuyenTruyCap.SelectedItem.ToString().Equals("Bộ phận"))
            {
                ch = 1;
            }
            if (CBB_QuyenTruyCap.SelectedItem.ToString().Equals("Công ty"))
            {
                ch = 2;
            }
            return ch;
        }
        // Tạo tham số cho bảng CongViec để truyền vào DataProvider

        private Dictionary<string, object> AddParameterCongViec()
        {
            string thoiHan = null;
            if (CB_thoihan.Checked == true)
            {
                thoiHan = DTP_ngay.Value.ToString("yyyy-MM-dd") + " " + DTP_gio.Text.Split(' ')[0].ToString();
            }
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@noiDung", TXB_noidung.Text},
                {"@ngayGiao", DateTime.Now.ToString("yyyy-MM-dd'T'HH:mm:ss")},
                {"@thoihan", thoiHan},
                {"@ngayHoanThanh", null},
                {"@ngayCapNhat", null},
                {"@trangThai", "Chưa bắt đầu"},
                {"@ghiChu", TXB_ghiChu.Text},
                {"@quyenTruyCap", GetQuyenTruyCap()},
                {"@phiDichVu", int.Parse(TXB_PhiDichVu.Text)}
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

        private Dictionary<string, object> AddParameterPDF()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@maCongViec", TXB_MaCongViec.Text},
                {"@pdffile", buffer},
                {"@tenFile", fileName },
                {"@fileExten", ".pdf" }
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
                        if (buffer != null)
                        {
                            if (JobBLL.Instance.AddJob_PDF(AddParameterPDF()))
                            {
                                return true;
                            }
                        }
                        else
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
        // Kiểm tra phí dịch vụ điền vào có phải là 1 số hợp lệ hay không
        private bool IsValidInteger(string input)
        {
            return int.TryParse(input, out _);
        }
        private void BTN_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXB_noidung.Text))
            {
                MessageBox.Show("Vui lòng điền nội dung công việc");
                return;
            }
            if (string.IsNullOrEmpty(TXB_macanho.Text))
            {
                MessageBox.Show("Vui lòng điền mã căn hộ");
                return;
            }
            if (string.IsNullOrEmpty(TXB_MaCongViec.Text))
            {
                MessageBox.Show("Vui lòng điền mã công việc");
                return;
            }
            if (CBB_QuyenTruyCap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn quyền hạn truy cập");
                return;
            }
            if (string.IsNullOrEmpty(TXB_PhiDichVu.Text))
            {
                MessageBox.Show("Vui lòng điền phí dịch vụ");
                return;
            }
            if (!IsValidInteger(TXB_PhiDichVu.Text))
            {
                MessageBox.Show("Vui lòng điền phí dịch vụ hợp lệ");
                return;
            }
            if (SaveCongViec())
            {
                MessageBox.Show("Thêm thành công");
                parent.Display_GGC_nhom();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void BTN_huy_Click(object sender, EventArgs e)
        {
            CBB_QuyenTruyCap.SelectedIndex = -1;
            CBB_phongban.SelectedIndex = -1;
            CBB_nhom.SelectedIndex = -1;
            TXB_noidung.Clear();
            TXB_MaCongViec.Clear();
            TXB_macanho.Clear();
            TXB_PhiDichVu.Clear();
            CBB_nhom.Enabled = false;
            TXB_noidung.Enabled = false;
            TXB_macanho.Enabled = false;
            TXB_MaCongViec.Enabled = false;
            CB_thoihan.Checked = false;
            BTN_file.Enabled = false;
            TXB_ghiChu.Enabled = false;
            CBB_QuyenTruyCap.Enabled = false;
            TXB_PhiDichVu.Enabled = false;  
        }

        private void CB_thoihan_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_thoihan.Checked)
            {
                DTP_ngay.Enabled = true;
                DTP_gio.Enabled = true;
            }
            else
            {
                DTP_gio.Enabled = false;
                DTP_ngay.Enabled = false;
            }
        }

        private void BTN_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|*.pdf", ValidateNames = true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Bạn có chắc muốn upload file này chứ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string file = dlg.FileName;
                        buffer = File.ReadAllBytes(file);
                        string[] words = file.Split('\\');
                        int length = words.Length;
                        fileName = words[length - 1];
                    }
                }
            }
            LLB_themfilenhom.Text = fileName;
            LLB_themfilenhom.Show();
        }
    }
}
