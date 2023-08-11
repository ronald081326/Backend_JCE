using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ICursoService;

namespace UniversidadJCE1.Controllers
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

        [HttpPost]
        public async Task<ActionResult<List<CursoDetalle>>> Addcurso(CursoDetalle newcursoDetalle)
        {
            var cursoDetalle = await _CursoDetalleService.Addcurso(newcursoDetalle);
            return Ok(_CursoDetalleService);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CursoDetalle>> GetById(int id)
        {
            var detalle = await _CursoDetalleService.GetById(id);
            if (detalle is null)
                return NotFound("Detalle del Curso no encontrado");

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
