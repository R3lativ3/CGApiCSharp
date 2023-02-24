using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface ITiposPrestamosDataService
    {
        public List<TiposPrestamos> GetAll();
    }
}
