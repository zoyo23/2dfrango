using System.Threading.Tasks;

namespace _2dfrango.domain.Interfaces.Services
{
    public interface IAutenticacaoService
    {
        Task CriarAutenticacao(string email, string nome);
    }
}
