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
    public class MunicipiosDataService : IMunicipiosDataService
    {
        public List<Municipios> GetAll()
        {
            try
            {
                string municipios = "select * from Municipios";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed)
                        conn.Open();

                var result = conn.Query<Municipios>(municipios);
                return result.AsList();
            }catch (Exception)
            {
                throw;
            }
        }
    }
}
