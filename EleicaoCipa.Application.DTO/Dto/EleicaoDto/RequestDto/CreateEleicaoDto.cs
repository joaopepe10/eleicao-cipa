﻿using EleicaoCipa.Aplicacao.DTO.Dto;

namespace EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.RequestDto;

public class CreateEleicaoDto : BaseDto
{
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
}
