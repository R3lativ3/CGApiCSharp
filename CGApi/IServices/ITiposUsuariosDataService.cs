using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface ITiposUsuariosDataService
    {
        public List<TiposUsuarios> GetAll();
        public TiposUsuarios GetTipoUsuario(int id);
    }
}
