using Aplicacion.Seguridad;
using Dominio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UsuariosController : MiControllerBase
    {
        [HttpPost("login")]
        public async Task<ActionResult<UsuarioData>> Login(Login.Ejecuta ejecuta)
        {
            return await Mediator.Send(ejecuta);
        }

        [HttpPost("registrar")]
        public async Task<ActionResult<UsuarioData>> Registrar(Registrar.Ejecuta ejecuta)
        {
            return await Mediator.Send(ejecuta);
        }

        [HttpGet("UsuarioActual")]
        public async Task<ActionResult<UsuarioData>> UsuarioActual() 
        {
            return await Mediator.Send(new UsuarioActual.Ejecutar());
        }

        [HttpPut("Actualizar")]
        public async Task<ActionResult<UsuarioData>> Actualizar(UsuariosActualizar.Ejecuta ejecuta)
        {
            return await Mediator.Send(ejecuta);
        }
    }


}