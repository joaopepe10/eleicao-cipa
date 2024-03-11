using AutoMapper;
using EleicaoCipa.Data.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Data.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Data.Repository;
using EleicaoCipa.Enums;
using EleicaoCipa.Model;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoCipa.ApplicationService;

public class ApplicationServiceEleicao
{
    private readonly IMapper _mapper;
    private readonly EleicaoRepository _repository;
    private readonly ApplicationServiceCandidato _serviceCandidato;
    public ApplicationServiceEleicao(IMapper mapper, EleicaoRepository repository, ApplicationServiceCandidato serviceCandidato)
    {
        _mapper = mapper;
        _repository = repository;
        _serviceCandidato = serviceCandidato;
    }

    public ReadEleicaoDto Update(UpdateStatusEleicaoDto dto, int eleicaoId)
    {
        VerificaEEncerraEleicaoSeAtingiuDataFim(eleicaoId);
        var entity = GetEleicaoById(eleicaoId);
        entity.Status = dto.Status;
        _repository.Update(entity);
        return _mapper.Map<ReadEleicaoDto>(entity);
    }
   
    public ReadEleicaoDto Post(CreateEleicaoDto dto)
    {
        var entity = _mapper.Map<Eleicao>(dto);
        _repository.Post(entity);
        var response = _mapper.Map<ReadEleicaoDto>(entity);
        return response;
    }

    public ReadEleicaoDto GetById(int id)
    {
        var eleicao = GetEleicaoById(id);
        var dto = _mapper.Map<ReadEleicaoDto>(eleicao);
        return dto;
    }

    public IEnumerable<ReadEleicaoDto> GetAll()
    {
        return _mapper.Map<List<ReadEleicaoDto>>(_repository.GetAll());
    }

    public ReadCandidatoDto PostCandidato(int eleicaoId, CreateCandidatoDto dto)
    {
        if(VerificaEEncerraEleicaoSeAtingiuDataFim(eleicaoId) || ExistsCandidatoEmUmaEleicao(eleicaoId, dto.UsuarioId))
            throw new Exception($"Candidato com ID {dto.UsuarioId} já existente nesta eleição");

        var respondeCandidatoDto = _serviceCandidato.Post(dto, eleicaoId);    
        return respondeCandidatoDto;
    }

    private bool IsEleicaoEncerrada(int eleicaoId)
    {
        var eleicao = _repository.GetById(eleicaoId);
        if (eleicao == null)
            throw new Exception($"Eleição com ID {eleicaoId} inválido.");
        if (eleicao.Status == StatusEnum.Encerrada)
            throw new Exception("Eleição com status encerrada, não é possível inserir candidato");
        return false;
    }

    bool ExistsCandidatoEmUmaEleicao(int eleicaoId, int usuarioId)
    {
        var eleicao = GetEleicaoById(eleicaoId);
        return eleicao.Candidatos
                            .Any(candidato => candidato.UsuarioId == usuarioId);
    }

    private Eleicao GetEleicaoById(int id)
    {
        var eleicao = _repository.GetById(id);
        return eleicao is null 
            ? throw new Exception($"Eleição com ID {id} inválido.") 
            : eleicao;
    }

    public IEnumerable<ReadResultadoEleicaoDto> GetResultado()
    {
        var resultados = _mapper.Map<List<ReadResultadoEleicaoDto>>(_repository.GetAll());
        return resultados;
    }

    private bool VerificaEEncerraEleicaoSeAtingiuDataFim(int idEleicao)
    {
        var eleicao = GetEleicaoById(idEleicao);
        var dataFim = eleicao.DataFim;
        if (DateTime.Now >= dataFim)
        {
            eleicao.Status = StatusEnum.Encerrada;
            _repository.Update(eleicao);
            throw new Exception($"Data fim {dataFim} da eleição superior a data atual {DateTime.Now}, portanto eleição encerrada.");
        }
        return false;
    }
}
