using EleicaoCipaVotacao.ApplicationService;
using EleicaoCipaVotacao.Data.Dto.UsuarioDto.RequestDto;
using EleicaoCipaVotacao.Data.Dto.UsuarioDto.ResponseDto;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoCipaVotacao.Controller;
[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly ApplicationServiceUsuario _service;
    public UsuarioController(ApplicationServiceUsuario service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateUsuarioDto dto)
    {
        if (dto is null) return NotFound("Dado para criação de usuário inválidos.");
        var responseDto = _service.Post(dto);
        return CreatedAtAction(nameof(GetById), new { responseDto.Id }, responseDto);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var dto = _service.GetById(id);
        return Ok(dto);
    }

    [HttpGet]
    public IEnumerable<ReadUsuarioDto> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("candidatos")]
    public IEnumerable<ReadAllCandidatosDto> GetAllCandidatos()
    {
        var candidatos = _service.GetAllCandidato();
        return candidatos;
    }
}
