using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface ICobradoresDataService
    {
        public List<Cobradores> GetAll();
    }
}
