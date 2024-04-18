﻿
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
using DAO;

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
            GGC_danhsachnv.Size = new System.Drawing.Size(950, 404);
            GGC_danhsachnv.DataSource = JobDAO.Instance.GetEmployees();
            
            GGC_danhsachnv.TableDescriptor.Columns[0].HeaderText = "Mã nhân viên";
            GGC_danhsachnv.TableDescriptor.Columns[1].HeaderText = "Họ";
            GGC_danhsachnv.TableDescriptor.Columns[2].HeaderText = "Tên";
            GGC_danhsachnv.TableDescriptor.Columns[3].HeaderText = "Mã bộ phận";
            GGC_danhsachnv.TableDescriptor.Columns[4].HeaderText = "Tổng công việc";
            GGC_danhsachnv.TableDescriptor.Columns[5].HeaderText = "Hoàn thành";
            GGC_danhsachnv.TableDescriptor.Columns[6].HeaderText = "Đang thực hiện";
            GGC_danhsachnv.TableDescriptor.Columns[7].HeaderText = "Chưa bắt đầu";
            GGC_danhsachnv.TableDescriptor.Columns[8].HeaderText = "Trễ Hạn";


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
                string maNhanVien = record.GetValue("maNhanVien").ToString();
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
