using System;
using System.Collections.Generic;
using CGApi.Common;
using System.Data;
using System.Data.SqlClient;
using CGApi.Models;
using Dapper;

namespace CGApi
{
	public class UsuarioDataService : IUsuarioDataService
	{
		public UsuarioDataService()
		{
		}

        public void Add(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Usuarios Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> GetAll()
        {
            try
            {
                string query = @"select * from Usuarios";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var result = conn.Query<Usuarios>(query);
                return result.AsList();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Usuarios usuarios)
        {
            throw new NotImplementedException();
        }
    }
}

