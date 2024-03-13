using EleicaoCipaVotacao.Data.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipaVotacao.Data.Dto.EleicaoDto.ResponseDto;

public class ReadResultadoEleicaoDto
{
    public int EleicaoId { get; set; }
    public IEnumerable<ReadCandidatoVotosDto> Candidatos { get; set; }
}
