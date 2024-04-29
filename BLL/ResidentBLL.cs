using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ResidentBLL
    {
        private static ResidentBLL instance;
        public static ResidentBLL Instance
        {
            get { if (instance == null) instance = new ResidentBLL(); return instance; }
            private set { instance = value; }
        }
        private ResidentBLL() { }
        public string GetNameOfMaCuDan(string maCuDan)
        {
            DataTable dt = ResidentDAO.Instance.GetResidentByResidentId(maCuDan);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["hoTen"].ToString();
            return "";
        }
        // Lấy cư dân có quốc tịch không phải VN
        public DataTable GetAllForeignNational()
        {
            return ResidentDAO.Instance.GetAllForeignNational();
        }
        // Lấy cư dân có quốc tịch Việt Nam
        public DataTable GetVietResidents()
        {
            return ResidentDAO.Instance.GetVietResidents();
        }
    }
}
