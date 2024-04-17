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

namespace DangNhap
{
    public partial class CanHo : Form
    {
        private List<Apartment> apartments;
        private Apartment canHoChiTiet;
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
            GGC_canho.TableDescriptor.Columns[6].HeaderText = "Lịch sử giao dịch";
            GGC_canho.TableDescriptor.Columns[7].HeaderText = "Tình trạng giao dịch hiện tại";
            GGC_canho.TableDescriptor.Columns[8].HeaderText = "Mã cư dân";

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
        private void GetApartmentById(string maCanHo)
        {
            canHoChiTiet = ApartmentBLL.Instance.GetApartmentById(maCanHo);
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
                string maNhanVien = record.GetValue("MaCanHo").ToString();
                GetApartmentById(maNhanVien);
                ChiTietCanHo ctch = new ChiTietCanHo(this, canHoChiTiet);
                ctch.ShowDialog();
            }
        }
    }
}
