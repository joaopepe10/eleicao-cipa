using AutoMapper;
using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Aplicacao.Interfaces;
using EleicaoCipa.Dominio.Model;
using EleicaoCipa.Dominio.Nucleo.Interfaces.Repositories;
using EleicaoCipa.Infraestrutura.CrossCutting.Enums.Enums;

namespace EleicaoCipa.Aplicacao.Service;

public class ApplicationServiceEleicao : IApplicationServiceEleicao
{
    private readonly IMapper _mapper;
    private readonly IEleicaoRepository _repository;
    private readonly IApplicationServiceCandidato _serviceCandidato;
    public ApplicationServiceEleicao(IMapper mapper, IEleicaoRepository repository, IApplicationServiceCandidato serviceCandidato)
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
        ValidaCriacaoDeEleicao(dto);
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
        if (VerificaEEncerraEleicaoSeAtingiuDataFim(eleicaoId) || ExistsCandidatoEmUmaEleicao(eleicaoId, dto.UsuarioId))
            throw new Exception($"Candidato com ID {dto.UsuarioId} já existente nesta eleição");

        var respondeCandidatoDto = _serviceCandidato.Post(dto, eleicaoId);
        return respondeCandidatoDto;
    }

    bool ExistsCandidatoEmUmaEleicao(int eleicaoId, int usuarioId)
    {
        var eleicao = GetEleicaoById(eleicaoId);
        return eleicao.Candidatos
                            .Any(candidato => candidato.UsuarioId == usuarioId);
    }

    public Eleicao GetEleicaoById(int id)
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

    public ReadResultadoEleicaoDto? GetEleicaoResultadoById(int id)
    {
        var eleicao = GetEleicaoById(id);
        return _mapper.Map<ReadResultadoEleicaoDto>(eleicao);
    }

    public void ValidaCriacaoDeEleicao(CreateEleicaoDto dto)
    {
        if (dto.DataFim <= dto.DataInicio)
            throw new Exception($"Não é possível criar uma eleição com a data fim {dto.DataFim} sendo maior que a data de início {dto.DataInicio}");
        if (dto.DataInicio < DateTime.Now)
            throw new Exception($"Data de início {dto.DataInicio} da eleição deve ser maior que a data atual {DateTime.Now}");
    }
}
