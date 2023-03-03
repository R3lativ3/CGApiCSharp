using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace CGApi.Controllers
{
    [Route("api/sedesGold")]
    [ApiController]
    public class SedesGoldController: ControllerBase
    {
        ISedesGoldDataService _sedesGoldDataService;

        public SedesGoldController(ISedesGoldDataService sedesGoldDataService)
        {
            _sedesGoldDataService = sedesGoldDataService;
        }

        [HttpGet]
        public ActionResult<List<RutasCobradores>> GetAll()
        {
            try
            {
                var respuesta = _sedesGoldDataService.GetAll();

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
