namespace EleicaoCipa.Model;

public class Voto
{
    public int Id { get; set; }
    public int EleicaoId { get; set; }
    public int EleitorId { get; set; }
    public int CandidatoId { get; set; }
    public DateTime DataVoto { get; set; }
}
