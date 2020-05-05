using _2dfrango.domain.Interfaces.Repositories;
using _2dfrango.domain.Models;
using _2dfrango.infra.repository.Context;
using Microsoft.EntityFrameworkCore;

namespace _2dfrango.infra.repository.Repositories
{
    public class PontuacaoRepository : IPontuacaoRepository
    {
        #region Atributos
        private readonly _2dFrangoContext _context;
        private readonly DbSet<Pontuacao> _pontuacoes;
        #endregion

        #region Construtores
        public PontuacaoRepository(_2dFrangoContext context)
        {
            _context = context;
            _pontuacoes = _context.Set<Pontuacao>();
        }
        #endregion

        #region Métodos
        public int AlterarPontacao(Pontuacao pontuacao)
        {
            try
            {
                _pontuacoes.Update(pontuacao);
                _context.SaveChanges();
                return 1;
            }
            catch (System.Exception e)
            {
                return 0;
            }
        }

        public Pontuacao ObterPontuacao(string email)
        {
            return _pontuacoes.Find(email);
        }
        #endregion
    }
}
