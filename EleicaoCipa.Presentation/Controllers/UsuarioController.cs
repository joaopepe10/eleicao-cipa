using EleicaoCipa.Aplicacao.DTO.Dto.UsuarioDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.UsuarioDto.ResponseDto;
using EleicaoCipa.Aplicacao.Service;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoCipa.Apresentacao.Controllers;
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
