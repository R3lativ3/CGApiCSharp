using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace CGApi.Controllers
{
    [Route("api/tiposPrestamos")]
    [ApiController]
    public class TiposPrestamosController: ControllerBase
    {
        ITiposPrestamosDataService _tiposPrestamosDataService;

        public TiposPrestamosController(ITiposPrestamosDataService tiposPrestamosDataService)
        {
            _tiposPrestamosDataService = tiposPrestamosDataService;
        }

        [HttpGet]
        public ActionResult<List<RutasCobradores>> GetAll()
        {
            try
            {
                var respuesta = _tiposPrestamosDataService.GetAll();

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
        public ActionResult<TiposPrestamos> GetTipoPrestamo(int id)
        {
            try
            {
                var respuesta = _tiposPrestamosDataService.GetTipoPrestamo(id);
                if(respuesta is null) return NotFound(respuesta);

                return Ok(respuesta);
            }catch(Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }
    }
}
