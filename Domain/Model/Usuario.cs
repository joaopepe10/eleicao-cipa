﻿namespace EleicaoCipa.Dominio.Model;
public class Usuario : BaseEntity
{
    public string Nome { get; set; }
    public int CandidatoId { get; set; }
    public virtual IEnumerable<Candidato>? Candidatos { get; set; }
    public virtual IEnumerable<Voto>? Votos { get; set; }
}
