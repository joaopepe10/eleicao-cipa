using EleicaoCipa.Aplicacao.DTO.Dto.UsuarioDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.UsuarioDto.ResponseDto;

namespace EleicaoCipa.Aplicacao.Interfaces;

public interface IApplicationServiceUsuario
{
    public ReadUsuarioDto Post(CreateUsuarioDto dto);

    public ReadUsuarioDto GetById(int id);

    public IEnumerable<ReadUsuarioDto> GetAll();

    public IEnumerable<ReadAllCandidatosDto> GetAllCandidato();
}
