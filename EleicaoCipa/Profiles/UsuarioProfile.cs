using AutoMapper;
using EleicaoCipa.Data.Dto.UsuarioDto.RequestDto;
using EleicaoCipa.Data.Dto.UsuarioDto.ResponseDto;
using EleicaoCipa.Model;

namespace EleicaoCipa.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>();
        CreateMap<Usuario, ReadUsuarioDto>();
        CreateMap<UpdateUsuarioDto, Usuario>();
        CreateMap<Usuario, ReadAllCandidatosDto>();
    }
}
