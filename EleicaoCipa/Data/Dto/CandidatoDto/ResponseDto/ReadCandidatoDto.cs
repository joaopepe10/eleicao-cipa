using EleicaoCipa.Data.Dto.UsuarioDto.ResponseDto;

namespace EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;

public class ReadCandidatoDto : BaseDto
{
    public int UsuarioId { get; set; }
    public string NomeCandidato { get; set; }
    public string Discurso { get; set; }
    public int EleicaoId { get; set; }
    public DateTime DataInscricao { get; set; }
    public int QuantidadeDeVotos { get; set; }
}
