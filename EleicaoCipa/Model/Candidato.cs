﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EleicaoCipa.Model;

public class Candidato
{    
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
    public int EleicaoId { get; set; }    
    public string Discurso { get; set; }
}