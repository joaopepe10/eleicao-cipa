using AutoMapper;
using EleicaoCipa.Domain.Model;
using EleicaoCipaVotacao.Data.Dto.VotoDto.RequestDto;
using EleicaoCipaVotacao.Data.Dto.VotoDto.ResponseDto;

namespace EleicaoCipaVotacao.Profiles;

public class VotoProfile : Profile
{
    public VotoProfile()
    {
        CreateMap<CreateVotoDto, Voto>().ReverseMap();
        CreateMap<Voto, ReadVotoDto>().ReverseMap();
    }
}
