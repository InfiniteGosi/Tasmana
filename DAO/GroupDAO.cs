using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GroupDAO
    {
        private static GroupDAO instance;
        public static GroupDAO Instance
        {
            get { if (instance == null) instance = new GroupDAO(); return instance; }
            private set { instance = value; }
        }
        private GroupDAO() { }
        public DataTable GetGroupsByDivisonId(string maBoPhan)
        {
            string query = $"select * from Nhom where maBoPhan = '{maBoPhan}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
