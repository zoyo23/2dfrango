using _2dfrango.domain.Interfaces.Repositories;
using _2dfrango.domain.Interfaces.Services;
using _2dfrango.domain.Models;

namespace _2dfrango.service.Services
{
    public class PontuacaoService : IPontuacaoService
    {
        #region Atributos
        private readonly IPontuacaoRepository _pontuacaoRepository;

        #endregion

        #region Construtores
        public PontuacaoService(IPontuacaoRepository pontuacaoRepository)
        {
            _pontuacaoRepository = pontuacaoRepository;
        }
        #endregion

        #region Métodos
        public int AlterarPontacao(Pontuacao pontuacao)
        {
            return _pontuacaoRepository.AlterarPontacao(pontuacao);
        }

        public Pontuacao ObterPontuacao(string email)
        {
            return _pontuacaoRepository.ObterPontuacao(email); ;
        }
        #endregion
    }
}
