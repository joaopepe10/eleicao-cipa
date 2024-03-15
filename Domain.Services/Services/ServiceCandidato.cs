using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Domain.Nucleo.Interfaces.Services;
using EleicaoCipa.Dominio.Model;

namespace EleicaoCipa.Domain.Servicos.Services;

public class ServiceCandidato : ServiceBase<Candidato>, IServiceCandidato
{
    private readonly ICandidatoRepository _repository;
    public ServiceCandidato(ICandidatoRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
