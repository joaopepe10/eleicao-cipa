using AutoMapper;
using EleicaoCipa.ApplicationService;
using EleicaoCipa.Data;
using EleicaoCipa.Data.Dto.UsuarioDto.RequestDto;
using EleicaoCipa.Data.Dto.UsuarioDto.ResponseDto;
using EleicaoCipa.Model;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoCipa.Controller;
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
        var responseDto = _service.Post(dto);
        return CreatedAtAction(nameof(GetById), new { Id = responseDto.Id }, responseDto);
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
