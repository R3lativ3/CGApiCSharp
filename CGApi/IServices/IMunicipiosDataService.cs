using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface IMunicipiosDataService
    {
        public List<Municipios> GetAll();
    }
}
