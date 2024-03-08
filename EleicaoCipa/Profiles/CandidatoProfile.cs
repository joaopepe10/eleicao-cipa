﻿using AutoMapper;
using EleicaoCipa.Data.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Model;

namespace EleicaoCipa.Profiles;

public class CandidatoProfile : Profile
{
    public CandidatoProfile()
    {
        CreateMap<CreateCandidatoDto, Candidato>().ReverseMap();
        CreateMap<Candidato, ReadCandidatoDto>()
            .ForMember(dto => dto.QuantidadeDeVotos, opts => opts.MapFrom(entidade => entidade.Votos.Count()))
            .ForMember(dto => dto.NomeCandidato, opts => opts.MapFrom(entidade => entidade.Usuario.Nome))
            .ReverseMap();            
        CreateMap<UpdateDiscursoDto, Candidato>().ReverseMap();
    }
}
