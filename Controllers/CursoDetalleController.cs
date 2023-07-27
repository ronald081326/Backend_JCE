using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Controllers
{
    [Route("CursoDetalle")]
    [ApiController]
    public class CursoDetalleController : ControllerBase
    {
        private static List<CursoDetalle> Detalle = new List<CursoDetalle>
        {
            new CursoDetalle
            {
                CursoDetalleId = 1,
                CursoId = 1,
                EstudianteId = 1,
            },
            new CursoDetalle
            {
                CursoDetalleId = 12,
                CursoId = 12,
                EstudianteId = 12,
            }

        };

        [HttpGet]

        public async Task<ActionResult<List<CursoDetalle>>> Get()
        {
            return Ok(Detalle);
        }

        [HttpGet("ID")]

        public async Task<ActionResult<CursoDetalle>> GetById(int id)
        {
            var cursoDetalle = Detalle.Find(p => p.CursoDetalleId == id);
            if (cursoDetalle == null)
                return BadRequest("Aun no hay Detalles de este Curso.");
            return Ok(Detalle);
        }


        [HttpPost]

        public async Task<ActionResult<List<CursoDetalle>>> Addcurso(CursoDetalle cursoDetalle)
        {
            Detalle.Add(cursoDetalle);
            return Ok(Detalle);
        }


        [HttpPut]

        public async Task<ActionResult<List<CursoDetalle>>> Updatecurso(CursoDetalle request)
        {
            var cursoDetalle = Detalle.Find(p => p.EstudianteId == request.EstudianteId);
            if (cursoDetalle == null)
                return BadRequest("Aun no hay Detalles de este Curso.");

            cursoDetalle.EstudianteId = request.EstudianteId;
            cursoDetalle.CursoDetalleId = request.CursoDetalleId;
            cursoDetalle.CursoId = request.CursoId;
            cursoDetalle.EstudianteId = request.EstudianteId;    



            return Ok(Detalle);
        }
    }
}
