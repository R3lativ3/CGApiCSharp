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
    public class CobrosPrestamosDataService : ICobrosPrestamosDataService
    {
        public List<CobrosPrestamos> GetAll()
        {
            try
            {
                string cobrosPrestamos = "select * from CobrosPrestamos";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed) 
                    {
                        conn.Open();
                    }

                var result = conn.Query<CobrosPrestamos>(cobrosPrestamos);
                return result.AsList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
