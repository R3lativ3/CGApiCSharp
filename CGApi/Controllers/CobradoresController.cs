using CGApi.Common;
using CGApi.IServices;
using CGApi.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        [HttpGet("{id}")]
        public ActionResult<Cobradores> GetCobrador(int id) {
            try
            {
                var respuesta = _cobradoresDataService.GetCobrador(id);

                if(respuesta is null)
                    return NotFound(respuesta);

                return Ok(respuesta);
            }catch (Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }
    }
}
