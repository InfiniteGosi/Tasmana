using BLL;
using DTO;
using Syncfusion.GridHelperClasses;
using Syncfusion.Licensing;
using Syncfusion.Windows.Forms.Grid.Grouping;
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
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Shared;

namespace DangNhap
{
    public partial class NhanVien : Form
    {
        private Employee nhanVienChiTiet;
        private List<Employee> employees = new List<Employee>();
        public NhanVien()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzIxOTI2MkAzMjM1MmUzMDJlMzBORkJZeFRVdUQxeERjT2xkWC9vdFgxS29wUmREOU9CZVdENkRUN0lrSStVPQ==;Mgo+DSMBaFt6QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRbQlliS3xTck1hW35Wcnc=");
            InitializeComponent();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            DisplayGGC_danhsachnhanvien();
        }
        // Gọi hàm lấy nhân viên
        private void GetEmployees()
        {
            employees = EmployeeBLL.Instance.GetEmployeeList();
        }
     
        // Nhấn nút thêm nhân viên sẽ mở cửa sổ thông tin nhân viên
        private void BTN_themnhanvien_Click(object sender, EventArgs e)
        {
            // Truyền form để refresh dgv
            ThongTinCaNhan ttcn = new ThongTinCaNhan(this);
            ttcn.ShowDialog();
        }
        // Lấy thông tin nhân viên bằng mã nhân viên
        private void GetEmployeeByEmployeeId(string maNhanVien)
        {
            nhanVienChiTiet =  EmployeeBLL.Instance.GetEmployeeByEmployeeId(maNhanVien);
        }
        // Phương thức refresh lại GGC
        public override void Refresh()
        {
            employees = new List<Employee>();
            DisplayGGC_danhsachnhanvien();
        }
        // Hiển thị dữ liệu lên GGC_danhsachnhanvien
        private void DisplayGGC_danhsachnhanvien()
        {
            GetEmployees();
            GGC_danhsachnv.DataSource = employees.Select(e => new
            {
                e.MaNhanVien,
                e.Ho,
                e.Ten,
                e.Email,
                e.SoDienThoai,
                NgaySinh = e.NgaySinh.ToString("dd/MM/yyyy"),
                GioiTinh = e.GioiTinh ? "Nam" : "Nữ",
                e.QueQuan,
                e.MaDinhDanh,
                e.LoaiNhanVien,
                e.TinhTrangHonNhan,
                e.MaSoBHXH,
                e.DaTungLamNhanVien,
                NgayKyHDLD = e.NgayKyHDLD.ToString("dd/MM/yyyy"),
                NgayHetHDLD = e.NgayHetHDLD.ToString("dd/MM/yyyy"),
                e.DiaChiThuongTru,
                e.DiaChiTamTru,
                e.TinhTrangHDLD,
                e.MaNhom,
                e.TaiKhoanNguoiDung
            }).ToList();
            
            GGC_danhsachnv.TableDescriptor.Columns[0].HeaderText = "Mã nhân viên";
            GGC_danhsachnv.TableDescriptor.Columns[1].HeaderText = "Họ";
            GGC_danhsachnv.TableDescriptor.Columns[2].HeaderText = "Tên";
            GGC_danhsachnv.TableDescriptor.Columns[3].HeaderText = "Email";
            GGC_danhsachnv.TableDescriptor.Columns[4].HeaderText = "Số điện thoại";
            GGC_danhsachnv.TableDescriptor.Columns[5].HeaderText = "Ngày sinh";
            GGC_danhsachnv.TableDescriptor.Columns[6].HeaderText = "Giới tính";
            GGC_danhsachnv.TableDescriptor.Columns[7].HeaderText = "Quê quán";
            GGC_danhsachnv.TableDescriptor.Columns[8].HeaderText = "Mã định danh";
            GGC_danhsachnv.TableDescriptor.Columns[9].HeaderText = "Loại nhân viên";
            GGC_danhsachnv.TableDescriptor.Columns[10].HeaderText = "Tình trạng hôn nhân";
            GGC_danhsachnv.TableDescriptor.Columns[11].HeaderText = "Mã số bảo hiểm xã hội";
            GGC_danhsachnv.TableDescriptor.Columns[12].HeaderText = "Đã từng làm nhân viên";
            GGC_danhsachnv.TableDescriptor.Columns[13].HeaderText = "Ngày ký hợp đồng lao động";
            GGC_danhsachnv.TableDescriptor.Columns[14].HeaderText = "Ngày hết hợp đồng lao động";
            GGC_danhsachnv.TableDescriptor.Columns[15].HeaderText = "Địa chỉ thường trú";
            GGC_danhsachnv.TableDescriptor.Columns[16].HeaderText = "Địa chỉ tạm trú";
            GGC_danhsachnv.TableDescriptor.Columns[17].HeaderText = "Tình trạng hợp đồng lao động";
            GGC_danhsachnv.TableDescriptor.Columns[18].HeaderText = "Mã Nhóm";
            GGC_danhsachnv.TableDescriptor.Columns[19].HeaderText = "Mã tài khoản nhân viên";
            GGC_danhsachnv.TableDescriptor.VisibleColumns.Remove("TaiKhoanNguoiDung_Password");
            GGC_danhsachnv.TableDescriptor.VisibleColumns.Remove("TaiKhoanNguoiDung_EmployeeId");
            GGC_danhsachnv.TableDescriptor.Columns[22].HeaderText = "Phân quyền";
            GGC_danhsachnv.TableDescriptor.Columns[23].HeaderText = "Tài khoản đã bị vô hiệu hóa";

            GGC_danhsachnv.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_danhsachnv.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            GGC_danhsachnv.ShowGroupDropArea = true;
            GGC_danhsachnv.BorderStyle = BorderStyle.FixedSingle;

            //// Tạo đối tượng GridColumnDescriptorCollection để quản lý các cột
            GridColumnDescriptorCollection columns = GGC_danhsachnv.TableDescriptor.Columns;
            foreach (GridColumnDescriptor column in columns)
            {
                column.AllowFilter = true;
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(GGC_danhsachnv);

            GridExcelFilter excelFilter = new GridExcelFilter();
            excelFilter.WireGrid(GGC_danhsachnv);
            // Thiết lập AutoSizeMode cho mỗi cột
            foreach (GridColumnDescriptor column in columns)
            {
                column.Appearance.AnyRecordFieldCell.AutoSize = true;
                column.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            }
        }

        private void GGC_danhsachnv_TableControlCellDoubleClick(object sender, GridTableControlCellClickEventArgs e)
        {
            // Get the index of the clicked row
            int rowIndex = e.Inner.RowIndex - 5;
            // Check if the clicked row index is valid
            if (rowIndex >= 0 && rowIndex < GGC_danhsachnv.Table.Records.Count)
            {
                // Get the record corresponding to the clicked row
                Record record = GGC_danhsachnv.Table.Records[rowIndex];

                // Extract data from the record
                string maNhanVien = record.GetValue("MaNhanVien").ToString();
                GetEmployeeByEmployeeId(maNhanVien);
                ThongTinCaNhan ttcn = new ThongTinCaNhan(this, nhanVienChiTiet);
                ttcn.ShowDialog();
            }
        }

        private void BTN_themnhom_Click(object sender, EventArgs e)
        {
            ThemNhom tn = new ThemNhom();
            tn.Show();
        }
    }
}
