using _2dfrango.domain.Interfaces.Services;
using _2dfrango.service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace _2dfrango.infra.ioc.Dependency_Injection
{
    public static class ServicesResolver
    {
        public static void Resolver(IServiceCollection services)
        {
            services.AddScoped<IAutenticacaoService, AutenticacaoService>();
        }
    }
}
