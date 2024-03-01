using System.ComponentModel.DataAnnotations;

namespace EleicaoCipa.Model;

public class Usuario
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "Nome é obrigatório")]
    public string Nome { get; set; }


}
