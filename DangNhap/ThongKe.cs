using BLL;
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

namespace DangNhap
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzIxOTI2MkAzMjM1MmUzMDJlMzBORkJZeFRVdUQxeERjT2xkWC9vdFgxS29wUmREOU9CZVdENkRUN0lrSStVPQ==;Mgo+DSMBaFt6QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRbQlliS3xTck1hW35Wcnc=");
            InitializeComponent();
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
        private List<Job> GetAllJobs()
        {
            List<Job> jobs = new List<Job>();
            jobs = JobBLL.Instance.GetAllJob();
            return jobs;
        }
        private void BTN_ThongKe_Click(object sender, EventArgs e)
        {
            if(RBtn_Congty.Checked)
            {
                
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            GGC_ThongKe.Size = new System.Drawing.Size(950, 404);
            /*
            GGC_ThongKe.TableDescriptor.Columns[0].HeaderText = "Mã công việc";
            GGC_ThongKe.TableDescriptor.Columns[1].HeaderText = "Mã nhân viên";
            GGC_ThongKe.TableDescriptor.Columns[2].HeaderText = "Tên";
            GGC_ThongKe.TableDescriptor.Columns[3].HeaderText = "Số công việc đúng hạn";
            GGC_ThongKe.TableDescriptor.Columns[4].HeaderText = "Số công việc trước hạn";
            GGC_ThongKe.TableDescriptor.Columns[5].HeaderText = "Số công việc trễ hạn";
            GGC_ThongKe.TableDescriptor.Columns[5].HeaderText = "Số công việc chưa bắt đầu";
            */
            GGC_ThongKe.TopLevelGroupOptions.ShowFilterBar = true;
            GGC_ThongKe.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            //GGC_ThongKe.ShowGroupDropArea = true;
            GGC_ThongKe.BorderStyle = BorderStyle.FixedSingle;

        }
    }
}
