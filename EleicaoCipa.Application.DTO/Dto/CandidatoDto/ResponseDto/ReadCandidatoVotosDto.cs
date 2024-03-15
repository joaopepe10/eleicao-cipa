using EleicaoCipa.Aplicacao.DTO.Dto;

namespace EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.ResponseDto;

public class ReadCandidatoVotosDto : BaseDto
{
    public string Nome { get; set; }
    public int QuantidadeDeVotos { get; set; }
}
