using EleicaoCipaVotacao.Data.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipaVotacao.Data.Dto.EleicaoDto.ResponseDto;

public class ReadEleicaoDto : BaseDto
{
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string Status { get; set; }
    public ICollection<ReadCandidatoDto> Candidatos { get; set; }
}
