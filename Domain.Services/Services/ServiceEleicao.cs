using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Services;

namespace EleicaoCipa.Dominio.Servicos.Services;

public class ServiceEleicao : ServiceBase<Eleicao>, IServiceEleicao
{
    private readonly IEleicaoRepository _repository;

    public ServiceEleicao(IEleicaoRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
