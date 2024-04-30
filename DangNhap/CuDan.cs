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
    public partial class CuDan : Form
    {
        private int index = 0;
        public CuDan()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzIxOTI2MkAzMjM1MmUzMDJlMzBORkJZeFRVdUQxeERjT2xkWC9vdFgxS29wUmREOU9CZVdENkRUN0lrSStVPQ==;Mgo+DSMBaFt6QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRbQlliS3xTck1hW35Wcnc=");
            InitializeComponent();
        }
        private void DisplayGGC_chuho()
        {
            Console.WriteLine(ChuHoBLL.Instance.GetAllChuHo());
            GGC_cudan.DataSource = ChuHoBLL.Instance.GetAllChuHo().Select(e => new
            {
                e.MaCuDan, 
                e.MaCanHo,
                e.LoaiCuDan,
                e.HoTen,
                NgaySinh = e.NgaySinh.ToString("dd/MM/yyyy"),
                e.MaDinhDanh,
                e.SoDienThoai,
                e.Email,
                e.QuocTich,
                e.SoTheTamTru,
                NgayNhanBanGiaoCanHo = e.NgayNhanBanGiaoCanHo.ToString("dd/MM/yyyy"),
                NgayChuyenVao = e.NgayChuyenVao.ToString("dd/MM/yyyy"),
                NgayChuyenDi = e.NgayChuyenDi.HasValue ? e.NgayChuyenDi.Value.ToString("dd/MM/yyyy") : "",
                e.SoDienNuocNgayBanGiao,
                e.BienSoXeDangKy,
                e.MaCuDanBanGiao,
                e.MaCuDanLuuTruCung,
                e.TinhTrangCongNo,
                e.DuLieuDangKyThuNuoi,
            }).ToList();

            GGC_cudan.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_cudan.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            GGC_cudan.ShowGroupDropArea = true;
            GGC_cudan.BorderStyle = BorderStyle.FixedSingle;

            GridColumnDescriptorCollection columns = GGC_cudan.TableDescriptor.Columns;
            if (columns.Count > 0)
            {
                foreach (GridColumnDescriptor column in columns)
                {
                    // Thiết lập thuộc tính cho mỗi cột
                    column.AllowFilter = true;
                }

                // Thiết lập tiêu đề cho các cột
                string[] headers = { "Mã cư dân", "Mã căn hộ", "Loại cư dân", "Họ tên", "Ngày sinh", "Mã định danh", 
                    "Số điện thoại", "Email", "Quốc tịch", "Số thẻ tạm trú", 
                    "Ngày nhân bàn giao căn hộ", "Ngày chuyển vào", "Ngày chuyển đi", 
                    "Số điện nước ngày bàn giao", "Biển số xe đăng ký", "Mã cư dân bàn giao", 
                    "Mã cư dân lưu trú cùng", "Tình trạng công nợ", "Dữ liệu thú nuôi"};
                for (int i = 0; i < columns.Count && i < headers.Length; i++)
                {
                    columns[i].HeaderText = headers[i];
                }
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(GGC_cudan);

            GridExcelFilter excelFilter = new GridExcelFilter();
            excelFilter.WireGrid(GGC_cudan);
            // Thiết lập AutoSizeMode cho mỗi cột
            foreach (GridColumnDescriptor column in columns)
            {
                column.Appearance.AnyRecordFieldCell.AutoSize = true;
                column.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            }
        }
        private void DisplayGGC_uyquyen()
        {
            GGC_cudan.DataSource = NguoiDcUyQuyenChuHoBLL.Instance.GetAllNguoiUyQuyen().Select(e => new
            {
                e.MaCuDan,
                e.MaCanHo,
                e.LoaiCuDan,
                e.HoTen,
                NgaySinh = e.NgaySinh.ToString("dd/MM/yyyy"),
                e.MaDinhDanh,
                e.SoDienThoai,
                e.Email,
                e.QuocTich,
                e.SoTheTamTru,
                NgayChuyenVao = e.NgayChuyenVao.ToString("dd/MM/yyyy"),
                NgayChuyenDi = e.NgayChuyenDi.HasValue ? e.NgayChuyenDi.Value.ToString("dd/MM/yyyy") : "",
                e.BienSoXeDangKy,
                e.MaCuDanLuuTruCung,
                e.TinhTrangCongNo,
                e.DuLieuDangKyThuNuoi,
            }).ToList();

            GGC_cudan.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_cudan.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            GGC_cudan.ShowGroupDropArea = true;
            GGC_cudan.BorderStyle = BorderStyle.FixedSingle;

            GridColumnDescriptorCollection columns = GGC_cudan.TableDescriptor.Columns;
            if (columns.Count > 0)
            {
                foreach (GridColumnDescriptor column in columns)
                {
                    // Thiết lập thuộc tính cho mỗi cột
                    column.AllowFilter = true;
                }

                //Thiết lập tiêu đề cho các cột
                string[] headers = { "Mã cư dân", "Mã căn hộ", "Loại cư dân", "Họ tên", "Ngày sinh", "Mã định danh",
                    "Số điện thoại", "Email", "Quốc tịch", "Số thẻ tạm trú",
                    "Ngày chuyển vào", "Ngày chuyển đi", "Biển số xe đăng ký",
                    "Mã cư dân lưu trú cùng", "Tình trạng công nợ", "Dữ liệu thú nuôi"};
                for (int i = 0; i < columns.Count && i < headers.Length; i++)
                {
                    columns[i].HeaderText = headers[i];
                }
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(GGC_cudan);

            GridExcelFilter excelFilter = new GridExcelFilter();
            excelFilter.WireGrid(GGC_cudan);
            // Thiết lập AutoSizeMode cho mỗi cột
            foreach (GridColumnDescriptor column in columns)
            {
                column.Appearance.AnyRecordFieldCell.AutoSize = true;
                column.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            }
        }
        private void DisplayGGC_khachnganngay()
        {
            GGC_cudan.DataSource = KhachNganNgayBLL.Instance.GetAllKhachNganNgay().Select(e => new
            {
                e.MaCuDan,
                e.MaCanHo,
                e.LoaiCuDan,
                e.HoTen,
                NgaySinh = e.NgaySinh.ToString("dd/MM/yyyy"),
                e.MaDinhDanh,
                e.SoDienThoai,
                e.Email,
                e.QuocTich,
                e.SoTheTamTru,
                NgayChuyenVao = e.NgayChuyenVao.ToString("dd/MM/yyyy"),
                NgayChuyenDi = e.NgayChuyenDi.HasValue ? e.NgayChuyenDi.Value.ToString("dd/MM/yyyy") : "",
                e.BienSoXeDangKy,
                e.MaCuDanLuuTruCung,
                e.TinhTrangCongNo,
                e.DuLieuDangKyThuNuoi,
            }).ToList();

            GGC_cudan.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_cudan.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            GGC_cudan.ShowGroupDropArea = true;
            GGC_cudan.BorderStyle = BorderStyle.FixedSingle;

            GridColumnDescriptorCollection columns = GGC_cudan.TableDescriptor.Columns;
            if (columns.Count > 0)
            {
                foreach (GridColumnDescriptor column in columns)
                {
                    // Thiết lập thuộc tính cho mỗi cột
                    column.AllowFilter = true;
                }

                //Thiết lập tiêu đề cho các cột
                string[] headers = { "Mã cư dân", "Mã căn hộ", "Loại cư dân", "Họ tên", "Ngày sinh", "Mã định danh",
                    "Số điện thoại", "Email", "Quốc tịch", "Số thẻ tạm trú",
                    "Ngày chuyển vào", "Ngày chuyển đi", "Biển số xe đăng ký",
                    "Mã cư dân lưu trú cùng", "Tình trạng công nợ", "Dữ liệu thú nuôi"};
                for (int i = 0; i < columns.Count && i < headers.Length; i++)
                {
                    columns[i].HeaderText = headers[i];
                }
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(GGC_cudan);

            GridExcelFilter excelFilter = new GridExcelFilter();
            excelFilter.WireGrid(GGC_cudan);
            // Thiết lập AutoSizeMode cho mỗi cột
            foreach (GridColumnDescriptor column in columns)
            {
                column.Appearance.AnyRecordFieldCell.AutoSize = true;
                column.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            }
        }
        private void DisplayGGC_khachthuektm()
        {
            GGC_cudan.DataSource = KhachThueKhuThuongMaiBLL.Instance.GetAllKhachThue();
            GGC_cudan.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_cudan.ActivateCurrentCellBehavior = GridCellActivateAction.None;
            GGC_cudan.ShowGroupDropArea = true;
            GGC_cudan.BorderStyle = BorderStyle.FixedSingle;
            GridColumnDescriptorCollection columns = GGC_cudan.TableDescriptor.Columns;
            if (columns.Count > 0)
            {
                foreach (GridColumnDescriptor column in columns)
                {
                    // Thiết lập thuộc tính cho mỗi cột
                    column.AllowFilter = true;
                }

                // Thiết lập tiêu đề cho các cột
                string[] headers = { "Mã khách đang thuê", "Tên công ty", "Họ tên người đại diện", "Mã nhân viên phụ trách", 
                    "Số điện thoại", "Email", "Ngày ký họp đồng thuê", "Ngày chuyển vào", "Ngày chuyển đi", "Phí quản lý",
                    "Mô tả khu vực cho thuê", "Biển số xe đăng ký"};
                for (int i = 0; i < columns.Count && i < headers.Length; i++)
                {
                    columns[i].HeaderText = headers[i];
                }
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(GGC_cudan);

            GridExcelFilter excelFilter = new GridExcelFilter();
            excelFilter.WireGrid(GGC_cudan);
            // Thiết lập AutoSizeMode cho mỗi cột
            foreach (GridColumnDescriptor column in columns)
            {
                column.Appearance.AnyRecordFieldCell.AutoSize = true;
                column.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            }
        }

        private void CuDan_Load(object sender, EventArgs e)
        {
            CBB_choice.SelectedIndex = index;
            DisplayGGC_chuho();
        }

        private void CBB_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = CBB_choice.SelectedIndex;

            if (CBB_choice.SelectedIndex == 0)
            {
                GGC_cudan.DataSource = null;
                DisplayGGC_chuho();
            }
            else if (CBB_choice.SelectedIndex == 1)
            {
                GGC_cudan.DataSource = null;
                DisplayGGC_uyquyen();
            }
            else if (CBB_choice.SelectedIndex == 2)
            {
                GGC_cudan.DataSource = null;
                DisplayGGC_khachnganngay();
            }
            else if (CBB_choice.SelectedIndex == 3)
            {
                GGC_cudan.DataSource = null;
                DisplayGGC_khachthuektm();
            }
        }

        private void GGC_cudan_TableControlCellDoubleClick(object sender, GridTableControlCellClickEventArgs e)
        {
            GridTableCellStyleInfo style = e.TableControl.GetTableViewStyleInfo(e.Inner.RowIndex, e.Inner.ColIndex);
            GridTableCellStyleInfoIdentity id = style.TableCellIdentity;
            if (id.DisplayElement.Kind == DisplayElementKind.Record)
            {
                Record record = id.DisplayElement.GetRecord();
                ThongTinCuDan ttcd;
                // Extract data from the record
                if (record.GetValue("LoaiCuDan") == null)
                {
                    string maKhachThue = record.GetValue("MaKhachDangThue").ToString();
                    ThongTinKhachThueKTM tt = new ThongTinKhachThueKTM(this, KhachThueKhuThuongMaiBLL.Instance.GetKhachThueKTMByMaKhach(maKhachThue));
                    tt.ShowDialog();
                }
                else
                {
                    string loaiCuDan = record.GetValue("LoaiCuDan").ToString();
                    string maCuDan = record.GetValue("MaCuDan").ToString();
                    switch (loaiCuDan)
                    {
                        case "Chủ hộ":
                            ttcd = new ThongTinCuDan(this, ChuHoBLL.Instance.GetChuHoByMaCuDan(maCuDan));
                            ttcd.ShowDialog();
                            break;
                        case "Người được ủy quyền của chủ hộ":
                            ttcd = new ThongTinCuDan(this, NguoiDcUyQuyenChuHoBLL.Instance.GetNguoiUyQuyenByMaCuDan(maCuDan));
                            ttcd.ShowDialog();
                            break;
                        case "Khách ngắn ngày":
                        case "Khách vãng lai":
                        case "Nhân viên của chủ hộ":
                            ttcd = new ThongTinCuDan(this, KhachNganNgayBLL.Instance.GetKhachNganNgayByMaCuDan(maCuDan));
                            ttcd.ShowDialog();
                            break;
                    }
                }
            }
        }
    }
}
