using Dominio;
using Microsoft.AspNetCore.Mvc;
using Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly GestionContext gestionContext;
        public WeatherForecastController(GestionContext gestionContext) 
        {
            this.gestionContext = gestionContext;
        }

        [HttpGet]
        public IEnumerable<TiposDocumentos> Get()
        {

            return gestionContext.ParamTiposDocumentos.ToList();
        }
    }
}
