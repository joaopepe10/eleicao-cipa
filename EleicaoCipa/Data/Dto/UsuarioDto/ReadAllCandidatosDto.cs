using EleicaoCipa.Data.Dto.CandidatoDto;

namespace EleicaoCipa.Data.Dto.UsuarioDto;

public class ReadAllCandidatosDto
{
    public int Id { get; set; }
    public ICollection<ReadCandidatoDto> Candidatos { get; set;}
}
