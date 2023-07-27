using UniversidadJCE1.Models;
using UniversidadJCE1.Controllers;
using UniversidadJCE1.Services.CursoService;

namespace UniversidadJCE1.Services.ICursoService
{
    public interface ICursoDetalleService
    {
        List<CursoDetalle> Get();
        CursoDetalle GetById(int id);
        List<CursoDetalle> Addcurso(CursoDetalle cursoDetalle);
        List<CursoDetalle> Updatecurso(CursoDetalle request);
    }
}
