using EleicaoCipa.Infraestrutura.CrossCutting.Enum.Enums;

namespace EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.RequestDto;

public class UpdateStatusEleicaoDto : BaseDto
{
    public StatusEnum Status { get; set; }
}
