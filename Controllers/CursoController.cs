using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadJCE1.Models;

namespace UniversidadJCE1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        /*private readonly ICursoDetalleService _cursoDetalleService;

        public CursoDetalleController(ICursoDetalleService cursoDetalleService)
        {
            _cursoDetalleService = cursoDetalleService;
        }
        [HttpGet]
        public async Task<ActionResult<List<CursoDetalle>>> Get()
        {
            return Ok(cursodetalle);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<CursoDetalle>> Get(int Id)
        {
            var detalle = cursodetalle.Find(c => c.CursoId == Id);
            if (detalle == null)
                return BadRequest("Aun No hay Detalles de este Curso");
            return Ok(cursodetalle);
        }

        [HttpPost]
        public async Task<ActionResult<List<CursoDetalle>>> Addcurso(CursoDetalle detalle)
        {
            cursodetalle.Add(detalle);
            return Ok(cursodetalle);
        }

        [HttpPut]
        public async Task<ActionResult<List<CursoDetalle>>> Updatecurso(CursoDetalle request)
        {
        }*/
    }
}
