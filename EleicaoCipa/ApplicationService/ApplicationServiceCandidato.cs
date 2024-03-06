﻿using AutoMapper;
using EleicaoCipa.Data.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Data.Repository;
using EleicaoCipa.Model;

namespace EleicaoCipa.ApplicationService;

public class ApplicationServiceCandidato
{
    private readonly IMapper _mapper;
    private readonly CandidatoRepository _repository;
    public ApplicationServiceCandidato(IMapper mapper, CandidatoRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public ReadCandidatoDto Post(CreateCandidatoDto dto)
    {
        var entity = _mapper.Map<Candidato>(dto);
        _repository.Post(entity);
        return _mapper.Map<ReadCandidatoDto>(entity);
    }

    public ReadCandidatoDto GetById(int id)
    {
        var dto = _mapper.Map<ReadCandidatoDto>(_repository.GetById(id));
        if (dto is null) throw new ArgumentException($"Usuario com ID {id} não encontrado.");
        return dto;
    }

    public IEnumerable<ReadCandidatoDto> GetAll()
    {
        return _mapper.Map<List<ReadCandidatoDto>>(_repository.GetAll());
    }
}