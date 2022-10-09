using Microsoft.Extensions.DependencyInjection;
using ProjectTemplate.Application.Interfaces;
using ProjectTemplate.Application.Services;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Domain.Interfaces.Services;
using ProjectTemplate.Domain.Services;
using ProjectTemplate.Infra.Data.Repositories;

namespace ProjectTemplate.Infra.IoC
{
    public static class InjectorDependencies
    {
        public static void Registrer(IServiceCollection services)
        {
            //Application
            services.AddScoped(typeof(IBaseApp<,>), typeof(BaseServicoApp<,>));
            services.AddScoped<IClienteApp, ClienteServicoApp>();

            //Domínio
            services.AddScoped(typeof(IBaseServico<>), typeof(BaseServico<>));
            services.AddScoped<IClienteServico, ClienteServico>();

            //Repositorio
            services.AddScoped(typeof(IBaseRepositorio<>), typeof(BaseRepositorio<>));
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
        }
    }
}
