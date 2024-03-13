namespace EleicaoCipa.Application.DTO.Dto.VotoDto.RequestDto
{
    public class CreateVotoDto
    {
        public int UsuarioId { get; set; }
        public int EleicaoId { get; set; }
        public int CandidatoId { get; set; }
    }
}