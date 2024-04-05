using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
