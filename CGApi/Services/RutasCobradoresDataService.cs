using CGApi.Common;
using CGApi.IServices;
using CGApi.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System;

namespace CGApi.Services
{
    public class RutasCobradoresDataService : IRutasCobradoresDataService
    {
        public List<RutasCobradores> GetAll()
        {
            try
            {
                string rutasCobradores = "select * from RutasCobradores";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var result = conn.Query<RutasCobradores>(rutasCobradores);
                return result.AsList();
            }catch (Exception)
            {
                throw;
            }
        }
    }
}
