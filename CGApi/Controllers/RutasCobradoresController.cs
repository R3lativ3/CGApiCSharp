using CGApi.IServices;
using CGApi.Models;
using CGApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CGApi.Controllers
{
    [Route("api/rutasCobradores")]
    [ApiController]
    public class RutasCobradoresController: ControllerBase
    {
        IRutasCobradoresDataService _rutasCobradoresDataService;

        public RutasCobradoresController(IRutasCobradoresDataService rutasCobradoresDataService)
        {
            _rutasCobradoresDataService = rutasCobradoresDataService;
        }

        [HttpGet]
        public ActionResult<List<RutasCobradores>> GetAll() {
            try
            {
                var respuesta = _rutasCobradoresDataService.GetAll();

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
