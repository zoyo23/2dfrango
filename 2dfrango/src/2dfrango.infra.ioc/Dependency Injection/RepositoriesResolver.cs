using _2dfrango.domain.Interfaces.Repositories;
using _2dfrango.infra.repository;
using _2dfrango.infra.repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using System.Data.SqlClient;

namespace _2dfrango.infra.ioc.Dependency_Injection
{
    public class RepositoriesResolver
    {
        public static void Resolver(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<_2dFrangoContext>(options =>
            {
                var psw = Environment.GetEnvironmentVariable("DatabasePsd");
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection").Replace("[PSW_DB]", psw));
            });

            services.AddScoped<IAutenticacaoRepository, AutenticacaoRepository>();
        }
    }
}
