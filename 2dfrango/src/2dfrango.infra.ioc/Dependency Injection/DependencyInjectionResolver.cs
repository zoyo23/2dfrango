using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _2dfrango.infra.ioc.Dependency_Injection
{
    public static class DependencyInjectionResolver
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            ServicesResolver.Resolver(services);
            RepositoriesResolver.Resolver(services, configuration);
        }
    }
}
