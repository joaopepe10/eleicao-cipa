using AutoMapper;
using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Aplicacao.Interfaces;
using EleicaoCipa.Domain.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Dominio.Model;

namespace EleicaoCipa.Aplicacao.Service;

public class ApplicationServiceCandidato : IApplicationServiceCandidato
{
    private readonly IMapper _mapper;
    private readonly ICandidatoRepository _repository;
    public ApplicationServiceCandidato(IMapper mapper, ICandidatoRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public ReadCandidatoDto Post(CreateCandidatoDto dto, int eleicaoId)
    {
        var entity = _mapper.Map<Candidato>(dto);
        entity.EleicaoId = eleicaoId;
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

    public ReadCandidatoDto PutDiscurso(int id, UpdateDiscursoDto dto)
    {
        var entity = _repository.GetById(id);
        _mapper.Map(dto, entity);
        Candidato entityAlterada = _repository.Update(entity);
        var responseCandidato = _mapper.Map<ReadCandidatoDto>(entityAlterada);
        return responseCandidato;
    }
}
