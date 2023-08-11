using UniversidadJCE1.Models;
using UniversidadJCE1.Controllers;
using UniversidadJCE1.Services.CursoService;

namespace UniversidadJCE1.Services.ICursoService
{
    public interface ICursoDetalleService
    {
        Task<List<CursoDetalle>> Get();
        Task<List<CursoDetalle>?> Addcurso(CursoDetalle cursoDetalle);
        Task<CursoDetalle> GetById(int id);
        Task<List<CursoDetalle>?> Updatecurso(int id, CursoDetalle request);

    }
}
