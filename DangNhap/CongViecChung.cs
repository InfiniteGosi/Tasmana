﻿using BLL;
using DTO;
using Syncfusion.GridHelperClasses;
using Syncfusion.Grouping;
using Syncfusion.Licensing;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace DangNhap
{
    public partial class CongViecChung : Form
    {
        private List<Job> jobs = new List<Job>();

        private void GetJobs()
        {
            jobs = JobBLL.Instance.GetJob();
        }

        public CongViecChung()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzIxOTI2MkAzMjM1MmUzMDJlMzBORkJZeFRVdUQxeERjT2xkWC9vdFgxS29wUmREOU9CZVdENkRUN0lrSStVPQ==;Mgo+DSMBaFt6QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRbQlliS3xTck1hW35Wcnc=");
            InitializeComponent();

        }

        private void BTN_themcongviec_Click(object sender, EventArgs e)
        {
            ThemCongViecNhanVien tcv = new ThemCongViecNhanVien();
            tcv.Show();
        }

        private void BTN_chitietcongviec_Click(object sender, EventArgs e)
        {
            ChiTietCongViec ctcv = new ChiTietCongViec();
            ctcv.Show();
        }

        private void CongViecChung_Load(object sender, EventArgs e)
        {
            GetJobs();
            GGC_hienthicongviec.Size = new System.Drawing.Size(950, 300);
            GGC_hienthicongviec.DataSource = jobs;
            GGC_hienthicongviec.TableDescriptor.Columns[0].HeaderText = "Mã công việc";
            GGC_hienthicongviec.TableDescriptor.Columns[1].HeaderText = "Mã nhân viên";
            GGC_hienthicongviec.TableDescriptor.Columns[2].HeaderText = "Họ";
            GGC_hienthicongviec.TableDescriptor.Columns[3].HeaderText = "Tên";
            GGC_hienthicongviec.TableDescriptor.Columns[4].HeaderText = "Nội dung";
            GGC_hienthicongviec.TableDescriptor.Columns[5].HeaderText = "Mã căn hộ";
            GGC_hienthicongviec.TableDescriptor.Columns[6].HeaderText = "Ngày giao";
            GGC_hienthicongviec.TableDescriptor.Columns[7].HeaderText = "Thời hạn";
            GGC_hienthicongviec.TableDescriptor.Columns[8].HeaderText = "Ngày hoàn thành";
            GGC_hienthicongviec.TableDescriptor.Columns[9].HeaderText = "Ngày cập nhật";
            GGC_hienthicongviec.TableDescriptor.Columns[10].HeaderText = "Trạng thái";
            GGC_hienthicongviec.TableDescriptor.Columns[11].HeaderText = "Ghi chú";

            GGC_hienthicongviec.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_hienthicongviec.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            GGC_hienthicongviec.ShowGroupDropArea = true;
            GGC_hienthicongviec.BorderStyle = BorderStyle.FixedSingle;

            // Tạo đối tượng GridColumnDescriptorCollection để quản lý các cột
            GridColumnDescriptorCollection columns = GGC_hienthicongviec.TableDescriptor.Columns;
            foreach (GridColumnDescriptor column in columns)
            {
                column.AllowFilter = true;
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(GGC_hienthicongviec);

            GridExcelFilter excelFilter = new GridExcelFilter();
            excelFilter.WireGrid(GGC_hienthicongviec);
            // Thiết lập AutoSizeMode cho mỗi cột
            foreach (GridColumnDescriptor column in columns)
            {
                column.Appearance.AnyRecordFieldCell.AutoSize = true;
                column.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            }
            if (!DangNhap.currentAccount.Level.Equals("CEO"))
            {
                BTN_themcongviec.Enabled = false;
                BTN_themcongviec.Visible = false;
            }
        }


        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            if (GGC_hienthicongviec.Table.Records.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "CongViec.pdf"
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
                            Export export = new Export();
                            export.ToPDF(GGC_hienthicongviec, save.FileName);

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

        private void BTN_excel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("Mã công việc");
            DataColumn col2 = new DataColumn("Mã nhân viên");
            DataColumn col3 = new DataColumn("Họ");
            DataColumn col4 = new DataColumn("Tên");
            DataColumn col5 = new DataColumn("Nội dung");
            DataColumn col6 = new DataColumn("Mã căn hộ");
            DataColumn col7 = new DataColumn("Ngày giao");
            DataColumn col8 = new DataColumn("Ngày cập nhật");
            DataColumn col9 = new DataColumn("Thời hạn");
            DataColumn col10 = new DataColumn("Ngày hoàn thành");
            DataColumn col11 = new DataColumn("Trạng thái");
            DataColumn col12 = new DataColumn("Ghi chú");

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

            foreach (Record record in GGC_hienthicongviec.Table.Records)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = record.GetValue("MaCongViec");
                dtRow[1] = record.GetValue("MaNhanVien");
                dtRow[2] = record.GetValue("Ho");
                dtRow[3] = record.GetValue("Ten");
                dtRow[4] = record.GetValue("NoiDung");
                dtRow[5] = record.GetValue("MaCanHo");
                dtRow[6] = record.GetValue("NgayGiao");
                dtRow[7] = record.GetValue("NgayCapNhat");
                dtRow[8] = record.GetValue("ThoiHan");
                dtRow[9] = record.GetValue("NgayHoanThanh");
                dtRow[10] = record.GetValue("TrangThai");
                dtRow[11] = record.GetValue("GhiChu");

                dataTable.Rows.Add(dtRow);
            }
            Export export = new Export();
            export.ToExcel(dataTable, "Cong_viec", "CÔNG VIỆC CHUNG");

        }

        private void BTN_in_Click(object sender, EventArgs e)
        {
            GGC_hienthicongviec.TableModel.Properties.PrintFrame = false;

            GridPrintDocumentAdv gridPrintDocument = new GridPrintDocumentAdv(GGC_hienthicongviec.TableControl);
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
