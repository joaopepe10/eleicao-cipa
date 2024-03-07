using EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Data.Dto.UsuarioDto.ResponseDto;

    
    
    
public class ReadAllCandidatosDto : BaseDto
{
    public ICollection<ReadCandidatoDto>? Candidatos { get; set; }
}
