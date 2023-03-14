using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface IUsuariosDataService
    {
        public List<Usuarios> GetAll();
        public Usuarios GetUsuario(int id);
    }
}
