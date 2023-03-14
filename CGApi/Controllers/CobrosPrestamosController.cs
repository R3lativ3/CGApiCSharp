using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CGApi.Controllers
{
    [Route("api/cobrosPrestamos")]
    [ApiController]
    public class CobrosPrestamosController: ControllerBase
    {
        ICobrosPrestamosDataService _cobrosPrestamosDataService;

        public CobrosPrestamosController(ICobrosPrestamosDataService cobrosPrestamosDataService)
        {
            _cobrosPrestamosDataService= cobrosPrestamosDataService;
        }

        [HttpGet]
        public ActionResult<List<CobrosPrestamosController>> GetAll()
        {
            try
            {
                var respuesta = _cobrosPrestamosDataService.GetAll();
                if(respuesta == null)
                {
                    return NotFound(respuesta);
                }

                return Ok(respuesta);
            }catch (Exception ex) {
                return Problem(ex.Message, null, 500);
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<CobrosPrestamos> GetCobroPrestamo(int id)
        {
            try
            {
                var respuesta = _cobrosPrestamosDataService.GetCobroPrestamo(id);
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
