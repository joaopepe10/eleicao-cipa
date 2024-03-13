using EleicaoCipa.Application.DTO.Dto.VotoDto.RequestDto;
using EleicaoCipa.Application.DTO.Dto.VotoDto.ResponseDto;

namespace EleicaoCipa.Application.Interfaces;

public interface IApplicationServiceVoto
{
    public ReadVotoDto Post(CreateVotoDto dto);

    public ReadVotoDto GetById(int id);
}
