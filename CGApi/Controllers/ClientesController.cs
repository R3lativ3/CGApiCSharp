using System;
using Microsoft.AspNetCore.Mvc;

namespace CGApi.Controllers
{
    // ruta para acceder al recurso
    [Route("api/clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
	{
		public ClientesController()
		{
		}

        // endpoints, peticion GET sin subruta (es decir, tomara el nombre del recurso [linea 7])
        [HttpGet]
        // Retorna un ActionResult (para manejar estado de las peticiones, 200, 400, etc)
        // y Dentro del ActionResult el contenido que se va a obtener (la data en si), puede ser int, float, string, incluso una clase.
        public ActionResult<string> Hi()
        {
            return Ok("Clientes");
        }

        // peticion get con subruta.
        [HttpGet("nombre-subruta")]
        public ActionResult<int> HiNumber()
        {
            return Ok(1000);
        }
    }
}

