using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachNganNgayDAO
    {
        private static KhachNganNgayDAO instance;
        public static KhachNganNgayDAO Instance
        {
            get { if (instance == null) instance = new KhachNganNgayDAO(); return instance; }
            private set { instance = value; }
        }
        private KhachNganNgayDAO() { }
        public DataTable GetAllKhachNganNgay()
        {
            string query = "select * from KhachNganNgay";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetKhachByMaCuDan(string maCuDan)
        {
            string query = $"select * from KhachNganNgay where maCuDan = '{maCuDan}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
