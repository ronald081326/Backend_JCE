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
            new Profesores
            {
                ProfesorId = 1,
                Nombre = "Dostin",
                Apellido = "Santana",
                 CursoId = 1,
                Activo = true,
            },
            new Profesores
            {
                ProfesorId = 2,
                Nombre = "Claudio",
                Apellido = "Ferreira",
                CursoId = 2,
                Activo =true,
            }

        };

        [HttpGet]

        public async Task<ActionResult<List<Profesores>>> Get()
        { 
          return Ok(Profesor);
        }

        [HttpGet("ID")]

        public async Task<ActionResult<Profesores>> GetById(int id)
        {
            var profesor = Profesor.Find(p => p.ProfesorId == id);
            if (profesor == null)
                return BadRequest("Profesor No encontrado.");
              return Ok(Profesor);
        }

        
        [HttpPost]

        public async Task<ActionResult<List<Profesores>>> AddProfesor(Profesores profesores)
        {
            Profesor.Add(profesores);
            return Ok(Profesor);
        }


        [HttpPut]

        public async Task<ActionResult<List<Profesores>>> UpdateProfesor(Profesores request)
        {
            var profesor = Profesor.Find(p => p.ProfesorId == request.ProfesorId);
            if (profesor == null)
                return BadRequest("Profesor No encontrado.");

            profesor.ProfesorId = request.ProfesorId;
            profesor.Nombre = request.Nombre;
            profesor.Apellido = request.Apellido;
            profesor.Activo = request.Activo;
            profesor.CursoId = request.CursoId;


            return Ok(Profesor);
        }

    }
}

          

       
 

