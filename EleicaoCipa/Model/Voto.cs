namespace EleicaoCipa.Model;

public class Voto : BaseEntity
{
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
    public int EleicaoId { get; set; }
    public virtual Eleicao Eleicao { get; set; }
    public int CandidatoId { get; set; }
    public virtual Candidato Candidato { get; set; }
    public DateTime DataVoto { get; set; }
}
