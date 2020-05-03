using _2dfrango.api.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

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
        [HttpPost("cadastrar")]
        public IActionResult CadastrarCliente(CadastroViewModel cadastroViewModel)
        {
            try
            {

            }
            catch (Exception)
            {

                return UnprocessableEntity();
            }

            return Ok();
        }

        [HttpPost("login")]
        public IActionResult AutenticarCliente(AutenticacaoViewModel autenticacaoViewModel)
        {
            try
            {

            }
            catch (Exception)
            {

                return UnprocessableEntity();
            }

            return Ok();
        }

        [HttpGet("verificaLogin")]
        [Authorize]
        public IActionResult VerificaAutorizacao()
        {
            try
            {

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