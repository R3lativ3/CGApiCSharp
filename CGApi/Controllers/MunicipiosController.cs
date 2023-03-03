using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CGApi.Controllers
{
    [Route("api/municipios")]
    [ApiController]
    public class MunicipiosController: ControllerBase
    {
        IMunicipiosDataService _municipiosDataService;

        public MunicipiosController(IMunicipiosDataService municipiosDataService)
        {
            _municipiosDataService = municipiosDataService;
        }

        [HttpGet]
        public ActionResult<List<Municipios>> GetAll()
        {
            try
            {
                var respuesta = _municipiosDataService.GetAll();

                if (respuesta is null)
                    return NotFound(respuesta);

                return Ok(respuesta);
            }catch(Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }           
        }
    }
}
