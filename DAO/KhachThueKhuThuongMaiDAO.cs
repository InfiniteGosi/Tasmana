using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachThueKhuThuongMaiDAO
    {
        private static KhachThueKhuThuongMaiDAO instance;
        public static KhachThueKhuThuongMaiDAO Instance
        {
            get { if (instance == null) instance = new KhachThueKhuThuongMaiDAO(); return instance; }
            private set { instance = value; }
        }
        private KhachThueKhuThuongMaiDAO() { }
        public DataTable GetKhachThueById(string maKhachDangThue)
        {
            string query = $"select * from KhachThueKhuThuongMai where maKhachDangThue = '{maKhachDangThue}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetAllKhachThue()
        {
            string query = $"select * from KhachThueKhuThuongMai";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
