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
        private readonly IMontosPrestamosDataService _montosPrestamosDataService;

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

        [HttpGet("{id:int}")]
        public ActionResult<MontosPrestamos> GetMontoPrestamo(int id)
        {
            try
            {
                var respuesta = _montosPrestamosDataService.GetMontoPrestamo(id);
                if(respuesta is null) return NotFound(respuesta);

                return Ok(respuesta);
            }catch(Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }
    }
}
