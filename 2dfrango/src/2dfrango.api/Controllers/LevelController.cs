using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2dfrango.domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _2dfrango.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        // GET: /<controller>/
        [HttpGet("status")]
        public IActionResult ObterLevelStatus([FromHeader]string email)
        {
            var levelStatus = new LevelStatus();

            levelStatus.LevelAtual = 3;
            levelStatus.DesafiosConcluidos.Add(new Desafio()
            {
                Level = 1,
                Descricao = "Economizar R$20,00"
            });
            levelStatus.DesafiosConcluidos.Add(new Desafio()
            {
                Level = 2,
                Descricao = "Economizar R$50,00"
            });
            levelStatus.DesafiosPendentes.Add(new Desafio()
            {
                Level =3,
                Descricao = "Economizar R$100,00"
            });
            levelStatus.DesafiosPendentes.Add(new Desafio()
            {
                Level = 3,
                Descricao = "Indique um amigo"
            });

            return Ok(levelStatus);
        }
    }
}
