using CGApi.Common;
using CGApi.IServices;
using CGApi.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CGApi.Services
{
    public class MontosPrestamosDataService : IMontosPrestamosDataService
    {
        public List<MontosPrestamos> GetAll()
        {
            try
            {
                string montosPrestamos = "select * from MontosPrestamos";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed)
                        conn.Open();

                var result = conn.Query<MontosPrestamos>(montosPrestamos);
                return result.AsList();
            }catch (Exception)
            {
                throw;
            }
        }
    }
}
