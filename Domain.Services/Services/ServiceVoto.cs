using EleicaoCipa.Domain.Core.Interfaces.Repositories;
using EleicaoCipa.Domain.Core.Interfaces.Services;
using EleicaoCipa.Domain.Model;

namespace EleicaoCipa.Domain.Services.Services;

public class ServiceVoto : ServiceBase<Voto>, IServiceVoto
{
    private readonly IRepositoryVoto _repository;
    public ServiceVoto(IRepositoryVoto repository) : base(repository)
    {
        _repository = repository;
    }
}
