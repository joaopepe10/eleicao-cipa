using EleicaoCipa.ApplicationService;
using EleicaoCipa.Data.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Data.Dto.CandidatoDto.ResponseDto;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoCipa.Controller;
[ApiController]
[Route("[controller]")]
public class CandidatoController : ControllerBase
{
    private readonly ApplicationServiceCandidato _service;
    public CandidatoController(ApplicationServiceCandidato service)
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
        catch(ArgumentException e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public IEnumerable<ReadCandidatoDto> GetAll()
    {
        return _service.GetAll();
    }
}
