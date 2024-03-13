using EleicaoCipa.Application.DTO.Dto;

namespace EleicaoCipa.Application.DTO.Dto.EleicaoDto.RequestDto;

public class CreateEleicaoDto : BaseDto
{
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
}
