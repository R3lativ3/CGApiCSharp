using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface ITiposUsuariosDataService
    {
        public List<TiposUsuarios> GetAll();
    }
}
