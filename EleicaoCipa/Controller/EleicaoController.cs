using AutoMapper;
using EleicaoCipa.ApplicationService;
using EleicaoCipa.Data;
using EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Data.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Data.Repository;
using EleicaoCipa.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.OData;

namespace EleicaoCipa.Controller;
[ApiController]
[Route("[controller]")]
public class EleicaoController : ControllerBase    
{
    private ApplicationServiceEleicao _service;

    public EleicaoController(EleicaoRepository eleicaoRepository, ApplicationServiceEleicao service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateEleicaoDto dto)
    {        
        var responseDto = _service.Post(dto);
        return CreatedAtAction(nameof(GetById), new { Id = responseDto.Id }, responseDto);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var dto = _service.GetById(id);
        if (dto == null) return NotFound();
        return Ok(dto);
    }

    [HttpGet]
    public IEnumerable<ReadEleicaoDto> GetAll()
    {
        return _service.GetAll();
    }

    [HttpPut("status/{id}")]
    public IActionResult UpdateStatus(int id, [FromBody] UpadateStatusEleicaoDto dto)
    {
        
        return NoContent();
    }
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

    [HttpPut("data-fim/{id}")]
    public IActionResult UpdateDataFim(int id, [FromBody] UpdateEleicaoDataFimDto dto)
    {        
        return Ok(_service.Update(dto, id));
    }
    [HttpPatch("{id}")]
    public IActionResult UpdatePatch(int id, [FromBody] Delta<UpdateEleicaoDto> alteracoes)
    {
        if (alteracoes == null) return NotFound();        
        var responseDto = _service.UpdatePatch(alteracoes, id);
        return Ok(responseDto);
    }
}
