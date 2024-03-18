using EleicaoCipa.Aplicacao.Interfaces;
using EleicaoCipa.Aplicacao.Service;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Services;
using EleicaoCipa.Dominio.Servicos.Services;
using EleicaoCipa.Infraestrutura.Data;
using EleicaoCipa.Infraestrutura.Repository.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace EleicaoCipa.Infraestrutura.CrossCutting.IOC;

public static class IocModule
{
    public static void RegisteModule(this IServiceCollection services)
    {
        RegisterContext(services);
        RegisterSingleton(services);
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

    private static void RegisterContext(IServiceCollection services)
    {
        services.AddScoped<EleicaoContext>();
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
        services.AddScoped<IServiceCandidato, ServiceCandidato>();
        services.AddScoped<IServiceEleicao, ServiceEleicao>();
        services.AddScoped<IServiceVoto, ServiceVoto>();
        services.AddScoped<IServiceUsuario, ServiceUsuario>();
    }

    private static void RegisterRepository(IServiceCollection services)
    {
        services.AddScoped<ICandidatoRepository, CandidatoRepository>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        services.AddScoped<IVotoRepository, VotoRepository>();
        services.AddScoped<IEleicaoRepository, EleicaoRepository>();
    }

}
