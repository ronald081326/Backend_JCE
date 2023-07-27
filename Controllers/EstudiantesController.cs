using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ProfesoresService;

namespace UniversidadJCE1.Controllers
{
    [Route("Estudiantes")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly IEstudianteService _estudianteService;

        public EstudiantesController(IEstudianteService estudianteService)
        {
            _estudianteService = estudianteService;
        }
        [HttpGet]

        public async Task<ActionResult<List<Estudiantes>>> Get()
        {
            return await _estudianteService.Get();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Estudiantes>> GetById(int id)
        {
            var result = await _estudianteService.GetById(id);
            if (result is null)
                return NotFound("student not found");

            return Ok(result);
        }


        [HttpPost]

        public async Task<ActionResult<List<Estudiantes>>> AddEstudiante(Estudiantes estudiantes)
        {
            var result = await _estudianteService.AddEstudiante(estudiantes);
            return Ok(result);
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<List<Estudiantes>>> UpdateEstudiante(int id ,Estudiantes request)
        {
            var result = await _estudianteService.UpdateEstudiante(id, request);
            if (result is null)
                return NotFound("student not updated");

            return Ok(result);
            /*
            var estudiantes = Estudiante.Find(p => p.EstudianteId == request.EstudianteId);
            if (estudiantes == null)
                return BadRequest("Estudiante No encontrado.");

            estudiantes.EstudianteId = request.EstudianteId;
            estudiantes.Nombre = request.Nombre;
            estudiantes.Apellido = request.Apellido;    
            estudiantes.FechaNacimiento = request.FechaNacimiento;
            estudiantes.CursoId = request.CursoId;
            estudiantes.Activo = request.Activo;


            return Ok(Estudiante);*/
        }

    }
}  