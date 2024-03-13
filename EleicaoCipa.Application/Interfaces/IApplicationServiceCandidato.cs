using EleicaoCipa.Application.DTO.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Application.DTO.Dto.CandidatoDto.ResponseDto;

namespace EleicaoCipa.Application.Interfaces;

public interface IApplicationServiceCandidato
{
    public ReadCandidatoDto Post(CreateCandidatoDto dto, int eleicaoId);

    public ReadCandidatoDto GetById(int id);

    public IEnumerable<ReadCandidatoDto> GetAll();

    public ReadCandidatoDto PutDiscurso(int id, UpdateDiscursoDto dto);
}
