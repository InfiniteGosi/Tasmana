using DTO;
using Syncfusion.Licensing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using System.IO;

namespace DangNhap
{
    public partial class CanHo : Form
    {
        private List<Apartment> apartments;
        public CanHo()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzIxOTI2MkAzMjM1MmUzMDJlMzBORkJZeFRVdUQxeERjT2xkWC9vdFgxS29wUmREOU9CZVdENkRUN0lrSStVPQ==;Mgo+DSMBaFt6QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRbQlliS3xTck1hW35Wcnc=");
            InitializeComponent();
        }

        private void BTN_themcanho_Click(object sender, EventArgs e)
        {
            ChiTietCanHo ctch = new ChiTietCanHo(this);
            ctch.ShowDialog();
        }
        private void GetApartments()
        {
            apartments = ApartmentBLL.Instance.GetApartmentList();
        }

        private void DisplayGCC_canho()
        {
            GetApartments();
            GGC_canho.DataSource = apartments;
            GGC_canho.DataSource = apartments.Select(e => new
            {
                e.MaCanHo,
                e.DienTich,
                e.ViTriTang,
                e.SoLuongPhongNgu,
                e.SoLuongToilet,
                e.SoLuongTheThangMay,
                e.MucPhiQuanLyHangThang,
                LichSuGiaoDich = e.LichSuGiaoDich.ToString("dd/MM/yyyy"),
                e.TinhTrangGiaoDichHienTai,
                e.MaCuDan

            }).ToList();

            GGC_canho.TableDescriptor.Columns[0].HeaderText = "Mã căn hộ";
            GGC_canho.TableDescriptor.Columns[1].HeaderText = "Diện tích";
            GGC_canho.TableDescriptor.Columns[2].HeaderText = "Vị trí tầng";
            GGC_canho.TableDescriptor.Columns[3].HeaderText = "Số lượng phòng ngủ";
            GGC_canho.TableDescriptor.Columns[4].HeaderText = "Số lượng toilet";
            GGC_canho.TableDescriptor.Columns[5].HeaderText = "Số lượng thẻ thang máy";
            GGC_canho.TableDescriptor.Columns[6].HeaderText = "Mức phí quản lý hàng tháng";
            GGC_canho.TableDescriptor.Columns[7].HeaderText = "Lịch sử giao dịch";
            GGC_canho.TableDescriptor.Columns[8].HeaderText = "Tình trạng giao dịch hiện tại";
            GGC_canho.TableDescriptor.Columns[9].HeaderText = "Mã cư dân";

            GGC_canho.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_canho.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            GGC_canho.ShowGroupDropArea = true;
            GGC_canho.BorderStyle = BorderStyle.FixedSingle;

            //// Tạo đối tượng GridColumnDescriptorCollection để quản lý các cột
            GridColumnDescriptorCollection columns = GGC_canho.TableDescriptor.Columns;
            foreach (GridColumnDescriptor column in columns)
            {
                column.AllowFilter = true;
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(GGC_canho);

            GridExcelFilter excelFilter = new GridExcelFilter();
            excelFilter.WireGrid(GGC_canho);
            // Thiết lập AutoSizeMode cho mỗi cột
            foreach (GridColumnDescriptor column in columns)
            {
                column.Appearance.AnyRecordFieldCell.AutoSize = true;
                column.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            }
        }

        private void CanHo_Load(object sender, EventArgs e)
        {
            DisplayGCC_canho();
        }
        

        private void GGC_canho_TableControlCellDoubleClick(object sender, GridTableControlCellClickEventArgs e)
        {
            // Get the index of the clicked row
            int rowIndex = e.Inner.RowIndex - 5;
            // Check if the clicked row index is valid
            if (rowIndex >= 0 && rowIndex < GGC_canho.Table.Records.Count)
            {
                // Get the record corresponding to the clicked row
                Record record = GGC_canho.Table.Records[rowIndex];

                // Extract data from the record
                string maCanHo = record.GetValue("MaCanHo").ToString();
                ChiTietCanHo ctch = new ChiTietCanHo(this, maCanHo);
                ctch.ShowDialog();
            }
        }

        private DataTable GetDataTable()
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("Mã căn hộ");
            DataColumn col2 = new DataColumn("Diện tích");
            DataColumn col3 = new DataColumn("Vị trí tầng");
            DataColumn col4 = new DataColumn("Số lượng phòng ngủ");
            DataColumn col5 = new DataColumn("Số lượng toilet");
            DataColumn col6 = new DataColumn("Số lượng thẻ thang máy");
            DataColumn col7 = new DataColumn("Mức phí quản lý hàng tháng");
            DataColumn col8 = new DataColumn("Lịch sử giao dịch");
            DataColumn col9 = new DataColumn("Tình trạng giao dịch hiện tại");
            DataColumn col10 = new DataColumn("Mã cư dân");

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

            foreach (Record record in GGC_canho.Table.Records)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = record.GetValue("MaCanHo");
                dtRow[1] = record.GetValue("DienTich");
                dtRow[2] = record.GetValue("ViTriTang");
                dtRow[3] = record.GetValue("SoLuongPhongNgu");
                dtRow[4] = record.GetValue("SoLuongToilet");
                dtRow[5] = record.GetValue("SoLuongTheThangMay");
                dtRow[6] = record.GetValue("MucPhiQuanLyHangThang");
                dtRow[7] = record.GetValue("LichSuGiaoDich");
                dtRow[8] = record.GetValue("TinhTrangGiaoDichHienTai");
                dtRow[9] = record.GetValue("MaCuDan");

                dataTable.Rows.Add(dtRow);
            }
            return dataTable;
        }
        private void BTN_excel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetDataTable();
            Export export = new Export();
            export.ToExcelCH(dataTable, "Can_Ho", "CĂN HỘ");
        }

        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            if (GGC_canho.Table.Records.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "CanHo.pdf"
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
            GGC_canho.TableModel.Properties.PrintFrame = false;

            GridPrintDocumentAdv gridPrintDocument = new GridPrintDocumentAdv(GGC_canho.TableControl);
            PrintDialog printDialog = new PrintDialog();
            gridPrintDocument.ScaleColumnsToFitPage = true;
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = gridPrintDocument;

            printPreviewDialog.ShowDialog();
            printDialog.Document = gridPrintDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                gridPrintDocument.Print();
        }
    }
}
