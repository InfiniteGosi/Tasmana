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
        public List<Job> GetAllJob()
        {
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
    }
}
