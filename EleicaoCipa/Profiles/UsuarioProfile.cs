using AutoMapper;
using EleicaoCipa.Data.Dto.UsuarioDto;
using EleicaoCipa.Model;

namespace EleicaoCipa.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>();
        CreateMap<Usuario, ReadUsuarioDto>();
        CreateMap<UpdateUsuarioDto, Usuario>();
    }
}
