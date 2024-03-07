using EleicaoCipa.Data.Repository.Interface;
using EleicaoCipa.Model;

namespace EleicaoCipa.Data.Repository;

public class VotoRepository : IRepositoryBase<Voto>
{
    private readonly EleicaoContext _context;

    public VotoRepository(EleicaoContext context)
    {
        _context = context;
    }

    public IEnumerable<Voto> GetAll()
    {
        return _context.Votos.ToList();
    }

    public Voto? GetById(int id) => _context.Votos.FirstOrDefault(voto => voto.Id == id);

    public Voto Post(Voto entity)
    {
        _context.Votos.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public Voto Update(Voto entity)
    {
        _context.Votos.Update(entity);
        _context.SaveChanges();
        return entity;
    }
}
