using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Context;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.CursoService;
using UniversidadJCE1.Services.ICursoService;
using UniversidadJCE1.Services.ProfesoresService;

namespace UniversidadJCE1.Controllers
{
    [Route("CursoDetalle")]
    [ApiController]
    public class CursoDetalleController : ControllerBase
    {
        private readonly CursoDetalleService _CursoDetalleService;

        public CursoDetalleController(CursoDetalleService CursoDetalleService)
        {
            _CursoDetalleService = CursoDetalleService;
        }
        [HttpGet]

        public async Task<ActionResult<List<CursoDetalle>>> Get()
        {
            return await _CursoDetalleService.Get();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<CursoDetalle>> GetById(int id)
        {
            var detalle = await _CursoDetalleService.GetById(id);
            if (detalle is null)
                return NotFound("Detalle del Curso no encontrado");

            return Ok(detalle);
        }


        [HttpPost]

        public async Task<ActionResult<List<CursoDetalle>>> Addcurso(CursoDetalle cursoDetalle)
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
