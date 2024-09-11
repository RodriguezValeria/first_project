using backend_lab_C16696.Handlers;
using backend_lab_C16696.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_lab_C16696.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly PaisHandler _paisHandler;

        public PaisesController()
        {
            _paisHandler = new PaisHandler();
        }

        [HttpGet]
        public List<PaisModel> Get() {
            var paises = _paisHandler.ObtenerPais();
            return paises;
        }
    }
}
