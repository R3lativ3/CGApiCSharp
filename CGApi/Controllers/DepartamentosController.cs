using Microsoft.AspNetCore.Mvc;

namespace CGApi.Controllers
{
    [Route("api/departamentos")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        [HttpGet]
        public string say()
        {
            return "say";
        }
    }
}
