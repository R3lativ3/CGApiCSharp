﻿using CGApi.Common;
using CGApi.IServices;
using CGApi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace CGApi.Services
{
    public class TiposUsuariosDataService : ITiposUsuariosDataService
    {
        public List<TiposUsuarios> GetAll()
        {
            try
            {
                string típosUsuarios = "select * from TiposUsuarios";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var result = conn.Query<TiposUsuarios>(típosUsuarios);
                return result.AsList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
