using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.ResponseDto;
using EleicaoCipa.Aplicacao.Interfaces;
using EleicaoCipa.Aplicacao.Service;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoCipa.Apresentacao.Controllers;
[ApiController]
[Route("[controller]")]
public class CandidatoController : ControllerBase
{
    private readonly IApplicationServiceCandidato _service;
    public CandidatoController(IApplicationServiceCandidato service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        try
        {
            var responseDto = _service.GetById(id);
            return Ok(responseDto);
        }
        catch (ArgumentException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpPut("{id}/altera_discurso")]
    public IActionResult PutDiscurso(int id, UpdateDiscursoDto dto)
    {
        if (dto is null || dto.Discurso.Equals(string.Empty))
            return NotFound("Não é possivel fazer alguma alteração com o discurso nulo ou vazio.");
        return Ok(_service.PutDiscurso(id, dto));
    }

    [HttpGet]
    public IEnumerable<ReadCandidatoDto> GetAll()
    {
        return _service.GetAll();
    }
}
