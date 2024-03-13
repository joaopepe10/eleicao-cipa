using EleicaoCipa.Domain.Enums;

namespace EleicaoCipa.Application.DTO.Dto.EleicaoDto.RequestDto;

public class UpdateStatusEleicaoDto : BaseDto
{
    public StatusEnum Status { get; set; }
}
