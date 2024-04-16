using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
namespace DangNhap
{
    public partial class ThemCongViecNhanVien : Form
    {
        int mov;
        int movX;
        int movY;
        public ThemCongViecNhanVien()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PN_hienthithemcongviec.Controls.Add(childForm);
            PN_hienthithemcongviec.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BTN_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_nhanvien_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            BTN_nhanvien.BackColor = Color.FromArgb(51, 53, 55);
            BTN_nhom.BackColor = Color.Transparent;
            BTN_phongban.BackColor = Color.Transparent;
        }

        private void BTN_phongban_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemCongViecPhongBan());
            BTN_phongban.BackColor = Color.FromArgb(51, 53, 55);
            BTN_nhanvien.BackColor = Color.Transparent;
            BTN_nhom.BackColor = Color.Transparent;
        }

        private void BTN_nhom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemCongViecNhom());
            BTN_nhom.BackColor = Color.FromArgb(51, 53, 55);
            BTN_phongban.BackColor = Color.Transparent;
            BTN_nhanvien.BackColor = Color.Transparent;
        }

        private void ThemCongViecNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void ThemCongViecNhanVien_MousMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void ThemCongViecNhanVien_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        public List<Division> GetPhongBan()
        {
            List<Division> listMaPB = new List<Division>();
            listMaPB = DivisionBLL.Instance.GetDivisionList();
            return listMaPB;
        }
        private void ReadPhongBan()
        {
            List<Division> listPB = new List<Division>();
            CBB_phongban.Enabled = true;
            CBB_phongban.Items.Clear();
            listPB = GetPhongBan();
            for (int i = 0; i < listPB.Count; i++)
            {
                CBB_phongban.Items.Add(listPB[i].MaBoPhan + "-" + listPB[i].TenBoPhan);
            }
        }

        private List<Group> GetNhom(string maBoPhan)
        {
            List<Group> list = new List<Group>();
            list = GroupBLL.Instance.GetGroupListByDivisionId(maBoPhan);
            return list;
        }
        private void ReadNhom()
        {
            CBB_nhom.Enabled = true;
            CBB_nhom.Items.Clear();
            string maBoPhan = CBB_phongban.SelectedItem.ToString().Split('-')[0];
            List<Group> listNhom = new List<Group>();
            listNhom = GetNhom(maBoPhan);
            for (int i = 0; i < listNhom.Count; i++)
            {
                CBB_nhom.Items.Add((listNhom[i].MaNhom));
            }
        }


        private List<Employee> GetNV(string maNhom)
        {
            List<Employee> list = new List<Employee>();
            list = EmployeeBLL.Instance.GetEmployeesByGroup(maNhom);
            return list;
        }
        private void readNV()
        {
            CBB_manhanvien.Enabled = true;
            CBB_manhanvien.Items.Clear();
            List<Employee> listNV = new List<Employee>();
            listNV = GetNV(CBB_nhom.SelectedItem.ToString());
            for (int i = 0; i < listNV.Count; i++)
            {
                CBB_manhanvien.Items.Add(listNV[i].MaNhanVien + "_" + listNV[i].Ten);
            }
        }

        private void ThemCongViecNhanVien_Load(object sender, EventArgs e)
        {
            ReadPhongBan();
        }


        private void CBB_nhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_nhom.SelectedIndex != -1)
            {
                readNV();
            }
        }

        private void CBB_phongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_phongban.SelectedIndex != -1)
            {
                ReadNhom();
            }
        }

        public string maCongViec;
        public byte[] buffer = null;
        public string fileName;
        private void GetNewestJobID()
        {
            maCongViec = JobBLL.Instance.GetNewJobID();
            TXB_MaCongViec.Text = maCongViec;
        }
        private void CBB_manhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_manhanvien.SelectedIndex != -1)
            {
                TXB_noidung.Enabled = true;
                TXB_macanho.Enabled = true;
                GetNewestJobID();
                DTP_gio.Enabled = true;
                DTP_ngay.Enabled = true;
                BTN_file.Enabled = true;
            }
        }

        private void CBB_phongban_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBB_phongban.SelectedIndex != -1)
            {
                CBB_nhom.SelectedIndex = -1;
                CBB_manhanvien.SelectedIndex = -1;
                ReadNhom();
            }
        }

        private void CBB_nhom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBB_nhom.SelectedIndex != -1)
            {
                CBB_manhanvien.SelectedIndex = -1;
                readNV();
            }
        }

        // Tạo tham số cho bảng CongViec để truyền vào DataProvider
        private Dictionary<string, object> AddParameterCongViec()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@noiDung", TXB_noidung.Text},
                {"@ngayGiao", DateTime.UtcNow.ToString("yyyy-MM-dd'T'HH:mm:ss")},
                {"@thoihan",  DTP_ngay.Value.ToString("yyyy-MM-dd") + " " + DTP_gio.Text.Split(' ')[0].ToString()},
                {"@ngayHoanThanh", null},
                {"@ngayCapNhat", DateTime.UtcNow.ToString("yyyy-MM-dd'T'HH:mm:ss")},
                {"@trangThai", "Chưa bắt đầu"},
                {"@ghiChu", null}
            };
            return dict;
        }

        // Tạo tham số cho bảng CongViec_NhanVien để truyền vào DataProvider
        private Dictionary<string, object> AddParameterCongViec_NhanVien()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>
            {
                {"@maNhanVien",  CBB_manhanvien.SelectedItem.ToString().Split('_')[0].ToString()},
                {"@maCongViec", TXB_MaCongViec.Text},
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
                if (JobBLL.Instance.AddJob_Employee(AddParameterCongViec_NhanVien()))
                {
                    if (JobBLL.Instance.AddRequestFromCustom(AddParameterYeuCau()))
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

        private void BTN_ok_Click(object sender, EventArgs e)
        {
            if (TXB_MaCongViec != null & TXB_macanho != null & TXB_noidung != null)
            {
                if (SaveCongViec())
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
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
            LLB_hienfile.Text = fileName;
            LLB_hienfile.Show();
        }

        private void BTN_huy_Click(object sender, EventArgs e)
        {
            CBB_phongban.SelectedIndex = -1;
            CBB_nhom.SelectedIndex = -1;
            CBB_manhanvien.SelectedIndex = -1;
            TXB_noidung.Clear();
            TXB_MaCongViec.Clear();
            TXB_macanho.Clear();
            CBB_nhom.Enabled = false;
            CBB_manhanvien.Enabled = false;
            TXB_noidung.Enabled = false;
            TXB_macanho.Enabled= false;
            TXB_MaCongViec.Enabled = false;
            DTP_gio.Enabled = false;
            DTP_ngay.Enabled = false;   
            BTN_file.Enabled = false;
        }
    }
}
