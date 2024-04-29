using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NoticeBLL
    {
        private static NoticeBLL instance;
        public static NoticeBLL Instance
        {
            get { if (instance == null) instance = new NoticeBLL(); return instance; }
            private set { instance = value; }
        }
        private NoticeBLL() { }
        public bool AddNotice(Dictionary<string, object> parameters)
        {
            if (NoticeDAO.Instance.AddNotice(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddNoticeWithout(Dictionary<string, object> parameters)
        {
            if (NoticeDAO.Instance.AddNoticeWithout(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddNoticeTo(Dictionary<string, object> parameters)
        {
            if (NoticeDAO.Instance.AddNoticeTo(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetSTT()
        {
            return NoticeDAO.Instance.GetSTT();
        }
    }
}
