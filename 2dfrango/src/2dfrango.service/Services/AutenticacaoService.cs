using _2dfrango.domain.Interfaces.Repositories;
using _2dfrango.domain.Interfaces.Services;

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
    }
}
