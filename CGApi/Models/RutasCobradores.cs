using System;

namespace CGApi.Models
{
    public class RutasCobradores
    {
        public int id { get;set;}
        public int idCobrador { get;set;}
        public int idRuta { get; set; }
        public DateTime fechaAsignacion { get; set; }
    }
}
