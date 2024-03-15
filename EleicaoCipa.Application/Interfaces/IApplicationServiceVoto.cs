using EleicaoCipa.Aplicacao.DTO.Dto.VotoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.VotoDto.ResponseDto;

namespace EleicaoCipa.Aplicacao.Interfaces;

public interface IApplicationServiceVoto
{
    public ReadVotoDto Post(CreateVotoDto dto);

    public ReadVotoDto GetById(int id);
}
