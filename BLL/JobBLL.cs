using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL
{
    public class JobBLL
    {
        private static JobBLL instance;

        public static JobBLL Instance
        {
            get { if (instance == null) instance = new JobBLL(); return instance; }
            private set { instance = value; }
        }
        private JobBLL() { }
        public bool AddJob(Dictionary<string, object> parameters)
        {
            if(JobDAO.Instance.AddJob(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddJob_Employee(Dictionary<string, object> parameters)
        {
            if(JobDAO.Instance.AddJob_Employee(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddJob_Group(Dictionary<string, object> parameters)
        {
            if (JobDAO.Instance.AddJob_Group(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddJob_Division(Dictionary<string, object> parameters)
        {
            if (JobDAO.Instance.AddJob_Division(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddRequestFromCustom(Dictionary<string, object> parameters)
        {
            if (JobDAO.Instance.AddRequestFromCustom(parameters))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
