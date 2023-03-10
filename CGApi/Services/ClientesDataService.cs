using CGApi.Common;
using CGApi.IServices;
using CGApi.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CGApi.Services
{
    public class ClientesDataService : IClientesDataService
    {
        public List<Clientes> GetAll()
        {
            try
            {
                string clientes = "select * from Clientes";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed)
                        conn.Open();

                var result = conn.Query<Clientes>(clientes);
                return result.AsList();
            } catch (Exception)
            {
                throw;
            }
        }

        public Clientes GetCliente(int idCliente)
        {
            string cliente = "select * from Clientes where id = @id;";
            using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if(conn.State == ConnectionState.Closed)
                    conn.Open();

            var result = conn.QueryFirst<Clientes>(cliente, new {id = idCliente});
            return result;
        }
    }
}
