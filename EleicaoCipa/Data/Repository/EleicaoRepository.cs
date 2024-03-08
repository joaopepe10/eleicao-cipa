using EleicaoCipa.Model;
using Microsoft.EntityFrameworkCore;

namespace EleicaoCipa.Data.Repository;

public class EleicaoRepository
{
    private EleicaoContext _context;
    public EleicaoRepository(EleicaoContext context)
    {

        _context = context;
    }

    public Eleicao Post(Eleicao eleicao)
    {
        _context.Eleicoes.Add(eleicao);
        _context.SaveChanges();
        return eleicao;
    }
    public void Update(Eleicao entity)
    {        
        _context.Update(entity);
        _context.SaveChanges();
    }    

    public Eleicao? GetById(int id) => _context.Eleicoes.FirstOrDefault(eleicao => eleicao.Id == id);

    public IEnumerable<Eleicao> GetAll()
    {
        var eleicoes = _context.Eleicoes
            .Include(eleicao => eleicao.Candidatos)
            .ThenInclude(candidato => candidato.Usuario)
            .ToList();
        return eleicoes;
    }
}
