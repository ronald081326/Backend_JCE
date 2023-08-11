using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.CursoService;

namespace UniversidadJCE1.Controllers
{
    [Route("Curso")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _CursoService;

        public CursoController( ICursoService cursoService)
        {
            _CursoService = cursoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Curso>>> Get()
        {
            return await _CursoService.Get();
        }

        [HttpPost]
        public async Task<ActionResult<List<Curso>>> AddcursoAsync(Curso cursos)
        {
            var curso = await _CursoService.Addcurso(cursos);
            return Ok(curso);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> GetById(int id)
        {
            var cursos = await _CursoService.GetById(id);
            if (cursos is null)
                return NotFound("Curso no encontrado.");

            return Ok(cursos);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Curso>>> Updatecurso(int id, Curso request)
        {
            var cursos = await _CursoService.Updatecurso(id, request);
            if (cursos is null)
                return NotFound("Curso No encontrado.");

            return Ok(cursos);

        }
    }
}




