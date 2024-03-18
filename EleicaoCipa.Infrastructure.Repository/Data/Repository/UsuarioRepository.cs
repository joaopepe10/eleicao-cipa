using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Infraestrutura.Data;

namespace EleicaoCipa.Infraestrutura.Repository.Data.Repository;

public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
{
    private readonly EleicaoContext _context;

    public UsuarioRepository(EleicaoContext context) : base(context)
    {
        _context = context;
    }
}
