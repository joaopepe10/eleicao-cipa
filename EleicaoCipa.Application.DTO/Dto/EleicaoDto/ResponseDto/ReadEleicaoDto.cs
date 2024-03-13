using EleicaoCipa.Application.DTO.Dto;
using EleicaoCipa.Application.DTO.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Application.DTO.Dto.EleicaoDto.ResponseDto;

public class ReadEleicaoDto : BaseDto
{
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string Status { get; set; }
    public ICollection<ReadCandidatoDto> Candidatos { get; set; }
}
