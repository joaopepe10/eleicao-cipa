using EleicaoCipa.Domain.Enums;

namespace EleicaoCipa.Domain.Model;
public class Eleicao : BaseEntity
{
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public StatusEnum Status { get; set; } = 0;
    public int CandidatoId { get; set; }
    public virtual IEnumerable<Candidato>? Candidatos { get; set; }
    public virtual IEnumerable<Voto>? Votos { get; set; }
}

