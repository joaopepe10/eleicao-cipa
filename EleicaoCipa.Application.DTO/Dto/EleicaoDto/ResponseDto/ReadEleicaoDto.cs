using EleicaoCipa.Aplicacao.DTO.Dto;
using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.ResponseDto;

public class ReadEleicaoDto : BaseDto
{
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string Status { get; set; }
    public ICollection<ReadCandidatoDto> Candidatos { get; set; }
}
