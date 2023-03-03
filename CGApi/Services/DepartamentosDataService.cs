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
    public class DepartamentosDataService : IDepartamentosDataService
    {
        public List<Departamentos> GetAll()
        {
            try
            {
                string departamentos = "Select * from Departamentos";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                var result = conn.Query<Departamentos>(departamentos);
                return result.AsList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
