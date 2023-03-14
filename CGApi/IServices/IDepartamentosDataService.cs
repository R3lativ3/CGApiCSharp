using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface IDepartamentosDataService
    {
        public List<Departamentos> GetAll();
        public Departamentos GetDepartamento(int id);
    }
}
