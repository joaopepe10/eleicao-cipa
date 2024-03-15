using EleicaoCipa.Aplicacao.DTO.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Aplicacao.DTO.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EleicaoCipa.Apresentacao.Controllers;
[ApiController]
[Route("[controller]")]
public class EleicaoController : ControllerBase
{
    private readonly IApplicationServiceEleicao _service;

    public EleicaoController(IApplicationServiceEleicao service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateEleicaoDto dto)
    {
        if (dto is null)
            return NotFound("Não foi possível criar uma nova eleição, preencha todos os campos.");
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
        var dto = _service.GetById(id);
        if (dto == null) return NotFound();
        return Ok(dto);
    }

    [HttpPost("{id}/insere-candidato")]
    public IActionResult PostCondidato(int id, [FromBody] CreateCandidatoDto dto)
    {
        try
        {
            var responseCandidato = _service.PostCandidato(id, dto);
            return Ok(responseCandidato);
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPut("{id}/altera-status")]
    public IActionResult Put(int id, [FromBody] UpdateStatusEleicaoDto dto)
    {
        if (dto is null) return NotFound("Favor preencer o campo de status.");
        var responseDto = _service.Update(dto, id);
        return Ok(responseDto);
    }

    [HttpGet]
    public IEnumerable<ReadEleicaoDto> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("resultado")]
    public IEnumerable<ReadResultadoEleicaoDto> GetResultado()
    {
        return _service.GetResultado();
    }

    [HttpGet("{id}/resultado")]
    public IActionResult GetEleicaoResultadoById(int id)
    {
        return Ok(_service.GetEleicaoResultadoById(id));
    }
}
