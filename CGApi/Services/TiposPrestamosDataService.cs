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
    public class TiposPrestamosDataService : ITiposPrestamosDataService
    {
        public List<TiposPrestamos> GetAll()
        {
            try
            {
                string típosPrestamos = "select * from TiposPrestamos";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var result = conn.Query<TiposPrestamos>(típosPrestamos);
                return result.AsList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TiposPrestamos GetTipoPrestamo(int Id)
        {
            try
            {
                string query = "select * from TiposPrestamos where id = @id;";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed) conn.Open();

                var result = conn.QueryFirst<TiposPrestamos>(query, new {id = Id});
                return result;
            }catch (Exception)
            {
                throw;
            }
        }
    }
}
