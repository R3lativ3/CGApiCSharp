using System;
using System.Collections.Generic;
using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CGApi.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosController: ControllerBase
    {
        IUsuariosDataService _usuariosDataService;

        public UsuariosController(IUsuariosDataService usuarioDataService)
        {
            _usuariosDataService = usuarioDataService;
        }

        // ENDPOINT
        [HttpGet]
        public ActionResult<List<Usuarios>> GetAll()
        {
            try
            {
                var respuesta = _usuariosDataService.GetAll();

                if (respuesta is null)
                {
                    return NotFound(respuesta);
                }

                return Ok(respuesta);
            }catch (Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
            
        }

        [HttpGet("{id:int}")]
        public ActionResult<Usuarios> GetUsuario(int id)
        {
            try
            {
                var respuesta = _usuariosDataService.GetUsuario(id);
                if(respuesta is null)
                {
                    return NotFound(respuesta);
                }

                return Ok(respuesta);
            }catch(Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }
    }
}
