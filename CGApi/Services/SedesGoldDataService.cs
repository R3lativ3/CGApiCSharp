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
    public class SedesGoldDataService : ISedesGoldDataService
    {
        public List<SedesGold> GetAll()
        {
            try
            {
                string sedesGold = "select * from SedesGold";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var result = conn.Query<SedesGold>(sedesGold);
                return result.AsList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
