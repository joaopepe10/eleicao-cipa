using AutoMapper;
using EleicaoCipa.Data.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Data.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Data.Repository;
using EleicaoCipa.Model;

namespace EleicaoCipa.ApplicationService;

public class ApplicationServiceEleicao
{
    private IMapper _mapper;
    private EleicaoRepository _repository;
    private ApplicationServiceCandidato _serviceCandidato;
    public ApplicationServiceEleicao(IMapper mapper, EleicaoRepository repository, ApplicationServiceCandidato serviceCandidato)
    {
        _mapper = mapper;
        _repository = repository;
        _serviceCandidato = serviceCandidato;
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
        if (eleicao == null) throw new ArgumentException($"Eleição com ID {id} inválido!");
        var dto = _mapper.Map<ReadEleicaoDto>(eleicao);
        return dto;
    }

    public IEnumerable<ReadEleicaoDto> GetAll()
    {
        return _mapper.Map<List<ReadEleicaoDto>>(_repository.GetAll());
    }

    public ReadCandidatoDto PostCandidato(CreateCandidatoDto dto)
    {
        if (existsCandidatoEmUmaEleicao(dto.EleicaoId, dto.UsuarioId)) throw new Exception($"Candidato com ID {dto.UsuarioId} já existente nesta eleição");
        var respondeCandidatoDto = _serviceCandidato.Post(dto);    
        return respondeCandidatoDto;
    }

    bool existsCandidatoEmUmaEleicao(int eleicaoId,int usuarioId)
    {
        var eleicao = GetById(eleicaoId);
        return eleicao.Candidatos
                            .Any(candidato => candidato.UsuarioId == usuarioId);
    }
}
