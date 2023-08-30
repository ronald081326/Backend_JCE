using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Services.CursoDetalleService;

namespace UniversidadJCE1.CursoDetalleControllers
{ 

[Route("CursoDetalle")]
[ApiController]
public class CursoDetalleController : ControllerBase
{
    private readonly ICursoDetalleService _CursoDetalleService;

    public CursoDetalleController(ICursoDetalleService cursoDetalleService)
    {

        _CursoDetalleService = cursoDetalleService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CursoDetalle>>> Get()
    {
        return await _CursoDetalleService.Get();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CursoDetalle>> GetSingleId(int id)
    {
        var detalle = await _CursoDetalleService.GetSingleId(id);
        if (detalle is null)
            return NotFound("Detalle del Curso no encontrado");

        return Ok(detalle);
    }

    [HttpPost]
    public async Task<ActionResult> Addcurso(CursoDetalle cursoDetalle)
    {
        var detalle = await _CursoDetalleService.Addcurso(cursoDetalle);
        return Ok(detalle);
    }


    [HttpPut("{id}")]

    public async Task<ActionResult<List<CursoDetalle>>> Updatecurso(int id, CursoDetalle request)
    {
        var detalle = await _CursoDetalleService.Updatecurso(id, request);
        if (detalle is null)
            return NotFound("Detalle del Curso no encontrado");

        return Ok(detalle);
    }
  } 
}
