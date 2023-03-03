using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CGApi.Controllers
{
    [Route("api/departamentos")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        IDepartamentosDataService _departamentosDataService;

        public DepartamentosController(IDepartamentosDataService departamentosDataService)
        {
            _departamentosDataService = departamentosDataService;
        }

        [HttpGet]
        public ActionResult<List<Departamentos>> GetAll()
        {
            try
            {
                var respuesta = _departamentosDataService.GetAll();
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
    }
}
