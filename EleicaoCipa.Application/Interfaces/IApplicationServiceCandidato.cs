using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Aplicacao.Interfaces;

public interface IApplicationServiceCandidato
{
    public ReadCandidatoDto Post(CreateCandidatoDto dto, int eleicaoId);

    public ReadCandidatoDto GetById(int id);

    public IEnumerable<ReadCandidatoDto> GetAll();

    public ReadCandidatoDto PutDiscurso(int id, UpdateDiscursoDto dto);
}
