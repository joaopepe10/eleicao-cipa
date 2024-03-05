using AutoMapper;
using EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Data.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Data.Repository;
using EleicaoCipa.Enums;
using EleicaoCipa.Model;

namespace EleicaoCipa.ApplicationService;

public class ApplicationServiceEleicao
{
    private IMapper _mapper;
    private EleicaoRepository _repository;
    public ApplicationServiceEleicao(IMapper mapper, EleicaoRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public ReadEleicaoDto Update<TDTO>(TDTO dto, int id)
    {
        var entity = _repository.GetById(id);
        if (entity == null) throw new Exception("Id de eleição inválido!");        
        _mapper.Map(dto, entity);
        _repository.Update(entity);
        return _mapper.Map<ReadEleicaoDto>(entity);
    }
    
    public ReadEleicaoDto Post(CreateEleicaoDto dto)
    {
        if (dto == null) throw new Exception("Dados para criação de eleição inválidos!");
        var entity = _mapper.Map<Eleicao>(dto);
        _repository.Post(entity);
        var response = _mapper.Map<ReadEleicaoDto>(entity);
        return response;
    }

    public ReadEleicaoDto? GetById(int id)
    {
        var eleicao = _repository.GetById(id);
        if (eleicao == null) return null;
        var dto = _mapper.Map<ReadEleicaoDto>(eleicao);
        return dto;
    }

    public IEnumerable<ReadEleicaoDto> GetAll()
    {
        return _mapper.Map<List<ReadEleicaoDto>>(_repository.GetAll());
    }

    public ReadEleicaoDto AbrirVotacao(int id)
    {
        var entity = BuscarEleicaoCadastradaPeloId(id);

        entity.Status = StatusEnum.EmVotacao;

        _repository.Update(entity);

        return _mapper.Map<ReadEleicaoDto>(entity);
    }

    public ReadEleicaoDto AbrirVotacao(CreateEleicaoDto dto)
    {
        var entity = BuscarEleicaoCadastradaPeloId(dto.Id);

        _mapper.Map(dto, entity);
        _repository.Update(entity);
        
        return _mapper.Map<ReadEleicaoDto>(entity);
    }

    Eleicao BuscarEleicaoCadastradaPeloId(int id)
    {
        var entity = _repository.GetCadastradaById(id);

        if (entity is null)
            throw new Exception($"Eleição com ID {id} não encontrada.");

        return entity;
    }
}
