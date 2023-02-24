using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface IMontosPrestamosDataService
    {
        public List<MontosPrestamos> GetAll();
    }
}
