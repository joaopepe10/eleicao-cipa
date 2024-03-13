using EleicaoCipa.Domain.Core.Interfaces.Repositories;
using EleicaoCipa.Domain.Core.Interfaces.Services;
using EleicaoCipa.Domain.Model;

namespace EleicaoCipa.Domain.Services.Services;

public class ServiceEleicao : ServiceBase<Eleicao>, IServiceEleicao
{
    private readonly IEleicaoRepository _repository;

    public ServiceEleicao(IEleicaoRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
