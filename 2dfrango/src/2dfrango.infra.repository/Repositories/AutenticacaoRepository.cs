using _2dfrango.domain.Interfaces.Repositories;
using _2dfrango.domain.Models;
using _2dfrango.infra.repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace _2dfrango.infra.repository
{
    public class AutenticacaoRepository : IAutenticacaoRepository
    {
        #region Atributos

        private readonly _2dFrangoContext _context;
        private readonly DbSet<Autenticacao> _autenticacoes;
        private readonly DbSet<Pontuacao> _pontuacoes;
        #endregion

        #region Construtores

        public AutenticacaoRepository(_2dFrangoContext context)
        {
            _context = context;
            _autenticacoes = _context.Set<Autenticacao>();
            _pontuacoes = _context.Set<Pontuacao>();
        }

        #endregion

        #region Public Methods

        public async Task<Autenticacao> CadastrarClienteAsync(Autenticacao autenticacao)
        {

            var clienteCriado = _autenticacoes.Add(autenticacao);
            var pontuacoes = _pontuacoes.Add(new Pontuacao
            {
                Email = autenticacao.Email,
                Diamantes = 0,
                Moedas = 10
            });

            try
            {
                _context.SaveChanges();

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
            }

            return clienteCriado.Entity;
        }

        public async Task<Autenticacao> RecuperarClientePorEmail(string email)
        {
            return await _autenticacoes.FirstOrDefaultAsync(p => p.Email == email);
        }

        #endregion
    }
}
