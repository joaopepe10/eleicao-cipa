using EleicaoCipa.Data.Dto;
using EleicaoCipa.Model;

namespace EleicaoCipa.Data.Repository;

public class EleicaoRepository
{
    private EleicaoContext _context;
    public EleicaoRepository(EleicaoContext context)
    {

        _context = context;
    }

    public void Update<T>(T dto, int id)
    {
        var entity = _context.Find(id);

        _context.Update(dto);
        _context.SaveChanges();
    }
}
