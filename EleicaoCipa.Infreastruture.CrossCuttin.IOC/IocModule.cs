using EleicaoCipa.Aplicacao.Interfaces;
using EleicaoCipa.Aplicacao.Service;
using Microsoft.Extensions.DependencyInjection;

namespace EleicaoCipa.Infreastruture.CrossCutting.IOC;

public static class IocModule
{
    public static void RegisteModule(this IServiceCollection services)
    {
        RegisteModule(services);
        RegisterScopped(services);
        RegisterTransient(services);
    }

    private static void RegisterScopped(IServiceCollection services)
    {
        RegisterRepository(services);
        RegisterService(services);
        RegisterApplicationService(services);
    
    }

    private static void RegisterSingleton(IServiceCollection services)
    {

    }

    private static void RegisterTransient(IServiceCollection services) 
    {
        
    }


    private static void RegisterApplicationService(IServiceCollection services)
    {
        services.AddScoped<IApplicationServiceCandidato, ApplicationServiceCandidato>();
        services.AddScoped<IApplicationServiceEleicao, ApplicationServiceEleicao>();
        services.AddScoped<IApplicationServiceVoto, ApplicationServiceVoto>();
        services.AddScoped<IApplicationServiceUsuario, ApplicationServiceUsuario>();
    }

    private static void RegisterService(IServiceCollection services)
    {

    }

    private static void RegisterRepository(IServiceCollection services) 
    {

    }

}
