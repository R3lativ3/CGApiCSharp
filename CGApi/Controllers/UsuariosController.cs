using System.Collections.Generic;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CGApi.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosController: ControllerBase
    {
        IUsuarioDataService _usuarioDataService;

        public UsuariosController(IUsuarioDataService usuarioDataService)
        {
            _usuarioDataService = usuarioDataService;
        }

        // ENDPOINT
        [HttpGet]
        public ActionResult<List<Usuarios>> GetAll()
        {
            var respuesta = _usuarioDataService.GetAll();

            if(respuesta is null)
            {
                return NotFound(respuesta);
            }

            return respuesta;
        }
    }
}
