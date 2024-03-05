using EleicaoCipa.Enums;

namespace EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;

public class UpdateEleicaoDto : BaseDto
{    
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public StatusEnum Status { get; set; }
}
