using EleicaoCipaVotacao.Data.Dto;

namespace EleicaoCipaVotacao.Data.Dto.VotoDto.ResponseDto
{
    public class ReadVotoDto : BaseDto
    {
        public int UsuarioId { get; set; }
        public int EleicaoId { get; set; }

    }
}