using AutoMapper;
using EleicaoCipa.Aplicacao.DTO.Dto.UsuarioDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.UsuarioDto.ResponseDto;
using EleicaoCipa.Dominio.Model;

namespace EleicaoCipa.Infrastruture.CrossCutting.Adapter.Map.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>().ReverseMap();
        CreateMap<Usuario, ReadUsuarioDto>().ReverseMap();
        CreateMap<UpdateUsuarioDto, Usuario>().ReverseMap();
        CreateMap<Usuario, ReadAllCandidatosDto>()
            .ForMember(dto => dto.CandidaturasDoUsuario, opts => opts.MapFrom(entidade => entidade.Candidatos))
            .ForMember(dto => dto.Nome, opts => opts.MapFrom(entidade => entidade.Nome))
            .ReverseMap();
    }
}
