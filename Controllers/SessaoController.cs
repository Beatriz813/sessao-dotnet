using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;

namespace UsandoSessao.Controllers
{
    [ApiController]
    [Route("sessao")]
    public class SessaoController : ControllerBase
    {
        [HttpGet]
        public IActionResult SetSession ([FromQuery] string nome)
        {
            HttpContext.Session.Set("nome", Encoding.UTF8.GetBytes(nome));
            
            return Ok();
        }

       [HttpGet("listar")]
       public IActionResult GetSession ()
        {
           var n = Encoding.UTF8.GetString(HttpContext.Session.Get("nome") ?? new byte[0]);
            return Ok(new { nome = n });
        }

    }
}
