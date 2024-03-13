using EleicaoCipa.Application.DTO.Dto;
using EleicaoCipa.Domain.Enums;

namespace EleicaoCipa.Application.DTO.Dto.EleicaoDto.RequestDto;

public class UpdateEleicaoDto : BaseDto
{
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public StatusEnum Status { get; set; }
}
