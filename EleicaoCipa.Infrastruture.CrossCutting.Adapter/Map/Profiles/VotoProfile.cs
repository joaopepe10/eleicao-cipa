using AutoMapper;
using EleicaoCipa.Aplicacao.DTO.Dto.VotoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.VotoDto.ResponseDto;
using EleicaoCipa.Dominio.Model;

namespace EleicaoCipa.Infraestrutura.CrossCutting.Adapter.Map.Profiles;

public class VotoProfile : Profile
{
    public VotoProfile()
    {
        CreateMap<CreateVotoDto, Voto>().ReverseMap();
        CreateMap<Voto, ReadVotoDto>().ReverseMap();
    }
}
