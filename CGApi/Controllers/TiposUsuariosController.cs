using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace CGApi.Controllers
{
    [Route("api/tiposUsuarios")]
    [ApiController]
    public class TiposUsuariosController: ControllerBase
    {
        ITiposUsuariosDataService _tiposUsuariosDataService;

        public TiposUsuariosController(ITiposUsuariosDataService tiposUsuariosDataService)
        {
            _tiposUsuariosDataService = tiposUsuariosDataService;
        }

        [HttpGet]
        public ActionResult<List<RutasCobradores>> GetAll()
        {
            try
            {
                var respuesta = _tiposUsuariosDataService.GetAll();

                if (respuesta is null)
                    return NotFound(respuesta);

                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<TiposUsuarios> GetTipoUsuario(int id)
        {
            try
            {
                var respuesta = _tiposUsuariosDataService.GetTipoUsuario(id);

                if (respuesta is null)
                    return NotFound(respuesta);

                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }
    }
}
