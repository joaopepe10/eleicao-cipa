using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Infraestrutura.Data;

namespace EleicaoCipa.Infraestrutura.Repository.Data.Repository;

public class CandidatoRepository : RepositoryBase<Candidato>, ICandidatoRepository
{
    private readonly EleicaoContext _context;
    public CandidatoRepository(EleicaoContext context) : base(context)
    {
        _context = context;
    }
}
