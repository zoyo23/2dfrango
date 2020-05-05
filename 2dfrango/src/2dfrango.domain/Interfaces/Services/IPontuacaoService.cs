using _2dfrango.domain.Models;

namespace _2dfrango.domain.Interfaces.Services
{
    public interface IPontuacaoService
    {
        #region Métodos Síncronos
        Pontuacao ObterPontuacao(string email);

        int AlterarPontacao(Pontuacao pontuacao);
        #endregion
    }
}
