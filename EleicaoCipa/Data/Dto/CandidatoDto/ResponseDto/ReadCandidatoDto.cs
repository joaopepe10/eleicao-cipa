using EleicaoCipa.Data.Dto.UsuarioDto.ResponseDto;

namespace EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;

public class ReadCandidatoDto : BaseDto
{
    public int UsuarioId { get; set; }
    public ReadUsuarioDto Usuario { get; set; }
    public string Discurso { get; set; }
    public DateTime DataInscricao { get; set; }
}
