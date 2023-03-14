using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CGApi.IServices
{
    public interface IMunicipiosDataService
    {
        public List<Municipios> GetAll();
        public Municipios GetMunicipio(int id);
        public Task InsertMunicipio(Municipios municipio);
        public Task UpdateMunicipio(Municipios municipio, int id);
        public Task DeleteMunicipio(int id);
    }
}
