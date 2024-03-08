using EleicaoCipa.ApplicationService;
using EleicaoCipa.Data.Dto.VotoDto;
using EleicaoCipa.Data.Dto.VotoDto.RequestDto;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoCipa.Controller;
[ApiController]
[Route("[controller]")]
public class VotoController : ControllerBase
{
    private readonly ApplicationServiceVoto _service;

    public VotoController(ApplicationServiceVoto service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Post(CreateVotoDto dto)
    {
        if (dto == null) return NotFound();
        var responseDto = _service.Post(dto);
        return CreatedAtAction(nameof(GetById), new { Id = responseDto.Id }, responseDto);
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
