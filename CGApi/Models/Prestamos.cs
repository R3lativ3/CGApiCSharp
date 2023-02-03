namespace CGApi.Models
{
    public class Prestamos
    {
        public int id { get;set;}
        public string fecha { get;set;}
        public int idRutaCobrador { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
        public int idTipoPrestamo { get; set; }
        public int idMonto { get; set; }
        public int activo { get; set; }
        public int entregaEfectivo { get; set; }
        public int eliminado { get; set; }
    }
}
