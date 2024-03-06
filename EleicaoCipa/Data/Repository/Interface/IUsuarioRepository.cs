using EleicaoCipa.Model;

namespace EleicaoCipa.Data.Repository.Interface;

public interface IUsuarioRepository
{
    Usuario Post(Usuario usuario);
    Usuario? GetById(int id);
    IEnumerable<Usuario> GetAll();
    Usuario Update(Usuario candidato);
}
