﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VehicleDAO
    {
        private static VehicleDAO instance;
        public static VehicleDAO Instance
        {
            get { if (instance == null) instance = new VehicleDAO(); return instance; }
            private set { instance = value; }
        }
        private VehicleDAO() { }
        public DataTable GetVehicleByBienSo(string bienSo)
        {
            string query = $"select * from PhuongTien where bienSo = '{bienSo}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
