using Microsoft.AspNetCore.Mvc;
using quemsoueuapi.models;

namespace quemsoueuapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class quemsoueuapiController : ControllerBase
    {
        [HttpGet]
        public quemsoueuapiModel Get()
        {
            var resultado = new quemsoueuapiModel
            {
                mensagem = "Bárbara Rodrigues de Oliveira",
                url = "https://github.com/barbararoliveira"
            };
            return resultado;
        }
    }
}