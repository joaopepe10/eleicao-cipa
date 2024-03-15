using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Domain.Nucleo.Interfaces.Services;
using EleicaoCipa.Dominio.Model;

namespace EleicaoCipa.Domain.Servicos.Services;

public class ServiceVoto : ServiceBase<Voto>, IServiceVoto
{
    private readonly IVotoRepository _repository;
    public ServiceVoto(IVotoRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
