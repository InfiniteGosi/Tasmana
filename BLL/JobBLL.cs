using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL
{
    public class JobBLL
    {
        private static JobBLL instance;

        public static JobBLL Instance
        {
            get { if (instance == null) instance = new JobBLL(); return instance; }
            private set { instance = value; }
        }
        private JobBLL() { }
        public bool AddJob(Dictionary<string, object> parameters)
        {
            if(JobDAO.Instance.AddJob(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetNewJobID()
        {
            string newJobID = JobDAO.Instance.GetNewJobID();
            return newJobID;
        }
        public bool AddJob_Employee(Dictionary<string, object> parameters)
        {
            if(JobDAO.Instance.AddJob_Employee(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddJob_Group(Dictionary<string, object> parameters)
        {
            if (JobDAO.Instance.AddJob_Group(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddJob_PDF(Dictionary<string, object> parameters)
        {
            if (JobDAO.Instance.AddJob_PDF(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddJob_Division(Dictionary<string, object> parameters)
        {
            if (JobDAO.Instance.AddJob_Division(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddRequestFromCustom(Dictionary<string, object> parameters)
        {
            if (JobDAO.Instance.AddRequestFromCustom(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Lấy danh sách công việc nhân viên theo ngày thời hạn hoàn thành công việc
        public List<Job> GetJobOfEmployeeByDate(string maNV, string thoiHan)
        {
            List<Job> jobs = new List<Job>();
            DataTable dt = JobDAO.Instance.GetJobOfEmployeeByDate(maNV, thoiHan);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maCongViec = dt.Rows[i]["maCongViec"].ToString();
                string noiDung = dt.Rows[i]["noiDung"].ToString();
                DateTime ngayGiao = (DateTime)dt.Rows[i]["ngayGiao"];
                DateTime thoihan = (DateTime)dt.Rows[i]["thoiHan"];
                DateTime ngayHoanThanh = dt.Rows[i]["ngayHoanThanh"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dt.Rows[i]["ngayHoanThanh"].ToString());
                DateTime ngayCapNhat = (DateTime)dt.Rows[i]["ngayCapNhat"];
                string trangThai = dt.Rows[i]["trangThai"].ToString();
                string ghiChu = dt.Rows[i]["ghiChu"].ToString();
                Job job = new Job(maCongViec, noiDung, ngayGiao, thoihan, ngayHoanThanh, ngayCapNhat, trangThai, ghiChu);
                jobs.Add(job);
            }
            return jobs;
        }
        // Lấy toàn bộ danh sách công việc của một nhân viên
        public List<Job> GetAllJobOfEmployee(string maNV)
        {
            List<Job> jobs = new List<Job>();
            DataTable dt = JobDAO.Instance.GetAllJobOfEmployee(maNV);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maCongViec = dt.Rows[i]["maCongViec"].ToString();
                string noiDung = dt.Rows[i]["noiDung"].ToString();
                DateTime ngayGiao = (DateTime)dt.Rows[i]["ngayGiao"];
                DateTime thoihan = (DateTime)dt.Rows[i]["thoiHan"];
                DateTime ngayHoanThanh = dt.Rows[i]["ngayHoanThanh"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dt.Rows[i]["ngayHoanThanh"].ToString());
                DateTime ngayCapNhat = (DateTime)dt.Rows[i]["ngayCapNhat"];
                string trangThai = dt.Rows[i]["trangThai"].ToString();
                string ghiChu = dt.Rows[i]["ghiChu"].ToString();
                Job job = new Job(maCongViec, noiDung, ngayGiao, thoihan, ngayHoanThanh, ngayCapNhat, trangThai, ghiChu);
                jobs.Add(job);
            }
            return jobs;
        }
        // Lấy toàn bộ tất cả công việc
        public List<Job> GetAllJob()
        {
            DateTime? nullDateTime = null;
            List <Job> jobs = new List<Job>();
            DataTable dt = JobDAO.Instance.GetAllJob();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maCongViec = dt.Rows[i]["maCongViec"].ToString();
                string noiDung = dt.Rows[i]["noiDung"].ToString();
                DateTime ngayGiao = (DateTime)dt.Rows[i]["ngayGiao"];
                DateTime thoihan = (DateTime)dt.Rows[i]["thoiHan"];
                DateTime ngayHoanThanh = dt.Rows[i]["ngayHoanThanh"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dt.Rows[i]["ngayHoanThanh"].ToString());
                DateTime ngayCapNhat = (DateTime)dt.Rows[i]["ngayCapNhat"];
                string trangThai = dt.Rows[i]["trangThai"].ToString();
                string ghiChu = dt.Rows[i]["ghiChu"].ToString();
                Job job = new Job(maCongViec, noiDung, ngayGiao, thoihan, ngayHoanThanh, ngayCapNhat, trangThai, ghiChu);
                jobs.Add(job);
            }
            return jobs;
        }
        public List<Job> GetJob()
        {
            List<Job> jobs = new List<Job>();
            DataTable dt = JobDAO.Instance.GetJob();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maCongViec = dt.Rows[i]["Mã công việc"].ToString();
                string maNhanVien = dt.Rows[i]["Mã nhân viên"].ToString() ;
                string ho = dt.Rows[i]["Họ"].ToString();
                string ten = dt.Rows[i]["Tên"].ToString();
                string noiDung = dt.Rows[i]["Nội dung"].ToString();
                string maCanHo = dt.Rows[i]["Mã căn hộ"].ToString();
                DateTime ngayGiao = (DateTime)dt.Rows[i]["Ngày giao"];
                DateTime ngayCapNhat = (DateTime)dt.Rows[i]["Ngày cập nhật"];
                DateTime thoiHan = (DateTime)dt.Rows[i]["Thời hạn"];
                DateTime ngayHoanThanh = dt.Rows[i]["Ngày hoàn thành"] == DBNull.Value ? default(DateTime) : Convert.ToDateTime(dt.Rows[i]["ngayHoanThanh"].ToString());
                string trangThai = dt.Rows[i]["Trạng thái"].ToString();
                string ghiChu = dt.Rows[i]["Ghi chú"].ToString();
                Job job = new Job(maCongViec,maNhanVien,ho, ten, noiDung, maCanHo, ngayGiao,  ngayCapNhat,  thoiHan, ngayHoanThanh, trangThai, ghiChu);
                jobs.Add(job);
            }
            return jobs;
        }

        // Chỉnh sửa công việc
        public bool EditJobOfEmployee(Dictionary<string, object> parameters)
        {
            if (JobDAO.Instance.EditJobOfEmployee(parameters))
            {
                return true;
            }

            return false;
        }

        // Xóa công việc của nhân viên theo mã công việc
        public bool DeleteJobOfEmployee(Dictionary<string, object> parameters)
        {
            if (JobDAO.Instance.DeleteJobOfEmployee(parameters))
            {
                return true;
            }
            return false;
        }
    }
}
