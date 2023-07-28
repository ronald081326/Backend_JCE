using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversidadJCE1.Context;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.CursoService;
using UniversidadJCE1.Services.ICursoService;

namespace UniversidadJCE1.Controllers
{
    [Route("Curso")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly CursoService _CursoService;

        public CursoController(CursoService CursoService)
        {
            _CursoService = CursoService;
        }
        [HttpGet]

        public async Task<ActionResult<List<Curso>>> Get()
        {
            return await _CursoService.Get();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Profesores>> GetById(int id)
        {
            var cursos = await _CursoService.GetById(id);
            if (cursos is null)
                return NotFound("Curso No encontrado.");

            return Ok(cursos);
        }


        [HttpPost]

        public async Task<ActionResult<List<Curso>>> Addcurso(Curso curso)
        {
            var cursos = await _CursoService.Addcurso(curso);
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


