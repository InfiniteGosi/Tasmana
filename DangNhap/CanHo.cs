﻿using DTO;
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
        private List<KhuThuongMai> arrKhuThuongMai;
        private int index = 0;
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

        private void DisplayGGC_canho()
        {
            GetApartments();
            GGC_canho.DataSource = apartments.Select(e => new
            {
                e.MaCanHo,
                e.DienTichGSA,
                e.DienTichNSA,
                e.ViTriTang,
                e.SoLuongPhongNgu,
                e.SoLuongToilet,
                e.SoLuongTheThangMay,
                e.MucPhiQuanLyHangThang,
                e.TinhTrangGiaoDichHienTai,
                e.MaCuDan

            }).ToList();

            GGC_canho.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_canho.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            GGC_canho.ShowGroupDropArea = true;
            GGC_canho.BorderStyle = BorderStyle.FixedSingle;

            GridColumnDescriptorCollection columns = GGC_canho.TableDescriptor.Columns;
            if (columns.Count > 0)
            {
                foreach (GridColumnDescriptor column in columns)
                {
                    // Thiết lập thuộc tính cho mỗi cột
                    column.AllowFilter = true;
                }

                // Thiết lập tiêu đề cho các cột
                string[] headers = { "Mã căn hộ", "Diện tích GSA", "Diện tích NSA", "Vị trí tầng", "Số lượng phòng ngủ", "Số lượng toilet", "Số lượng thẻ thang máy", "Mức phí quản lý hàng tháng", "Tình trạng giao dịch hiện tại", "Mã cư dân" };
                for (int i = 0; i < columns.Count && i < headers.Length; i++)
                {
                    columns[i].HeaderText = headers[i];
                }
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
        private void GetListKhuThuongMai()
        {
            arrKhuThuongMai = KhuThuongMaiBLL.Instance.GetAllKhuThuongMai();
        }

        private void DisplayGGC_khuthuongmai()
        {
            GetListKhuThuongMai();
            GGC_canho.DataSource = arrKhuThuongMai.Select(e => new
            {
                e.MaCanHo,
                e.MaKhachDangThue,
                e.DienTichGSA,
                e.DienTichNSA,
                e.ViTriTang,
                e.SoLuongPhongNgu,
                e.SoLuongToilet,
                e.SoLuongTheThangMay,
                e.MucPhiQuanLyHangThang,
            }).ToList();

            GGC_canho.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_canho.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            GGC_canho.ShowGroupDropArea = true;
            GGC_canho.BorderStyle = BorderStyle.FixedSingle;

            GridColumnDescriptorCollection columns = GGC_canho.TableDescriptor.Columns;
            if (columns.Count > 0)
            {
                foreach (GridColumnDescriptor column in columns)
                {
                    // Thiết lập thuộc tính cho mỗi cột
                    column.AllowFilter = true;
                }

                // Thiết lập tiêu đề cho các cột
                string[] headers = { "Mã khu thương mại", "Mã khách đang thuê", "Diện tích GSA", "Diện tích NSA", "Vị trí tầng", "Số lượng phòng ngủ", "Số lượng toilet", "Số lượng thẻ thang máy", "Mức phí quản lý hàng tháng"};
                for (int i = 0; i < columns.Count && i < headers.Length; i++)
                {
                    columns[i].HeaderText = headers[i];
                }
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
            CBB_choice.SelectedIndex = index;
            DisplayGGC_canho();
        }
        
        private void GGC_canho_TableControlCellDoubleClick(object sender, GridTableControlCellClickEventArgs e)
        {
            GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
            GridTableCellStyleInfoIdentity id = style.TableCellIdentity;
            if (id.DisplayElement.Kind == DisplayElementKind.Record)
            {
                Record record = id.DisplayElement.GetRecord();
                // Extract data from the record
                string maCanHo = record.GetValue("MaCanHo").ToString();
                if (!maCanHo.Contains("KTM"))
                {
                    ChiTietCanHo ctch = new ChiTietCanHo(this, maCanHo);
                    ctch.ShowDialog();
                }
                else
                {
                    ChiTietKhuThuongMai ctktm = new ChiTietKhuThuongMai(this, maCanHo);
                    ctktm.ShowDialog();
                }
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
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = gridPrintDocument
            };

            printPreviewDialog.ShowDialog();
            printDialog.Document = gridPrintDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                gridPrintDocument.Print();
        }

        private void CBB_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = CBB_choice.SelectedIndex;
            
            if (CBB_choice.SelectedIndex == 0)
            {
                GGC_canho.DataSource = null;
                DisplayGGC_canho();
            }
            else if (CBB_choice.SelectedIndex == 1)
            {
                GGC_canho.DataSource = null;
                DisplayGGC_khuthuongmai();
            }
        }

        private void BTN_XemHoaDon_Click(object sender, EventArgs e)
        {
            ChiPhiHangThang cpht = new ChiPhiHangThang();
            cpht.ShowDialog();
        }
    }
}
