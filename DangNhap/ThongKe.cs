using BLL;
using DTO;
using Syncfusion.GridHelperClasses;
using Syncfusion.Grouping;
using Syncfusion.Licensing;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DangNhap
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzIxOTI2MkAzMjM1MmUzMDJlMzBORkJZeFRVdUQxeERjT2xkWC9vdFgxS29wUmREOU9CZVdENkRUN0lrSStVPQ==;Mgo+DSMBaFt6QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRbQlliS3xTck1hW35Wcnc=");
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            currentFormChild?.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PN_hienthi.Controls.Add(childForm);
            PN_hienthi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            CBB_PhongBan.Enabled = true;
            CBB_PhongBan.Items.Clear();
            listPB = GetPhongBan();
            for (int i = 0; i < listPB.Count; i++)
            {
                CBB_PhongBan.Items.Add(listPB[i].MaBoPhan + "-" + listPB[i].TenBoPhan);
            }
        }

        public List<Employee> GetEmployee(string maBoPhan)
        {
            List<Employee> list = new List<Employee>();
            list = EmployeeBLL.Instance.GetEmployeeByDivision(maBoPhan);
            return list;
        }

        public void ReadNV()
        {
            List<Employee> employees = new List<Employee>();
            CBB_NhanVien.Enabled = true;
            CBB_NhanVien.Items.Clear();
            employees = GetEmployee(CBB_PhongBan.SelectedItem.ToString().Split('-')[0]);
            for (int i = 0; i < employees.Count; i++)
            {
                CBB_NhanVien.Items.Add(employees[i].MaNhanVien + "_" + employees[i].Ten);
            }
        }
        // 3 Radio Button sử dụng chung 1 sự kiện check changed
        private void RBtn_PhongBan_CheckedChanged(object sender, EventArgs e)
        {
            // Thống kê dữ liệu toàn công ty
            if(RBtn_Congty.Checked)
            {
                CBB_PhongBan.Enabled = false;
                CBB_PhongBan.SelectedIndex = -1;

                CBB_NhanVien.Enabled = false;
                CBB_NhanVien.SelectedIndex = -1;

                CBB_LoaiDoThi.Enabled = true;
                CBB_LoaiDoThi.SelectedIndex = -1;

            }
            // Thống kê dữ liệu của một phòng ban
            else if(RBtn_PhongBan.Checked) 
            {
                ReadPhongBan();
                CBB_PhongBan.Enabled = true;
                CBB_PhongBan.SelectedIndex = -1;

                CBB_NhanVien.Enabled = false;
                CBB_NhanVien.SelectedIndex = -1;

                CBB_LoaiDoThi.Enabled = true;
                CBB_LoaiDoThi.SelectedIndex = -1;
            }
            // Thống kê dữ liệu của một nhân viên
            else if (RBtn_NhanVien.Checked)
            {
                ReadPhongBan();
                CBB_PhongBan.Enabled = true;
                CBB_PhongBan.SelectedIndex = -1;

                CBB_NhanVien.Enabled = true;
                CBB_NhanVien.SelectedIndex = -1;
                
                CBB_LoaiDoThi.Enabled = true;
                CBB_LoaiDoThi.SelectedIndex = -1;
            }
        }

        private void CBB_PhongBan_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CBB_PhongBan.SelectedIndex != -1 && RBtn_NhanVien.Checked) 
            {
                ReadNV();
            }
        }
        // lấy dữ liệu thống kê của toàn công ty
        private DataTable GetAllJobs(DateTime tuNgay, DateTime denNgay)
        {
            DataTable data = new DataTable();
            data = JobBLL.Instance.StatisticAllJob(tuNgay, denNgay);
            return data;
        }
        // Lấy dữ liệu thống kê của phòng ban
        private DataTable GetAll_DivisionJob(DateTime tuNgay, DateTime denNgay, string maBoPhan)
        {
            DataTable data = new DataTable();
            data = JobBLL.Instance.StatisticDivisionJob(tuNgay, denNgay, maBoPhan); 
            return data;
        }
        // Lấy dữ liệu thống kê của nhân viên
        private DataTable GetAll_EmployeeJob(DateTime tuNgay, DateTime denNgay, string maNhanVien)
        {
            DataTable data = new DataTable();
            data = JobBLL.Instance.StatisticEmployeeJob(tuNgay, denNgay, maNhanVien);
            return data;
        }
        // Hiển thị dữ liệu lên GGC_ThongKe
        private void LoadThongKeCongTy()
        {
            GGC_ThongKe.Visible = true;
            C_ThongKe.Visible = false;
            DateTime tuNgay = DTP_TuNgay.Value;
            DateTime denNgay = DTP_DenNgay.Value;
            DataTable dataSource = new DataTable();
            //DataColumn col1 = new DataColumn("Mã nhân viên");
            //DataColumn col2 = new DataColumn("Họ");
            //DataColumn col3 = new DataColumn("Tên");
            //DataColumn col4 = new DataColumn("Số công việc đúng hạn");
            //DataColumn col5 = new DataColumn("Số công việc trước hạn");
            //DataColumn col6 = new DataColumn("Số công việc trễ hạn");
            //DataColumn col7 = new DataColumn("Số công việc chưa hoàn thành");

            //dataSource.Columns.Add(col1);
            //dataSource.Columns.Add(col2);
            //dataSource.Columns.Add(col3);
            //dataSource.Columns.Add(col4);
            //dataSource.Columns.Add(col5);
            //dataSource.Columns.Add(col6);
            //dataSource.Columns.Add(col7);

            dataSource = GetAllJobs(tuNgay, denNgay);
            GGC_ThongKe.DataSource = null; // Clear previous data
            GGC_ThongKe.DataSource = dataSource;
            GGC_ThongKe.TableDescriptor.Columns[0].HeaderText = "Mã nhân viên";
            GGC_ThongKe.TableDescriptor.Columns[1].HeaderText = "Họ";
            GGC_ThongKe.TableDescriptor.Columns[2].HeaderText = "Tên";
            GGC_ThongKe.TableDescriptor.Columns[3].HeaderText = "Số công việc đúng hạn";
            GGC_ThongKe.TableDescriptor.Columns[4].HeaderText = "Số công việc trước hạn";
            GGC_ThongKe.TableDescriptor.Columns[5].HeaderText = "Số công việc trễ hạn";
            GGC_ThongKe.TableDescriptor.Columns[6].HeaderText = "Số công việc chưa bắt đầu";

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

            //foreach (Record record in GGC_ThongKe.Table.Records)
            //{
            //    DataRow dtRow = dataSource.NewRow();
            //    dtRow[0] = record.GetValue("maNhanVien");
            //    dtRow[1] = record.GetValue("ho");
            //    dtRow[2] = record.GetValue("Ten");
            //    dtRow[3] = record.GetValue("dungHan");
            //    dtRow[4] = record.GetValue("trcHan");
            //    dtRow[5] = record.GetValue("treHan");
            //    dtRow[6] = record.GetValue("chuaBatDau");
            //}
        }
        private void LoadThongKe_PhongBan()
        {
            GGC_ThongKe.Visible = true;
            C_ThongKe.Visible = false;
            DateTime tuNgay = DTP_TuNgay.Value;
            DateTime denNgay = DTP_DenNgay.Value;
            string maBoPhan = CBB_PhongBan.SelectedItem.ToString().Split('-')[0];
            DataTable dataSource = new DataTable();
            dataSource = GetAll_DivisionJob(tuNgay, denNgay, maBoPhan);
            GGC_ThongKe.DataSource = null; // Clear previous data
            GGC_ThongKe.DataSource = dataSource;
            GGC_ThongKe.TableDescriptor.Columns[0].HeaderText = "Mã nhân viên";
            GGC_ThongKe.TableDescriptor.Columns[1].HeaderText = "Họ";
            GGC_ThongKe.TableDescriptor.Columns[2].HeaderText = "Tên";
            GGC_ThongKe.TableDescriptor.Columns[3].HeaderText = "Số công việc đúng hạn";
            GGC_ThongKe.TableDescriptor.Columns[4].HeaderText = "Số công việc trước hạn";
            GGC_ThongKe.TableDescriptor.Columns[5].HeaderText = "Số công việc trễ hạn";
            GGC_ThongKe.TableDescriptor.Columns[6].HeaderText = "Số công việc chưa bắt đầu";

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
        private void LoadThongKe_NhanVien()
        {
            GGC_ThongKe.Visible = true;
            C_ThongKe.Visible = false;
            DateTime tuNgay = DTP_TuNgay.Value;
            DateTime denNgay = DTP_DenNgay.Value;
            string maNhanVien = CBB_NhanVien.SelectedItem.ToString().Split('_')[0];
            DataTable dataSource = new DataTable();
            dataSource = GetAll_EmployeeJob(tuNgay, denNgay, maNhanVien);
            GGC_ThongKe.DataSource = null; // Clear previous data
            GGC_ThongKe.DataSource = dataSource;
            GGC_ThongKe.TableDescriptor.Columns[0].HeaderText = "Mã nhân viên";
            GGC_ThongKe.TableDescriptor.Columns[1].HeaderText = "Họ";
            GGC_ThongKe.TableDescriptor.Columns[2].HeaderText = "Tên";
            GGC_ThongKe.TableDescriptor.Columns[3].HeaderText = "Số công việc đúng hạn";
            GGC_ThongKe.TableDescriptor.Columns[4].HeaderText = "Số công việc trước hạn";
            GGC_ThongKe.TableDescriptor.Columns[5].HeaderText = "Số công việc trễ hạn";
            GGC_ThongKe.TableDescriptor.Columns[6].HeaderText = "Số công việc chưa bắt đầu";

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
        private void BTN_ThongKe_Click(object sender, EventArgs e)
        {
            if(RBtn_Congty.Checked)
            {
                LoadThongKeCongTy();    
            }
            if (RBtn_PhongBan.Checked)
            {
                if(CBB_PhongBan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phòng ban muốn thống kê");
                    CBB_PhongBan.Focus();
                    return;
                }
                else
                {
                    LoadThongKe_PhongBan();
                }
            }
            if (RBtn_NhanVien.Checked)
            {
                if (CBB_PhongBan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phòng ban của nhân viên muốn thống kê");
                    CBB_PhongBan.Focus();
                    return;
                }
                if(CBB_NhanVien.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên muốn thống kê");
                    CBB_NhanVien.Focus();
                    return;
                }
                LoadThongKe_NhanVien();
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            GGC_ThongKe.Size = new System.Drawing.Size(950, 404);
            GGC_ThongKe.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_ThongKe.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            //GGC_ThongKe.ShowGroupDropArea = true;
            GGC_ThongKe.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Btn_XuatDoThi_Click(object sender, EventArgs e)
        {
            if (RBtn_Congty.Checked)
            {
                LoadThongKeCongTy();
                GGC_ThongKe.Visible = false;
            }
            if (RBtn_PhongBan.Checked)
            {
                if (CBB_PhongBan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phòng ban muốn thống kê");
                    CBB_PhongBan.Focus();
                    return;
                }
                else
                {
                    LoadThongKe_PhongBan();
                    GGC_ThongKe.Visible = false;
                }
            }
            if (RBtn_NhanVien.Checked)
            {
                if (CBB_PhongBan.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phòng ban của nhân viên muốn thống kê");
                    CBB_PhongBan.Focus();
                    return;
                }
                if (CBB_NhanVien.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên muốn thống kê");
                    CBB_NhanVien.Focus();
                    return;
                }
                LoadThongKe_NhanVien();
                GGC_ThongKe.Visible = false;
            }

            if(RBtn_Congty.Checked == false && RBtn_PhongBan.Checked == false && RBtn_NhanVien.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu muốn thống kê");
                return;
            }

            if (CBB_LoaiDoThi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại đồ thị");
                CBB_LoaiDoThi.Focus();
                return;
            }
            if(CBB_LoaiDoThi.SelectedIndex == 0)
            {
                GGC_ThongKe.Visible = false;
                C_ThongKe.Location = new Point(21, 189);

                // Clear any existing series
                C_ThongKe.Series.Clear();

                // Ensure that the chart is visible
                C_ThongKe.Visible = true;

                // Add a new series and set its chart type to Pie
                C_ThongKe.Series.Add("PieSeries");
                C_ThongKe.Series["PieSeries"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                C_ThongKe.Series["PieSeries"].IsValueShownAsLabel = true;
                C_ThongKe.Series["PieSeries"].LabelFormat = "#.##%";
                // Calculate total for each type of job
                Dictionary<string, int> jobTotals = new Dictionary<string, int>();

                foreach (DataRow row in ((DataTable)GGC_ThongKe.DataSource).Rows)
                {
                    string[] dataColumnNames = { "dungHan", "trcHan", "treHan", "chuaBatDau" };
                    string[] columnNames = { "Số công việc đúng hạn", "Số công việc trước hạn", "Số công việc trễ hạn", "Số công việc chưa bắt đầu" };

                    for (int i = 0; i < dataColumnNames.Length; i++)
                    {
                        if (!jobTotals.ContainsKey(columnNames[i]))
                        {
                            jobTotals.Add(columnNames[i], Convert.ToInt32(row[dataColumnNames[i]]));
                        }
                        else
                        {
                            jobTotals[columnNames[i]] += Convert.ToInt32(row[dataColumnNames[i]]);
                        }
                    }
                }

                // Calculate total number of jobs
                int totalJobs = jobTotals.Sum(x => x.Value);

                // Add data to PieSeries
                foreach (var kvp in jobTotals)
                {
                    // Calculate percentage for each job type
                    double percentage = (double)kvp.Value / totalJobs;

                    // Add data point with percentage label
                    C_ThongKe.Series["PieSeries"].Points.AddXY(kvp.Key, percentage);
                    //C_ThongKe.Series["PieSeries"].Points.Last().Label = $"{kvp.Key} ({percentage.ToString("F1")}%)";
                }
            }
            if (CBB_LoaiDoThi.SelectedIndex == 1) // Check if the selected chart type is Bar Chart
            {
                // Hide the grid and show the chart
                GGC_ThongKe.Visible = false;
                C_ThongKe.Location = new Point(21, 189);
                C_ThongKe.Series.Clear(); // Clear existing series

                // Show the chart
                C_ThongKe.Visible = true;

                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Số lượng công việc");
                series.ChartType = SeriesChartType.Column; // Set chart type to column
                series.IsValueShownAsLabel = true; // Show values as labels on top of bars
                C_ThongKe.Series.Add(series);
                C_ThongKe.ChartAreas[0].AxisX.Title = "Tình trạng công việc";
                C_ThongKe.ChartAreas[0].AxisY.Title = "Số lượng công việc";
                Dictionary<string, int> jobTotals = new Dictionary<string, int>();

                // Turn off major grid lines
                C_ThongKe.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                C_ThongKe.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                foreach (DataRow row in ((DataTable)GGC_ThongKe.DataSource).Rows)
                {
                    string[] dataColumnNames = { "dungHan", "trcHan", "treHan", "chuaBatDau" };
                    string[] columnNames = { "Số công việc đúng hạn", "Số công việc trước hạn", "Số công việc trễ hạn", "Số công việc chưa bắt đầu" };

                    for (int i = 0; i < dataColumnNames.Length; i++)
                    {
                        if (!jobTotals.ContainsKey(columnNames[i]))
                        {
                            jobTotals.Add(columnNames[i], Convert.ToInt32(row[dataColumnNames[i]]));
                        }
                        else
                        {
                            jobTotals[columnNames[i]] += Convert.ToInt32(row[dataColumnNames[i]]);
                        }
                    }
                }

                foreach (var data in jobTotals)
                {
                    series.Points.AddXY(data.Key, data.Value);
                }

                int totalJobs = jobTotals.Sum(x => x.Value);
                // Tính toán giá trị trung bình của interval
                double averageInterval = totalJobs / 4;

                // Đặt interval trung bình cho trục Y
                C_ThongKe.ChartAreas[0].AxisY.Interval = (int)averageInterval;
            }
            if (CBB_LoaiDoThi.SelectedIndex == 2) // Check if the selected chart type is Line Chart
            {
                // Hide the grid and show the chart
                GGC_ThongKe.Visible = false;
                C_ThongKe.Location = new Point(21, 189);
                C_ThongKe.Series.Clear(); // Clear existing series

                // Show the chart
                C_ThongKe.Visible = true;

                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Số lượng công việc");
                series.ChartType = SeriesChartType.Line; // Set chart type to Line
                series.IsValueShownAsLabel = true; // Show values as labels on data points
                C_ThongKe.Series.Add(series);
                C_ThongKe.ChartAreas[0].AxisX.Title = "Tình trạng công việc";
                C_ThongKe.ChartAreas[0].AxisY.Title = "Số lượng công việc";
                Dictionary<string, int> jobTotals = new Dictionary<string, int>();
                
                // Turn off major grid lines
                C_ThongKe.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                C_ThongKe.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                foreach (DataRow row in ((DataTable)GGC_ThongKe.DataSource).Rows)
                {
                    string[] dataColumnNames = { "dungHan", "trcHan", "treHan", "chuaBatDau" };
                    string[] columnNames = { "Số công việc đúng hạn", "Số công việc trước hạn", "Số công việc trễ hạn", "Số công việc chưa bắt đầu" };

                    for (int i = 0; i < dataColumnNames.Length; i++)
                    {
                        if (!jobTotals.ContainsKey(columnNames[i]))
                        {
                            jobTotals.Add(columnNames[i], Convert.ToInt32(row[dataColumnNames[i]]));
                        }
                        else
                        {
                            jobTotals[columnNames[i]] += Convert.ToInt32(row[dataColumnNames[i]]);
                        }
                    }
                }

                foreach (var data in jobTotals)
                {
                    series.Points.AddXY(data.Key, data.Value);
                }

                int totalJobs = jobTotals.Sum(x => x.Value);
                // Tính toán giá trị trung bình của interval
                double averageInterval =  totalJobs/ 4;

                // Đặt interval trung bình cho trục Y
                C_ThongKe.ChartAreas[0].AxisY.Interval = (int)averageInterval;
            }
        }

        private void BTN_thongkecanho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeCanHo());
            LB_ThongKeCV.Text = "THỐNG KÊ CĂN HỘ";
        }

        private void BTN_thongkecongviec_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            LB_ThongKeCV.Text = "THỐNG KÊ CÔNG VIỆC";
        }

        private void BTN_XepHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XepHang());
            LB_ThongKeCV.Text = "BẢNG XẾP HẠNG";
        }
    }
}
