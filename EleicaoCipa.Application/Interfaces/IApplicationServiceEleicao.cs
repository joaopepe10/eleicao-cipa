using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Dominio.Model;

namespace EleicaoCipa.Aplicacao.Interfaces;

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
