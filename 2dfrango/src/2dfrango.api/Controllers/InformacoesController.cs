using _2dfrango.api.Filter;
using _2dfrango.api.ViewModel;
using _2dfrango.domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace _2dfrango.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[AuthorizeGoogle]
    public class InformacoesController : ControllerBase
    {
        #region Atributos
        private readonly IPontuacaoService _pontuacaoService;
        #endregion

        #region Construtores
        public InformacoesController(IPontuacaoService pontuacaoService)
        {
            _pontuacaoService = pontuacaoService;
        }
        #endregion

        #region Métodos Públicos
        [HttpGet("obterPontuacao")]
        public async Task<IActionResult> ObterInformacoesPontuacao(string email)
        {
            try
            {
                // TODO: Incluir o cliente no banco de dados
                return Ok(_pontuacaoService.ObterPontuacao(email));
            }
            catch (Exception e)
            {

                return UnprocessableEntity(e.Message);
            }
        }

        [HttpPut("alterarPontuacao")]
        public async Task<IActionResult> AlterarPontuacao(string email, PontuacaoViewModel pontuacaoViewModel)
        {
            try
            {
                return Ok(_pontuacaoService.AlterarPontacao(new domain.Models.Pontuacao
                {
                    Email = email,
                    Diamantes = pontuacaoViewModel.Diamantes,
                    Moedas = pontuacaoViewModel.Moedas
                }));
            }
            catch (Exception e)
            {

                return UnprocessableEntity(e.Message);
            }
        }
        #endregion

        #region Métodos Privados

        #endregion
    }
}