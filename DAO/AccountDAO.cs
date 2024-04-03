using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool CheckAccountExistence(string userId)
        {
            string query = $"select * from TaiKhoan where maNguoiDung = '{userId}'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool CheckAccountPasword(string userId, string password)
        {
            string query = $"select * from TaiKhoan where maNguoiDung = '{userId}'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return password.Equals(result.Rows[0]["matKhau"].ToString());
        }
        public DataTable GetAccount(string userId)
        {
            string query = $"select * from TaiKhoan where maNguoiDung = '{userId}'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

    }
}
