﻿using CGApi.Common;
using CGApi.IServices;
using CGApi.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CGApi.Services
{
    public class PrestamosDataService : IPrestamosDataService
    {
        public List<Prestamos> GetAll()
        {
            try
            {
                string prestamos = "select * from Prestamos";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed)
                        conn.Open();

                var result = conn.Query<Prestamos>(prestamos);
                return result.AsList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
