using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace CGApi.Controllers
{
    [Route("api/rutas")]
    [ApiController]
    public class RutasController: ControllerBase
    {
        IRutasDataService _rutasDataService;

        public RutasController(IRutasDataService rutasDataService)
        {
            _rutasDataService = rutasDataService;
        }

        [HttpGet]
        public ActionResult<List<RutasCobradores>> GetAll()
        {
            try
            {
                var respuesta = _rutasDataService.GetAll();

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
        public ActionResult<Rutas> GetRuta(int id)
        {
            try
            {
                var respuesta = _rutasDataService.GetRuta(id);
                if(respuesta is null) return NotFound(respuesta);

                return Ok(respuesta);
            }catch (Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }
    }
}
