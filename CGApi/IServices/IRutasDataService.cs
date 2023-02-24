using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface IRutasDataService
    {
        public List<Rutas> GetAll();
    }
}
