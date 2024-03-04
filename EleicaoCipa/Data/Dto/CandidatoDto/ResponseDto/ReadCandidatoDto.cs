using EleicaoCipa.Data.Dto.UsuarioDto.ResponseDto;

namespace EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;

public class ReadCandidatoDto
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public ReadUsuarioDto Usuario { get; set; }
    public string Discurso { get; set; }
}
