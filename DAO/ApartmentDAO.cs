﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ApartmentDAO
    {
        private static ApartmentDAO instance;
        public static ApartmentDAO Instance
        {
            get { if (instance == null) instance = new ApartmentDAO(); return instance; }
            private set { instance = value; }
        }
        private ApartmentDAO() { }
        public DataTable GetAllApartments()
        {
            string query = "select * from CanHo";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetApartmentById(string maCanHo)
        {
            string query = $"select * from CanHo where maCanHo = '{maCanHo}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool UpdateApartment(Dictionary<string, object> parameters)
        {
            int result = DataProvider.Instance.ExecuteStoredProcedure("SP_CapNhatCanHo", parameters);
            return result > 0;
        }
        public bool DeleteApartment(string maCanHo)
        {
            string query = $"exec SP_XoaCanHo @maCanHo = '{maCanHo}'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool AddMonthlyBill(Dictionary<string, object> parameters)
        {
            return DataProvider.Instance.ExecuteStoredProcedure("SP_ThemChiPhiHangThang", parameters) > 0;
        }
        public DataTable GetMonthlyBill()
        {
            string query = $"Select * From ChiPhiHangThang";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool EditMonthlyBill(Dictionary<string, object> parameters)
        {
            return DataProvider.Instance.ExecuteStoredProcedure("EditHoaDonHangThang", parameters) > 0;
        }
    }
}
