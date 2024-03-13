using EleicaoCipa.Application.DTO.Dto.UsuarioDto.RequestDto;
using EleicaoCipa.Application.DTO.Dto.UsuarioDto.ResponseDto;

namespace EleicaoCipa.Application.Interfaces;

public interface IApplicationServiceUsuario
{
    public ReadUsuarioDto Post(CreateUsuarioDto dto);

    public ReadUsuarioDto GetById(int id);

    public IEnumerable<ReadUsuarioDto> GetAll();

    public IEnumerable<ReadAllCandidatosDto> GetAllCandidato();
}
