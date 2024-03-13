using EleicaoCipaVotacao.Data.Dto;
using EleicaoCipaVotacao.Data.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipaVotacao.Data.Dto.UsuarioDto.ResponseDto;




public class ReadAllCandidatosDto : BaseDto
{
    public string Nome { get; set; }
    public ICollection<ReadCandidatoDto>? CandidaturasDoUsuario { get; set; }
}
