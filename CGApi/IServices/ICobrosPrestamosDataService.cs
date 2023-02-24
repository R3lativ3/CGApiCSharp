using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface ICobrosPrestamosDataService
    {
        public List<CobrosPrestamos> GetAll();
    }
}
