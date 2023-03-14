using CGApi.Common;
using CGApi.IServices;
using CGApi.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CGApi.Services
{
    public class MunicipiosDataService : IMunicipiosDataService
    {
        public List<Municipios> GetAll()
        {
            try
            {
                string municipios = "select * from Municipios";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed)
                        conn.Open();

                var result = conn.Query<Municipios>(municipios);
                return result.AsList();
            }catch (Exception)
            {
                throw;
            }
        }

        public Municipios GetMunicipio(int idMunicipio) {
            try
            {
                string municipio = "select * from Municipios where id = @id;";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var result = conn.QueryFirst<Municipios>(municipio, new {id = idMunicipio });
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task InsertMunicipio(Municipios municipio)
        {
            try
            {
                string insert = "insert into Municipios(municipio) values (@municipio);";
                //var parameters = new
                //{
                //    municipio = municipio.municipio
                //};
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var result = conn.Execute(insert, new { municipio.municipio });

                return Task.FromResult(result);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task UpdateMunicipio(Municipios municipio, int Id)
        {
            try
            {
                string query = "update Municipios set municipio = @municipio where id = @id;";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State == ConnectionState.Closed) conn.Open();

                var result = conn.Execute(query, new {municipio = municipio.municipio, id = Id});
                return Task.FromResult(result);
            }catch (Exception)
            {
                throw;
            }
        }

        public Task DeleteMunicipio(int Id)
        {
            try
            {
                string query = "delete from Municipios where id = @id;";
                using IDbConnection conn = new SqlConnection(Global.ConnectionString);
                    if(conn.State!= ConnectionState.Closed) conn.Open();

                var result = conn.Execute(query, new {id = Id});
                return Task.FromResult(result);
            }catch(Exception)
            {
                throw;
            }
        }
    }
}
