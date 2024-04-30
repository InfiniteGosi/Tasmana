
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
using System.IO;

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
            GGC_danhsachnv.DataSource = EmployeeBLL.Instance.GetEmployees();
            
            GGC_danhsachnv.TableDescriptor.Columns[0].HeaderText = "Mã nhân viên";
            GGC_danhsachnv.TableDescriptor.Columns[1].HeaderText = "Họ";
            GGC_danhsachnv.TableDescriptor.Columns[2].HeaderText = "Tên";
            GGC_danhsachnv.TableDescriptor.Columns[3].HeaderText = "Mã định danh";
            GGC_danhsachnv.TableDescriptor.Columns[4].HeaderText = "Mã Bộ phận";
            GGC_danhsachnv.TableDescriptor.Columns[5].HeaderText = "Chức vụ";
            GGC_danhsachnv.TableDescriptor.Columns[6].HeaderText = "Tổng công việc";
            GGC_danhsachnv.TableDescriptor.Columns[7].HeaderText = "Hoàn thành";
            GGC_danhsachnv.TableDescriptor.Columns[8].HeaderText = "Chưa bắt đầu";
            GGC_danhsachnv.TableDescriptor.Columns[9].HeaderText = "Đang thực hiện";
            GGC_danhsachnv.TableDescriptor.Columns[10].HeaderText = "Trễ hạn";
            GGC_danhsachnv.TableDescriptor.Columns[11].HeaderText = "Công việc Phòng ban";
            GGC_danhsachnv.TableDescriptor.Columns[12].HeaderText = "Công việc Nhóm";


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
            GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
            GridTableCellStyleInfoIdentity id = style.TableCellIdentity;
            if (id.DisplayElement.Kind == DisplayElementKind.Record)
            {
                Record record = id.DisplayElement.GetRecord();
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
        private DataTable GetDataTable()
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("Mã nhân viên");
            DataColumn col2 = new DataColumn("Họ");
            DataColumn col3 = new DataColumn("Tên");
            DataColumn col4 = new DataColumn("Mã định danh");
            DataColumn col5 = new DataColumn("Mã Bộ phận");
            DataColumn col6 = new DataColumn("Chức vụ");
            DataColumn col7 = new DataColumn("Tổng công việc");
            DataColumn col8 = new DataColumn("Hoàn thành");
            DataColumn col9 = new DataColumn("Chưa bắt đầu");
            DataColumn col10 = new DataColumn("Đang thực hiện");
            DataColumn col11 = new DataColumn("Trễ hạn");
            DataColumn col12 = new DataColumn("Công việc Phòng ban");
            DataColumn col13 = new DataColumn("Công việc Nhóm");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);
            dataTable.Columns.Add(col10);
            dataTable.Columns.Add(col11);
            dataTable.Columns.Add(col12);
            dataTable.Columns.Add(col13);

            foreach (Record record in GGC_danhsachnv.Table.Records)
            {
                DataRow dtRow = dataTable.NewRow();
                dtRow[0] = record.GetValue("maNhanVien");
                dtRow[1] = record.GetValue("ho");
                dtRow[2] = record.GetValue("ten");
                dtRow[3] = record.GetValue("maDinhDanh");
                dtRow[4] = record.GetValue("maBoPhan");
                dtRow[5] = record.GetValue("chucVu");
                dtRow[6] = record.GetValue("tongCongViec");
                dtRow[7] = record.GetValue("hoanThanh");
                dtRow[8] = record.GetValue("chuaBatDau");
                dtRow[9] = record.GetValue("dangThucHien");
                dtRow[10] = record.GetValue("treHan");
                dtRow[11] = record.GetValue("congViecPhongBan");
                dtRow[12] = record.GetValue("congViecNhom");
                dataTable.Rows.Add(dtRow);
            }
            return dataTable;
        }
        private void BTN_excel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetDataTable();
            Export export = new Export();
            export.ToExcelNV(dataTable, "Nhan_vien", "NHÂN VIÊN");

        }

        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            if (GGC_danhsachnv.Table.Records.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "NhanVien.pdf"
                };
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            DataTable dataTable = GetDataTable();
                            Export export = new Export();
                            export.ToPDF(dataTable, save.FileName);

                            MessageBox.Show("Successful", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No record found", "Info");
            }
        }

        private void BTN_in_Click(object sender, EventArgs e)
        {
            GGC_danhsachnv.TableModel.Properties.PrintFrame = false;

            GridPrintDocumentAdv gridPrintDocument = new GridPrintDocumentAdv(GGC_danhsachnv.TableControl);
            PrintDialog printDialog = new PrintDialog();
            gridPrintDocument.ScaleColumnsToFitPage = true;
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = gridPrintDocument;

            printPreviewDialog.ShowDialog();
            printDialog.Document = gridPrintDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                gridPrintDocument.Print();
        }

        private void BTN_PhongBan_Click(object sender, EventArgs e)
        {
            ThemPhongBan themPhongBan = new ThemPhongBan();
            themPhongBan.ShowDialog();
        }
    }
}
