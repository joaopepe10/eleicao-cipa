using EleicaoCipa.Application.DTO.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Application.DTO.Dto.EleicaoDto.ResponseDto;

public class ReadResultadoEleicaoDto
{
    public int EleicaoId { get; set; }
    public IEnumerable<ReadCandidatoVotosDto> Candidatos { get; set; }
}
