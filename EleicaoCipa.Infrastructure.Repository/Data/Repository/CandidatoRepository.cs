using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Infraestrutura.Data;
using EleicaoCipa.Infrastructure.Repository.Data.Repository;

namespace EleicaoCipaVotacao.Data.Repository;

public class CandidatoRepository : RepositoryBase<Candidato>, ICandidatoRepository
{
    private readonly EleicaoContext _context;
    public CandidatoRepository(EleicaoContext context) : base(context)
    {
        _context = context;
    }
}
