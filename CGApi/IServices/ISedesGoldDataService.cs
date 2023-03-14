using CGApi.Models;
using System.Collections.Generic;

namespace CGApi.IServices
{
    public interface ISedesGoldDataService
    {
        public List<SedesGold> GetAll();
        public SedesGold GetSede(int id);
    }
}
