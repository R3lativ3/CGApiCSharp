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
    public class CobradoresDataService : ICobradoresDataService
    {
        public List<Cobradores> GetAll()
        {
            try
            {
                string cobradores = "select * from Cobradores";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                var result = conn.Query<Cobradores>(cobradores);
                return result.AsList();
            }catch (Exception)
            {
                throw;
            }
        }

        public Cobradores GetCobrador(int Id)
        {
            try
            {
                string cobrador = "select * from Cobradores where id = @id;";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var result = conn.QueryFirst<Cobradores>(cobrador, new { id = Id });

                return result;
            }catch(Exception)
            {
                throw;
            }
        }
    }
}
