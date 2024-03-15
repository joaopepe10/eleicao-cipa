using AutoMapper;
using Castle.Core.Internal;
using EleicaoCipa.Aplicacao.DTO.Dto.VotoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.VotoDto.ResponseDto;
using EleicaoCipa.Aplicacao.Interfaces;
using EleicaoCipa.Dominio.Model;
using EleicaoCipaVotacao.Data.Repository;

namespace EleicaoCipa.Aplicacao.Service;

public class ApplicationServiceVoto : IApplicationServiceVoto
{
    private readonly VotoRepository _repository;
    private readonly IMapper _mapper;
    private readonly ApplicationServiceEleicao _serviceEleicao;

    public ApplicationServiceVoto(VotoRepository repository, IMapper mapper, ApplicationServiceEleicao serviceEleicao)
    {
        _repository = repository;
        _mapper = mapper;
        _serviceEleicao = serviceEleicao;
    }

    public ReadVotoDto Post(CreateVotoDto dto)
    {
        ValidaVoto(dto);
        var entity = _mapper.Map<Voto>(dto);
        _repository.Post(entity);
        return _mapper.Map<ReadVotoDto>(entity);
    }

    public ReadVotoDto GetById(int id)
    {
        var entity = _repository.GetById(id);
        if (entity == null) throw new Exception($"Usuário com ID {id} inválido.");
        var responseDto = _mapper.Map<ReadVotoDto>(entity);
        return responseDto;
    }

    private bool ExistsVotoDuplicado(int usuarioId, int eleicaoId)
    {
        var votos = _repository.GetAll();
        return votos
            .Any(voto => voto.EleicaoId == eleicaoId && voto.UsuarioId == usuarioId);
    }

    private void ValidaVoto(CreateVotoDto dto)
    {
        var eleicao = _serviceEleicao.GetEleicaoById(dto.EleicaoId);
        if (eleicao.Candidatos.IsNullOrEmpty())
            throw new Exception($"Eleição com ID {dto.EleicaoId} está vazia, não é possível votar.");
        if (ExistsVotoDuplicado(dto.UsuarioId, dto.EleicaoId))
            throw new Exception("Não foi possível registrar este voto pois está duplicado.");
    }
}
