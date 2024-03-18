using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Services;

namespace EleicaoCipa.Dominio.Servicos.Services;

public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
{
    private readonly IUsuarioRepository _repository;
    public ServiceUsuario(IUsuarioRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
