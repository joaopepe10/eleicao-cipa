using AutoMapper;
using EleicaoCipa.Domain.Model;
using EleicaoCipaVotacao.Data.Dto.CandidatoDto.RequestDto;
using EleicaoCipaVotacao.Data.Dto.CandidatoDto.ResponseDto;
using EleicaoCipaVotacao.Data.Repository;

namespace EleicaoCipaVotacao.ApplicationService;

public class ApplicationServiceCandidato
{
    private readonly IMapper _mapper;
    private readonly CandidatoRepository _repository;
    public ApplicationServiceCandidato(IMapper mapper, CandidatoRepository repository)
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
