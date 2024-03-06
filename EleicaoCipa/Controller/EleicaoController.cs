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

    [HttpPost("insere_candidato")]
    public IActionResult PostCondidato([FromBody] CreateCandidatoDto dto)
    {
        try
        {
            var resposnseCandidatoDto = _service.PostCandidato(dto);
            return Ok(resposnseCandidatoDto);
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
    public IActionResult UpdateDataFim(int id, [FromBody] CreateEleicaoDto dto)
    {        
        return Ok(_service.Update(dto, id));
    }
    
}
