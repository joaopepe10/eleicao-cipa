using EleicaoCipa.Domain.Enums;

namespace EleicaoCipaVotacao.Data.Dto.EleicaoDto.RequestDto;

public class UpdateStatusEleicaoDto : BaseDto
{
    public StatusEnum Status { get; set; }
}
