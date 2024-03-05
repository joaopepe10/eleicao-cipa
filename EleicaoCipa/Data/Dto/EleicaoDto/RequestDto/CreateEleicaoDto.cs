using EleicaoCipa.Enums;

namespace EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;

public class CreateEleicaoDto : BaseDto
{
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }    
}
