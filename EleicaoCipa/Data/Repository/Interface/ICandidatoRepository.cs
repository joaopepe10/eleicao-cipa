using EleicaoCipa.Model;

namespace EleicaoCipa.Data.Repository.Interface;

public interface ICandidatoRepository
{
    Candidato Post(Candidato candidato);
    Candidato? GetById(int id);
    IEnumerable<Candidato> GetAll();
    Candidato Update(Candidato candidato);
}
