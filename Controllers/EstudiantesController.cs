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

        [HttpPost]
        public async  Task<ActionResult<List<Estudiantes>>> AddEstudiante(Estudiantes  newestudiantes)
        {
            var estudiantes = await _estudianteService.AddEstudiante(newestudiantes);
            return Ok(estudiantes);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Estudiantes>> GetById(int id)
        {
            var result = await  _estudianteService.GetById(id);
            if (result is null)
                return NotFound("Estudiante  no encontrado");

            return Ok(result);
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