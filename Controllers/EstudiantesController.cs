using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Services.EstudianteService;

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

        public async Task<ActionResult<Estudiantes?>> GetSingleId(int id)
        {
            var result = await _estudianteService.GetSingleId(id);
            if (result is null)
                return NotFound("Estudiante  no encontrado");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Estudiantes>>> AddEstudiante(Estudiantes  estudiantes)
        {
            var estudiante = await _estudianteService.AddEstudiante(estudiantes);
            return Ok(estudiante);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<Estudiantes>>> UpdateEstudiante(int id ,Estudiantes request)
        {
            var result = await _estudianteService.UpdateEstudiante(id, request);
            if (result is null)
                return NotFound("Estudiante no actualizado.");

            return Ok(result);

        }
    }
}  