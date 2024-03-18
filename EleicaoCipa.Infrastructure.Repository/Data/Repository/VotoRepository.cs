using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Infraestrutura.Data;

namespace EleicaoCipa.Infraestrutura.Repository.Data.Repository;

public class VotoRepository : RepositoryBase<Voto>, IVotoRepository
{
    private readonly EleicaoContext _context;

    public VotoRepository(EleicaoContext context) : base(context)
    {
        _context = context;
    }
}
