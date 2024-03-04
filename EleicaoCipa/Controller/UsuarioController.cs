using AutoMapper;
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
    private EleicaoContext _context;
    private IMapper _mapper;

    public UsuarioController(EleicaoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateUsuarioDto dto)
    {
        var usuario = _mapper.Map<Usuario>(dto);
        var readUsuario = _mapper.Map<ReadUsuarioDto>(usuario);
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { Id = usuario.Id }, readUsuario);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
        if (usuario == null) return NotFound();

        var dto = _mapper.Map<ReadUsuarioDto>(usuario);
        return Ok(dto);
    }

    [HttpGet("candidatos")]
    public IEnumerable<ReadAllCandidatosDto> GetAllCandidatos()
    {
        var candidatos = _mapper.Map<List<ReadAllCandidatosDto>>(_context.Usuarios.ToList());

        return candidatos;
    }
}
