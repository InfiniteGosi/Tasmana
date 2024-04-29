using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NguoiDcUyQuyenChuHoDAO
    {
        private static NguoiDcUyQuyenChuHoDAO instance;
        public static NguoiDcUyQuyenChuHoDAO Instance
        {
            get { if (instance == null) instance = new NguoiDcUyQuyenChuHoDAO(); return instance; }
            private set { instance = value; }
        }
        private NguoiDcUyQuyenChuHoDAO() { }
        public DataTable GetAllNguoiUyQuyen()
        {
            string query = "select * from NguoiDcUyQuyenChuHo";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
