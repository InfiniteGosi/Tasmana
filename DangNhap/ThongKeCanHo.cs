using BLL;
using DTO;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class ThongKeCanHo : Form
    {
        public ThongKeCanHo()
        {
            InitializeComponent();
        }

        private void CBB_DuLieuTK_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CBB_DuLieuTK.SelectedItem.Equals("Mã căn hộ")) 
            {
                string[] ListOption = {"Công nợ", "Danh sách yêu cầu", "Tổng chi phí điện/nước", "Tổng chi phí quản lý", "Các phí dịch vụ khác", "Tình trạng căn hộ"};
                foreach(string option in ListOption) 
                {
                    CBB_DuLieuMuonThongKe.Items.Add(option);
                }
            }
            if(CBB_DuLieuTK.SelectedItem.Equals("Nhân viên"))
            {
                CBB_DuLieuMuonThongKe.Enabled = false;

            }
        }

        private void LoadApartment()
        {
            List<Apartment> list = new List<Apartment>();   
            list = ApartmentBLL.Instance.GetApartmentList();
            CBB_LoaiThoiGian.Items.Clear();
            CBB_LoaiThoiGian.Items.Add("Tất cả");
            foreach(Apartment a in list)
            {
                CBB_LoaiThoiGian.Items.Add(a.MaCanHo);
            }
        }
        private void CBB_DuLieuMuonThongKe_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CBB_DuLieuMuonThongKe.SelectedItem.Equals("Công nợ"))
            {
                CBB_TinhTrang.Enabled = false;
                CBB_ThoiGian.Enabled = false;
                CBB_LoaiThoiGian.Enabled = true;
                LB_ThoiGianTK.Text = "Chọn mã căn hộ";
                LoadApartment();
                CBB_LoaiThoiGian.Focus();
            }
            if(CBB_DuLieuMuonThongKe.SelectedItem.Equals("Danh sách yêu cầu"))
            {
                CBB_TinhTrang.Enabled = false;
                CBB_ThoiGian.Enabled = false;
                CBB_LoaiThoiGian.Enabled = false;
                BTN_ThongKe.Focus();
            }
            if(CBB_DuLieuMuonThongKe.SelectedItem.Equals("Tổng chi phí điện/nước"))
            {
                CBB_LoaiThoiGian.Enabled = true;
                CBB_LoaiThoiGian.Items.Clear();
                string[] optionList = { "Ngày", "Tháng", "Quý", "Năm" };
                foreach(string option in optionList)
                {
                    CBB_LoaiThoiGian.Items.Add(option);
                }
                CBB_LoaiThoiGian.Focus();
            }
        }

        private void CBB_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CBB_ThoiGian_SelectedValueChanged(object sender, EventArgs e)
        {
            CBB_TinhTrang.Enabled = false;
            if(CBB_ThoiGian.SelectedIndex != -1)
            {
                CBB_TinhTrang.Enabled = true;
                CBB_TinhTrang.Items.Clear();
                string[] options = { "Tất cả", "Chưa thanh toán", "Đã thanh toán" };
            }
        }
        private void CBB_LoaiThoiGian_SelectedValueChanged(object sender, EventArgs e)
        {
            DTP_TuNgay.Enabled = false;
            DTP_DenNgay.Enabled = false;
            if (CBB_DuLieuMuonThongKe.SelectedItem.Equals("Tổng chi phí điện/nước"))
            {
                if (CBB_LoaiThoiGian.SelectedItem.Equals("Ngày"))
                {
                    DTP_TuNgay.Enabled = true;
                    DTP_DenNgay.Enabled = true;
                    DTP_TuNgay.Focus();
                }
                if (CBB_LoaiThoiGian.SelectedItem.Equals("Tháng"))
                {
                    CBB_ThoiGian.Enabled = true;
                    string[] listMonth = {"Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6","Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"};
                    CBB_ThoiGian.Items.Clear();
                    foreach(string m in listMonth)
                    {
                        CBB_ThoiGian.Items.Add(m);
                    }
                    CBB_ThoiGian.Focus();
                }
                if (CBB_LoaiThoiGian.SelectedItem.Equals("Quý"))
                {
                    CBB_ThoiGian.Enabled = true;
                    string[] listQuy = {"Quý 1", "Quý 2", "Quý 3", "Quý 4"};
                    CBB_ThoiGian.Items.Clear();
                    foreach (string m in listQuy)
                    {
                        CBB_ThoiGian.Items.Add(m);
                    }
                    CBB_ThoiGian.Focus();
                }
                if (CBB_LoaiThoiGian.SelectedItem.Equals("Năm"))
                {
                    CBB_ThoiGian.Enabled = true;
                    List<int> years = ApartmentBLL.Instance.GetYearList();
                    CBB_ThoiGian.Items.Clear();
                    for (int i = 0; i < years.Count; i++)
                    {
                        CBB_ThoiGian.Items.Add(years[i]);
                    }
                    CBB_ThoiGian.Focus();
                }
            }
        }
        private void LoadGGC()
        {
            GGC_ThongKe.Size = new System.Drawing.Size(950, 404);
            GGC_ThongKe.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_ThongKe.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            //GGC_ThongKe.ShowGroupDropArea = true;
            GGC_ThongKe.BorderStyle = BorderStyle.FixedSingle;
            // Tạo đối tượng GridColumnDescriptorCollection để quản lý các cột
            GridColumnDescriptorCollection columns = GGC_ThongKe.TableDescriptor.Columns;
            foreach (GridColumnDescriptor column in columns)
            {
                column.AllowFilter = true;
            }
            GridDynamicFilter dynamicFilter = new GridDynamicFilter();
            dynamicFilter.WireGrid(GGC_ThongKe);

            GridExcelFilter excelFilter = new GridExcelFilter();
            excelFilter.WireGrid(GGC_ThongKe);
            // Thiết lập AutoSizeMode cho mỗi cột
            foreach (GridColumnDescriptor column in columns)
            {
                column.Appearance.AnyRecordFieldCell.AutoSize = true;
                column.Appearance.AnyRecordFieldCell.CellType = "TextBox";
            }
        }
        // Load Công nợ của tất cả căn hộ
        private void LoadDebtOfAllApartments()
        {
            DataTable dataSource = new DataTable();
            dataSource = ApartmentBLL.Instance.GetDebtOfAllApartments();
            // Clear old data
            GGC_ThongKe.DataSource = null;
            GGC_ThongKe.DataSource = dataSource;
            if(dataSource.Rows.Count > 0)
            {
                GGC_ThongKe.TableDescriptor.Columns[0].HeaderText = "Mã căn hộ";
                GGC_ThongKe.TableDescriptor.Columns[1].HeaderText = "Tình trạng công nợ";
            }
            LoadGGC();
        }
        // Load Công nợ của một căn hộ nhất định
        private void LoadDebtOfApartment(string maCanHo)
        {
            DataTable dataSource = new DataTable();
            dataSource = ApartmentBLL.Instance.GetDebtOfApartment(maCanHo);
            GGC_ThongKe.DataSource = null;
            GGC_ThongKe.DataSource = dataSource;
            if(dataSource.Rows.Count > 0)
            {
                GGC_ThongKe.TableDescriptor.Columns[0].HeaderText = "Mã căn hộ";
                GGC_ThongKe.TableDescriptor.Columns[1].HeaderText = "Tình trạng công nợ";
            }
            LoadGGC();
        }
        private void LoadRequestList()
        {
            DataTable dataSource = new DataTable();
            dataSource = ApartmentBLL.Instance.GetRequestList();
            GGC_ThongKe.DataSource = null;
            GGC_ThongKe.DataSource = dataSource;
            if(dataSource.Rows.Count > 0)
            {
                GGC_ThongKe.TableDescriptor.Columns[0].HeaderText = "Mã căn hộ";
                GGC_ThongKe.TableDescriptor.Columns[1].HeaderText = "Mã người yêu cầu";
                GGC_ThongKe.TableDescriptor.Columns[2].HeaderText = "Họ tên";
                GGC_ThongKe.TableDescriptor.Columns[3].HeaderText = "Trạng thái yêu cầu";
                GGC_ThongKe.TableDescriptor.Columns[4].HeaderText = "Nhân viên phụ trách";
            }
            LoadGGC();
        }
        private void BTN_ThongKe_Click(object sender, EventArgs e)
        {
            if(CBB_DuLieuTK.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đối tượng muốn thống kê");
                CBB_DuLieuTK.Focus();
                return;
            }
            if(CBB_DuLieuTK.SelectedItem.Equals("Mã căn hộ"))
            {
                if(CBB_DuLieuMuonThongKe.SelectedIndex == -1) 
                {
                    MessageBox.Show("Vui lòng chọn mục tiêu muốn thống kê");
                    CBB_DuLieuMuonThongKe.Focus();
                    return;
                }

                if(CBB_DuLieuMuonThongKe.SelectedItem.Equals("Công nợ"))
                {
                    if(CBB_LoaiThoiGian.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng chọn mã căn hộ muốn thống kê");
                        CBB_LoaiThoiGian.Focus();
                        return;
                    }
                    if(CBB_LoaiThoiGian.SelectedItem.Equals("Tất cả"))
                    {
                        LoadDebtOfAllApartments();
                    }
                    else
                    {
                        string maCanHo = CBB_LoaiThoiGian.SelectedItem.ToString();
                        LoadDebtOfApartment(maCanHo);
                    }
                }

                if(CBB_DuLieuMuonThongKe.SelectedItem.Equals("Danh sách yêu cầu"))
                {
                    LoadRequestList();
                }

                if(CBB_DuLieuMuonThongKe.SelectedItem.Equals("Tổng chi phí điện/nước"))
                {

                }
            }
        }

        private void ThongKeCanHo_Load(object sender, EventArgs e)
        {
            LoadGGC();
        }


    }
}
