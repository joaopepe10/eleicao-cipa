using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;

namespace EleicaoCipa.Infraestrutura.Repository.Data.Repository;

public class EleicaoRepository : RepositoryBase<Eleicao>, IEleicaoRepository
{
    private EleicaoContext _context;

    public EleicaoRepository(EleicaoContext context) : base(context)
    {
        _context = context;
    }

    public override IEnumerable<Eleicao> GetAll()
    {
        var eleicoes = _context.Eleicoes
            .Include(eleicao => eleicao.Candidatos)
            .ThenInclude(candidato => candidato.Usuario)
            .ToList();
        return eleicoes;
    }
}
