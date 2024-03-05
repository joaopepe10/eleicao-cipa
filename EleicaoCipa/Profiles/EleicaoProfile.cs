using AutoMapper;
using EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Data.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Enums;
using EleicaoCipa.Model;

namespace EleicaoCipa.Profiles;

public class EleicaoProfile : Profile
{
    public EleicaoProfile()
    {
        CreateMap<CreateEleicaoDto, Eleicao>();
        CreateMap<CreateEleicaoDto, ReadEleicaoDto>().ReverseMap();

        CreateMap<Eleicao, ReadEleicaoDto>()
            .ForMember(dto => dto.Status, opts => opts.MapFrom(entidade => Enum.GetName(typeof(StatusEnum), entidade.Status)));
        CreateMap<UpadateStatusEleicaoDto, Eleicao>();
        CreateMap<UpdateEleicaoDataInicioDto, Eleicao>();
        CreateMap<UpdateEleicaoDataFimDto, Eleicao>();
        CreateMap<UpdateEleicaoDto, Eleicao>();
        CreateMap<Eleicao, UpdateEleicaoDto>();
    }
}
