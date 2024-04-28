using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ResidentDAO
    {
        private static ResidentDAO instance;
        public static ResidentDAO Instance
        {
            get { if (instance == null) instance = new ResidentDAO(); return instance; }
            private set { instance = value; }
        }
        private ResidentDAO() { }
        public DataTable GetResidentByApartmentId(string maCanHo)
        {
            string query = "select cd.* " +
                           "from CanHo ch inner join CuDan cd " +
                           "on ch.maCuDan = cd.maCuDan " +
                           $"where ch.maCanHo = '{maCanHo}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetResidentByResidentId(string maCuDan)
        {
            string query = $"select * from CuDan where maCuDan = '{maCuDan}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllResidents()
        {
            string query = $"select * from CuDan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        // Lấy cư dân có quốc tịch không phải VN
        public DataTable GetAllForeignNational()
        {
            string query = "EXEC ThongKeCuDanNguocNgoai";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        // Lấy cư dân có quốc tịch Việt Nam
        public DataTable GetVietResidents()
        {
            string query = "EXEC ThongKeCuDanVietNam";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
