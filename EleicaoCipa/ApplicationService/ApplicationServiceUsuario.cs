using AutoMapper;
using EleicaoCipa.Domain.Model;
using EleicaoCipaVotacao.Data.Dto.UsuarioDto.RequestDto;
using EleicaoCipaVotacao.Data.Dto.UsuarioDto.ResponseDto;
using EleicaoCipaVotacao.Data.Repository;

namespace EleicaoCipaVotacao.ApplicationService;

public class ApplicationServiceUsuario
{
    private readonly IMapper _mapper;
    private readonly UsuarioRepository _repository;

    public ApplicationServiceUsuario(IMapper mapper, UsuarioRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public ReadUsuarioDto Post(CreateUsuarioDto dto)
    {
        var entity = _mapper.Map<Usuario>(dto);
        _repository.Post(entity);
        var responseDto = _mapper.Map<ReadUsuarioDto>(entity);
        return responseDto;
    }

    public ReadUsuarioDto GetById(int id)
    {
        var entity = _repository.GetById(id);
        if (entity is null) throw new Exception($"Usuário com ID {id} inválido.");
        var responseDto = _mapper.Map<ReadUsuarioDto>(entity);
        return responseDto;
    }

    public IEnumerable<ReadUsuarioDto> GetAll()
    {
        return _mapper.Map<List<ReadUsuarioDto>>(_repository.GetAll());
    }

    public IEnumerable<ReadAllCandidatosDto> GetAllCandidato()
    {
        var candidatos = _mapper.Map<List<ReadAllCandidatosDto>>(_repository.GetAll());
        return candidatos;
    }
}
