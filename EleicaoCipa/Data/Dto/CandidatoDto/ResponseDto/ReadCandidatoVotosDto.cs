using EleicaoCipaVotacao.Data.Dto;

namespace EleicaoCipaVotacao.Data.Dto.CandidatoDto.ResponseDto;

public class ReadCandidatoVotosDto : BaseDto
{
    public string Nome { get; set; }
    public int QuantidadeDeVotos { get; set; }
}
