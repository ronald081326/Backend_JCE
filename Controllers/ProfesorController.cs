using Microsoft.AspNetCore.Mvc;
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


        [HttpGet("{id}")]
        public async Task<ActionResult<Profesor>> GetSingleId(int id)
        {
            var Profesor = await _profesoresService.GetSingleId(id);
            if (Profesor is null)
                return NotFound("Profesor no encontrado");

            return Ok(Profesor);
        }

        [HttpPost]
        public async Task<ActionResult<List<Profesor>>> AddProfesor(Profesor profesores)
        {
            var profesor = await _profesoresService.AddProfesor(profesores);
            return Ok(profesor);
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<List<Profesor>?>> UpdateProfesor(int id, Profesor request)
        {
            var profesor = await _profesoresService.UpdateProfesor(id, request);
            if (profesor is null)
                return NotFound("Profesor no encontrado.");

            return Ok(profesor);
        }
    }
}