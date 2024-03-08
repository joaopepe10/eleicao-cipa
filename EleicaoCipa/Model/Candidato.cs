using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EleicaoCipa.Model;

public class Candidato
{    
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
    public virtual Eleicao Eleicao { get; set; }
    public int EleicaoId { get; set; }    
    public string Discurso { get; set; }
    public virtual IEnumerable<Voto> Votos { get; set; }
    public DateTime DataInscricao { get; set; } = DateTime.Now;
}
