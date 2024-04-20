using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace DAO
{
    public class JobDAO
    {
        private static JobDAO instance;

        public static JobDAO Instance
        {
            get { if (instance == null) instance = new JobDAO(); return instance; }
        }
        private JobDAO() { }

        public DataTable GetAllJob()
        {
            string query = "select * from CongViec";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddJob(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("SP_ThemCongViec", parameters);
            return result > 0;
        }

        public string GetNewJobID()
        {
            // Define the output parameter dictionary
            Dictionary<string, SqlDbType> outputParams = new Dictionary<string, SqlDbType>();
            outputParams.Add("@nextJobId", SqlDbType.VarChar);

            // Call the method to execute the stored procedure and retrieve output parameters
            Dictionary<string, object> outputValues = DataProvider.Instance.ExecuteStoredProcedureWithOutput("[dbo].[Auto_Create_Job]", outputParams);

            // Retrieve the value of the output parameter '@nextJobId'
            string nextJobId = outputValues["@nextJobId"].ToString();
            return nextJobId;
        }

        public bool AddJob_Employee(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("ThemCongViec_NhanVien", parameters);
            return result > 0;
        }

        public bool AddJob_Group(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("ThemCongViec_Nhom", parameters);
            return result > 0;
        }

        public bool AddJob_Division(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("ThemCongViec_PhongBan", parameters);
            return result > 0;
        }

        public bool AddJob_PDF(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("ThemFile", parameters);
            return result > 0;
        }

        public bool AddRequestFromCustom(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("ThemYeuCau", parameters);
            return result > 0;
        }

        // Lấy Công việc của NV theo thời hạn hoàn thành công việc
        public DataTable GetJobOfEmployeeByDate(string maNV, string thoiHan)
        {
            string query = $"Select CV.* From CongViec CV, Congviec_Nhanvien CNV Where CV.maCongViec = CNV.maCongViec and CNV.maNhanVien = '{maNV}' and CONVERT(date, CV.thoiHan) = '{thoiHan}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        // Lây tất cả công việc của một NV
        public DataTable GetAllJobOfEmployee(string maNV)
        {
            string query = $"Select CV.* From CongViec CV, Congviec_Nhanvien CNV Where CV.maCongViec = CNV.maCongViec and CNV.maNhanVien = '{maNV}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        // Chỉnh sửa công việc 
        public bool EditJobOfEmployee(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("SP_EditCongViec", parameters);
            return result > 0;
        }

        // Xóa công việc
        public bool DeleteJobOfEmployee(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("SP_XoaCongViec_NhanVien", parameters);
            return result > 0;
        }

        //Lấy tên tệp đính kèm theo mã công việc
        public DataTable GetNameOfFile(string maCongViec)
        {
            string query = $"SELECT * FROM CongViec_PDF WHERE maCongViec = '{maCongViec}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //Lấy tệp đính kèm theo tên của nó
        public DataTable GetFileOfJob(string tenFile)
        {
            string query = $"SELECT * FROM CongViec_PDF WHERE tenFile = '{tenFile}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        // Lấy công việc theo mã
        public DataTable GetJobFromJobID(string maCV)
        {
            string query = $"SELECT * FROM CongViec Where maCongViec = '{maCV}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy nhân viên và số lượng công việc load trong form NhanVien
        public DataTable GetEmployees()
        {
            string query = $"EXEC [dbo].[Count_Job_State]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //Lấy tất cả công việc của nhân viên
        public DataTable GetJobOfEmployees()
        {
            string query = $"EXEC [dbo].[Job_Of_Employees]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //Lấy tất cả công việc của nhóm
        public DataTable GetJobOfGroups()
        {
            string query = $"EXEC [dbo].[Job_Of_Groups]";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy tất cả công việc của phòng ban
        public DataTable GetJobOfDivisions()
        {
            string query = $"EXEC [dbo].[Job_Of_Divisions]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable StatisticAllJob(DateTime tuNgay, DateTime denNgay)
        {
            // Tạo dictionary chứa các tham số cho stored procedure
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@tuNgay", tuNgay);
            parameters.Add("@denNgay", denNgay);

            // Gọi stored procedure và nhận kết quả vào một DataTable
            DataTable result = DataProvider.Instance.ExecuteStoredProcedureWithTableReturn("SP_ThongKeCongViecCongTy", parameters);

            return result;
        }
    }
}
