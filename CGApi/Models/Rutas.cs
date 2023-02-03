namespace CGApi.Models
{
    public class Rutas
    {
        public int id { get;set;}
        public string nombreRuta { get;set;}
        public int idSede { get; set; }
        public int idMunicipio { get; set; }
    }
}
