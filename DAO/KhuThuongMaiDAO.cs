using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhuThuongMaiDAO
    {
        private static KhuThuongMaiDAO instance;
        public static KhuThuongMaiDAO Instance
        {
            get { if (instance == null) instance = new KhuThuongMaiDAO(); return instance; }
            private set { instance = value; }
        }
        private KhuThuongMaiDAO() { }
        public DataTable GetAllKhuThuongMai()
        {
            string query = $"select * from KhuThuongMai";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
