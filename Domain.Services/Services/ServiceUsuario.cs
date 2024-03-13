using EleicaoCipa.Domain.Core.Interfaces.Repositories;
using EleicaoCipa.Domain.Core.Interfaces.Services;
using EleicaoCipa.Domain.Model;

namespace EleicaoCipa.Domain.Services.Services;

public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
{
    private readonly IUsuarioRepository _repository;
    public ServiceUsuario(IUsuarioRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
