using UniversidadJCE1.Models;
using UniversidadJCE1.Services.CursoDetalleService;

namespace UniversidadJCE1.Services.CursoDetalleService

{
    public interface ICursoDetalleService
    {
        Task<List<CursoDetalle>> Get();
        Task<CursoDetalle?> GetSingleId(int id);
        Task<List<CursoDetalle>> Addcurso(CursoDetalle cursoDetalle);
        Task<List<CursoDetalle>?> Updatecurso(int id, CursoDetalle request);
    }
}
