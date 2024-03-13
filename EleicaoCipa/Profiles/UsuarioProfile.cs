using AutoMapper;
using EleicaoCipa.Domain.Model;
using EleicaoCipaVotacao.Data.Dto.UsuarioDto.RequestDto;
using EleicaoCipaVotacao.Data.Dto.UsuarioDto.ResponseDto;

namespace EleicaoCipaVotacao.Profiles;

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
