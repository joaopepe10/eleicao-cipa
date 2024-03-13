using EleicaoCipa.Application.DTO.Dto;

namespace EleicaoCipa.Application.DTO.Dto.CandidatoDto.ResponseDto;

public class ReadCandidatoVotosDto : BaseDto
{
    public string Nome { get; set; }
    public int QuantidadeDeVotos { get; set; }
}
