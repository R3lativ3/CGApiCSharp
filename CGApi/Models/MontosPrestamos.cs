namespace CGApi.Models
{
    public class MontosPrestamos
    {
        public int id { get;set;}
        public float montoEntregado { get;set;}
        public float montoConInteres { get; set; }
        public float porcentajeInteres { get; set; }
        public int plazoDias { get; set; }
        public float lcobroDiario { get; set; }
    }
}
