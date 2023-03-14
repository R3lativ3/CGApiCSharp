using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CGApi.Controllers
{
    // ruta para acceder al recurso
    [Route("api/clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        IClientesDataService _clientesDataService;

        public ClientesController(IClientesDataService clientesDataService)
        {
            _clientesDataService = clientesDataService;
        }

        [HttpGet]
        public ActionResult<List<Clientes>> GetAll()
        {
            try
            {
                var respuesta = _clientesDataService.GetAll();
                if(respuesta is null)
                {
                    return NotFound(respuesta);
                }

                return Ok(respuesta);
            } catch (Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Clientes> GetCliente(int id) {
            try
            {
                var cliente = _clientesDataService.GetCliente(id);
                if(cliente is null)
                {
                    return NotFound(cliente);
                }

                return Ok(cliente);
            }catch(Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }
        }

        // endpoints, peticion GET sin subruta (es decir, tomara el nombre del recurso [linea 7])

        // Retorna un ActionResult (para manejar estado de las peticiones, 200, 400, etc)
        // y Dentro del ActionResult el contenido que se va a obtener (la data en si), puede ser int, float, string, incluso una clase.
        [HttpGet("a")]
        public ActionResult<string> Hi()
        {
            return Ok("Clientes");
        }

        // peticion get con subruta.
        [HttpGet("nombre-subruta")]
        public ActionResult<int> HiNumber()
        {
            return Ok(1000);
        }
    }
}

