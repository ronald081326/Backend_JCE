using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Controllers
{
    [Route("Profesores")]
    [ApiController]
    public class ProfesoresController : ControllerBase
    {
        private static List<Profesores> Profesor = new List<Profesores>
        {
            new Profesores {
                ProfesorId = 1,
                Nombre = "Dostin",
                Apellido = "Santana",
                Activo = "Yes"
            },
            new Profesores {
                ProfesorId = 2,
                Nombre = "Claudio",
                Apellido = "Santana",
                Activo = "Yes"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Profesores>>> Get()
        {
            return Ok(Profesor);
        }

        [HttpGet]
        public async Task<ActionResult<Profesores>> Get(int Id)
        {
            var profesor = Profesor.Find(p => p.ProfesorId == Id);
            if (profesor == null)
                return BadRequest("Profesor no encontrado.");
            return Ok(profesor);
        }

        [HttpPost]
        public async Task<ActionResult<List<Profesores>>> AddProfesor(Profesores profesor)
        {
            Profesor.Add(profesor);
            return Ok(profesor);
        }

        [HttpPut]

        public async Task<ActionResult<List<Profesores>>> UpdateProfesor(Profesores request)
        {
            var profesor = Profesor.Find(p => p.ProfesorId == request.Id);
            if (profesor == null)
                return BadRequest("Profesor no encontrado.");

            profesor.ProfesorId = request.Id;
            profesor.Nombre = request.Nombre;
            profesor.Apellido = request.Apellido;
            profesor.Activo = request.Activo;

            return Ok(profesor);
        }


    }
}
