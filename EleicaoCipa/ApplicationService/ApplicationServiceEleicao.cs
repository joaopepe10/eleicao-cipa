using AutoMapper;
using EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Data.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Data.Repository;
using EleicaoCipa.Model;
using System.Web.Http.OData;

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
        var entity = GetById(id);
        if (entity == null) throw new Exception("Id de eleição inválido!");        
        _mapper.Map(dto, entity);
        _repository.Update(entity);
        return _mapper.Map<ReadEleicaoDto>(entity);
    }

    public ReadEleicaoDto? UpdatePatch(Delta<UpdateEleicaoDto> alteracoes, int id)
    {
        var dto = _mapper.Map<UpdateEleicaoDto>(_repository.GetById(id));
        alteracoes.Patch(dto);
        var entity = _mapper.Map<Eleicao>(dto);
        return _mapper.Map<ReadEleicaoDto>(_repository.UpdatePatch(entity));
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
}
