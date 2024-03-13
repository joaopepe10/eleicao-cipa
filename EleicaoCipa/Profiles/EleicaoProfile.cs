using AutoMapper;
using EleicaoCipa.Domain.Enums;
using EleicaoCipa.Domain.Model;
using EleicaoCipaVotacao.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipaVotacao.Data.Dto.EleicaoDto.ResponseDto;

namespace EleicaoCipaVotacao.Profiles;

public class EleicaoProfile : Profile
{
    public EleicaoProfile()
    {
        CreateMap<CreateEleicaoDto, Eleicao>();
        CreateMap<CreateEleicaoDto, ReadEleicaoDto>().ReverseMap();
        CreateMap<Eleicao, ReadEleicaoDto>()
            .ForMember(dto => dto.Status, opts => opts.MapFrom(entidade => Enum.GetName(typeof(StatusEnum), entidade.Status)));
        CreateMap<Eleicao, ReadResultadoEleicaoDto>()
            .ForMember(dto => dto.EleicaoId, opts => opts.MapFrom(entidade => entidade.Id))
            .ReverseMap();
        CreateMap<UpdateStatusEleicaoDto, Eleicao>();
        CreateMap<UpdateEleicaoDataInicioDto, Eleicao>();
        CreateMap<UpdateEleicaoDataFimDto, Eleicao>();
        CreateMap<UpdateEleicaoDto, Eleicao>();
        CreateMap<Eleicao, UpdateEleicaoDto>();
    }
}
