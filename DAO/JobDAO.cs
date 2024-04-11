using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

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
    }
}
