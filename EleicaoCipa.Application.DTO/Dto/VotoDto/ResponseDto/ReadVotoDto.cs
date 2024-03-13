using EleicaoCipa.Application.DTO.Dto;

namespace EleicaoCipa.Application.DTO.Dto.VotoDto.ResponseDto
{
    public class ReadVotoDto : BaseDto
    {
        public int UsuarioId { get; set; }
        public int EleicaoId { get; set; }

    }
}