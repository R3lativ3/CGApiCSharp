using System;

namespace CGApi.Models
{
    public class Clientes
    {
        public int id { get;set;}
        public string dpi { get;set;}
        public string telefono { get; set; }
        public string telefono2 { get; set; }
        public string ocupacion { get; set; }
        public string negocio { get; set; }
        public string foto { get; set; }
        public string fotoCasa { get; set; }
        public string direccion { get; set; }
        public string nit { get; set; }
        public string referencia { get; set; }
        public DateTime createdAt { get; set; }
        public string nombre { get; set; }
    }
}
