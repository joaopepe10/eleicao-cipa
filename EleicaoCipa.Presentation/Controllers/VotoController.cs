using EleicaoCipa.Aplicacao.DTO.Dto.VotoDto.RequestDto;
using EleicaoCipa.Aplicacao.Interfaces;
using EleicaoCipa.Aplicacao.Service;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoCipa.Apresentacao.Controllers;
[ApiController]
[Route("[controller]")]
public class VotoController : ControllerBase
{
    private readonly IApplicationServiceVoto _service;

    public VotoController(IApplicationServiceVoto service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Post(CreateVotoDto dto)
    {
        if (dto == null) return NotFound();
        try
        {
            var responseDto = _service.Post(dto);
            return CreatedAtAction(nameof(GetById), new { responseDto.Id }, responseDto);
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        try
        {
            var responseDto = _service.GetById(id);
            return Ok(responseDto);
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }
}
