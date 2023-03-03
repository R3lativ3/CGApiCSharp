using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CGApi.Controllers
{
    [Route("api/cobradores")]
    [ApiController]
    public class CobradoresController: ControllerBase
    {
        ICobradoresDataService _cobradoresDataService;

        public CobradoresController(ICobradoresDataService cobradoresDataService)
        {
            _cobradoresDataService = cobradoresDataService;
        }

        [HttpGet]
        public ActionResult<List<Cobradores>> GetAll()
        {
            try
            {
                var respuesta = _cobradoresDataService.GetAll();
                if(respuesta is null)
                {
                    return NotFound(respuesta);
                }

                return Ok(respuesta);
            }catch (Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }
    }
}
