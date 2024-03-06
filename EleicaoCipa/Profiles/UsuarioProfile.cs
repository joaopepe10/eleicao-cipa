using AutoMapper;
using EleicaoCipa.Data.Dto.UsuarioDto.RequestDto;
using EleicaoCipa.Data.Dto.UsuarioDto.ResponseDto;
using EleicaoCipa.Model;

namespace EleicaoCipa.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>().ReverseMap();
        CreateMap<Usuario, ReadUsuarioDto>().ReverseMap();
        CreateMap<UpdateUsuarioDto, Usuario>().ReverseMap();
        CreateMap<Usuario, ReadAllCandidatosDto>().ReverseMap();
    }
}
