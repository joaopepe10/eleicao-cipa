using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Domain.Nucleo.Interfaces.Services;
using EleicaoCipa.Dominio.Model;

namespace EleicaoCipa.Domain.Servicos.Services;

public class ServiceEleicao : ServiceBase<Eleicao>, IServiceEleicao
{
    private readonly IEleicaoRepository _repository;

    public ServiceEleicao(IEleicaoRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
