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
    }
}
