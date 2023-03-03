using CGApi.Common;
using CGApi.IServices;
using CGApi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CGApi.Services
{
    public class RutasDataService : IRutasDataService
    {
        public List<Rutas> GetAll()
        {
            try
            {
                string rutas = "select * from Rutas";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var result = conn.Query<Rutas>(rutas);
                return result.AsList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
