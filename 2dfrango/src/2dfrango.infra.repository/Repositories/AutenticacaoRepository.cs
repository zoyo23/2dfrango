using _2dfrango.domain.Interfaces.Repositories;
using _2dfrango.domain.Models;
using _2dfrango.infra.repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;

namespace _2dfrango.infra.repository
{
    public class AutenticacaoRepository : IAutenticacaoRepository
    {
        #region Atributos

        private readonly _2dFrangoContext _context;

        #endregion

        #region Construtores

        public AutenticacaoRepository(_2dFrangoContext context)
        {
            _context = context;
        }

        #endregion

        #region Public Methods

        public async Task<Autenticacao> CadastrarClienteAsync(Autenticacao autenticacao)
        {
            var clienteCriado = await _context.Autenticacao.AddAsync(autenticacao);
            await _context.SaveChangesAsync();
            return clienteCriado.Entity;
        }

        public async Task<Autenticacao> RecuperarClientePorEmail(string email)
        {
            return await _context.Autenticacao.FirstOrDefaultAsync(p => p.Email == email);
        }

        #endregion
    }
}
