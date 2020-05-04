using _2dfrango.domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace _2dfrango.infra.repository.Context
{
    public class _2dFrangoContext : DbContext
    {
        public _2dFrangoContext(DbContextOptions<_2dFrangoContext> options) : base(options)
        { }

        #region DBSets

        public DbSet<Autenticacao> Autenticacao { get; set; }

        #endregion

        #region Mapeamentos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autenticacao>()
                .Property(p => p.Email)
                .IsRequired();

            modelBuilder.Entity<Autenticacao>()
                .Property(p => p.Telefone)
                .IsRequired();

            modelBuilder.Entity<Autenticacao>()
                .HasKey(c => c.Email);

            base.OnModelCreating(modelBuilder);
        }
        #endregion

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var config = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        //    //base.OnConfiguring(optionsBuilder);
        //}
    }
}
