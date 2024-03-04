using AutoMapper;
using EleicaoCipa.Data.Repository;
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

    public TDTO Update<TDTO>(TDTO dto, int id)
    {
        var entity = _mapper.Map<Eleicao>(dto);
        _repository.Update(entity);
        return _mapper.Map<TDTO>(entity);
    }

}
