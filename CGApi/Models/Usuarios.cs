namespace CGApi.Models
{
    public class Usuarios
    {
        public int id { get;set;}
        public string nombreUsuario { get;set;}
        public string emailUsuario { get; set; }
        public string psw { get; set; }
        public int idTipoUsuario { get; set; }
        public string salt { get; set; }
    }
}
