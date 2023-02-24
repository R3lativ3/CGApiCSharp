using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface IRutasCobradoresDataService
    {
        public List<RutasCobradores> GetAll();
    }
}
