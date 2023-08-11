using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.ProfesoresService;

namespace UniversidadJCE1.Controllers
{
    [Route("Profesor")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorService _profesoresService;
        public ProfesorController(IProfesorService profesoresService)
        {
            _profesoresService = profesoresService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Profesor>>> Get()
        {
            return await _profesoresService.Get();
        }

        [HttpPost]
        public async Task<ActionResult<List<Profesor>>> AddProfesor(Profesor newProfesor)
        {
            var profesor = await _profesoresService.AddProfesor(newProfesor);         
            return Ok(profesor);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Profesor>> GetById(int id)
        {
            var Profesor = await _profesoresService.GetById(id);
            if (Profesor is null)
                return NotFound("Profesor no encontrado");

            return Ok(Profesor);
        }

        [HttpPut("{id}")]

        public ActionResult<List<Profesor>> UpdateProfesor(int id, Profesor request)
        {
            var profesor = _profesoresService.UpdateProfesor(id, request);
            if (profesor is null)
                return NotFound("Estudiante no actualizado.");

            return Ok(profesor);
        }

    }
}