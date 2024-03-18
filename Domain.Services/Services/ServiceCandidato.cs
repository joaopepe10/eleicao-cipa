using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Services;

namespace EleicaoCipa.Dominio.Servicos.Services;

public class ServiceCandidato : ServiceBase<Candidato>, IServiceCandidato
{
    private readonly ICandidatoRepository _repository;
    public ServiceCandidato(ICandidatoRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
