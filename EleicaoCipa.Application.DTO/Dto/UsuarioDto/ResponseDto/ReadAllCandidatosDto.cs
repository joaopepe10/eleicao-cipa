using EleicaoCipa.Aplicacao.DTO.Dto;
using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Aplicacao.DTO.Dto.UsuarioDto.ResponseDto;




public class ReadAllCandidatosDto : BaseDto
{
    public string Nome { get; set; }
    public ICollection<ReadCandidatoDto>? CandidaturasDoUsuario { get; set; }
}
