using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CGApi.Controllers
{
    [Route("api/montosPrestamos")]
    [ApiController]
    public class MontosPrestamosController: ControllerBase
    {
        IMontosPrestamosDataService _montosPrestamosDataService;

        public MontosPrestamosController(IMontosPrestamosDataService montosPrestamosDataService)
        {
            _montosPrestamosDataService = montosPrestamosDataService;
        }

        [HttpGet]
        public ActionResult<List<MontosPrestamos>> GetAll()
        {
            try
            {
                var respuesta = _montosPrestamosDataService.GetAll();

                if (respuesta is null)
                    return NotFound(respuesta);

                return Ok(respuesta);
            }catch (Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }
    }
}
