using AutoMapper;
using EleicaoCipa.Data.Dto.VotoDto;
using EleicaoCipa.Data.Dto.VotoDto.RequestDto;
using EleicaoCipa.Data.Repository;
using EleicaoCipa.Model;

namespace EleicaoCipa.ApplicationService;

public class ApplicationServiceVoto
{
    private readonly VotoRepository _repository;
    private readonly IMapper _mapper;

    public ApplicationServiceVoto(VotoRepository repository,IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public ReadVotoDto Post(CreateVotoDto dto)
    {
        var entity = _mapper.Map<Voto>(dto);
        _repository.Post(entity);
        return _mapper.Map<ReadVotoDto>(entity);
    }

    public IEnumerable<ReadVotoDto> GetAll()
    {
        var votos = _repository.GetAll();
        return _mapper.Map<List<ReadVotoDto>>(votos);
    }

    public ReadVotoDto GetById(int id)
    {
        var entity = _repository.GetById(id);
        if (entity == null) throw new Exception($"Usuário com ID {id} inválido.");
        var responseDto = _mapper.Map<ReadVotoDto>(entity);
        return responseDto;
    }
}
