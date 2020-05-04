using _2dfrango.domain.Models;
using System.Threading.Tasks;

namespace _2dfrango.domain.Interfaces.Repositories
{
    public interface IAutenticacaoRepository
    {
        Task<Autenticacao> CadastrarClienteAsync(Autenticacao autenticacao);
        Task<Autenticacao> RecuperarClientePorEmail(string email);
    }
}
