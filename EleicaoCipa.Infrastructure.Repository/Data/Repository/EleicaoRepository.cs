using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Infraestrutura.Data;
using EleicaoCipa.Infrastructure.Repository.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace EleicaoCipaVotacao.Data.Repository;

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
