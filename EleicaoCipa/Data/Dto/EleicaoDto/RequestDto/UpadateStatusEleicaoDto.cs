using EleicaoCipa.Enums;

namespace EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;

public class UpadateStatusEleicaoDto : BaseDto
{
    public StatusEnum Status { get; set; }
}
