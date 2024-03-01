using System.ComponentModel.DataAnnotations;

namespace EleicaoCipa.Model;

public class Usuario
{    
    public int Id { get; set; }    
    public string Nome { get; set; }
    public virtual Candidato Candidato { get; set; }
}
