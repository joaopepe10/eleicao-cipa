using EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Enums;

namespace EleicaoCipa.Data.Dto.EleicaoDto.ResponseDto;

public class ReadEleicaoDto
{
    public int Id { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string Status { get; set; }
    public ICollection<ReadCandidatoDto> Candidatos { get; set; }
}
