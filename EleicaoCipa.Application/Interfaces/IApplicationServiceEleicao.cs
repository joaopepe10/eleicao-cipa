using EleicaoCipa.Application.DTO.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Application.DTO.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Application.DTO.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Application.DTO.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Domain.Model;

namespace EleicaoCipa.Application.Interfaces;

public interface IApplicationServiceEleicao
{
    public ReadEleicaoDto Update(UpdateStatusEleicaoDto dto, int eleicaoId);

    public ReadEleicaoDto Post(CreateEleicaoDto dto);

    public ReadEleicaoDto GetById(int id);

    public IEnumerable<ReadEleicaoDto> GetAll();

    public ReadCandidatoDto PostCandidato(int eleicaoId, CreateCandidatoDto dto);

    public Eleicao GetEleicaoById(int id);

    public IEnumerable<ReadResultadoEleicaoDto> GetResultado();

    public ReadResultadoEleicaoDto? GetEleicaoResultadoById(int id);

    public void ValidaCriacaoDeEleicao(CreateEleicaoDto dto);
}
