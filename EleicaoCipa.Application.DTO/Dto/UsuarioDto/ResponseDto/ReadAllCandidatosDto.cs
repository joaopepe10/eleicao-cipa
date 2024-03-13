using EleicaoCipa.Application.DTO.Dto;
using EleicaoCipa.Application.DTO.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Application.DTO.Dto.UsuarioDto.ResponseDto;




public class ReadAllCandidatosDto : BaseDto
{
    public string Nome { get; set; }
    public ICollection<ReadCandidatoDto>? CandidaturasDoUsuario { get; set; }
}
