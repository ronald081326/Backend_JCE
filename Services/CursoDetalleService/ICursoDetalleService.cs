using UniversidadJCE1.Models;
using UniversidadJCE1.Services.CursoService;

namespace UniversidadJCE1.Services.ICursoService
{
    public interface ICursoDetalleService
    {
        List<CursoDetalle> Get();
        List<CursoDetalle> Get(int Id);
        List<CursoDetalle> Addcurso(CursoDetalle detalle);
        List<CursoDetalle> Updatecurso(CursoDetalle request);
    }
}
