using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;


namespace BLL
{
    public class AccountBLL
    {
        private static AccountBLL instance;
        public static AccountBLL Instance
        {
            get { if (instance == null) instance = new AccountBLL(); return instance; }
            private set { instance = value; }
        }
        private AccountBLL() { }
        public bool CheckAccountExistence(string userId)
        {
            return AccountDAO.Instance.CheckAccountExistence(userId);
        }
        public bool CheckAccountPasword(string userId, string password)
        {
            return AccountDAO.Instance.CheckAccountPasword(userId, password);
        }
        public Account GetAccount(string userId)
        {
            DataTable dt = AccountDAO.Instance.GetAccount(userId);

            return new Account(userId, dt.Rows[0]["matKhau"].ToString(), dt.Rows[0]["maNhanVien"].ToString(), PhanQuyen(userId));
        }
        public bool AddAccount(Dictionary<string, object> parameters)
        {
            if (AccountDAO.Instance.AddAccount(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string PhanQuyen(string userID)
        {
            string level = "";
            string[] temp = userID.Split('.');
            if (!string.IsNullOrEmpty(temp[0]))
            {
                string loaiNV = temp[0].Substring(0, 2);
                switch (loaiNV)
                {
                    case "GD":
                        level = "CEO";
                        break;
                    case "DV":
                        level = "DV";
                        break;
                    case "TC":
                        level = "TaiChinh";
                        break;
                    case "VS":
                        level = "VeSinh";
                        break;
                    case "AN":
                        level = "AnNinh";
                        break;
                    case "KT":
                        level = "KyThuat";
                        break;
                    case "XD":
                        level = "XayDung";
                        break;
                    default:
                        break;
                }
            }
            return level;
        }
    }
}
