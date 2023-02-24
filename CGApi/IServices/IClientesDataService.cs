using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface IClientesDataService
    {
        public List<Clientes> GetAll();
    }
}
