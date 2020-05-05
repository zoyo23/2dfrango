using _2dfrango.domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace _2dfrango.infra.repository.Context
{
    public class _2dFrangoContext : DbContext
    {
        #region DBSets
        private readonly IDbConnection _dbConnection;
        public DbSet<Autenticacao> Autenticacao { get; set; }
        public DbSet<Pontuacao> Pontuacao { get; set; }
        #endregion

        #region Construtor
        public _2dFrangoContext(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        #endregion

        #region Mapeamentos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Autenticação
            modelBuilder.Entity<Autenticacao>()
                .Property(p => p.Email)
                .IsRequired();

            modelBuilder.Entity<Autenticacao>()
                .Property(p => p.Telefone);

            modelBuilder.Entity<Autenticacao>()
                .Property(p => p.Nome);

            modelBuilder.Entity<Autenticacao>()
                .HasKey(c => c.Email);


            modelBuilder.Entity<Autenticacao>()
                .HasOne(t => t.Pontuacao)
                .WithOne(t => t.Autenticacao)
                .HasForeignKey<Autenticacao>(e => e.Email);
            #endregion

            #region Pontuação
            modelBuilder.Entity<Pontuacao>()
                .HasKey(c => c.Email);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbConnection.ConnectionString);
        }
    }
}
