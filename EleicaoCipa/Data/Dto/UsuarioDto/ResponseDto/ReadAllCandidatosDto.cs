using EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Data.Dto.UsuarioDto.ResponseDto;

    
    
    
public class ReadAllCandidatosDto : BaseDto
{
    public string Nome { get; set; }
    public ICollection<ReadCandidatoDto>? CandidaturasDoUsuario { get; set; }
}
