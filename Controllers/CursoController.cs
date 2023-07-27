using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private static List<Curso> curso = new List<Curso>
        {
            new Curso
            {
                CursoId = 1,
                Descripcion = "Software",
                Fecha = new DateTime(26, 07, 2023),
                ProfesorId = 1,
                CursoDetalleId = 1,
                EstudianteId = 1,
            },
            new Curso
            {
                CursoId = 2,
                Descripcion = "db",
                Fecha = new DateTime(26, 07, 2023),
                ProfesorId = 2,
                CursoDetalleId = 2,
                EstudianteId = 2,
            }

        };

        [HttpGet]

        public async Task<ActionResult<List<Curso>>> Get()
        {
            return Ok(curso);
        }

        [HttpGet("ID")]

        public async Task<ActionResult<Curso>> GetById(int id)
        {
            var cursos = curso.Find(p => p.CursoId == id);
            if (cursos == null)
                return BadRequest("Aun no hay Detalles de este Curso.");
            return Ok(curso);
        }


        [HttpPost]

        public async Task<ActionResult<List<Curso>>> Addcurso(Curso cursos)
        {
            curso.Add(cursos);
            return Ok(curso);
        }


        [HttpPut]

        public async Task<ActionResult<List<Curso>>> Updatecurso(Curso request)
        {
            var cursos = curso.Find(p => p.CursoId == request.CursoId);
            if (cursos== null)
                return BadRequest("Aun no hay Detalles de este Curso.");

            cursos.CursoId = request.CursoId;
            cursos.Descripcion = request.Descripcion;
            cursos.Fecha = request.Fecha;
            cursos.ProfesorId = request.ProfesorId;
            cursos.CursoDetalleId = request.CursoDetalleId;
            cursos.EstudianteId = request.EstudianteId;

            return Ok(curso);
        }
    }
}
