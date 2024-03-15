namespace EleicaoCipa.Dominio.Model;

public class Candidato : BaseEntity
{
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
    public virtual Eleicao Eleicao { get; set; }
    public int EleicaoId { get; set; }
    public string Discurso { get; set; }
    public virtual IEnumerable<Voto>? Votos { get; set; }
    public DateTime DataInscricao { get; set; } = DateTime.Now;
}
