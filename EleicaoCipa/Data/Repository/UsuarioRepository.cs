using EleicaoCipa.Data.Repository.Interface;
using EleicaoCipa.Model;

namespace EleicaoCipa.Data.Repository;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly EleicaoContext _context;

    public UsuarioRepository(EleicaoContext context)
    {
        _context = context;
    }

    public Usuario Post(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return usuario;
    }

    public IEnumerable<Usuario> GetAll()
    {
        return _context.Usuarios.ToList();
    }

    public Usuario? GetById(int id)
    {
        return _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
    }

    public Usuario Update(Usuario usuario)
    {
        _context.Usuarios.Update(usuario);
        _context.SaveChanges();
        return usuario;
    }
}
