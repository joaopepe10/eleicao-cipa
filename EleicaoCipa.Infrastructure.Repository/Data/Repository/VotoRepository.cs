using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Infrastructure.Data;
using EleicaoCipa.Infrastructure.Repository.Data.Repository;

namespace EleicaoCipaVotacao.Data.Repository;

public class VotoRepository : RepositoryBase<Voto>, IRepositoryVoto
{
    private readonly EleicaoContext _context;

    public VotoRepository(EleicaoContext context) : base(context)
    {
        _context = context;
    }
}
