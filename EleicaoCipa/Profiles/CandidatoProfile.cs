using AutoMapper;
using EleicaoCipa.Data.Dto.CandidatoDto;
using EleicaoCipa.Model;

namespace EleicaoCipa.Profiles;

public class CandidatoProfile : Profile
{
    public CandidatoProfile()
    {
        CreateMap<CreateCandidatoDto, Candidato>();
        CreateMap<Candidato, ReadCandidatoDto>();
    }
}
