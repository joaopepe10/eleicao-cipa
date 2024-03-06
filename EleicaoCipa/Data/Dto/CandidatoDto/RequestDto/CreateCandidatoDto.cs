namespace EleicaoCipa.Data.Dto.CandidatoDto.RequestDto;

public class CreateCandidatoDto
{
    public int UsuarioId { get; set; }
    public string Discurso { get; set; } = string.Empty;
    public int EleicaoId { get; set; }
}
