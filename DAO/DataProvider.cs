using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        // Singleton 
        private static DataProvider instance;
        
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }
        private DataProvider() { }

        private readonly string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=Tasmana;Integrated Security=True;TrustServerCertificate=True";

        // Dùng để chạy câu query bình thường hoặc stored procedure
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return data;
        }
        // Thực hiện thêm xóa sửa
        // Trả về số dòng thành công
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return data;
        }
        // Đếm số lượng, ví dụ COUNT(*)
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            return data;
        }
        // Dùng để chạy stored procedure
        // Param + storedprocedure: Tên của stored procedure muốn chạy
        //       + parameters: hashmap chứa biến và giá trị tương ứng của biến đó, ví dụ 1 pair {"@ho", "Trump"} 
        public int ExecuteStoredProcedure(string storedprocedure, Dictionary<string, object> parameters) 
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                try
                {
                    conn.Open();
                    
                    using (SqlCommand cmd = new SqlCommand(storedprocedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p;
                        foreach (var pair in parameters)
                        {
                            Console.WriteLine($"Parameter: {pair.Key}, Value: {pair.Value?.ToString() ?? "null"}");
                            // Get the value of each object
                            object value = pair.Value;
                            if (value != null)
                            {
                                if (value is int intValue)
                                    p = new SqlParameter(pair.Key, SqlDbType.Int) { Value = intValue };
                                else if (value is string stringValue)
                                    p = new SqlParameter(pair.Key, SqlDbType.NVarChar) { Value = stringValue };
                                else if (value is double doubleValue)
                                    p = new SqlParameter(pair.Key, SqlDbType.Float) { Value = doubleValue };
                                else if (value is bool boolValue)
                                    p = new SqlParameter(pair.Key, SqlDbType.Bit) { Value = boolValue };
                                else if (value is DateTime dateTimeValue)
                                {
                                    if (dateTimeValue.Year < 1900 || dateTimeValue.Year > 2100)
                                        throw new ArgumentException($"DateTime parameter '{pair.Key}' is out of range.");
                                    p = new SqlParameter(pair.Key, SqlDbType.Date) { Value = dateTimeValue };
                                }
                                else
                                    throw new ArgumentException($"Unsupported data type for parameter: {pair.Key}");
                            }
                            else
                            {
                                p = new SqlParameter(pair.Key, SqlDbType.NVarChar) { Value = "" }; ;
                            }

                            cmd.Parameters.Add(p);
                        }

                        data = cmd.ExecuteNonQuery();
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                }
            }
            return data;
        }
    }
}
