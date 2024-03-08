using EleicaoCipa.Enums;

namespace EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;

public class UpdateStatusEleicaoDto : BaseDto
{
    public StatusEnum Status { get; set; }
}
