using AutoMapper;
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
