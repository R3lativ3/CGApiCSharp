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

        public Rutas GetRuta(int Id)
        {
            try
            {
                string query = "select * from Rutas where id = @id;";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed) conn.Open();

                var result = conn.QueryFirst<Rutas>(query, new {id = Id});
                return result;
            }catch (Exception)
            {
                throw;
            }
        }
    }
}
