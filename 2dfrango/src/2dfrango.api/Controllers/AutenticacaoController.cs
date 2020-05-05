using _2dfrango.domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace _2dfrango.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        #region Atributos

        #endregion

        #region Construtores

        #endregion

        #region Métodos Públicos
        [HttpPost("verificaLogin")]
        public async Task<IActionResult> VerificaAutorizacao([FromServices]IAutenticacaoService autenticacaoService, string email, string nome)
        {
            try
            {
                // TODO: Incluir o cliente no banco de dados
                await autenticacaoService.CriarAutenticacao(email, nome);
            }
            catch (Exception e)
            {

                return UnprocessableEntity(e.Message);
            }

            return Ok();
        }
        #endregion

        #region Métodos Privados

        #endregion
    }
}