using AutoMapper;
using EleicaoCipa.Data.Dto.VotoDto;
using EleicaoCipa.Data.Dto.VotoDto.RequestDto;
using EleicaoCipa.Model;

namespace EleicaoCipa.Profiles;

public class VotoProfile : Profile
{
    public VotoProfile()
    {
        CreateMap<CreateVotoDto, Voto>().ReverseMap();
        CreateMap<Voto, ReadVotoDto>().ReverseMap();
    }
}
