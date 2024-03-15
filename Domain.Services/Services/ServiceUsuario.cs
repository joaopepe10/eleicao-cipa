using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Domain.Nucleo.Interfaces.Services;
using EleicaoCipa.Dominio.Model;

namespace EleicaoCipa.Domain.Servicos.Services;

public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
{
    private readonly IUsuarioRepository _repository;
    public ServiceUsuario(IUsuarioRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
