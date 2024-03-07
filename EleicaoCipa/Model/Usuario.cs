﻿using System.ComponentModel.DataAnnotations;

namespace EleicaoCipa.Model;

public class Usuario
{    
    public int Id { get; set; }    
    public string Nome { get; set; }
    public int CandidatoId { get; set; }
    public virtual IEnumerable<Candidato>? Candidatos { get; set; }
    public virtual IEnumerable<Voto>? Votos { get; set; }
}
