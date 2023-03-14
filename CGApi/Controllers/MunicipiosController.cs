using CGApi.IServices;
using CGApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CGApi.Controllers
{
    [Route("api/municipios")]
    [ApiController]
    public class MunicipiosController: ControllerBase
    {
        IMunicipiosDataService _municipiosDataService;

        public MunicipiosController(IMunicipiosDataService municipiosDataService)
        {
            _municipiosDataService = municipiosDataService;
        }

        [HttpGet]
        public ActionResult<List<Municipios>> GetAll()
        {
            try
            {
                var respuesta = _municipiosDataService.GetAll();

                if (respuesta is null)
                    return NotFound(respuesta);

                return Ok(respuesta);
            }catch(Exception ex)
            {
                return Problem(ex.Message, null, 500);
            }           
        }

        [HttpGet("{id:int}")]
        public ActionResult<Municipios> GetUsuario(int id)
        {
            try
            {
                var respuesta = _municipiosDataService.GetMunicipio(id);
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

        [HttpPost]
        public Task InsertMunicipio(Municipios municipio)
        {
            try
            {
                var result = _municipiosDataService.InsertMunicipio(municipio);

                if(result == null) Console.WriteLine(BadRequest(result));

                return Task.FromResult(result);
            }catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }

        [HttpPut]
        public Task UpdateMunicipio(Municipios municipio, int id)
        {
            try
            {
                var respuesta = _municipiosDataService.UpdateMunicipio(municipio, id);
                if(respuesta is null) Console.WriteLine(NotFound(respuesta));

                return Task.FromResult(respuesta);
            }catch (Exception ex)
            {
                return Task.FromException(ex);
            }
        }

        [HttpDelete("{id:int}")]
        public Task DeleteMunicipio(int id)
        {
            try
            {
                var respuesta = _municipiosDataService.DeleteMunicipio(id);
                if(respuesta is null) Console.WriteLine(NotFound(respuesta));

                return Task.FromResult(respuesta);
            }catch(Exception ex)
            {
                return Task.FromException(ex);
            }
        }
    }
}
