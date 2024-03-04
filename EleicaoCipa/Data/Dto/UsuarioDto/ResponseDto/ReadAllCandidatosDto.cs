using EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Data.Dto.UsuarioDto.ResponseDto;

public class ReadAllCandidatosDto
{
    public int Id { get; set; }
    public ICollection<ReadCandidatoDto> Candidatos { get; set; }
}
