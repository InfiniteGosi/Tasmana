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
    public class GroupBLL
    {
        private static GroupBLL instance;
        public static GroupBLL Instance
        {
            get { if (instance == null) instance = new GroupBLL(); return instance; }
            private set { instance = value; }
        }
        private GroupBLL() { }
        public List<Group> GetGroupListByDivisionId(string maBoPhan)
        {
            DataTable dt = GroupDAO.Instance.GetGroupsByDivisonId(maBoPhan);
            List<Group> groups = new List<Group>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maNhom = dt.Rows[i]["maNhom"].ToString();
                string maTruongNhom = dt.Rows[i]["maTruongNhom"].ToString();
                Group group = new Group(maNhom, maTruongNhom, maBoPhan);
                groups.Add(group);
            }
            return groups;
        }
    }
}
