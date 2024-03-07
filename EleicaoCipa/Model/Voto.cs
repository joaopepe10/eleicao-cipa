namespace EleicaoCipa.Model;

public class Voto
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
    public int EleicaoId { get; set; }
    public virtual Eleicao Eleicao { get; set; }
    public DateTime DataVoto { get; set; }
}
