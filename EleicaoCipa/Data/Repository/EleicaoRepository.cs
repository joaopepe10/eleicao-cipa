using EleicaoCipa.Data.Dto;
using EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Model;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.OData;

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
        _context.Add(eleicao);
        _context.SaveChanges();
        return eleicao;
    }
    public void Update<T>(T dto)
    {        
        _context.Update(dto);
        _context.SaveChanges();
    }

    public Eleicao UpdatePatch(Eleicao eleicao)
    {
        _context.Update(eleicao);
        _context.SaveChanges();
        return GetById(eleicao.Id);
    }

    public Eleicao GetById(int id) => _context.Eleicoes.FirstOrDefault(eleicao => eleicao.Id == id);
    // PERGUNTAR PQ DEU ERRO DE RETORNO QUANDO RETORNAVA SEM ATRIBUIR A VARIAVEL 
    public IEnumerable<Eleicao> GetAll()
    {
        var eleicoes = _context.Eleicoes
            .Include(eleicao => eleicao.Candidatos)
            .ThenInclude(candidato => candidato.Usuario)
            .ToList();
        return eleicoes;
    }
}
