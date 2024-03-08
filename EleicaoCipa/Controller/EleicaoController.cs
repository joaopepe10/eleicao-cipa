using EleicaoCipa.ApplicationService;
using EleicaoCipa.Data.Dto.CandidatoDto.RequestDto;
using EleicaoCipa.Data.Dto.EleicaoDto.RequestDto;
using EleicaoCipa.Data.Dto.EleicaoDto.ResponseDto;
using EleicaoCipa.Data.Repository;
using Microsoft.AspNetCore.Mvc;

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
        if(dto is null) return NotFound("Favor preencer o campo de status.");
        var responseDto = _service.Update(dto, id);
        return Ok(responseDto);
    }

    [HttpGet]
    public IEnumerable<ReadEleicaoDto> GetAll()
    {
        return _service.GetAll();
    }
}
