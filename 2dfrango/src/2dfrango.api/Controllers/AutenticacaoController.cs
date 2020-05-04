using _2dfrango.api.Filter;
using _2dfrango.api.ViewModel;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        [Authorize]
        public IActionResult AutenticarCliente(AutenticacaoViewModel autenticacaoViewModel)
        {
            try
            {

            }
            catch (Exception)
            {

                return UnprocessableEntity();
            }

            return Ok(JsonConvert.SerializeObject(this.User));
        }

        [HttpGet("verificaLogin")]
        [AuthorizeGoogle]
        public async Task<IActionResult> VerificaAutorizacao(string email)
        {
            try
            {
                // TODO: Incluir o cliente no banco de dados
            }
            catch (Exception e)
            {

                return UnprocessableEntity(e.Message);
            }

            return Ok(JsonConvert.SerializeObject(this.User.Identity));
        }
        #endregion

        #region Métodos Privados

        #endregion
    }
}