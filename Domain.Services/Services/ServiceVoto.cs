using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Services;

namespace EleicaoCipa.Dominio.Servicos.Services;

public class ServiceVoto : ServiceBase<Voto>, IServiceVoto
{
    private readonly IVotoRepository _repository;
    public ServiceVoto(IVotoRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
