using _2dfrango.domain.Models;

namespace _2dfrango.domain.Interfaces.Repositories
{
    public interface IPontuacaoRepository
    {
        #region Métodos Síncronos
        Pontuacao ObterPontuacao(string email);

        int AlterarPontacao(Pontuacao pontuacao);
        #endregion
    }
}
