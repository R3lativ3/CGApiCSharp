using CGApi.Common;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using CGApi.IServices;
using System;

namespace CGApi.Services
{
    public class UsuariosDataService: IUsuariosDataService
    {
        public UsuariosDataService() 
        {
        
        }

        public void Add(Usuarios usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Usuarios Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Usuarios> GetAll()
        {
            try
            {
                string usuarios = "select * from Usuarios";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if (conn.State == ConnectionState.Closed)                    
                        conn.Open();

                var result = conn.Query<Usuarios>(usuarios);
                return result.AsList();
                    
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Update(Usuarios usuarios)
        {
            throw new System.NotImplementedException();
        }
    }
}
