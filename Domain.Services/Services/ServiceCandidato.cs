using EleicaoCipa.Domain.Core.Interfaces.Repositories;
using EleicaoCipa.Domain.Core.Interfaces.Services;
using EleicaoCipa.Domain.Model;

namespace EleicaoCipa.Domain.Services.Services;

public class ServiceCandidato : ServiceBase<Candidato>, IServiceCandidato
{
    private readonly ICandidatoRepository _repository;
    public ServiceCandidato(ICandidatoRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
