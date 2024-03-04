using AutoMapper;
using EleicaoCipa.ApplicationService;
using EleicaoCipa.Data;
using EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Data.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Data.Repository;
using EleicaoCipa.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EleicaoCipa.Controller;
[ApiController]
[Route("[controller]")]
public class EleicaoController : ControllerBase    
{
    private IMapper _mapper;
    private EleicaoRepository _eleicaoRepository;
    private ApplicationServiceEleicao _service;

    public EleicaoController(EleicaoRepository eleicaoRepository, IMapper mapper, ApplicationServiceEleicao service)
    {
        _eleicaoRepository = eleicaoRepository;
        _mapper = mapper;
        _service = service;
    }

    //[HttpPost]
    //public IActionResult Post([FromBody] CreateEleicaoDto dto)
    //{
    //    Eleicao eleicao = _mapper.Map<Eleicao>(dto);
    //    _context.Eleicoes.Add(eleicao);
    //    _context.SaveChanges();
    //    return CreatedAtAction(nameof(GetById), new { Id = eleicao.Id }, eleicao);
    //}
    //[HttpGet("{id}")]
    //public IActionResult GetById(int id)
    //{
    //    ReadEleicaoDto dto = _mapper.Map<ReadEleicaoDto>(_context.Eleicoes.FirstOrDefault(eleicao => eleicao.Id == id));
    //    if (dto == null) return NotFound();
    //    return Ok(dto);
    //}

    //[HttpGet]
    //public IEnumerable<ReadEleicaoDto> GetAll()
    //{
    //    return _mapper.Map<List<ReadEleicaoDto>>(_context.Eleicoes
    //        .Include(eleicao => eleicao.Candidatos)
    //        .ThenInclude(candidato => candidato.Usuario)
    //        .ToList());
    //}

    //[HttpPut("status/{id}")]
    //public IActionResult UpdateStatus(int id, [FromBody] UpadateStatusEleicaoDto dto)
    //{
    //    var eleicao = _context.Eleicoes.Find(id);
    //    if (eleicao == null) return NotFound();
    //    _mapper.Map(dto, eleicao);
    //    _context.SaveChanges();
    //    return NoContent();
    //}
    //// COLOCAR VALIDAÇÃO DE INSERÇÃO DE DATA, TEMPO MINIMO
    //// COLOCAR VALIDAÇÃO DE QUE DATA-INICIO N PODE SER MAIOR QUE DATA-FIM E AO CONTRÁRIO
    //[HttpPut("data-inicio/{id}")]
    //public IActionResult UpdateDataInicio(int id, [FromBody] UpdateEleicaoDataInicioDto dto)
    //{
    //    var eleicao = _context.Eleicoes.Find(id);
    //    if (eleicao == null) return NotFound();
    //    _mapper.Map(dto, eleicao);
    //    _context.SaveChanges();
    //    return NoContent();
    //}

    //[HttpPut("data-fim/{id}")]
    //public IActionResult UpdateDataFim(int id, [FromBody] UpdateEleicaoDataFimDto dto)
    //{
    //    var eleicao = _context.Eleicoes.Find(id);
    //    if (eleicao == null) return NotFound();
    //    _mapper.Map(dto, eleicao);
    //    _context.SaveChanges();
    //    return NoContent();
    //}
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] UpdateEleicaoDto dto)
    {
        
        if (dto == null) return NotFound();
        var responseDto = _service.Update(dto);
        return Ok(responseDto);
    }
}
