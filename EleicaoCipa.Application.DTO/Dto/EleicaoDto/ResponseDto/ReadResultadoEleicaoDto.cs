using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.ResponseDto;

public class ReadResultadoEleicaoDto
{
    public int EleicaoId { get; set; }
    public IEnumerable<ReadCandidatoVotosDto> Candidatos { get; set; }
}
