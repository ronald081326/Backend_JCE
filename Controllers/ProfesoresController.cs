using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Models;
using UniversidadJCE1.Services.IProfesoresServices;

namespace UniversidadJCE1.Controllers
{
    [Route("Profesores")]
    [ApiController]
    public class ProfesoresController : ControllerBase
    {
        private readonly ProfesoresService _ProfesoresService;

        public ProfesoresController(ProfesoresService ProfesoresService)
        {
            _ProfesoresService = ProfesoresService;
        }
        [HttpGet]

        public async Task<ActionResult<List<Profesores>>> Get()
        {
            return await _ProfesoresService.Get();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Profesores>> GetById(int id)
        {
            var profesor = await _ProfesoresService.GetById(id);
            if (profesor is null)
                return NotFound("Profesor not found");

            return Ok(profesor);
        }


        [HttpPost]

        public async Task<ActionResult<List<Profesores>>> AddProfesor(Profesores profesores)
        {
            var profesor = await _ProfesoresService.AddProfesor(profesores);
            return Ok(profesores);
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<List<Profesores>>> UpdateProfesor(int id, Profesores request)
        {
            var profesor = await _ProfesoresService.UpdateProfesor(id, request);
            if (profesor is null)
                return NotFound("Profesor no actualizado.");

            return Ok(profesor);
           
        }

    }
}


