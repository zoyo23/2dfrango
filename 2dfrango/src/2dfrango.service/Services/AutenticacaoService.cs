using _2dfrango.domain.Interfaces.Repositories;
using _2dfrango.domain.Interfaces.Services;
using _2dfrango.domain.Models;
using System.Threading.Tasks;

namespace _2dfrango.service.Services
{
    public class AutenticacaoService : IAutenticacaoService
    {
        #region Atributos

        private readonly IAutenticacaoRepository _autenticacaoRepository;

        #endregion

        #region Construtores

        public AutenticacaoService(IAutenticacaoRepository autenticacaoRepository)
        {
            _autenticacaoRepository = autenticacaoRepository;
        }

        #endregion

        #region Public Methods

        public async Task CriarAutenticacao(string email, string nome)
        {
            Autenticacao autenticacao = await _autenticacaoRepository.RecuperarClientePorEmail(email);
            if (autenticacao == null)
            {
                await _autenticacaoRepository.CadastrarClienteAsync(new domain.Models.Autenticacao
                {
                    Email = email,
                    Nome = nome
                });
            }
        }

        #endregion
    }
}
