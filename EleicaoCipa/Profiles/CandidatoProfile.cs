using AutoMapper;
using EleicaoCipa.Domain.Model;
using EleicaoCipaVotacao.Data.Dto.CandidatoDto.RequestDto;
using EleicaoCipaVotacao.Data.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipaVotacao.Profiles;

public class CandidatoProfile : Profile
{
    public CandidatoProfile()
    {
        CreateMap<CreateCandidatoDto, Candidato>().ReverseMap();
        CreateMap<Candidato, ReadCandidatoVotosDto>()
            .ForMember(dto => dto.Nome, opts => opts.MapFrom(entidade => entidade.Usuario.Nome))
            .ForMember(dto => dto.QuantidadeDeVotos, opts => opts.MapFrom(entidade => entidade.Votos.Count()))
            .ReverseMap();
        CreateMap<Candidato, ReadCandidatoDto>()
            .ForMember(dto => dto.QuantidadeDeVotos, opts => opts.MapFrom(entidade => entidade.Votos.Count()))
            .ForMember(dto => dto.NomeCandidato, opts => opts.MapFrom(entidade => entidade.Usuario.Nome))
            .ReverseMap();
        CreateMap<UpdateDiscursoDto, Candidato>().ReverseMap();
    }
}
