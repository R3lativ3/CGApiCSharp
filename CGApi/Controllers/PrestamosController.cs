using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CGApi.Controllers
{
    [Route("api/prestamos")]
    [ApiController]
    public class PrestamosController: ControllerBase
    {
        IPrestamosDataService _prestamosDataService;

        public PrestamosController(IPrestamosDataService prestamosDataService)
        {
            _prestamosDataService = prestamosDataService;
        }

        [HttpGet]
        public ActionResult<List<Prestamos>> GetAll()
        {
            try
            {
                var respuesta = _prestamosDataService.GetAll();

                if (respuesta is null)
                    return NotFound(respuesta);

                return Ok(respuesta);
            }catch (Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<Prestamos> GetPrestamo(int id)
        {
            try
            {
                var respuesta = _prestamosDataService.GetPrestamo(id);
                if(respuesta is null) return NotFound(respuesta);

                return Ok(respuesta);
            }catch(Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }
    }
}
