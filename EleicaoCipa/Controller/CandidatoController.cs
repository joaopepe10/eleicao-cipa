using AutoMapper;
using EleicaoCipa.Data.Dto.UsuarioDto;
using EleicaoCipa.Data;
using EleicaoCipa.Model;
using Microsoft.AspNetCore.Mvc;
using EleicaoCipa.Data.Dto.CandidatoDto;

namespace EleicaoCipa.Controller;
[ApiController]
[Route("[controller]")]
public class CandidatoController : ControllerBase
{
    private EleicaoContext _context;
    private IMapper _mapper;

    public CandidatoController(EleicaoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateCandidatoDto dto)
    {
        var candidato = _mapper.Map<Candidato>(dto);
        var readCandidato = _mapper.Map<ReadCandidatoDto>(candidato);
        _context.Candidatos.Add(candidato);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { Id = candidato.Id }, readCandidato);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var candidato = _context.Candidatos.FirstOrDefault(candidato => candidato.Id == id);
        if (candidato == null) return NotFound();

        var dto = _mapper.Map<ReadCandidatoDto>(candidato);
        return Ok(dto);
    }
}
