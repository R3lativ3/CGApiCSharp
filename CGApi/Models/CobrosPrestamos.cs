using System;

namespace CGApi.Models
{
    public class CobrosPrestamos
    {
        public int id { get;set;}
        public float cobro { get;set;}
        public float lat { get; set; }
        public float lon { get; set; }
        public DateTime fecha { get; set; }
        public int idPrestamo { get; set; }
        public int eliminado { get; set; }
    }
}
