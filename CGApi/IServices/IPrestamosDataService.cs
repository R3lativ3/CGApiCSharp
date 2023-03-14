using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface IPrestamosDataService
    {
        public List<Prestamos> GetAll();
        public Prestamos GetPrestamo(int id);
    }
}
